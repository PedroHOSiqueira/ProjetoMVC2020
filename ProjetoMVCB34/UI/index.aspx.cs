using ProjetoMVCB34.BLL;
using ProjetoMVCB34.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoMVCB34.UI
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_enviar_Click(object sender, EventArgs e)
        {

            try
            {
                tblclienteDTO objDTO = new tblclienteDTO();
                objDTO.Cpf_cliente = txtCpfB34.Text;
                objDTO.Nome_mae = txtNomeMaeB34.Text;
                objDTO.Nome_cliente = txtNomeB34.Text;

                tblclienteBLL objBLL = new tblclienteBLL();
                if (objBLL.autenticar(objDTO.Nome_cliente, objDTO.Cpf_cliente, objDTO.Nome_mae))
                {
                    lbl_erro.Visible = true;
                    lbl_erro.Text = "Beneficiário Localizado no Banco de Dados. Processo em análise.";
                    img_encontrado.Visible = true;
                    img_nao_encontrado.Visible = false;

                }
                else
                {
                    lbl_erro.Visible = true;
                    lbl_erro.Text = "Beneficiário Não Localizado no Banco de dados. Benefício Negado";
                    img_nao_encontrado.Visible = true;
                    img_encontrado.Visible = false;
                }

            }
            catch (Exception error)
            {
                lbl_erro.Visible = true;
                lbl_erro.Text = error.Message;
                img_nao_encontrado.Visible = true;
                img_encontrado.Visible = false;
            }
        }
    }
}