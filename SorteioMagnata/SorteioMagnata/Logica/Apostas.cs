using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SorteioMagnata.Logica
{
    public partial class FrmApostas : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;

        
        public FrmApostas()
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

        private void btnAleatorio_Click(object sender, System.EventArgs e)
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

            txtNumeroAposta1.Text = rand.Next(1, 81).ToString();
            txtNumeroAposta2.Text = rand.Next(1, 81).ToString();
            txtNumeroAposta3.Text = rand.Next(1, 81).ToString();
            txtNumeroAposta4.Text = rand.Next(1, 81).ToString();
            txtNumeroAposta5.Text = rand.Next(1, 81).ToString();
            txtNumeroAposta6.Text = rand.Next(1, 81).ToString();
            txtNumeroAposta7.Text = rand.Next(1, 81).ToString();
            txtNumeroAposta8.Text = rand.Next(1, 81).ToString();
            txtNumeroAposta9.Text = rand.Next(1, 81).ToString();
            txtNumeroAposta10.Text = rand.Next(1, 81).ToString();

        }

        private void FrmApostas_Load(object sender, EventArgs e)
        {

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

            //CODIGO DO BOTÃO DE SALVAR
            con.AbrirCon();
            sql = "INSERT INTO apostas " +
                "(nomecartela, " +
                "idapostador, " +
                "numeroaposta1, aposta1flag," +
                " numeroaposta2, aposta2flag," +
                " numeroaposta3, aposta3flag," +
                " numeroaposta4, aposta4flag," +
                " numeroaposta5, aposta5flag," +
                " numeroaposta6, aposta6flag," +
                " numeroaposta7, aposta7flag," +
                " numeroaposta8, aposta8flag," +
                " numeroaposta9, aposta9flag," +
                "  numeroaposta10, aposta10flag," +
                " data) " +
                "VALUES " +
               "(@nomecartela, " +
               "@idapostador, " +
               "@numeroaposta1, FALSE," +
               " @numeroaposta2, FALSE," +
               " @numeroaposta3, FALSE," +
               " @numeroaposta4, FALSE," +
               " @numeroaposta5, FALSE," +
               " @numeroaposta6, FALSE," +
               " @numeroaposta7, FALSE," +
               " @numeroaposta8, FALSE," +
               " @numeroaposta9, FALSE," +
               " @numeroaposta10, FALSE," +
               " curDate())";
            cmd = new MySqlCommand(sql, con.con);
            
            cmd.Parameters.AddWithValue("@idapostador", cb_Apostadores.SelectedValue);
            cmd.Parameters.AddWithValue("@numeroaposta1", txtNumeroAposta1.Text);
            cmd.Parameters.AddWithValue("@numeroaposta2", txtNumeroAposta2.Text);
            cmd.Parameters.AddWithValue("@numeroaposta3", txtNumeroAposta3.Text);
            cmd.Parameters.AddWithValue("@numeroaposta4", txtNumeroAposta4.Text);
            cmd.Parameters.AddWithValue("@numeroaposta5", txtNumeroAposta5.Text);
            cmd.Parameters.AddWithValue("@numeroaposta6", txtNumeroAposta6.Text);
            cmd.Parameters.AddWithValue("@numeroaposta7", txtNumeroAposta7.Text);
            cmd.Parameters.AddWithValue("@numeroaposta8", txtNumeroAposta8.Text);
            cmd.Parameters.AddWithValue("@numeroaposta9", txtNumeroAposta9.Text);
            cmd.Parameters.AddWithValue("@numeroaposta10", txtNumeroAposta10.Text);

            //COUNT ID APOSTADOR PARA VER QUAL NOME COLOCAR
            MySqlCommand cmdVerificar;
            cmdVerificar = new MySqlCommand("SELECT idapostador FROM apostas WHERE idapostador = @idapostador", con.con);
            cmdVerificar.Parameters.AddWithValue("@idapostador", cb_Apostadores.SelectedValue);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdVerificar;
            DataTable dt = new DataTable();
            da.Fill(dt);
            string nomeCartela = cb_Apostadores.Text + " (" + (dt.Rows.Count + 1).ToString() + ")";
            cmd.Parameters.AddWithValue("@nomecartela", nomeCartela);

            cmd.ExecuteNonQuery();
            con.FecharCon();

            MessageBox.Show("Aposta Realizada com Sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            Grid.Columns[0].Width = 100;
            Grid.Columns[1].Width = 25;
            Grid.Columns[2].Width = 25;
            Grid.Columns[3].Width = 25;
            Grid.Columns[4].Width = 25;
            Grid.Columns[5].Width = 25;
            Grid.Columns[6].Width = 25;
            Grid.Columns[7].Width = 25;
            Grid.Columns[8].Width = 25;
            Grid.Columns[9].Width = 25;
            Grid.Columns[10].Width = 35;
            Grid.Columns[11].Visible = false;
            Grid.Columns[12].Width = 100;
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con.AbrirCon();
            Grid.DataSource = null;
            sql = "SELECT nomecartela as 'Cartela', " +
                "acertos, " +
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
                "data " +
                "FROM apostas order by nomecartela asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            Grid.DataSource = dt;
            con.FecharCon();
            Listar();
        }


    }
}
