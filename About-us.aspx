<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="About-us.aspx.cs" Inherits="CRM.About_us" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="box col-md-12">
            <div class="box-inner">
                <div class="box-header well" data-original-title="">
                    <h2><i class="glyphicon glyphicon-star-empty"></i>About Us Form</h2>

                    <div class="box-icon">
                        <a href="#" class="btn btn-minimize btn-round btn-default"><i
                            class="glyphicon glyphicon-chevron-up"></i></a>

                    </div>
                </div>
                <div class="box-content">
                    <!-- put your content here -->

                    <table>
                        <tr>
                            <td>Image  </td>
                            <td>
                                <asp:FileUpload ID="FileUpload1" runat="server" /></td>
                            <td>
                                <asp:Image ID="Image1" runat="server" Visible="false" Style="width: 200px" /></td>
                            <asp:HiddenField ID="Hnfd" runat="server" />
                        </tr>
                        <tr>
                            <td>Welcome Content  </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" class="form-control" TextMode="MultiLine" Width="418px" MaxLength="200"></asp:TextBox></td>
                        </tr>


                        <tr>
                            <td>Mission & Vision Content  </td>
                            <td>
                                <asp:TextBox ID="TextBox2" TextMode="MultiLine" class="form-control" runat="server" Width="418px" MaxLength="200"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnAboutus" runat="server" class="btn btn-info" Text="Add" OnClick="btnAboutus_Click" Height="45px" Width="103px" />
                                <asp:HiddenField ID="hnId" runat="server" />

                            </td>
                        </tr>
                    </table>
                </div>


            </div>
        </div>
    </div>

    <!--/row-->
    <div class="row">
        <div class="box col-md-12">
            <div class="box-inner">
                <div class="box-header well" data-original-title="">
                    <h2><i class="glyphicon glyphicon-star-empty"></i>About Us</h2>

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
                                <th>Image</th>
                                <th>Welcome Content</th>
                                <th>Mission & Vision Content</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeaterid1" runat="server" OnItemCommand="Repeaterid1_ItemCommand">
                                <ItemTemplate>
                                    <tr>
                                        <td><%#Eval("AID") %></td>
                                        <td>
                                            <img alt="Image not available" style="width: 100px; height: 100px" src='<%#Eval("ImagePath") %>' />
                                        </td>
                                        <td><%#Eval("WCContent") %></td>
                                        <td><%#Eval("MissionVisionContent") %></td>
                                        <td class="center">
                                            <asp:Button ID="btnEdit" runat="server" class="btn btn-info" Text="Edit" CommandName="Update" CommandArgument='<%#Eval("AID") %>' />
                                            <br />
                                            <br />
                                            <asp:Button ID="btnDelete" runat="server" class="btn btn-danger" Text='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandName='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandArgument='<%#Eval("AID") %>' />
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
