<%@ Page Title="" Language="C#" MasterPageFile="~/ClientMasterPage.Master" AutoEventWireup="true" CodeBehind="event-gallery.aspx.cs" Inherits="CRM.event_gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id='main-content-header'>
        <div class='container'>
            <div class='row'>
                <div class='col-sm-12'>
                    <h1 class='title'>Event Gallery
                </h1>
                    <ol class='breadcrumb'>
                        <li>
                            <a href="Default.aspx">
                                <i class='fa fa-home'></i>
                            </a>
                        </li>
                        <li class='active'>Event Gallery</li>


                    </ol>
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
                <div class='row portfolio-boxes' id='portfolio-container'>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <div class="col-sm-4 portfolio-box portfolio-filter-photography portfolio-item isotope-item" style="position: absolute; left: 0px; top: 0px; transform: translate3d(0px, 0px, 0px);">

                                <div class="image-link">
                                <a href='show-images.aspx?EID=<%#Eval("EventID") %>'  >
                                    <img class="img-responsive img-rounded center-block" alt="Image not available" width="360" height="235" src='<%#Eval("CoverImage") %>' />
                                </div>
                                </a>
                                <h3 class="title"><%#Eval("EventName") %></h3>


                            </div>
                             
                        </ItemTemplate>
                    </asp:Repeater>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
