<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CRM._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class=" row">
                    <div class="col-md-3 col-sm-3 col-xs-6">
                        <a data-toggle="tooltip" title="6 new members." class="well top-block" href="#">
                            <i class="glyphicon glyphicon-envelope red"></i>
                            
                            <div>Total Enquiry</div>
                            <div><asp:Label ID="TotalEnquiry" runat="server"></asp:Label></div>
                          
                                   
                        </a>
                    </div>

                    <div class="col-md-3 col-sm-3 col-xs-6">
                        <a data-toggle="tooltip" title="4 new pro members." class="well top-block" href="#">
                            <i class="glyphicon glyphicon-star green"></i>

                            <div>Total Subscriber</div>
                            <div><asp:Label ID="Label2" runat="server"></asp:Label></div>
                            
                        </a>
                    </div>

                    <div class="col-md-3 col-sm-3 col-xs-6">
                        <a data-toggle="tooltip" title="$34 new sales." class="well top-block" href="#">
                            <i class="glyphicon glyphicon-bookmark"></i>

                            <div>Total Testimonial</div>
                            <div>
                                <asp:Label ID="lblTotaltestimonial" runat="server" Text="Label"></asp:Label></div>
                            
                        </a>
                    </div>

                    <div class="col-md-3 col-sm-3 col-xs-6">
                        <a data-toggle="tooltip" title="12 new messages." class="well top-block" href="#">
                            <i class="glyphicon glyphicon-briefcase"></i>

                            <div>Total Portfolio</div>
                            <div>
                                <asp:Label ID="lblTotalportfolio" runat="server" Text="Label"></asp:Label></div>
                            
                        </a>
                    </div>
                </div>
</asp:Content>
