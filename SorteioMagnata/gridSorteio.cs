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
    public partial class gridSorteio : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;
        public gridSorteio()
        {
            InitializeComponent();
        }

        private void gridSorteio_Load(object sender, EventArgs e)
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
            FormatarDGSorteios();
            con.FecharCon();
        }
        private void FormatarDGSorteios()
        {
            Grid.Columns[0].HeaderText = "Nome do Sorteio";
            Grid.Columns[1].HeaderText = "";
            Grid.Columns[2].HeaderText = "";
            Grid.Columns[3].HeaderText = "";
            Grid.Columns[4].HeaderText = "";
            Grid.Columns[5].HeaderText = "";
            Grid.Columns[6].HeaderText = "Data do Sorteio";

            Grid.Columns[0].Width = 300;
            Grid.Columns[1].Width = 50;
            Grid.Columns[2].Width = 50;
            Grid.Columns[3].Width = 50;
            Grid.Columns[4].Width = 50;
            Grid.Columns[5].Width = 50;
            Grid.Columns[6].Width = 200;
        }
    }
}
