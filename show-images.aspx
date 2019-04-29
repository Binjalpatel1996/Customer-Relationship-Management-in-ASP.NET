<%@ Page Title="" Language="C#" MasterPageFile="~/ClientMasterPage.Master" AutoEventWireup="true" CodeBehind="show-images.aspx.cs" Inherits="CRM.show_images" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div id='main' role='main'>
            <div id='main-content-header'>
                <div class='container'>
                    <div class='row'>
                        <div class='col-sm-12'>
                            <h1 class='title'>Portfolio
                 
                                <small>Portfolio with 4 columns</small>
                            </h1>
                        </div>
                    </div>
                </div>
            </div>
    <div id='main-content'>
        <div class='container'>
            <div class='row'>
                <div class='col-sm-12'>
                    <p class='lead text-center no-mg-b'>Quisque nunc sapien, malesuada vitae luctus in, blandit eu erat. Cras fringilla eros eget justo dictum convallis.</p>
                </div>
            </div>
        </div>
       
            <div id='Div1'>
                <div class='container'>
                    <div class='row portfolio-boxes'  id='portfolio-container'>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <div class='col-sm-3 portfolio-box portfolio-filter-photography portfolio-item' >
                                     <div class='row text-center'>
                                     
                                    <a data-lightbox data-lightbox-gallery='lightbox-test' href='<%#Eval("ImagePath") %>'>

                                    <img class="img-responsive img-rounded center-block" alt="Image not available" height="171" src='<%#Eval("ImagePath") %>' style="height:171px"/>
                                    </a>
                                       
                                </div>
                                         
                                    </div>

                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
    </div>
    </div>
            <div class='fade' id='scroll-to-top'>
            </div>
        </div>
    </div>
</asp:Content>
