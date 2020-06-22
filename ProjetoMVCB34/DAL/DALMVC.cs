using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetoMVCB34.DAL
{
    public class DALMVC
    {
        private string conexao = "Persist Security info=false ; server=localhost; database=ProjetoMVCB34;user=root;pwd=;";
        private  MySqlConnection connection;

        public void Conectar()
        {
            try
            {
                connection = new MySqlConnection(conexao);
                connection.Open();
            }
            catch (MySqlException error)
            {
                throw new Exception("Falha ao conectar com o Banco de Dados!" + error.Message);
            }
        }

        // Não retorna dados - Insert/Delete/Update
        public void executarComando(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            catch (MySqlException error)
            {
                throw new Exception("Não foi possível executar o comando no Banco de Dados!" + error.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        // Retorna dados - Select
        public DataTable Consultar(string sql)
        {
            try
            {
                Conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, connection);
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException error)
            {
                throw new Exception("Falha na consulta com o Banco de Dados!" + error.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}