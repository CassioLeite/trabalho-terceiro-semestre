<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Redirect.aspx.cs" Inherits="website.Redirect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
            <header class="row">
                <nav class="navbar-inverse navbar-fixed-top">
                    <div class="navbar-header">
                        <a href="../Default.aspx" class="navbar-brand">AnkiOAB</a>
                        <button type="button" data-target=".navbar-collapse" data-toggle="collapse" class="navbar-toggle">Menu</button>
                    </div>
                    <div class="collapse navbar-collapse">
                        <ul class="nav navbar-nav">
                            <li><a href="About.aspx">About</a></li>
                            <li><a href="#">Blog</a></li>
                            <li class="dropdown">

                                <a href="#" data-toggle="dropdown" class="dropdown-toggle">Entre<span class="caret"></span></a>
                                <ul class="dropdown-menu">
                                    <li><a href="Login.aspx">Login</a></li>
                                    <li><a href="Cadastro.aspx">Cadastro</a></li>
                                </ul>
                            </li>
                        </ul>
                        <div class="navbar-form navbar-right">
                            <div class="form-group">
                                <input type="text" placeholder="Search" class="form-control" />
                            </div>
                            <input type="submit" value="Buscar" class="btn btn-default" />
                        </div>
                    </div>
                </nav>
            </header>
            <!--Fim cabeçalho-->
		<main>
            <div class="text-center">
                
                <br />
                <br />
                <br />
		        <p>Cadastro efetuado com sucesso, <a href="Login.aspx">clique aqui</a> para fazer <a href="Login.aspx">login</a>.</p>
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
