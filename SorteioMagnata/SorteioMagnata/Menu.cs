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
        private void FormatarDGPadrao()
        {
            for (int i = 0; i < Grid.Columns.Count; i++)
            {
                Grid.Columns[i].Width = 200;
            }
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
        }

        private void FormatarDGSorteios()
        {
            Grid.Columns[0].HeaderText = "Nome do Sorteio";
            Grid.Columns[1].HeaderText = "";
            Grid.Columns[2].HeaderText = "";
            Grid.Columns[3].HeaderText = "";
            Grid.Columns[4].HeaderText = "";
            Grid.Columns[5].HeaderText = "";
            Grid.Columns[6].HeaderText = "Data";

            Grid.Columns[0].Width = 350;
            Grid.Columns[1].Width = 50;
            Grid.Columns[2].Width = 50;
            Grid.Columns[3].Width = 50;
            Grid.Columns[4].Width = 50;
            Grid.Columns[5].Width = 60;
            Grid.Columns[6].Width = 150;
        }
        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Nome";
            Grid.Columns[2].HeaderText = "Celular";
            Grid.Columns[3].HeaderText = "Cargo";
            Grid.Columns[4].HeaderText = "Data";

            Grid.Columns[0].Visible = false;

            Grid.Columns[1].Width = 300;
            Grid.Columns[2].Width = 200;
            Grid.Columns[3].Width = 100;
            Grid.Columns[4].Width = 100;

        }

        private void btnApostadores_Click(object sender, EventArgs e)
        {
            con.AbrirCon();
            Grid.DataSource = null;
            sql = "SELECT * FROM apostadores order by nome asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            Grid.DataSource = dt;
            FormatarDGPadrao();
            con.FecharCon();
            FormatarDG();

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
        }

        private void btnCambistas_Click(object sender, EventArgs e)
        {
            con.AbrirCon();
            Grid.DataSource = null;
            sql = "SELECT * FROM cambistas order by nome asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            Grid.DataSource = dt;
            FormatarDGPadrao();
            con.FecharCon();
            FormatarDG();

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
        }

        private void btnApostas_Click(object sender, EventArgs e)
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
            PintarNumerosSorteados();
            con.FecharCon();
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Chk";
            dgvCmb.HeaderText = "Todos";
            Grid.Columns.Add(dgvCmb);
           
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
        }

        private void PintarNumerosSorteados()
        {
            con.AbrirCon();
            //Grid.DataSource = null;
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
                    Grid.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                if (flag2 == "True")
                    Grid.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                if (flag3 == "True")
                    Grid.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                if (flag4 == "True")
                    Grid.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                if (flag5 == "True")
                    Grid.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
                if (flag6 == "True")
                    Grid.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                if (flag7 == "True")
                    Grid.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                if (flag8 == "True")
                    Grid.Rows[i].Cells[8].Style.BackColor = Color.Yellow;
                if (flag9 == "True")
                    Grid.Rows[i].Cells[9].Style.BackColor = Color.Yellow;
                if (flag10 == "True")
                    Grid.Rows[i].Cells[10].Style.BackColor = Color.Yellow;

            }
        }

        private void btnSorteios_Click(object sender, EventArgs e)
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
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;

            List<int> listaExclusao = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                listaExclusao.Add(i);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Logica.EditarAposta form = new Logica.EditarAposta();
            form.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string txt = "";
            if()
        }
    }
}
