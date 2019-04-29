<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="changepassword.aspx.cs" Inherits="CRM.changepassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="box col-md-12">
            <div class="box-inner">
                <div class="box-header well" data-original-title="">
                    <h2><i class="glyphicon glyphicon-star-empty"></i>Change Your Password</h2>

                    <div class="box-icon">
                        <a href="#" class="btn btn-minimize btn-round btn-default"><i
                            class="glyphicon glyphicon-chevron-up"></i></a>

                    </div>
                </div>
                <div class="box-content">
                    <table>
                        <tr>
                            <td>Current Password</td>
                            <td>
                                <asp:TextBox ID="txtCurrentpassword" runat="server" class="form-control" required ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>New Password</td>
                            <td>
                                <asp:TextBox ID="txtNewpassword" runat="server" class="form-control" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Confirm Password</td>
                            <td>
                                <asp:TextBox ID="txtconfirmpassword" runat="server" class="form-control"  ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnChange" runat="server" Text="Change Password"  class="btn btn-info btn-lg" OnClick="btnChange_Click" /></td>
                            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
                        </tr>
                    </table>                   
                </div>
             </div>
        </div>
    </div>
</asp:Content>
