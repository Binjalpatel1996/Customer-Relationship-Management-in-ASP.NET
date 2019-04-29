<%@ Page Title="" Language="C#" MasterPageFile="~/ClientMasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRM.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class='hero-carousel carousel-contrast carousel-contrast-arrows carousel-contrast-pagination flexslider' id='carousel-example-2'>
        <ul class="slides">

            <asp:Repeater ID="repSlider" runat="server">
                <ItemTemplate>
                    <li style='width: 100%; float: left; margin-right: -100%; position: relative; opacity: 1; display: block; z-index: 2; background-position: center; background-image: url(<%# Eval("ImagePath") %> );'
                        class="item flex-active-slide">
                        <div class="container">
                            <div class="row">
                                <div class="col-lg-12 animate">
                                    <h1 class="big fadeInUp animated">
                                        <span class="animated"><%#Eval("SliderTitle") %></span>
                                    </h1>
                                    <p class="normal fadeInUp animated">
                                        <span class="animated"><%#Eval("SliderDescription") %></span>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
    <div id='main-content'>
        <div class='container'>
            <div class='row'>
                <div class='col-sm-12'>
                    <p class='lead lead-lg text-center'>Quisque nunc sapien, malesuada vitae luctus in, blandit eu erat. Cras fringilla eros eget justo dictum convallis.</p>
                </div>
            </div>
            <div class='panels-wrapper'>
                <div class='row panels'>
                    <div class='col-sm-4 panel-item'>
                        <a class='panel panel-circle-big-contrast' href='#'>
                            <div class='panel-icon'>
                                <i class='fa fa-clock-o icon'></i>
                            </div>
                            <div class='panel-body'>
                                <h3 class='panel-title'>Project planning</h3>
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed eu pharetra felis.est.</p>
                            </div>
                        </a>
                    </div>
                    <div class='col-sm-4 panel-item'>
                        <a class='panel panel-circle-big-contrast' href='#'>
                            <div class='panel-icon'>
                                <i class='fa fa-cog icon'></i>
                            </div>
                            <div class='panel-body'>
                                <h3 class='panel-title'>Easy customizable</h3>
                                <p>Etiam init rutrum ligula semper neque relu dapibus, non tempus mauris sodales.est.</p>
                            </div>
                        </a>
                    </div>
                    <div class='col-sm-4 panel-item'>
                        <a class='panel panel-circle-big-contrast' href='#'>
                            <div class='panel-icon'>
                                <i class='fa fa-rocket icon'></i>
                            </div>
                            <div class='panel-body'>
                                <h3 class='panel-title'>Fastest workers</h3>
                                <p>Pellentesque id neque sit amet nibh placerat suscipit et a purus, mauris id.</p>
                            </div>
                        </a>
                    </div>
                </div>
            </div>
            <div class='row'>
                <div class='col-sm-12'>
                    <div class='page-header page-header-with-icon'>
                        <i class='fa fa-suitcase'></i>
                        <h2>Our last projects
                   
                            <small>Phasellus malesuada sapien non orci semper gravida.</small>
                        </h2>
                    </div>
                    <div class='row portfolio-boxes'>
                        
                            <asp:Repeater ID="Repeater2" runat="server">
                                <ItemTemplate>
                                    <div class='col-sm-3 col-xs-6 no-mb-t-xs portfolio-box'>
                                    <img class="img-responsive img-rounded center-block" alt="Image not available" style="height:262px" src=' <%# Eval("CoverImage") %> '/>
                                       <h3 class='title'><%#Eval("Name") %></h3>
                                        </div> 
                                    </ItemTemplate>
                                </asp:Repeater>
                       
                        </div>
                        
                    
                </div>
            </div>

            <div class='row'>
                <div class='col-sm-12'>
                    <div class='page-header page-header-with-icon'>
                        <i class='fa fa-quote-right'></i>
                        <h2>Testimonials</h2>
                    </div>
                    <div class='row quotes'>
                        <div class='carousel carousel-default slide carousel-auto' id='carousel-testimonials'>
                            <div class='carousel-inner'>

                                <asp:Repeater ID="Repeater1" runat="server">
                                    <ItemTemplate>
                                        <div class='<%# Container.ItemIndex==0?"item active quote":"item quote" %>'>
                                            <div class='col-sm-12 text-center'>
                                                <p class='lead'><%#Eval("Testimonial") %></p>
                                                <div class='author-wrapper'>
                                                    <p class='author'>
                                                        <strong><%#Eval("Name") %></strong>
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                        <%--<ol class='carousel-indicators'>
                                        <li class='active' data-slide-to='0' data-target='#carousel-testimonials'></li>
                                        <li data-slide-to='1' data-target='#carousel-testimonials'></li>
                                        <li data-slide-to='2' data-target='#carousel-testimonials'></li>
                                        <li data-slide-to='3' data-target='#carousel-testimonials'></li>
                                    </ol>--%>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
