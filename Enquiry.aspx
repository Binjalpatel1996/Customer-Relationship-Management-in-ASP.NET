<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="Enquiry.aspx.cs" Inherits="CRM.Admin.Enquiry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="box col-md-12">
            <div class="box-inner">
                <div class="box-header well" data-original-title="">
                    <h2><i class="glyphicon glyphicon-user"></i> Enquiry </h2>

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
                            <th>Email</th>
                            <th>Phone</th>
                             <th>Subject</th>
                             <th>Message</th>
                             <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                                                 <ItemTemplate>
                                                    <tr>
                                                        <td><%#Eval("EnquiryID") %></td>
                                                        <td><%#Eval("Name") %></td>
                                                        <td><%#Eval("Email") %></td>
                                                        <td><%#Eval("Phone") %></td>
                                                        <td><%#Eval("Subject") %></td>
                                                        <td><%#Eval("Message") %></td>
                                                        <td class="center">
                                                       <asp:Button ID="btnedit" class="btn btn-danger" runat="server" Text='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandName='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandArgument='<%#Eval("EnquiryID") %>' />
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
