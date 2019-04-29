<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="User-Profile.aspx.cs" Inherits="CRM.User_Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="box col-md-12">
            <div class="box-inner">
                <div class="box-header well" data-original-title="">
                    <h2><i class="glyphicon glyphicon-star-empty"></i>User Profile</h2>
                       
                    <div class="box-icon">
                       
                        <a href="#" class="btn btn-minimize btn-round btn-default"><i
                            class="glyphicon glyphicon-chevron-up"></i></a>
                       
                    </div>
                </div>
                <div class="box-content">
                    <!-- put your content here -->
                    <h4>Personal Information</h4>
                    <table>
                         <tr>
                             <td>Name</td>
                             <td>
                                 <asp:TextBox ID="txtName" runat="server" class="form-control" Width="418px" MaxLength="20" ></asp:TextBox></td>
                             <td>Upload Profile </td>
                            <td>
                                <asp:FileUpload ID="UploadProfile" runat="server" /></td>
                                <asp:Image ID="Image1" runat="server" Visible="false" style="width: 200px; height: 100px"  />
                             <asp:HiddenField ID="hnfd" runat="server" />
                              </tr>
                        <tr>
                            <td>Email</td>
                            <td>
                                <asp:TextBox ID="TxtEmail" MaxLength="20" runat="server" class="form-control" Width="418px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Username</td>
                            <td>
                                
                                
                                <asp:TextBox ID="txtUsername" MaxLength="20" runat="server" class="form-control" Width="418px"></asp:TextBox>
                            </td>

                        </tr>
                        <tr>
                            <td>Password</td>
                            <td>
                                
                                <asp:TextBox ID="txtPassword" runat="server" class="form-control" Width="418px"></asp:TextBox>
                               </td>
                        </tr>
                        <tr>
                            <td>Contact</td>
                            <td>
                                
                           <asp:TextBox ID="txtContact" runat="server" class="form-control" MaxLength="10" Width="418px"></asp:TextBox>
                               </td>
                            </tr>
                        <tr>
                            
                            <td>
                                <asp:Button ID="btnSubmit" runat="server" class="btn btn-info btn-lg" Text="Submit" Height="50px" Width="143px" OnClick="btnSubmit_Click" />
                                <asp:HiddenField ID="hnId" runat="server" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
        </div>
    <div class="row">
        <div class="box col-md-12">
            <div class="box-inner">
                <div class="box-header well" data-original-title="">
                    <h2><i class="glyphicon glyphicon-user"></i>Users</h2>

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
                                <th>Profile</th>
                                <th>Name</th>
                                <th>Email</th>
                                <th>Username</th>
                                <th>Password</th>
                                <th>Contact</th>
                                <th>Actions</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeaterid1" runat="server" OnItemCommand="Repeaterid1_ItemCommand">
                                <ItemTemplate>
                                    <tr>
                                        <td><%#Eval("UserProfileID") %></td>
                                        <td><img alt="Image not available" style="width: 100px; height: 100px" src='<%#Eval("ImagePath") %>' />
                                        </td>
                                        <td><%#Eval("Name") %></td>
                                        <td><%#Eval("Email") %></td>
                                        <td><%#Eval("Username") %></td>
                                        <td><%#Eval("Password") %></td>
                                        <td><%#Eval("Contact") %></td>

                                        <td class="center">
                                            <asp:Button ID="btnUpdate" class="btn btn-info" runat="server" Text="EDIT" CommandName="Update" CommandArgument='<%#Eval("UserProfileID") %>' />
                                           &nbsp;
                                            <asp:Button ID="btnDelete" runat="server" class="btn btn-danger" Text='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandName='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandArgument='<%#Eval("UserProfileID") %>' />

                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>

                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <!--/span-->

    </div>
</asp:Content>
