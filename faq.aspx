<%@ Page Title="" Language="C#" MasterPageFile="~/ClientMasterPage.Master" AutoEventWireup="true" CodeBehind="faq.aspx.cs" Inherits="CRM.faq" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id='main' role='main'>
        <div id='main-content-header'>
            <div class='container'>
                <div class='row'>
                    <div class='col-sm-12'>
                         <h1 class='title'>FAQ
                         </h1>
                        <ol class='breadcrumb'>
                        <li>
                            <a href="Default.aspx">
                                <i class='fa fa-home'></i>
                            </a>
                        </li>
                        <li class='active'>Faq</li>


                    </ol>
                    </div>
                </div>
            </div>
        </div>
        <div id='main-content'>
            <div class='container'>
                <div class='row'>
                    <div class='col-sm-12'>
                        <p class='lead lead-md text-center no-mg-b'>Frequently Asked Question</p>
                    </div>
                </div>
                <div class='row'>
                    <div class='col-sm-12'>
                        <hr />
                        <div class='row'>
                            <div class='col-sm-12'>
                             </div>
                        </div>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <div class='panel-group accordion accordion-bordered' id='accordion'>
                                    <div class='panel panel-default'>
                                        <div class='panel-heading'>

                                            <h4 class='panel-title'>

                                                <a class='accordion-toggle collapsed' data-toggle='collapse' href="#accordion-item-<%# Container.ItemIndex+1 %>" aria-expanded="true"><%#Eval("Question") %></a>
                                            </h4>


                                            <div class='panel-collapse collapse' id='accordion-item-<%# Container.ItemIndex+1 %>'>
                                                <div class="panel-collapse collapse in" id="Div2" aria-expanded="true">
                                                    <div class='panel-body'>
                                                        <span><%#Eval("Answer") %></span>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
                
            </div>
        </div>
        <div class='fade' id='scroll-to-top'>
            <i class='fa fa-chevron-up'></i>
        </div>

    </div>
</asp:Content>
