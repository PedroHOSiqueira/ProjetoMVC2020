using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoMVCB34.DTO
{
    public class tblclienteDTO
    {
        private int id_cliente;
        private string nome_cliente, cpf_cliente, nome_mae;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }


        public string Nome_cliente
        {
            set
            {
                if(value != string.Empty)
                {
                    this.nome_cliente = value;
                }
                else
                {
                    throw new Exception("O campo 'Nome completo' é obrigatório ");
                }
            }

            get { return this.nome_cliente; }

        }
        public string Nome_mae
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome_mae = value;
                }
                else
                {
                    throw new Exception("O campo 'Nome da Mãe' é obrigatório ");
                }
            }

            get { return this.nome_mae; }

        }
        public string Cpf_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.cpf_cliente = value;
                }
                else
                {
                    throw new Exception("O campo 'CPF' é obrigatório ");
                }
            }

            get { return this.cpf_cliente; }

        }
    }
}