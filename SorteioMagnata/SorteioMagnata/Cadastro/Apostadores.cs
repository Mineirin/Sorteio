using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SorteioMagnata.Cadastro
{
    public partial class FrmApostadores : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;

        public FrmApostadores()
        {
            InitializeComponent();
        }

        private void CarregarCombobox()
        {
            con.AbrirCon();
            sql = "SELECT * FROM apostadores order by cargo asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbApostador.DataSource = dt;
            cbApostador.DisplayMember = "cargo";
            cbApostador.Text = "Apostador";
            con.FecharCon();
        }
        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Nome";
            Grid.Columns[2].HeaderText = "Celular";
            Grid.Columns[3].HeaderText = "Cargo";

            Grid.Columns[0].Visible = false;

            Grid.Columns[1].Width = 300;
            Grid.Columns[2].Width = 200;
            Grid.Columns[3].Width = 200;
            Grid.Columns[4].Width = 120;
        }

        private void Listar()
        {
            con.AbrirCon();
            sql = "SELECT * FROM apostadores order by nome asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            Grid.DataSource = dt;
            con.FecharCon();
            FormatarDG();
        }
        private void BuscarNome()
        {
            con.AbrirCon();
            sql = "SELECT * FROM apostadores where nome LIKE @nome order by nome asc";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtBuscar.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            Grid.DataSource = dt;
            con.FecharCon();
            FormatarDG();
        }

        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtCelular.Enabled = true;
        }

        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCelular.Enabled = false;
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtCelular.Text = "";
        }

        private void FrmApostadores_Load(object sender, EventArgs e)
        {
            CarregarCombobox();
            Listar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            cbApostador.Enabled = false;
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtCelular.Text.ToString().Trim() == "(  )     -")
            {
                MessageBox.Show("Preencha o Celular", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCelular.Text = "";
                txtCelular.Focus();
                return;
            }

            //CODIGO DO BOTÃO DE SALVAR
            con.AbrirCon();
            sql = "INSERT INTO apostadores (nome, celular, cargo, data) VALUES (@nome, @celular, @cargo, curDate())";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@celular", txtCelular.Text);
            cmd.Parameters.AddWithValue("@cargo", cbApostador.Text);

            //VERIFICAR SE O NUMERO DE CELULAR JA EXISTE NO BANCO
            MySqlCommand cmdVerificar;
            con.AbrirCon();
            cmdVerificar = new MySqlCommand("SELECT * FROM apostadores WHERE celular = @celular", con.con);
            cmdVerificar.Parameters.AddWithValue("@celular", txtCelular.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdVerificar;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Celular ja Registrado!", "Erro ao Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCelular.Text = "";
                txtCelular.Focus();
                return;
            }
            FormatarDG();

            cmd.ExecuteNonQuery();
            con.FecharCon();

            MessageBox.Show("Registro Salvo com Sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            limparCampos();
            desabilitarCampos();
            Listar();

        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            habilitarCampos();

            id = Grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txtCelular.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            cbApostador.Text = Grid.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtCelular.Text.ToString().Trim() == "(  )     -")
            {
                MessageBox.Show("Preencha o Celular", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCelular.Text = "";
                txtCelular.Focus();
                return;
            }

            //CODIGO DO BOTÃO DE EDITAR
            con.AbrirCon();
            sql = "UPDATE apostadores SET nome = @nome, celular = @celular where id = @id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@celular", txtCelular.Text);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.FecharCon();

            MessageBox.Show("Registro Editado com Sucesso!", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnEditar.Enabled = false;
            limparCampos();
            desabilitarCampos();
            Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //CODIGO DO BOTÃO DE EXCLUIR
                con.AbrirCon();
                sql = "DELETE FROM apostadores WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.FecharCon();

                MessageBox.Show("Registro Excluído com Sucesso!", "Registro Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnEditar.Enabled = false;
                txtNome.Text = "";
                txtNome.Enabled = false;

                Listar();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }
    }
}
