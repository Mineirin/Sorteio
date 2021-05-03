using MySql.Data.MySqlClient;
using System;

namespace SorteioMagnata
{
    class Conexao
    {

        //CONEXÃO COM O BANCO DE DADOS LOCAL
        string conex = "SERVER=localhost; DATABASE=sorteio; UID=root; PWD=; PORT=;";
        public MySqlConnection con = null;
        public void AbrirCon()
        {
            try
            {
                con = new MySqlConnection(conex);
                con.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void FecharCon()
        {
            try
            {
                con = new MySqlConnection(conex);
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
