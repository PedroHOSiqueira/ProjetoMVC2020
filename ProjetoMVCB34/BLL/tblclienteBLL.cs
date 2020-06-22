using ProjetoMVCB34.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetoMVCB34.BLL
{
    public class tblclienteBLL
    {

        private DALMVC DalBanco = new DALMVC();

        public Boolean autenticar(string nome, string cpf, string mae)
        {
            string consulta = string.Format($@"select * from tbl_clienteB34 where nome_cliente = '{nome}' and nome_mae = '{mae}' and cpf_cliente = '{cpf}';");
            DataTable dt = DalBanco.Consultar(consulta);
            if(dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}