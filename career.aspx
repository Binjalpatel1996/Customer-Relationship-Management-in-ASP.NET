<%@ Page Title="" Language="C#" MasterPageFile="~/ClientMasterPage.Master" AutoEventWireup="true" CodeBehind="career.aspx.cs" Inherits="CRM.career" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id='main-content-header'>
        <div class='container'>
            <div class='row'>
                <div class='col-sm-12'>
                    <h1 class='title'>Career
                         </h1>
                    <ol class='breadcrumb'>
                        <li>
                            <a href="Default.aspx">
                                <i class='fa fa-home'></i>
                            </a>
                        </li>
                        <li class='active'>Career</li>


                    </ol>

                </div>
            </div>
        </div>
    </div>
    <div id='main-content'>
        <div class='container'>
            <div class='row'>
                <div class='col-sm-12'>
                    <p class='lead lead-md text-center no-mg-b'>Suspendisse dignissim in sem eget pulvinar. Mauris aliquam nulla at libero pretium, eu tincidunt nulla molestie. Cras pulvinar posuere massa sed scelerisque.  Nam porta ac turpis id dapibus. Morbi facilisis eu nibh pulvinar convallis. Proin rutrum nisi ante, eu fringilla metus aliquam non. Vestibulum posuere, mauris sit amet.</p>
                </div>
            </div>
            <hr />
            <div class='row'>
                <div class='col-sm-6'>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <div class='panel-group accordion' id='accordion'>
                                <div class='panel panel-default'>
                                    <div class='panel-heading'>
                                        <h4 class='panel-title'>
                                            <a class='accordion-toggle collapsed' data-toggle='collapse' href="#accordion-item-<%# Container.ItemIndex+1 %>" aria-expanded="true"><%#Eval("Technology") %> <%#Eval("Post") %> </a>
                                            </a>
                                        </h4>
                                    </div>
                                    <div class='panel-collapse collapse' id='accordion-item-<%# Container.ItemIndex+1 %>'>

                                        <div class='panel-body'>
                                            <b>No. of Vacancy : </b><%#Eval("NumOfVacancies") %>
                                            <br />
                                            <br />
                                            <b>Job Location : </b><%#Eval("JobLocation") %>
                                            <br />
                                            <br />
                                            <b>Qualification : </b><%#Eval("Qualification") %>
                                            <br />
                                            <br />
                                            <b>Required Skills : </b><%#Eval("Requiredskills") %>
                                            <br />
                                            <br />
                                            <b>Description : </b><%#Eval("ExtraContent") %>
                                            <br />
                                            <br />

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



</asp:Content>
