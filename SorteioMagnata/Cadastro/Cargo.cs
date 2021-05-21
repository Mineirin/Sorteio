using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SorteioMagnata.Cadastro
{
    public partial class FrmCargo : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;

        public FrmCargo()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Cargo";

            Grid.Columns[0].Visible = false;

            Grid.Columns[1].Width = 200;
        }

        private void Listar()
        {
            con.AbrirCon();
            sql = "SELECT * FROM cargos order by cargo asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            Grid.DataSource = dt;
            con.FecharCon();
            FormatarDG();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o Cargo", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            //CODIGO DO BOTÃO DE SALVAR
            con.AbrirCon();
            sql = "INSERT INTO cargos (cargo) VALUES (@cargo)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cargo", txtNome.Text);
            cmd.ExecuteNonQuery();
            con.FecharCon();

            MessageBox.Show("Registro Salvo com Sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            txtNome.Text = "";
            txtNome.Enabled = false;
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;

            id = Grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txtNome.Enabled = true;
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
            sql = "UPDATE cargos SET cargo = @cargo where id = @id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cargo", txtNome.Text);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.FecharCon();

            MessageBox.Show("Registro Editado com Sucesso!", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnEditar.Enabled = false;
            txtNome.Text = "";
            txtNome.Enabled = false;
            Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //CODIGO DO BOTÃO DE EXCLUIR
                con.AbrirCon();
                sql = "DELETE FROM cargos WHERE id = @id";
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

        private void FrmCargo_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
