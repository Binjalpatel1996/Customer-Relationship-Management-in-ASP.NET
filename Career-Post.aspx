<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="Career-Post.aspx.cs" Inherits="CRM.Career_Post" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="box col-md-12">

            <div class="box-inner">
                <div class="box-header well" data-original-title="">
                    <h2><i class="glyphicon glyphicon-star-empty"></i>Add Career </h2>

                    <div class="box-icon">
                       
                        <a href="#" class="btn btn-minimize btn-round btn-default"><i
                            class="glyphicon glyphicon-chevron-up"></i></a>
                        
                    </div>
                </div>
                <div class="box-content">
                    <!-- put your content here -->

                    <table>
                        <tr>
                            <td>Technology
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownList1" class="btn btn-default btn-lg" runat="server" >
                                    <asp:ListItem>--Select Technology--</asp:ListItem>
                                    <asp:ListItem>PHP</asp:ListItem>
                                    <asp:ListItem>Asp.Net</asp:ListItem>
                                    <asp:ListItem>Java</asp:ListItem>
                                    <asp:ListItem>Android</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Post
                            </td>
                            <td>
                                <asp:TextBox ID="txtPost" runat="server" class="form-control" MaxLength="100"  Width="418px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>No.of Vacancies
                            </td>
                            <td>
                                <asp:TextBox ID="txtVacancies" runat="server" class="form-control" MaxLength="10"  Width="418px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Job Location
                            </td>
                            <td>
                                <asp:TextBox ID="txtJoblocation" runat="server" class="form-control" MaxLength="50" Width="418px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Qualification
                            </td>
                            <td>
                                <asp:TextBox ID="txtQualification" runat="server" class="form-control" MaxLength="100"  Width="418px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Required Skill
                            </td>
                            <td>
                                <asp:TextBox ID="txtReqiredskill" runat="server" class="form-control" TextMode="MultiLine" MaxLength="100"  Width="418px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Extra Details
                            </td>
                            <td>
                                <asp:TextBox ID="txtExtradetails" runat="server" class="form-control" TextMode="MultiLine" MaxLength="100" Width="418px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="BtnPost" runat="server" Text="Post" OnClick="BtnPost_Click" class="btn btn-info btn-lg" Width="129px" />
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
                    <h2><i class="glyphicon glyphicon-user"></i>Career Info</h2>

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
                                <th>Technology </th>
                                <th>Post</th>
                                <th>No.of Vacancies</th>
                                <th>Job Location</th>
                                <th>Qualification</th>
                                <th>Required Skill</th>
                                <th>Extra Details</th>
                                <th>Created Date</th>

                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                                <ItemTemplate>
                                    <tr>
                                        <td><%#Eval("CareerVacanciesID") %></td>
                                        <td><%#Eval("Technology") %></td>
                                        <td><%#Eval("Post") %></td>
                                        <td><%#Eval("NumOfVacancies") %></td>
                                        <td><%#Eval("JobLocation") %></td>
                                        <td><%#Eval("Qualification") %></td>
                                        <td><%#Eval("RequiredSkills") %></td>
                                        <td><%#Eval("ExtraContent") %></td>
                                        <td><%#Eval("CreatedDate") %></td>

                                        <td class="center">

                                            <asp:Button ID="btnUpdate" class="btn btn-info" runat="server" Text="EDIT" CommandName="Update" CommandArgument='<%#Eval("CareerVacanciesID") %>' />
                                            <br /><br />
                                            <asp:Button ID="btnedit" class="btn btn-danger" runat="server" Text='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandName='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandArgument='<%#Eval("CareerVacanciesID") %>' />

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
