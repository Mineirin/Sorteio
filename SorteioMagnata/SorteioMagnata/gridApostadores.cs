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
    public partial class gridEditApostadores : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        int idApost;
        public gridEditApostadores()
        {
            InitializeComponent();
        }
        private void gridEditApostadores_Load(object sender, EventArgs e)
        {
            con.AbrirCon();
            dgvApostadores.DataSource = null;
            sql = "SELECT * FROM apostadores order by nome asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvApostadores.DataSource = dt;
            con.FecharCon();

        }

        private void dgvApostadores_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgvApostadores.Columns)
            {
                switch (coluna.Name)
                {
                    case "id":
                        coluna.Visible = false;
                        break;
                    case "nome":
                        coluna.Width = 300;
                        coluna.HeaderText = "Nome";
                        break;
                    case "celular":
                        coluna.Width = 200;
                        coluna.HeaderText = "Celular";
                        break;
                    case "cargo":
                        coluna.Width = 100;
                        coluna.HeaderText = "Cargo";
                        break;
                    case "editar":
                        coluna.DisplayIndex = 5;
                        coluna.Width = 30;
                        break;
                    case "excluir":
                        coluna.DisplayIndex = 6;
                        coluna.Width = 30;
                        break;
                    default:
                        break;
                }
            }
        }

        private void dgvApostadores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvApostadores.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
            dgvApostadores.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir";
        }

        private void dgvApostadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idApost = Convert.ToInt32(dgvApostadores.Rows[e.RowIndex].Cells["id"].Value.ToString());
            if(dgvApostadores.Columns[e.ColumnIndex] == dgvApostadores.Columns["editar"])
            {
                lbNome.Visible = true;
                lbCelular.Visible = true;
                txtNome.Enabled = true;
                txtNome.Visible = true;
                txtCelular.Enabled = true;
                txtCelular.Visible = true;
                btnSalvar.Enabled = true;
                btnSalvar.Visible = true;
                btnFechar.Enabled = true;
                btnFechar.Visible = true;
                txtNome.Text = dgvApostadores.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtCelular.Text = dgvApostadores.Rows[e.RowIndex].Cells["celular"].Value.ToString();
            }
            else if (dgvApostadores.Columns[e.ColumnIndex] == dgvApostadores.Columns["excluir"])
            {
                var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    //CODIGO DO BOTÃO DE EXCLUIR
                    con.AbrirCon();
                    sql = "DELETE FROM apostadores WHERE id = @id";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@id", idApost);
                    cmd.ExecuteNonQuery();
                    con.FecharCon();

                    MessageBox.Show("Registro Excluído com Sucesso!", "Registro Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listar();
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            lbNome.Visible = false;
            lbCelular.Visible = false;
            txtNome.Enabled = false;
            txtNome.Visible = false;
            txtCelular.Enabled = false;
            txtCelular.Visible = false;
            btnSalvar.Enabled = false;
            btnSalvar.Visible = false;
            btnFechar.Enabled = false;
            btnFechar.Visible = false;
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

            //CODIGO DO BOTÃO DE EDITAR
            con.AbrirCon();
            sql = "UPDATE apostadores SET nome = @nome, celular = @celular where id = @id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@celular", txtCelular.Text);
            cmd.Parameters.AddWithValue("@id", idApost);
            cmd.ExecuteNonQuery();
            con.FecharCon();

            MessageBox.Show("Registro Editado com Sucesso!", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            Listar();
            limparCampos();
        }
        private void limparCampos()
        {
            txtNome.Text = "";
            txtCelular.Text = "";
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

            dgvApostadores.DataSource = dt;
            con.FecharCon();
        }
    }
}
