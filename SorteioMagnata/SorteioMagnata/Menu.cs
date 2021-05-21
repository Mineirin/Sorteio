using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SorteioMagnata
{
    public partial class FrmMenu : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;

        private readonly DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

        public FrmMenu()
        {
            InitializeComponent();

            con.AbrirCon();

            #region Contagem Apostadores
            sql = "SELECT COUNT(ID) as id FROM apostadores";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da1 = new MySqlDataAdapter();
            da1.SelectCommand = cmd;

            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            string rowCount1 = dt1.Rows[0]["id"].ToString();
            lbl_Apostadores.Text = rowCount1;
            #endregion Contagem Apostadores

            #region Contagem Cambistas
            sql = "SELECT COUNT(ID) as id FROM cambistas";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da2 = new MySqlDataAdapter();
            da2.SelectCommand = cmd;

            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            string rowCount2 = dt2.Rows[0]["ID"].ToString();
            lbl_Cambistas.Text = rowCount2;
            #endregion Contagem Cambistas

            #region Contagem Apostas
            sql = "SELECT COUNT(ID) as id FROM apostas";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da3 = new MySqlDataAdapter();
            da3.SelectCommand = cmd;

            DataTable dt3 = new DataTable();
            da3.Fill(dt3);

            string rowCount3 = dt3.Rows[0]["id"].ToString();
            lbl_Apostas.Text = rowCount3;
            #endregion Contagem Apostas

            #region Contagem Sorteios
            sql = "SELECT COUNT(ID) as id FROM resultsorteio";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da4 = new MySqlDataAdapter();
            da4.SelectCommand = cmd;

            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            string rowCount4 = dt4.Rows[0]["id"].ToString();
            lbl_Sorteios.Text = rowCount4;
            #endregion Contagem Sorteios

            con.FecharCon();
           
        }

        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            FrmLogin form = new FrmLogin();
            form.Show();
        }


        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {
            pnlMenu.Location = new Point(this.Width / 2 - 480, this.Height / 2 - 350);
        }

        private void pnlMenuGrid_Paint(object sender, PaintEventArgs e)
        {
            pnlMenuGrid.Location = new Point(this.Width / 2 - 480, this.Height / 2 - 100);
        }

        private void apostadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.FrmApostadores form = new Cadastro.FrmApostadores();
            form.Show();
        }

        private void cambistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.FrmCambistas form = new Cadastro.FrmCambistas();
            form.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.FrmUsuarios form = new Cadastro.FrmUsuarios();
            form.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.FrmCargo form = new Cadastro.FrmCargo();
            form.Show();
        }

        private void novoSorteioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logica.FrmSorteios form = new Logica.FrmSorteios();
            form.Show();
        }

        private void novaApostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logica.FrmApostas form = new Logica.FrmApostas();
            form.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Program.nomeUsuario;
            lblCargo.Text = Program.cargoUsuario;
            
        }
        

        private void FormatarDGApostas()
        {
            /*Grid.Columns[0].HeaderText = "Participantes";
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
            Grid.Columns[13].HeaderText = "";
            Grid.Columns[14].HeaderText = "";

            Grid.Columns[0].Width =180;
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
            Grid.Columns[11].Width = 60;
            Grid.Columns[12].Width = 80;
            Grid.Columns[13].Width = 30;
            Grid.Columns[14].Width = 30;*/
        }
        private void btnApostadores_Click(object sender, EventArgs e)
        {
            gridEditApostadores form = new gridEditApostadores();
            form.Show();
            form.Location = new Point(this.Width / 2 - 430, this.Height / 2 - 20);
        }

        private void btnCambistas_Click(object sender, EventArgs e)
        {
            gridCambistas form = new gridCambistas();
            form.Show();
            form.Location = new Point(this.Width / 2 - 430, this.Height / 2 - 20);
        }

        private void btnApostas_Click(object sender, EventArgs e)
        {
            gridApostas form = new gridApostas();
            form.Show();
            form.Location = new Point(this.Width / 2 - 430, this.Height / 2 - 20);
        }

       
        

       /* private void btnSorteios_Click(object sender, EventArgs e)
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

        }*/

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
