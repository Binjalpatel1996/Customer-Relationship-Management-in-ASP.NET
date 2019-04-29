<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="socialmedia-info.aspx.cs" Inherits="CRM.Admin.socialmedia_info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">

        <div class="box col-md-12">
            <div class="box-inner">
                <div class="box-header well" data-original-title="">
                    <h2><i class="glyphicon glyphicon-user"></i> Social Media Form</h2>
                    <div class="box-icon">
                        <a href="#" class="btn btn-minimize btn-round btn-default"><i
                            class="glyphicon glyphicon-chevron-up"></i></a>
                        
                    </div>
                </div>
                <div class="box-content">
                    <table>
                        <tr>
                            <td>Facebook URL
                            </td>
                            <td>
                                <asp:TextBox ID="txtFacebookurl"  class="form-control" runat="server" Width="418px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Twitter URL</td>
                            <td>
                              
                                  <asp:TextBox ID="txtTwitterurl" class="form-control" runat="server"  Width="418px"></asp:TextBox>
                                </td>
                        </tr>
                        <tr>
                            <td>Linkedin URL
                            </td>
                            <td>
                                <asp:TextBox ID="txtLinkedinurl" class="form-control" runat="server"  Width="418px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnsocialinfo" runat="server" Text="Save" class="btn btn-info btn-lg" Width="129px" OnClick="btnsocialinfo_Click" />
                                <asp:HiddenField ID="hnId" runat="server" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
