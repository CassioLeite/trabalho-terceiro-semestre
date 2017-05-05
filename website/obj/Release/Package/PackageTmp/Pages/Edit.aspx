<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="website.Pages.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Editar</title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.min.css" />
 		<meta name="viewport" content="width=device-width"/>
		<style>
			.navbar-header button{
				color: #fff;
			}

			footer{
				background: #333;
				color: #fff;
				text-align: center;
				padding: 20px 0;
			}

            main{
				padding-top: 50px;
			}
            .carousel .item {
                width: 100%; /*slider width*/
                max-height: 600px; /*slider height*/
            }
            .carousel .item img {
                width: 100%; /*img width*/
            }

		</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--Começo cabeçalho-->
        <header>
			<nav class="navbar-inverse navbar-fixed-top">
				<div class="navbar-header">
					<a href="#" class="navbar-brand">AnkiOAB</a>
					<button type="button" data-target=".navbar-collapse" data-toggle="collapse" class="navbar-toggle">Menu</button>
				</div>
				<div class="collapse navbar-collapse">
					<ul class="nav navbar-nav">
						<li><a href="Baralhos.aspx">Baralhos</a></li>
                        <li><a href="Edit.aspx">Adicionar</a></li>
                        <li><a href="Itens.aspx">Itens</a></li>
						<!--<li class="dropdown">

						<a href="#" data-toggle="dropdown" class="dropdown-toggle">Logout<span class="caret"></span></a>
							<ul class="dropdown-menu">
								<li><asp:LinkButton runat="server" Onclick="Unnamed_Click">Sair</asp:LinkButton></li>
							</ul>
						</li>-->
					</ul>
					<div class="navbar-form navbar-right">
						<div class="form-group">
							<input type="text" placeholder="Search" class="form-control"/>
						</div>
						<input type="submit" value="Buscar" class="btn btn-default"/>
					</div>
				</div>
			</nav>
		</header>
        <!--Fim cabeçalho-->
		<main>
		    
                 <div class="container" >
                    <div class="span10 offset1">
                        <div class="row">

                        <div class="row text-left">
                            <h2>Editar</h2>
                            <p>Edite seus baralhos.</p>
                        </div>

                        <br />

                        Nome baralho:
                        <br />
                        <asp:TextBox ID="txtNomeBaralho" runat="server" placeholder="Nome do Baralho" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="requiredNomeBaralho" runat="server" ControlToValidate="txtNomeBaralho"
                        ErrorMessage="Por favor, digite o nome do baralho." ForeColor="Red" />
                        <br />
                        Frente:
                        <br />
                        <asp:TextBox ID="txtFrente" runat="server" placeholder="Frente" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="requiredFrente" runat="server" ControlToValidate="txtFrente"
                        ErrorMessage="Por favor, digite a frente do baralho." ForeColor="Red" />
                       <br />
                        Verso:
                        <br />
                        <asp:TextBox ID="txtVerso" runat="server" placeholder="Verso" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="requiredVerso" runat="server" ControlToValidate="txtVerso"
                        ErrorMessage="Por favor, digite o verso do baralho." ForeColor="Red" />
                       <br />


                        <p>
                            <asp:Label ID="lblMensagem" runat="server" />
                        </p>

                        <div class="row text-center">
                        <div class="btn-group">
                            <asp:Button ID="btnCadastroBaralho" runat="server" Text="Salvar" CssClass="btn btn-success" Onclick="btnCadastroBaralho_Click"/>
                        </div>
                        </div>
                    </div>
                </div>
            </div>
        
		</main>

		<footer class="navbar-fixed-bottom">
			AnkiOAB © 2016 - Todos os direitos reservados.
        </footer>

            <asp:ScriptManager ID="ScriptManager1" runat="server">
                <Scripts>
                    <asp:ScriptReference Path="../Scripts/jquery-1.9.0.min.js"/>
                    <asp:ScriptReference Path="../Scripts/bootstrap.min.js"/>
                </Scripts>
            </asp:ScriptManager>
    </div>
    </form>
</body>
</html>
