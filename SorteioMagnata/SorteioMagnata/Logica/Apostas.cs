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
            
        }

        private void btnAleatorio_Click(object sender, System.EventArgs e)
        {
            
        }

        private void FrmApostas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarSorteio_Click(object sender, EventArgs e)
        {
            
        }
    }
}
