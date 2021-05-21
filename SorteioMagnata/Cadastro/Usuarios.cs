using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SorteioMagnata.Cadastro
{
    public partial class FrmUsuarios : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void CarregarCombobox()
        {
            con.AbrirCon();
            sql = "SELECT * FROM cargos order by cargo asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbUsuario.DataSource = dt;
            cbUsuario.DisplayMember = "cargo";
            con.FecharCon();
        }
        private void FormatarDG()
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

        private void Listar()
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
            FormatarDG();
        }
        private void BuscarNome()
        {
            con.AbrirCon();
            sql = "SELECT * FROM usuarios where nome LIKE @nome order by nome asc";
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
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            cbUsuario.Enabled = true;

        }

        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CarregarCombobox();
            Listar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (cbUsuario.Text == "")
            {
                MessageBox.Show("Cadastre um Cargo Antes!!");
                Close();
            }
            habilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            txtNome.Focus(); ;
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

            //CODIGO DO BOTÃO DE SALVAR
            con.AbrirCon();
            sql = "INSERT INTO usuarios (nome, cargo, usuario, senha, data) VALUES (@nome, @cargo, @usuario, @senha, curDate())";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cargo", cbUsuario.Text);
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

            //VERIFICAR SE O NOME DE USUARIO JA EXISTE NO BANCO
            MySqlCommand cmdVerificar;
            con.AbrirCon();
            cmdVerificar = new MySqlCommand("SELECT * FROM usuarios WHERE usuario = @usuario", con.con);
            cmdVerificar.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdVerificar;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Usuário ja Registrado!", "Erro ao Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtUsuario.Focus();
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
            cbUsuario.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            txtUsuario.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            txtSenha.Text = Grid.CurrentRow.Cells[4].Value.ToString();
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
            

            //CODIGO DO BOTÃO DE EDITAR
            con.AbrirCon();
            sql = "UPDATE usuarios SET nome = @nome, cargo = @cargo, usuario = @usuario, senha = @senha where id = @id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cargo", cbUsuario.Text);
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
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
                sql = "DELETE FROM usuarios WHERE id = @id";
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
                limparCampos();
                desabilitarCampos();
                Listar();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }
    }
}
