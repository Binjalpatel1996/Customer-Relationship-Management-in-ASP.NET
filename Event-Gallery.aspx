<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="Event-Gallery.aspx.cs" Inherits="CRM.Event_Gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">

        <div class="box col-md-12">
            <div class="box-inner">
                <div class="box-header well" data-original-title="">
                    <h2><i class="glyphicon glyphicon-user"></i>Add Event Form</h2>
                    <div class="box-icon">
                        <a href="#" class="btn btn-minimize btn-round btn-default"><i
                            class="glyphicon glyphicon-chevron-up"></i></a>
                        
                    </div>
                </div>
                <table>
                    <tr>
                        <td>Cover Image
                        </td>
                        <td>
                            <asp:FileUpload ID="UploadCoverimage" runat="server" /></td>
                        <asp:Image ID="Image1" runat="server" Style="width: 100px; height: 100px;" Visible="false" />
                    </tr>
                    <tr>
                        <td>Event Name
                        </td>
                        <td>
                            <asp:TextBox ID="txtEventname" runat="server" class="form-control" MaxLength="20" Width="418px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                    </tr>
                    <tr>
                        <td>Description
                        </td>
                        <td>
                            <asp:TextBox ID="txtDescription" runat="server" class="form-control" MaxLength="200" Width="418px" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnAddEvent" runat="server" Text="Add Event" class="btn btn-info btn-lg" Width="129px" OnClick="btnAddEvent_Click" />
                            <asp:HiddenField ID="hnId" runat="server" />
                            <asp:HiddenField ID="hnImagePath" runat="server" />

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
                    <h2><i class="glyphicon glyphicon-user"></i>Events</h2>

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
                                <th>Cover image</th>
                                <th>Event Name</th>
                                <th>Description</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                                <ItemTemplate>
                                    <tr>
                                        <td><%#Eval("EventID") %></td>
                                        <td><img alt="Image not available" style="width: 100px; height: 100px" src='<%#Eval("CoverImage") %>' /></td>
                                        <td><%#Eval("EventName") %></td>
                                        <td><%#Eval("Description") %></td>
                                        <td class="center">
                                           <asp:Button ID="btnUpdate" class="btn btn-info" runat="server" Text="EDIT" CommandName="Update" CommandArgument='<%#Eval("EventID") %>' />
                                            &nbsp;
                                           <asp:Button ID="btnedit" class="btn btn-danger" runat="server" Text='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandName='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandArgument='<%#Eval("EventID") %>' />
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
