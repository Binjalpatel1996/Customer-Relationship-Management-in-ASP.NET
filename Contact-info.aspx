<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="Contact-info.aspx.cs" Inherits="CRM.Contact_info" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">

        <div class="box col-md-12">
            <div class="box-inner">
                <div class="box-header well" data-original-title="">
                    <h2><i class="glyphicon glyphicon-user"></i>Add Contact Information</h2>
                </div>
                <div class="box-icon">
                        <a href="#" class="btn btn-minimize btn-round btn-default"><i
                            class="glyphicon glyphicon-chevron-up"></i></a>
                        
                    </div>
                <table>
                    <tr>
                        <td class="auto-style1">Company Logo 
                        </td>
                        <td class="auto-style2">
                            <asp:FileUpload ID="Uploadcompanylogo" runat="server" Width="241px" />
                            <asp:Image ID="Image1" runat="server" Style="width: 50px" Visible="false" /></td>
                        <asp:HiddenField ID="hnfd" runat="server" />
                        <td>Street Name</td>
                        <td>
                            <asp:TextBox ID="txtStreetName" runat="server" class="form-control" Width="216px" ></asp:TextBox></td>

                    </tr>
                    <tr>
                        <td class="auto-style1">Company Name</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtCompanyname" runat="server" class="form-control" MaxLength="100" Width="216px" Height="22px"></asp:TextBox>
                        </td>
                        <td>City</td>
                        <td>
                            <asp:TextBox ID="txtCity" runat="server"  class="form-control" MaxLength="100" Width="216px" Height="22px" ></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Contact 1 </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtContact1" runat="server" class="form-control" MaxLength="10" Width="216px" Height="22px" ></asp:TextBox></td>
                        <td>Zip Code</td>
                        <td>
                            <asp:TextBox ID="txtZipcode" runat="server"  class="form-control" MaxLength="8" Width="216px" Height="22px" ></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Contact 2 </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtContact2" runat="server" class="form-control" MaxLength="10"  Width="216px" Height="22px"></asp:TextBox></td>
                        <td>State</td>
                        <td>
                            <asp:TextBox ID="txtstate" runat="server" class="form-control" MaxLength="100" Width="216px" Height="22px"></asp:TextBox></td>
                    </tr>

                    <tr>
                        <td class="auto-style1">Email</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtEmail" runat="server" class="form-control" MaxLength="20" Width="216px" Height="22px"></asp:TextBox></td>
                        <td class="auto-style1">Country</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtCountry" runat="server" class="form-control" MaxLength="100" Width="216px" Height="22px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Map </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtMap" runat="server" class="form-control" Width="210px" Height="22px"></asp:TextBox>
                        </td>
                        <td class="auto-style1">Timings 
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtTiming" runat="server" class="form-control" MaxLength="100" Width="210px" Height="22px" TextMode="MultiLine" Rows="5"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">

                            <asp:Button ID="btnSave1" runat="server" Text="Save" class="btn btn-info btn-lg" Width="129px" OnClick="btnSave1_Click" />
                            <asp:HiddenField ID="hnId" runat="server" />
                            <%-- <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-info btn-lg" Width="129px" OnClick="btnUpdate_Click" />--%>
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
                    <h2><i class="glyphicon glyphicon-user"></i>Contact information</h2>

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
                                <th>Company Logo </th>
                                <th>Company Name</th>
                                <th>Streetname</th>
                                <th>City</th>
                                <th>Zipcode</th>
                                <th>State</th>
                                <th>Country</th>
                                <th>Contact 1</th>
                                <th>Contact 2</th>
                                <th>Email</th>
                                <th>Timimg</th>
                                <th>Map</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                                <ItemTemplate>
                                    <tr>
                                        <td><%#Eval("CID") %></td>
                                        <td>
                                            <img alt="Image not available" style="width: 100px; height: 100px" src='<%#Eval("CompanyLogo") %>' />
                                        </td>
                                        <td><%#Eval("CompanyName") %></td>
                                        <td><%#Eval("Streetname") %></td>
                                        <td><%#Eval("City") %></td>
                                        <td><%#Eval("Zipcode") %></td>
                                        <td><%#Eval("State") %></td>
                                        <td><%#Eval("Country") %></td>
                                        <td><%#Eval("Contact1") %></td>
                                        <td><%#Eval("Contact2") %></td>
                                        <td><%#Eval("Email") %></td>
                                        <td><%#Eval("Timing") %></td>
                                        <td><%#Eval("Map") %></td>
                                        <td class="center">

                                            <asp:Button ID="btnUpdate" class="btn btn-info" runat="server" Text="Edit" CommandName="Update" CommandArgument='<%#Eval("CID") %>' />
                                            <br />
                                            <br />
                                            <asp:Button ID="btnedit" class="btn btn-danger" runat="server" Text='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandName='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandArgument='<%#Eval("CID") %>' />

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
