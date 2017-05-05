<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="website.teste" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AnkiOAB um jeito novo de estudar</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.min.css" />
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

        .corpo {
            width: 960px;
            height: 350px;
            margin: auto;
            background-color: whitesmoke;
            -webkit-box-shadow: 9px 7px 5px rgba(50, 50, 50, 0.30);
        }

        .conteudo {
            display: table;
            padding-top: 20px;
        }

        .imagem {
            display: table-cell;
            float: left;
            width: 450px;
        }

        .texto {
            display: table-cell;
            float: left;
            max-width: 400px;
            margin-left: 20px;
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>
                <nav class="navbar-inverse navbar-fixed-top">
                    <div class="navbar-header">
                        <a href="Default.aspx" class="navbar-brand">AnkiOAB</a>
                        <button type="button" data-target=".navbar-collapse" data-toggle="collapse" class="navbar-toggle">Menu</button>
                    </div>
                    <div class="collapse navbar-collapse">
                        <ul class="nav navbar-nav">
                            <li><a href="Pages/About.aspx">About</a></li>
                            <li><a href="#">Blog</a></li>
                            <li class="dropdown">

                                <a href="#" data-toggle="dropdown" class="dropdown-toggle">Entre<span class="caret"></span></a>
                                <ul class="dropdown-menu">
                                    <li><a href="Pages/Login.aspx">Login</a></li>
                                    <li><a href="Pages/Cadastro.aspx">Cadastro</a></li>
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

            <div class="container-fluid">
                <div class="row">
                    <div id="carousel" class="carousel slide" data-ride="carousel">
                        <div class="carousel-inner" role="listbox">
                            <div class="item active">
                                <img src="Images/capa.jpg" alt="Livros" class="img-responsive" />
                            </div>
                            <div class="item">
                                <img src="Images/capa1.jpg" alt="Homem com celular" class="img-responsive" />
                            </div>
                        </div>
                        <a href="#carousel" data-slide="prev" class="left carousel-control"><span class="glyphicon glyphicon-chevron-left"></span></a>
                        <a href="#carousel" data-slide="next" class="right carousel-control"><span class="glyphicon glyphicon-chevron-right"></span></a>
                    </div>
                </div>
            </div>

            <h3 class="text-center">Estude em qualquer lugar</h3>
            <br />
            <section class="corpo">
                <div class="text-left">
                    <div class="conteudo">
                        <div class="imagem">
                            <img src="Images/devices1.png" alt="Devices" class="img-responsive" />
                        </div>

                        <div class="texto">
                            <h2><b>Acesse seus baralhos em qualquer lugar, a qualquer hora</b></h2>
                            <p>
                               Sabemos que você é ocupado. É por isso que tomamos o cuidado para que você possa
                               acessar seu conteúdo em qualquer lugar e em qualquer dispositivo. Seja no Smartphone,
                               no Desktop ou em um Tablet. Estude em qualquer lugar e consiga voos cada vez mais altos.
                            </p>
                        </div>
                    </div>
                </div>
            </section>

            <br />
            <br />
            <br />
            <br />
            <br />

            <main>
            </main>

            <footer class="navbar-fixed-bottom">
                AnkiOAB © 2016 - Todos os direitos reservados.
            </footer>

            <asp:ScriptManager ID="ScriptManager1" runat="server">
                <Scripts>
                    <asp:ScriptReference Path="Scripts/jquery-1.9.0.min.js" />
                    <asp:ScriptReference Path="Scripts/bootstrap.min.js" />
                </Scripts>
            </asp:ScriptManager>
        </div>
    </form>
</body>
</html>
