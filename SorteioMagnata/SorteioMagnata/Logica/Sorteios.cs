using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SorteioMagnata.Logica
{
    public partial class FrmSorteios : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;

        public FrmSorteios()
        {
            InitializeComponent();
        }

        static void Lista(string[] args)
        {
            List<Int32> NumerosSorteio;
            NumerosSorteio = new List<Int32>();

            for (int i = 1; i < 80; i++)
            {
                NumerosSorteio.Add(i);
            }

            foreach (var item in NumerosSorteio)
            {

            }
        }

        private void telaSorteio()
        {
            lblNomeSorteio.Text = txtNomeSorteio.Text;
            lblNumero1.Text = txtNumero1.Text;
            lblNumero2.Text = txtNumero2.Text;
            lblNumero3.Text = txtNumero3.Text;
            lblNumero4.Text = txtNumero4.Text;
            lblNumero5.Text = txtNumero5.Text;
        }

        private void FrmSorteios_Load(object sender, System.EventArgs e)
        {
            
        }

        private void txtNomeSorteio_TextChanged(object sender, System.EventArgs e)
        {
            telaSorteio();
        }

        private void txtNumero1_TextChanged(object sender, System.EventArgs e)
        {
            telaSorteio();
        }
    }
}
