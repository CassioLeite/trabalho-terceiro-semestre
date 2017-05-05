<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="website.Pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.min.css" />
    <meta name="viewport" content="width=device-width" />
    <style>
        .navbar-header button {
            color: #fff;
        }

        footer {
            background: #333;
            color: #fff;
            text-align: center;
            padding: 20px 0;
        }

        main {
            padding-top: 50px;
        }

        .img-circle {
            width: 100px;
        }

        .btn-group {
            padding-top: 0px;
        }

        .container-fluid {
            padding-top: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">
            <div class="row">

                <!--Começo cabeçalho-->
                <header>
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
                    <div class="col-xs-12 col-md-12 text-center">
                        <div class="text-center">
                            <h2>Faça login para continuar</h2>
                            <p>Faça seu login usando seu e-mail e senha</p>
                        </div>
                        <div>
                            <figure>
                                <img src="../Images/imagem-login.jpg" alt="imagem de login" class="img-circle" />
                            </figure>
                        </div>

                        <div class="container-fluid">
                            <div class="row col-xs-12 col-md-4 col-md-offset-4">
                                <div>
                                    <div>
                                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Entre com seu e-mail" CssClass="form-control" />
                                        <asp:RequiredFieldValidator ID="requiredEmail" runat="server" ControlToValidate="txtEmail"
                                            ErrorMessage="Por favor, digite seu e-mail" ForeColor="Red" />
                                    </div>
                                    <br />
                                    <div>
                                        <asp:TextBox ID="txtSenha" runat="server" placeholder="Senha" CssClass="form-control" type="password" />
                                        <asp:RequiredFieldValidator ID="requiredSenha" runat="server" ControlToValidate="txtSenha"
                                            ErrorMessage="Por favor, digite sua senha." ForeColor="Red" />
                                    </div>
                                    <br />
                                    <div class="btn-group">
                                        <asp:Button ID="btnLogin" runat="server" Text="Fazer login" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
                                    </div>

                                    <p>
                                        <asp:Label ID="lblMensagem" runat="server" />
                                    </p>
                                </div>
                            </div>
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
                        <asp:ScriptReference Path="../Scripts/jquery-1.9.0.min.js" />
                        <asp:ScriptReference Path="../Scripts/bootstrap.min.js" />
                    </Scripts>
                </asp:ScriptManager>
            </div>
        </div>
    </form>
</body>
</html>
