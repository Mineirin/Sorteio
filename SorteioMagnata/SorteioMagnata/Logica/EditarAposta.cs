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

namespace SorteioMagnata.Logica
{
    public partial class EditarAposta : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;
        public EditarAposta()
        {
            InitializeComponent();
            con.AbrirCon();

            #region Popular Apostadores na Combo
            sql = "SELECT id, nome FROM apostadores order by nome asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da1 = new MySqlDataAdapter();
            da1.SelectCommand = cmd;

            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            cb_Apostadores.DisplayMember = "nome";
            cb_Apostadores.ValueMember = "id";
            cb_Apostadores.DataSource = dt1;

            #endregion Popular Apostadores na Combo

            con.FecharCon();
        }

        private void Listar()
        {
            con.AbrirCon();
            GridEditAposta.DataSource = null;
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

            GridEditAposta.DataSource = dt;
            FormatarDGApostas();
            con.FecharCon();
        }

        private void FormatarDGApostas()
        {
            GridEditAposta.Columns[0].HeaderText = "Participantes";
            GridEditAposta.Columns[1].HeaderText = "";
            GridEditAposta.Columns[2].HeaderText = "";
            GridEditAposta.Columns[3].HeaderText = "";
            GridEditAposta.Columns[4].HeaderText = "";
            GridEditAposta.Columns[5].HeaderText = "";
            GridEditAposta.Columns[6].HeaderText = "";
            GridEditAposta.Columns[7].HeaderText = "";
            GridEditAposta.Columns[8].HeaderText = "";
            GridEditAposta.Columns[9].HeaderText = "";
            GridEditAposta.Columns[10].HeaderText = "";
            GridEditAposta.Columns[11].HeaderText = "Acertos";
            GridEditAposta.Columns[12].HeaderText = "Data";

            GridEditAposta.Columns[0].Width = 100;
            GridEditAposta.Columns[1].Width = 25;
            GridEditAposta.Columns[2].Width = 25;
            GridEditAposta.Columns[3].Width = 25;
            GridEditAposta.Columns[4].Width = 25;
            GridEditAposta.Columns[5].Width = 25;
            GridEditAposta.Columns[6].Width = 25;
            GridEditAposta.Columns[7].Width = 25;
            GridEditAposta.Columns[8].Width = 25;
            GridEditAposta.Columns[9].Width = 25;
            GridEditAposta.Columns[10].Width = 35;
            GridEditAposta.Columns[11].Visible = false;
            GridEditAposta.Columns[12].Width = 100;
        }

        private void EditarAposta_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalvarSorteio_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumeroAposta1.Text.ToString())
                || String.IsNullOrEmpty(txtNumeroAposta2.Text.ToString())
                || String.IsNullOrEmpty(txtNumeroAposta3.Text.ToString())
                || String.IsNullOrEmpty(txtNumeroAposta4.Text.ToString())
                || String.IsNullOrEmpty(txtNumeroAposta5.Text.ToString())
                || String.IsNullOrEmpty(txtNumeroAposta6.Text.ToString())
                || String.IsNullOrEmpty(txtNumeroAposta7.Text.ToString())
                || String.IsNullOrEmpty(txtNumeroAposta8.Text.ToString())
                || String.IsNullOrEmpty(txtNumeroAposta9.Text.ToString())
                || String.IsNullOrEmpty(txtNumeroAposta10.Text.ToString()))
            {
                MessageBox.Show("Preencha TODOS os números, por favor!", "Campo(s) Vazio(s)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
                "numeroaposta10=@numeroaposta10 " +
                "WHERE idApostador=@idapostador";
            cmd = new MySqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@idapostador", cb_Apostadores.SelectedValue);
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
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            con.FecharCon();

            MessageBox.Show("Aposta Editada com Sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCampos();
            Listar();
        }

        private void limparCampos()
        {
            txtNumeroAposta1.Text = "";
            txtNumeroAposta2.Text = "";
            txtNumeroAposta3.Text = "";
            txtNumeroAposta4.Text = "";
            txtNumeroAposta5.Text = "";
            txtNumeroAposta6.Text = "";
            txtNumeroAposta7.Text = "";
            txtNumeroAposta8.Text = "";
            txtNumeroAposta9.Text = "";
            txtNumeroAposta10.Text = "";
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

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = GridEditAposta.CurrentRow.Cells[0].Value.ToString();
            txtNumeroAposta1.Text = GridEditAposta.CurrentRow.Cells[1].Value.ToString();
            txtNumeroAposta2.Text = GridEditAposta.CurrentRow.Cells[2].Value.ToString();
            txtNumeroAposta3.Text = GridEditAposta.CurrentRow.Cells[3].Value.ToString();
            txtNumeroAposta4.Text = GridEditAposta.CurrentRow.Cells[4].Value.ToString();
            txtNumeroAposta5.Text = GridEditAposta.CurrentRow.Cells[5].Value.ToString();
            txtNumeroAposta6.Text = GridEditAposta.CurrentRow.Cells[6].Value.ToString();
            txtNumeroAposta7.Text = GridEditAposta.CurrentRow.Cells[7].Value.ToString();
            txtNumeroAposta8.Text = GridEditAposta.CurrentRow.Cells[8].Value.ToString();
            txtNumeroAposta9.Text = GridEditAposta.CurrentRow.Cells[9].Value.ToString();
            txtNumeroAposta10.Text = GridEditAposta.CurrentRow.Cells[10].Value.ToString();
            Listar();

        }
    }
    
}
