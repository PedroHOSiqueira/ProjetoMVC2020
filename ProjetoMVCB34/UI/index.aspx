<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ProjetoMVCB34.UI.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Benefício</title>
    <link href="../Content/bootstrap.css" rel="stylesheet"/>
   
    <style>
        body{
            margin: 0;
            font-family: 'Toma Sans';
        }
        .form-control{
            text-align: center;
            border-radius: 10px;
            width: 300px;
        }
        .labels{
            font-weight: bolder;
            font-size: 15px;
        }
        .btn{
            text-transform: uppercase;
            font-weight: 800;
            width: 350px;
            border-radius: 5px;
        }
        .container{
            margin-top: 10px;
            position: center;
            width: 700px;
        }
        .card{
            background-color: ghostwhite;
            border-bottom-left-radius: 20px;
            border-top-right-radius: 20px;
        
        }
        .card-header{
            border: double;
            background-color: lightslategrey;
            width: 700px;
            text-align:center;
        }
        .card_title{
            color: white;
            font-size: 30px;
            font-weight: 800;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
           <div class="card-header">
                <asp:Label ID="lbl_title" runat="server" class="card_title" Text="Verificação de Benefício"></asp:Label>
               <br />
               <asp:Image ID="img_title" runat="server" src="Images/money (1).png" />
               <div class="card">
                    <center>
                         <br />
                       <asp:Label ID="lbl_cpf" runat="server" class="labels" Text="CPF:"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtCpfB34" runat="server" type="number" class="form-control"
                            style="background-image: url(Images/number.png); background-repeat: no-repeat; background-position: left;"></asp:TextBox>
                        <br />
                        <asp:Label ID="lbl_NomeMae" runat="server" class="labels" Text="Nome da Mãe:"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtNomeMaeB34" runat="server" type="text" class="form-control" 
                            style="background-image: url(Images/quote.png); background-repeat: no-repeat; background-position: left;"></asp:TextBox>
                        <br />
                        <asp:Label ID="lbl_Nome" runat="server" class="labels" Text="Nome Completo:"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtNomeB34" runat="server" type="text" class="form-control"
                            style="background-image: url(Images/quote.png); background-repeat: no-repeat; background-position: left;"></asp:TextBox>
                        <br />
                        <asp:Button ID="btn_enviar" runat="server" class="btn btn-outline-success" Text="Enviar" OnClick="btn_enviar_Click"/>
                        <br /> <br /> 
                         <asp:Label ID="lbl_erro" runat="server" Text="." Visible ="false" style="font-weight: bold;"></asp:Label>
                        <br />
                        <asp:Image ID="img_encontrado" runat="server" src="Images/correct.png" Visible ="false" />
                        <asp:Image ID="img_nao_encontrado" runat="server" src="Images/error.png" Visible ="false" />
                        <br />
                  </center>
               </div>
           </div>
        </div>               
    </form>
</body>
</html>
