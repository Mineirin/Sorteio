using MySql.Data.MySqlClient;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SorteioMagnata.Logica
{
    public partial class FrmSorteios : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;

        public FrmSorteios()
        {
            InitializeComponent();
        }
        
        private void telaSorteio()
        {
            lblNomeSorteio.Text = txtNomeSorteio.Text;
            lblNumero1.Text = txtNumero1.Text;
            lblNumero2.Text = txtNumero2.Text;
            lblNumero3.Text = txtNumero3.Text;
            lblNumero4.Text = txtNumero4.Text;
            lblNumero5.Text = txtNumero5.Text;
        }

        private void FrmSorteios_Load(object sender, System.EventArgs e)
        {
            
        }

        private void txtNomeSorteio_TextChanged(object sender, System.EventArgs e)
        {
            telaSorteio();
        }

        private void txtNumero1_TextChanged(object sender, System.EventArgs e)
        {
            telaSorteio();
        }

        private void btnSalvarSorteio_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumero1.Text.ToString())
                || String.IsNullOrEmpty(txtNumero2.Text.ToString())
                || String.IsNullOrEmpty(txtNumero3.Text.ToString())
                || String.IsNullOrEmpty(txtNumero4.Text.ToString())
                || String.IsNullOrEmpty(txtNumero5.Text.ToString()))
            {
                MessageBox.Show("Preencha TODOS os números, por favor!", "Campo(s) Vazio(s)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            //CODIGO DO BOTÃO DE SALVAR
            con.AbrirCon();
            sql = " INSERT INTO resultsorteio (" +
                "nomesorteio, " +
                "numero1, " +
                "numero2, " +
                "numero3, " +
                "numero4, " +
                "numero5, " +
                "data) "+
                " VALUES " +
                "(@nomesorteio, " +
                "@numero1, " +
                "@numero2, " +
                "@numero3, " +
                "@numero4, " +
                "@numero5, " +
                "curDate())";
            cmd = new MySqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@nomesorteio", txtNomeSorteio.Text);
            cmd.Parameters.AddWithValue("@numero1", txtNumero1.Text);
            cmd.Parameters.AddWithValue("@numero2", txtNumero2.Text);
            cmd.Parameters.AddWithValue("@numero3", txtNumero3.Text);
            cmd.Parameters.AddWithValue("@numero4", txtNumero4.Text);
            cmd.Parameters.AddWithValue("@numero5", txtNumero5.Text);

            //Lógica para verificar os números de apostas e bater com os números do sorteio
            MySqlCommand cmdVerificar;
            cmdVerificar = new MySqlCommand("SELECT * FROM apostas", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdVerificar;
            DataTable dt = new DataTable();
            da.Fill(dt);

            List<string> numerosSorteio = new List<string>();
            numerosSorteio.Add(txtNumero1.Text);
            numerosSorteio.Add(txtNumero2.Text);
            numerosSorteio.Add(txtNumero3.Text);
            numerosSorteio.Add(txtNumero4.Text);
            numerosSorteio.Add(txtNumero5.Text);

            

            //Iniciando a verificação de todas as apostas
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                int idAposta = (int) dt.Rows[i]["id"];
                int acertosAnterior = (int) dt.Rows[i]["acertos"];
                int acertosAtual = 0;

                //Populando a Lista de bools com base na cartela (que já pode ter números sorteados de sorteios passados!)
                List<bool> flagNumSorteado = new List<bool>();
                for (int it = 1; it <= 10; it++)
                {
                    flagNumSorteado.Add(bool.Parse(dt.Rows[i]["aposta" + it + "flag"].ToString()));
                }

                //Iteração para passar pelos 10 números da cartela de cada aposta
                for (int j = 1; j <= 10; j++)
                {
                    bool numeroBateu = false;
                    string compararNum = dt.Rows[i]["numeroaposta" + j.ToString()].ToString();
                    for (int k = 0; k < numerosSorteio.Count; k++)
                    {
                        //Primeira verificação é se já não tinha sido sorteado o número.
                        //Se já tiver sido, nem compara, pq não pode somar no acerto
                        if (!flagNumSorteado[j - 1])
                        {
                            //Se algum dos 5 números do sorteio bater com o número da aposta
                            //na posição [j] (que vai de 1 até 10), então marca na flag e soma nos acertos atuais
                            numeroBateu = compararNum == numerosSorteio[k];
                            if (numeroBateu)
                            {
                                flagNumSorteado[j - 1] = true;
                                acertosAtual++;
                            }
                        }
                    }
                    
                }

                int acertosTotais = acertosAnterior + acertosAtual;

                if (acertosTotais == 10)
                {
                    try
                    {
                        con.AbrirCon();


                        Grid.DataSource = null;
                        sql = "SELECT nomecartela as 'Cartela', " +
                            "numeroaposta1 as n1, " +
                            "numeroaposta2 as n2, " +
                            "numeroaposta3 as n3, " +
                            "numeroaposta4 as n4, " +
                            "numeroaposta5 as n5, " +
                            "numeroaposta6 as n6, " +
                            "numeroaposta7 as n7, " +
                            "numeroaposta8 as n8, " +
                            "numeroaposta9 as n9, " +
                            "numeroaposta10 as n10, " +
                            "acertos, " +
                            "data " +
                            "FROM apostas order by acertos desc";
                        cmd = new MySqlCommand(sql, con.con);
                        MySqlDataAdapter data = new MySqlDataAdapter();
                        data.SelectCommand = cmd;

                        DataTable dtb = new DataTable();
                        data.Fill(dtb);

                        Grid.DataSource = dtb;
                        FormatarDGApostas();
                        con.FecharCon();

                        LimparTabelaSorteio();
                        FinalizarSorteio();

                        DialogResult dialogResult = MessageBox.Show("Alguem já ganhou! \n\n Deseja exportar a lista de apostas?", "Começar Novo Sorteio", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                            ExportarParaExcel(dtb);
                       
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.FecharCon();
                    }
                   
                }

                string sqlUpdateApostas = "UPDATE apostas SET " +
                    "acertos = @qtdAcertos, " +
                    "aposta1flag = @aposta1flag, " +
                    "aposta2flag = @aposta2flag, " +
                    "aposta3flag = @aposta3flag, " +
                    "aposta4flag = @aposta4flag, " +
                    "aposta5flag = @aposta5flag, " +
                    "aposta6flag = @aposta6flag, " +
                    "aposta7flag = @aposta7flag, " +
                    "aposta8flag = @aposta8flag, " +
                    "aposta9flag = @aposta9flag, " +
                    "aposta10flag = @aposta10flag " +
                    "WHERE id = @id";
                MySqlCommand cmdUpdateApostas = new MySqlCommand(sqlUpdateApostas, con.con);
                cmdUpdateApostas.Parameters.AddWithValue("@qtdAcertos", acertosTotais.ToString());
                cmdUpdateApostas.Parameters.AddWithValue("@aposta1flag", flagNumSorteado[0]);
                cmdUpdateApostas.Parameters.AddWithValue("@aposta2flag", flagNumSorteado[1]);
                cmdUpdateApostas.Parameters.AddWithValue("@aposta3flag", flagNumSorteado[2]);
                cmdUpdateApostas.Parameters.AddWithValue("@aposta4flag", flagNumSorteado[3]);
                cmdUpdateApostas.Parameters.AddWithValue("@aposta5flag", flagNumSorteado[4]);
                cmdUpdateApostas.Parameters.AddWithValue("@aposta6flag", flagNumSorteado[5]);
                cmdUpdateApostas.Parameters.AddWithValue("@aposta7flag", flagNumSorteado[6]);
                cmdUpdateApostas.Parameters.AddWithValue("@aposta8flag", flagNumSorteado[7]);
                cmdUpdateApostas.Parameters.AddWithValue("@aposta9flag", flagNumSorteado[8]);
                cmdUpdateApostas.Parameters.AddWithValue("@aposta10flag", flagNumSorteado[9]);
                cmdUpdateApostas.Parameters.AddWithValue("@id", idAposta);
                cmdUpdateApostas.ExecuteNonQuery();
            }
            
            cmd.ExecuteNonQuery();
            con.FecharCon();

            MessageBox.Show("Sorteio Realizado com Sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listar();
            
        }

        private void FinalizarSorteio()
        {
            try
            {
                con.AbrirCon();
                string sqlFinalizarSorteio = " UPDATE `resultsorteio` SET " +
                    "`sorteios-finalizado` = 1 " +
                    "ORDER BY `id` DESC " + 
                    "LIMIT 1";
                cmd = new MySqlCommand(sqlFinalizarSorteio, con.con);
                MySqlCommand cmdFinalizarSorteio = new MySqlCommand(sqlFinalizarSorteio, con.con);
                cmdFinalizarSorteio.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LimparTabelaSorteio()
        {
            try
            {
                con.AbrirCon();
                string sqlTruncate = " TRUNCATE TABLE apostas";
                cmd = new MySqlCommand(sqlTruncate, con.con);
                MySqlCommand cmdTruncate = new MySqlCommand(sqlTruncate, con.con);
                cmdTruncate.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ExportarParaExcel(DataTable dtb)
        {
            try
            {
                using (ExcelPackage pck = new ExcelPackage())
                {
                    ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Apostas");
                    ws.Cells["A1"].LoadFromDataTable(dtb, true);
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.InitialDirectory = @"C:\";
                    saveFileDialog1.Title = "Salvar arquivo em:";
                    saveFileDialog1.CheckPathExists = true;
                    saveFileDialog1.DefaultExt = "xlsx";
                    saveFileDialog1.Filter = "Arquivo do Excel *.xlsx | *.xlsx";
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.RestoreDirectory = true;
                    saveFileDialog1.ShowDialog();
                    pck.SaveAs(new System.IO.FileInfo(saveFileDialog1.FileName));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static Bitmap DrawControlToBitmap(Control control)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Rectangle rect = control.RectangleToScreen(control.ClientRectangle);
            graphics.CopyFromScreen(rect.Location, Point.Empty, control.Size);
            return bitmap;
        }
        private void btnRelatorioIMG_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = DrawControlToBitmap(imgResultSorteio);
            bitmap.Save("imgResultSorteio.bmp");
            System.Diagnostics.Process.Start("imgResultSorteio.bmp");
        }


        private void FormatarDGApostas()
        {
            Grid.Columns[0].HeaderText = "Participantes";
            Grid.Columns[1].HeaderText = "";
            Grid.Columns[2].HeaderText = "";
            Grid.Columns[3].HeaderText = "";
            Grid.Columns[4].HeaderText = "";
            Grid.Columns[5].HeaderText = "";
            Grid.Columns[6].HeaderText = "";
            Grid.Columns[7].HeaderText = "";
            Grid.Columns[8].HeaderText = "";
            Grid.Columns[9].HeaderText = "";
            Grid.Columns[10].HeaderText = "";
            Grid.Columns[11].HeaderText = "Acertos";
            Grid.Columns[12].HeaderText = "Data";

            Grid.Columns[0].Width = 130;
            Grid.Columns[1].Width = 30;
            Grid.Columns[2].Width = 30;
            Grid.Columns[3].Width = 30;
            Grid.Columns[4].Width = 30;
            Grid.Columns[5].Width = 30;
            Grid.Columns[6].Width = 30;
            Grid.Columns[7].Width = 30;
            Grid.Columns[8].Width = 30;
            Grid.Columns[9].Width = 30;
            Grid.Columns[10].Width = 45;
            Grid.Columns[11].Width = 100;
        }


        private void Listar()
        {
            con.AbrirCon();
            Grid.DataSource = null;
            sql = "SELECT nomecartela as 'Cartela', " +
                "numeroaposta1 as n1, " +
                "numeroaposta2 as n2, " +
                "numeroaposta3 as n3, " +
                "numeroaposta4 as n4, " +
                "numeroaposta5 as n5, " +
                "numeroaposta6 as n6, " +
                "numeroaposta7 as n7, " +
                "numeroaposta8 as n8, " +
                "numeroaposta9 as n9, " +
                "numeroaposta10 as n10, " +
                "acertos, " +
                "data " +
                "FROM apostas order by acertos desc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            Grid.DataSource = dt;
            FormatarDGApostas();
            con.FecharCon();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con.AbrirCon();
            Grid.DataSource = null;
            sql = "SELECT nomesorteio as 'Sorteio'," +
                " numero1 as n1, " +
                " numero2 as n2, " +
                " numero3 as n3, " +
                " numero4 as n4, " +
                " numero5 as n5, " +
                " data " +
                " FROM resultsorteio order by nomesorteio asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            Grid.DataSource = dt;
            con.FecharCon();
            Listar();
        }

        private void btnRelatorioLista_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = DrawControlToBitmap(panel2);
            bitmap.Save("panel2.bmp");
            System.Diagnostics.Process.Start("panel2.bmp");
        }
    }
}
