<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="Images.aspx.cs" Inherits="CRM.Images" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="box col-md-12">
            <div class="box-inner">
                <div class="box-header well" data-original-title="">
                    <h2><i class="glyphicon glyphicon-star-empty"></i>Event Images</h2>

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
                                <td>Event Name 
                                </td>
                                <td>
                                    <asp:DropDownList ID="DdlEventname" runat="server" class="btn btn-default btn-lg" Width="278px"></asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>Image 
                                </td>
                                <td>
                                    <asp:FileUpload ID="UploadEventimage" runat="server" />
                                    <asp:Image ID="Image1" runat="server" Visible="false" Style="width: 100px; height: 100px" />
                                    <asp:HiddenField ID="hnfd" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td>

                                    <asp:Button ID="BtnAddimages" runat="server" Text="Add image" class="btn btn-info btn-lg" Width="129px" OnClick="BtnAddimages_Click" />
                                    <asp:HiddenField ID="hnId" runat="server" />
                                </td>
                            </tr>
                        </table>
                    </div>

                </div>
            </div>
        </div>
    </div>

    <!--/row-->

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
                                <th>Event Name</th>
                                <th>Image</th>
                                <th colspan="2">Action</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeaterid1" runat="server" OnItemCommand="Repeaterid1_ItemCommand">
                                <ItemTemplate>
                                    <tr>
                                        <td><%#Eval("EventImageID") %></td>
                                        <td><%#Eval("EventName") %></td>
                                        <td>
                                            <img alt="Image not available" style="width: 100px; height: 100px" src='<%#Eval("ImagePath") %>' />
                                        </td>

                                        <td class="center">

                                            <asp:Button ID="btnUpdate" class="btn btn-info" runat="server" Text="EDIT" CommandName="Update" CommandArgument='<%#Eval("EventImageID") %>' />
                                             &nbsp;
                                            <asp:Button ID="btnedit" class="btn btn-danger" runat="server" Text='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandName='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandArgument='<%#Eval("EventImageID") %>' />
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
