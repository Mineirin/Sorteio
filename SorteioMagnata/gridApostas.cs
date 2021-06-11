using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorteioMagnata
{
    public partial class gridApostas : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        int idAposta;
        public gridApostas()
        {
            InitializeComponent();
        }

        

        private void gridApostas_Load(object sender, EventArgs e)
        {

            con.AbrirCon();
            dgvApostas.DataSource = null;
            sql = "SELECT id as 'idApostas', nomecartela as 'Cartela', " +
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
                "status, " +
                "data " +
                "FROM apostas order by acertos desc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvApostas.DataSource = dt; 
            PintarNumerosSorteados();
            CarregarCombobox();
            con.FecharCon();
        }

        private void CarregarCombobox()
        {
            con.AbrirCon();
            sql = "SELECT * FROM status order by status asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            cbStatus.DataSource = dt;
            cbStatus.DisplayMember = "status";
            con.FecharCon();
        }

        private void dgvApostas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvApostas.Columns["acertos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn coluna in dgvApostas.Columns)
            {
                switch (coluna.Name)
                {
                    case "idApostas":
                        coluna.DisplayIndex = 0;
                        coluna.Visible = false;
                        break;
                    case "Cartela":
                        coluna.DisplayIndex = 1;
                        coluna.Width = 200;
                        coluna.HeaderText = "Participantes";
                        break;
                    case "n1":
                        coluna.DisplayIndex = 2;
                        coluna.Width = 30;
                        coluna.HeaderText = "";
                        break;
                    case "n2":
                        coluna.DisplayIndex = 3;
                        coluna.Width = 30;
                        coluna.HeaderText = "";
                        break;
                    case "n3":
                        coluna.DisplayIndex = 4;
                        coluna.Width = 30;
                        coluna.HeaderText = "";
                        break;
                    case "n4":
                        coluna.DisplayIndex = 5;
                        coluna.Width = 30;
                        coluna.HeaderText = "";
                        break;
                    case "n5":
                        coluna.DisplayIndex = 6;
                        coluna.Width = 30;
                        coluna.HeaderText = "";
                        break;
                    case "n6":
                        coluna.DisplayIndex = 7;
                        coluna.Width = 30;
                        coluna.HeaderText = "";
                        break;
                    case "n7":
                        coluna.DisplayIndex = 8;
                        coluna.Width = 30;
                        coluna.HeaderText = "";
                        break;
                    case "n8":
                        coluna.DisplayIndex = 9;
                        coluna.Width = 30;
                        coluna.HeaderText = "";
                        break;
                    case "n9":
                        coluna.DisplayIndex = 10;
                        coluna.Width = 30;
                        coluna.HeaderText = "";
                        break;
                    case "n10":
                        coluna.DisplayIndex = 11;
                        coluna.Width = 30;
                        coluna.HeaderText = "";
                        break;
                    case "acertos":
                        coluna.DisplayIndex = 12;
                        coluna.Width = 75;
                        coluna.HeaderText = "Acertos";
                        break;
                    case "data":
                        coluna.DisplayIndex = 13;
                        coluna.Width = 80;
                        coluna.HeaderText = "Data";
                        break;
                    case "editar":
                        coluna.DisplayIndex = 14;
                        coluna.Width = 30;
                        break;
                    case "excluir":
                        coluna.DisplayIndex = 15;
                        coluna.Width = 30;
                        break;
                    case "status":
                        coluna.DisplayIndex = 16;
                        coluna.Width = 120;
                        coluna.HeaderText = "Status";
                        break;
                    default:
                        break;
                }
            }
        }
        private void dgvApostas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvApostas.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
            dgvApostas.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir";
        }

        private void dgvApostas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idAposta = Convert.ToInt32(dgvApostas.Rows[e.RowIndex].Cells["idApostas"].Value.ToString());
            if (dgvApostas.Columns[e.ColumnIndex] == dgvApostas.Columns["editar"])
            {
                lbNome.Visible = true;
                txtNome.Enabled = false;
                txtNome.Visible = true;
                btnSalvar.Enabled = true;
                btnSalvar.Visible = true;
                btnFechar.Enabled = true;
                btnFechar.Visible = true;
                btnAleatorio.Enabled = true;
                btnAleatorio.Visible = true;
                cbStatus.Enabled = true;
                cbStatus.Visible = true;

                txtNumeroAposta1.Enabled = true;
                txtNumeroAposta2.Enabled = true;
                txtNumeroAposta3.Enabled = true;
                txtNumeroAposta4.Enabled = true;
                txtNumeroAposta5.Enabled = true;
                txtNumeroAposta6.Enabled = true;
                txtNumeroAposta7.Enabled = true;
                txtNumeroAposta8.Enabled = true;
                txtNumeroAposta9.Enabled = true;
                txtNumeroAposta10.Enabled = true;
                ///
                txtNumeroAposta1.Visible = true;
                txtNumeroAposta2.Visible = true;
                txtNumeroAposta3.Visible = true;
                txtNumeroAposta4.Visible = true;
                txtNumeroAposta5.Visible = true;
                txtNumeroAposta6.Visible = true;
                txtNumeroAposta7.Visible = true;
                txtNumeroAposta8.Visible = true;
                txtNumeroAposta9.Visible = true;
                txtNumeroAposta10.Visible = true;

                txtNome.Text = dgvApostas.CurrentRow.Cells[3].Value.ToString();
                txtNumeroAposta1.Text = dgvApostas.CurrentRow.Cells[4].Value.ToString();
                txtNumeroAposta2.Text = dgvApostas.CurrentRow.Cells[5].Value.ToString();
                txtNumeroAposta3.Text = dgvApostas.CurrentRow.Cells[6].Value.ToString();
                txtNumeroAposta4.Text = dgvApostas.CurrentRow.Cells[7].Value.ToString();
                txtNumeroAposta5.Text = dgvApostas.CurrentRow.Cells[8].Value.ToString();
                txtNumeroAposta6.Text = dgvApostas.CurrentRow.Cells[9].Value.ToString();
                txtNumeroAposta7.Text = dgvApostas.CurrentRow.Cells[10].Value.ToString();
                txtNumeroAposta8.Text = dgvApostas.CurrentRow.Cells[11].Value.ToString();
                txtNumeroAposta9.Text = dgvApostas.CurrentRow.Cells[12].Value.ToString();
                txtNumeroAposta10.Text = dgvApostas.CurrentRow.Cells[13].Value.ToString();
                con.AbrirCon();
                
            }
            else if (dgvApostas.Columns[e.ColumnIndex] == dgvApostas.Columns["excluir"])
            {
                var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    //CODIGO DO BOTÃO DE EXCLUIR
                    con.AbrirCon();
                    sql = "DELETE FROM apostas WHERE id = @id";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@id", idAposta);
                    cmd.ExecuteNonQuery();
                    con.FecharCon();

                    MessageBox.Show("Registro Excluído com Sucesso!", "Registro Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            Listar();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            lbNome.Visible = false;
            txtNome.Enabled = false;
            txtNome.Visible = false; 
            btnSalvar.Enabled = false;
            btnSalvar.Visible = false;
            btnFechar.Enabled = false;
            btnFechar.Visible = false;
            btnAleatorio.Enabled = false;
            btnAleatorio.Visible = false;
            cbStatus.Enabled = false;
            cbStatus.Visible = false;

            txtNumeroAposta1.Enabled = false;
            txtNumeroAposta2.Enabled = false;
            txtNumeroAposta3.Enabled = false;
            txtNumeroAposta4.Enabled = false;
            txtNumeroAposta5.Enabled = false;
            txtNumeroAposta6.Enabled = false;
            txtNumeroAposta7.Enabled = false;
            txtNumeroAposta8.Enabled = false;
            txtNumeroAposta9.Enabled = false;
            txtNumeroAposta10.Enabled = false;

            txtNumeroAposta1.Visible = false;
            txtNumeroAposta2.Visible = false;
            txtNumeroAposta3.Visible = false;
            txtNumeroAposta4.Visible = false;
            txtNumeroAposta5.Visible = false;
            txtNumeroAposta6.Visible = false;
            txtNumeroAposta7.Visible = false;
            txtNumeroAposta8.Visible = false;
            txtNumeroAposta9.Visible = false;
            txtNumeroAposta10.Visible = false;
            con.AbrirCon();
            dgvApostas.DataSource = null;
            sql = "SELECT id as 'idApostas', nomecartela as 'Cartela', " +
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
                "status, " +
                "data " +
                "FROM apostas order by acertos desc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvApostas.DataSource = dt;
            PintarNumerosSorteados();
            con.FecharCon();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            //CODIGO DO BOTÃO DE EDITAR
            con.AbrirCon();
            sql = "UPDATE apostas SET numeroaposta1=@numeroaposta1," +
                "numeroaposta2=@numeroaposta2," +
                "numeroaposta3=@numeroaposta3, " +
                "numeroaposta4=@numeroaposta4," +
                "numeroaposta5=@numeroaposta5," +
                "numeroaposta6=@numeroaposta6," +
                "numeroaposta7=@numeroaposta7," +
                "numeroaposta8=@numeroaposta8," +
                "numeroaposta9=@numeroaposta9," +
                "numeroaposta10=@numeroaposta10, " +
                "status=@status " +
                "WHERE id=@id";
            cmd = new MySqlCommand(sql, con.con);
                        
            cmd.Parameters.AddWithValue("@numeroaposta1", txtNumeroAposta1.Text.PadLeft(2, '0'));
            cmd.Parameters.AddWithValue("@numeroaposta2", txtNumeroAposta2.Text.PadLeft(2, '0'));
            cmd.Parameters.AddWithValue("@numeroaposta3", txtNumeroAposta3.Text.PadLeft(2, '0'));
            cmd.Parameters.AddWithValue("@numeroaposta4", txtNumeroAposta4.Text.PadLeft(2, '0'));
            cmd.Parameters.AddWithValue("@numeroaposta5", txtNumeroAposta5.Text.PadLeft(2, '0'));
            cmd.Parameters.AddWithValue("@numeroaposta6", txtNumeroAposta6.Text.PadLeft(2, '0'));
            cmd.Parameters.AddWithValue("@numeroaposta7", txtNumeroAposta7.Text.PadLeft(2, '0'));
            cmd.Parameters.AddWithValue("@numeroaposta8", txtNumeroAposta8.Text.PadLeft(2, '0'));
            cmd.Parameters.AddWithValue("@numeroaposta9", txtNumeroAposta9.Text.PadLeft(2, '0'));
            cmd.Parameters.AddWithValue("@numeroaposta10", txtNumeroAposta10.Text.PadLeft(2, '0'));
            cmd.Parameters.AddWithValue("@status", cbStatus.Text);
            cmd.Parameters.AddWithValue("@id", idAposta);

            cmd.ExecuteNonQuery();
            con.FecharCon();

            MessageBox.Show("Aposta Editada com Sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCampos();
            Listar();
        }
        private void limparCampos()
        {
            txtNome.Text = "";
        }
        private void Listar()
        {
            con.AbrirCon();
            dgvApostas.DataSource = null;
            sql = "SELECT id as 'idApostas', nomecartela as 'Cartela', " +
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
                "status, " +
                "data " +
                "FROM apostas order by acertos desc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvApostas.DataSource = dt;
            con.FecharCon();
        }
        private void PintarNumerosSorteados()
        {
            con.AbrirCon();
            //dgvApostas.DataSource = null;
            sql = "SELECT nomecartela as 'Cartela', " +
                "aposta1flag, " +
                "numeroaposta1 as n1, " +
                "aposta2flag, " +
                "numeroaposta2 as n2, " +
                "aposta3flag, " +
                "numeroaposta3 as n3, " +
                "aposta4flag, " +
                "numeroaposta4 as n4, " +
                "aposta5flag, " +
                "numeroaposta5 as n5, " +
                "aposta6flag, " +
                "numeroaposta6 as n6, " +
                "aposta7flag, " +
                "numeroaposta7 as n7, " +
                "aposta8flag, " +
                "numeroaposta8 as n8, " +
                "aposta9flag, " +
                "numeroaposta9 as n9, " +
                "aposta10flag, " +
                "numeroaposta10 as n10 " +
                //"acertos, " +
                //"data " +
                "FROM apostas order by acertos desc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da2 = new MySqlDataAdapter();
            da2.SelectCommand = cmd;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                var flag1 = dt2.Rows[i][1].ToString();
                var numero1 = dt2.Rows[i][2].ToString();
                var flag2 = dt2.Rows[i][3].ToString();
                var numero2 = dt2.Rows[i][4].ToString();
                var flag3 = dt2.Rows[i][5].ToString();
                var numero3 = dt2.Rows[i][6].ToString();
                var flag4 = dt2.Rows[i][7].ToString();
                var numero4 = dt2.Rows[i][8].ToString();
                var flag5 = dt2.Rows[i][9].ToString();
                var numero5 = dt2.Rows[i][10].ToString();
                var flag6 = dt2.Rows[i][11].ToString();
                var numero6 = dt2.Rows[i][12].ToString();
                var flag7 = dt2.Rows[i][13].ToString();
                var numero7 = dt2.Rows[i][14].ToString();
                var flag8 = dt2.Rows[i][15].ToString();
                var numero8 = dt2.Rows[i][16].ToString();
                var flag9 = dt2.Rows[i][17].ToString();
                var numero9 = dt2.Rows[i][18].ToString();
                var flag10 = dt2.Rows[i][19].ToString();
                var numero10 = dt2.Rows[i][20].ToString();

                if (flag1 == "True")
                    dgvApostas.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                if (flag2 == "True")
                    dgvApostas.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                if (flag3 == "True")
                    dgvApostas.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                if (flag4 == "True")
                    dgvApostas.Rows[i].Cells[8].Style.BackColor = Color.Yellow;
                if (flag5 == "True")
                    dgvApostas.Rows[i].Cells[9].Style.BackColor = Color.Yellow;
                if (flag6 == "True")
                    dgvApostas.Rows[i].Cells[10].Style.BackColor = Color.Yellow;
                if (flag7 == "True")
                    dgvApostas.Rows[i].Cells[11].Style.BackColor = Color.Yellow;
                if (flag8 == "True")
                    dgvApostas.Rows[i].Cells[12].Style.BackColor = Color.Yellow;
                if (flag9 == "True")
                    dgvApostas.Rows[i].Cells[13].Style.BackColor = Color.Yellow;
                if (flag10 == "True")
                    dgvApostas.Rows[i].Cells[14].Style.BackColor = Color.Yellow;

            }
        }
        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            
            Random rand = new Random();
            List<int> numApostas = new List<int>();
            bool todosDiferentes = false;

            for (int i = 0; i < 10; i++)
            {
                numApostas.Add(rand.Next(1, 81));
            }

            //Garante que todos os números fiquem diferentes
            while (!todosDiferentes)
            {
                todosDiferentes = numApostas.Distinct().Count() == numApostas.Count();
                if (!todosDiferentes)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        numApostas[i] = rand.Next(1, 81);
                    }
                }
            }

            numApostas.Sort();

            txtNumeroAposta1.Text = numApostas[0].ToString("D2");
            txtNumeroAposta2.Text = numApostas[1].ToString("D2");
            txtNumeroAposta3.Text = numApostas[2].ToString("D2");
            txtNumeroAposta4.Text = numApostas[3].ToString("D2");
            txtNumeroAposta5.Text = numApostas[4].ToString("D2");
            txtNumeroAposta6.Text = numApostas[5].ToString("D2");
            txtNumeroAposta7.Text = numApostas[6].ToString("D2");
            txtNumeroAposta8.Text = numApostas[7].ToString("D2");
            txtNumeroAposta9.Text = numApostas[8].ToString("D2");
            txtNumeroAposta10.Text = numApostas[9].ToString("D2");
        }

    }
}
