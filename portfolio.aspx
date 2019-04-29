<%@ Page Title="" Language="C#" MasterPageFile="~/ClientMasterPage.Master" AutoEventWireup="true" CodeBehind="portfolio.aspx.cs" Inherits="CRM.portfolio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id='main' role='main'>
        <div id='main-content-header'>
            <div class='container'>
                <div class='row'>
                    <div class='col-sm-12'>
                        <h1 class='title'>Portfolio
                            </h1>
                        <ol class='breadcrumb'>
                            <li>
                                <a href="Default.aspx">
                                    <i class='fa fa-home'></i>
                                </a>
                            </li>
                            <li class='active'>Portfolio</li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>
        <div id='main-content'>

            <div class='container'>
                <div class='row portfolio-boxes' id='portfolio-container'>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <div class="col-sm-4 portfolio-box portfolio-filter-photography portfolio-item isotope-item" style="position: absolute;">

                                <div class="image-link">

                                    <img class="img-responsive img-rounded center-block" alt="Image not available" style="height:235px" src='<%#Eval("CoverImage") %>' />
                                </div>
                                <h3 class="title"><%#Eval("Name") %></h3>


                            </div>

                        </ItemTemplate>
                    </asp:Repeater>
                </div>

            </div>
        </div>

        <div class='fade' id='scroll-to-top'>
            <i class='fa fa-chevron-up'></i>
        </div>
    </div>
</asp:Content>
