﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="manage-portfolio.aspx.cs" Inherits="CRM.Admin.manage_portfolio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="box col-md-12">
            <div class="box-inner">
                <div class="box-header well" data-original-title="">
                    <h2><i class="glyphicon glyphicon-star-empty"></i>Portfolio</h2>

                    <div class="box-icon">
                        
                        <a href="#" class="btn btn-minimize btn-round btn-default"><i
                            class="glyphicon glyphicon-chevron-up"></i></a>
                        
                    </div>
                </div>
                <div class="box-content">
                    <!-- put your content here -->

                    <div>
                        <table>
                            <tr>
                                <td>Name
                                </td>
                                <td>
                                    <asp:TextBox ID="txtName" runat="server" class="form-control" MaxLength="20" Width="418px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Image 
                                </td>
                                <td>
                                    <asp:FileUpload ID="UploadPortfolio" runat="server" />
                                    <asp:Image ID="Image1" runat="server" Visible="false" Style="width: 100px; height: 100px" />
                                    <asp:HiddenField ID="Hnfd" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td>

                                    <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn btn-info btn-lg" Width="129px" OnClick="btnAdd_Click" />
                                    <asp:HiddenField ID="hnId" runat="server" />
                                </td>
                            </tr>
                        </table>
                    </div>

                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="box col-md-12">
            <div class="box-inner">
                <div class="box-header well" data-original-title="">
                    <h2><i class="glyphicon glyphicon-star-empty"></i></h2>

                    <div class="box-icon">
                        
                        <a href="#" class="btn btn-minimize btn-round btn-default"><i
                            class="glyphicon glyphicon-chevron-up"></i></a>
                        
                    </div>
                </div>
                <div class="box-content">
                    <table class="table table-striped table-bordered bootstrap-datatable datatable responsive">
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>Name</th>
                                <th>Image</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeaterid1" runat="server" OnItemCommand="Repeaterid1_ItemCommand">
                                <ItemTemplate>
                                    <tr>
                                        <td><%#Eval("PortfolioID") %></td>
                                        <td><%#Eval("Name") %></td>
                                        <td>
                                            <img alt="Image not available" style="width: 100px; height: 100px" src='<%#Eval("CoverImage") %>' />
                                        </td>

                                        <td class="center">

                                            <asp:Button ID="btnUpdate" class="btn btn-info" runat="server" Text="EDIT" CommandName="Update" CommandArgument='<%#Eval("PortfolioID") %>' />
                                            &nbsp;
                                            <asp:Button ID="btnedit" class="btn btn-danger" runat="server" Text='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandName='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandArgument='<%#Eval("PortfolioID") %>' />
                                        </td>
                                    </tr>

                                </ItemTemplate>

                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
