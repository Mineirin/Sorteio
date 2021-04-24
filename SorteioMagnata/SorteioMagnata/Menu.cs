using MySql.Data.MySqlClient;
using System;
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

        public FrmMenu()
        {
            InitializeComponent();
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
            pnlMenu.Location = new Point(this.Width / 2 - 500, this.Height / 2 - 500);
        }

        private void pnlMenuGrid_Paint(object sender, PaintEventArgs e)
        {
            pnlMenuGrid.Location = new Point(this.Width / 2 - 480, this.Height / 2 - 250);
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

        private void FormatarDGUser()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Nome";
            Grid.Columns[2].HeaderText = "Cargo";
            Grid.Columns[3].HeaderText = "Usuario";
            Grid.Columns[4].HeaderText = "Senha";
            Grid.Columns[5].HeaderText = "Data";

            Grid.Columns[0].Visible = false;

            Grid.Columns[1].Width = 200;
            Grid.Columns[2].Width = 150;
            Grid.Columns[3].Width = 200;
            Grid.Columns[4].Width = 150;
            Grid.Columns[5].Width = 120;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            con.AbrirCon();
            sql = "SELECT * FROM usuarios order by nome asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            Grid.DataSource = dt;
            con.FecharCon();
        }
        
    }
}
