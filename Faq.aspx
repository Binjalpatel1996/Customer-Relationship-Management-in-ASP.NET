<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="Faq.aspx.cs" Inherits="CRM.Faq" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">

        <div class="box col-md-12">
            <div class="box-inner">
                <div class="box-header well" data-original-title="">
                    <h2><i class="glyphicon glyphicon-user"></i>Add FAQ Form</h2>
                    <div class="box-icon">
                        <a href="#" class="btn btn-minimize btn-round btn-default"><i
                            class="glyphicon glyphicon-chevron-up"></i></a>
                        
                    </div>
                </div>
                <table>
                    <tr>
                        <td>Question 
                        </td>
                        <td>
                            <asp:TextBox ID="txtQuestion" runat="server" class="form-control" MaxLength="250" Width="418px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Answer
                        </td>
                        <td>
                            <asp:TextBox ID="txtAnswer" runat="server" class="form-control" Width="418px" MaxLength="100" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnAddFaq" runat="server" Text="Add FAQ" class="btn btn-info btn-lg" OnClick="btnAddFaq_Click" />
                            <asp:HiddenField ID="hnId" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="box col-md-12">
            <div class="box-inner">
                <div class="box-header well" data-original-title="">
                    <h2><i class="glyphicon glyphicon-star-empty"></i>Faq </h2>

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
                                <th>Question</th>
                                <th>Answer</th>

                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeaterid1" runat="server" OnItemCommand="Repeaterid1_ItemCommand">
                                <ItemTemplate>
                                    <td><%#Eval("FaqID") %></td>
                                    <td><%#Eval("Question") %></td>
                                    <td><%#Eval("Answer") %></td>

                                    <td class="center">

                                        <asp:Button ID="btnUpdate" class="btn btn-info" runat="server" Text="EDIT" CommandName="Update" CommandArgument='<%#Eval("FaqID") %>' />
                                          &nbsp;
                                        <asp:Button ID="btnDelete" class="btn btn-danger" runat="server" Text='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandName='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandArgument='<%#Eval("FaqID") %>' />

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
