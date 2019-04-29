<%@ Page Title="" Language="C#" MasterPageFile="~/ClientMasterPage.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="CRM.About_Us" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id='main-content-header'>
        <div class='container'>
            <div class='row'>
                <div class='col-sm-12'>
                    <h1 class='title'>About us
                         </h1>
                    <ol class='breadcrumb'>
                        <li>
                            <a href="Default.aspx">
                                <i class='fa fa-home'></i>
                            </a>
                        </li>
                        <li class='active'>About Us</li>


                    </ol>

                </div>
            </div>
        </div>
    </div>
    <div id='main-content'>
        <div class='container'>
            <div class='row'>
                <div class='col-sm-12'>
                    <div class='page-header page-header-with-icon no-mg-t'>
                        <i class='fa fa-tag'></i>
                        <h2>Who we are
                  </h2>
                    </div>
                    <div class='row'>
                        <div class='col-sm-12'>
                            <asp:Repeater ID="Repeater2" runat="server">
                                <ItemTemplate>
                                    <p class='lead lead-xs text-center'><%#Eval("WCContent") %></p>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>

                    </div>
                </div>
            </div>
            <div class='row'>
                <div class='col-sm-12'>
                    <div class='page-header page-header-with-icon'>
                        <i class='fa fa-leaf'></i>
                        <h2>What means to us
                  </h2>
                    </div>
                    <div class='row panels'>
                        <div class='col-sm-4 panel-item'>
                            <a class='panel panel-circle-contrast' href='#'>
                                <div class='panel-icon'>
                                    <i class='fa fa-clock-o icon'></i>
                                </div>
                                <div class='panel-body text-center'>
                                    <h3 class='panel-title'>Customer</h3>
                                    <p>Silverwing Infotech IT, business services and solutions support clients who comprise the current world economy, right from small-medium businesses to the most successful global Organizations. Our stakeholders rely on us for innovative solutions, expertise and services in Web, Mobility, Gaming, Open Source frameworks, Embedded Services and IT Consulting.Our objective is to deliver robust, scalable, viable and quality solutions while adhering to strict deadline.</p>
                                </div>
                            </a>
                        </div>
                        <div class='col-sm-4 panel-item'>
                            <a class='panel panel-circle-contrast' href='#'>
                                <div class='panel-icon'>
                                    <i class='fa fa-cog icon'></i>
                                </div>
                                <div class='panel-body text-center'>
                                    <h3 class='panel-title'>Results</h3>
                                    <p>In today’s world of excellence, high-end companies create improved business processes to accelerate their core competency. With continuous process improvement, these Organizations climb the ladder of success and become what they are in the current business scenario. A Center of Excellence brings together diverse people with varied skill set to promote collaboration and industry-standard best practices focusing on a specific area to drive exceptional business results. </p>
                                </div>
                            </a>
                        </div>
                        <div class='col-sm-4 panel-item'>
                            <a class='panel panel-circle-contrast' href='#'>
                                <div class='panel-icon'>
                                    <i class='fa fa-rocket icon'></i>
                                </div>
                                <div class='panel-body text-center'>
                                    <h3 class='panel-title'>Our Values</h3>
                                    <p>Silverwing Infotech is an india based IT company providing diverse solutions and services across the globe. Providing solutions to the world leaders and SMEs alike; we are dedicated to offer the highest quality in all our services. We work closely with customers to deliver perfect results as per their expectations.</p>
                                </div>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            

            <div class='row'>
                <div class='col-sm-12'>
                    <div class='page-header page-header-with-icon'>
                        <i class='fa fa-search'></i>
                        <h2>We are hiring
                  </h2>
                    </div>
                    <div class='icon-boxes icon-boxes-lg'>
                        <div class='row'>

                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <div class='col-sm-6 icon-box'>
                                        <div class='icon icon-wrap icon-circle icon-lg contrast-bg'>
                                            <i class='fa fa-desktop text-white'></i>
                                        </div>
                                        <div class='content'>
                                            <h3 class='title'><%#Eval("Technology") %> <%#Eval("Post") %></h3>
                                            <p><%#Eval("RequiredSkills") %></p>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>

                    </div>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
