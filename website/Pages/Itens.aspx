<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Itens.aspx.cs" Inherits="website.Pages.Itens" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Itens</title>
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
						<li class="dropdown">

						<a href="#" data-toggle="dropdown" class="dropdown-toggle">Logout<span class="caret"></span></a>
							<ul class="dropdown-menu">
								<li><asp:LinkButton runat="server" Onclick="Unnamed_Click">Sair</asp:LinkButton></li>
							</ul>
						</li>
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
		    <div>
				<h3 class="text-center">Decks</h3>
			</div>
			<div class="col-xs-12 col-md-4 col-lg-4 thumbnail text-center">
				<figure>
					<img src="../images/direito_trabalhista.jpg" alt="imgem direito trabalhista"/>
					<div>
						<h4>Direito Trabalhista</h4>
						<p>Estude os principais conceitos de direito trabalhista</p>
					</div>
				</figure>
				<div class="btn-group">
				<a href="Baralhos.aspx" class="btn btn-primary"><span class="glyphicon glyphicon-book"></span>

				
				Estudar</a>
				</div>
			</div>

            <div class="col-xs-12 col-md-4 thumbnail text-center">
				<figure>
					<img src="../images/direito_civil.jpg" alt="imgem direito Civil"/>
					<div>
						<h4>Direito Criminal</h4>
						<p>Estude os principais conceitos de direito criminal</p>
					</div>
				</figure>
				<div class="btn-group">
				<a href="Baralhos.aspx" class="btn btn-primary"><span class="glyphicon glyphicon-book"></span>

				
				Estudar</a>
				</div>
			</div>

            <div class="col-xs-12 col-md-4 thumbnail text-center">
				<figure>
					<img src="../images/icone_adicionar.png" alt="imgem direito Civil"/>
					<div>
						<h4>Novo baralho</h4>
						<p>Crie seu próprio baralho</p>
					</div>
				</figure>
				<div class="btn-group">
				<a href="Edit.aspx" class="btn btn-success"><span class="glyphicon glyphicon-plus"></span>

				
				Criar Baralho</a>
				</div>
			</div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
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
