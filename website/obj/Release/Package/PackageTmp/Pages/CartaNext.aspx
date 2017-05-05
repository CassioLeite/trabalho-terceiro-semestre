<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartaNext.aspx.cs" Inherits="website.Pages.CartaNext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cartas</title>
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
                                    <li>
                                        <asp:LinkButton runat="server" OnClick="Unnamed_Click">Sair</asp:LinkButton></li>
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

            <div class="container">
                <div class="span10 offset1">
                    <div>
                        <br />
                        <br />
                        <br />
                        <div class="text-left">
                            <asp:Button runat="server" ID="btnDeletarCarta" Text="Deletar" OnClick="btnDeletarCarta_Click" class="btn btn-danger btn-sm" />

                        </div>
                        <br />
                        <br />
                        <div class="row text-center">
                            <asp:Label runat="server" ID="lblFrente"></asp:Label>
                        </div>

                        <br />
                        <div class="row text-center">
                            <asp:Label runat="server" ID="lblLinha" Visible="false"></asp:Label>

                            <br />
                            <br />

                            <asp:Label runat="server" ID="lblVerso" Visible="false"></asp:Label>
                        </div>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />

                        <div class="text-center">
                            <asp:Button runat="server" ID="btnVerVerso" Text="VerVerso" OnClick="btnVerVerso_Click" class="btn btn-primary" />
                            <asp:Button runat="server" ID="btnNextCarta" Text="ProximaCarta" OnClick="btnNextCarta_Click" class="btn btn-default" />
                        </div>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />

                    </div>

                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>
                </div>
            </div>
        </div>

        <footer class="navbar-fixed-bottom">
            AnkiOAB © 2016 - Todos os direitos reservados.
        </footer>

        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Path="../Scripts/jquery-1.9.0.min.js" />
                <asp:ScriptReference Path="../Scripts/bootstrap.min.js" />
            </Scripts>
        </asp:ScriptManager>
    </form>
</body>
</html>
