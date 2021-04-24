using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        }

       /* private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Participantes";
            Grid.Columns[2].HeaderText = "numeroaposta1";
            Grid.Columns[3].HeaderText = "numeroaposta2";
            Grid.Columns[4].HeaderText = "numeroaposta3";
            Grid.Columns[5].HeaderText = "numeroaposta4";
            Grid.Columns[6].HeaderText = "numeroaposta5";
            Grid.Columns[7].HeaderText = "numeroaposta6";
            Grid.Columns[8].HeaderText = "numeroaposta7";
            Grid.Columns[9].HeaderText = "numeroaposta8";
            Grid.Columns[10].HeaderText = "numeroaposta9";
            Grid.Columns[11].HeaderText = "numeroaposta10";
            Grid.Columns[12].HeaderText = "Data";
            Grid.Columns[13].HeaderText = "Acertos";

            Grid.Columns[0].Visible = false;           

        }*/

        private void CarregaLista()
        {
            con.AbrirCon();
            sql = "SELECT * FROM apostas order by participantes asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            Grid.DataSource = dt;
            con.FecharCon();
            // FormatarDG();
        }

        private void btnAleatorio_Click(object sender, System.EventArgs e)
        {
            Random Aleatorio = new Random();
        }

        private void FrmApostas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarSorteio_Click(object sender, EventArgs e)
        {
            con.AbrirCon();
            sql = "INSERT INTO apostas (id, participantes, numeroaposta1, numeroaposta2, numeroaposta3, numeroaposta4, numeroaposta5, numeroaposta6, numeroaposta7, " +
                "numeroaposta8, numeroaposta9, numeroaposta10, data) VALUES (@id, @participantes, @numeroaposta1, @numeroaposta2, @numeroaposta3, @numeroaposta4, @numeroaposta5, " +
                "@numeroaposta6, @numeroaposta7, @numeroaposta8, @numeroaposta9, @numeroaposta10, curDate())";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@participantes", txtNomeApostador.Text);
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
           
            cmd.ExecuteNonQuery();
            con.FecharCon();
            //FormatarDG();
            CarregaLista();
        }
    }
}
