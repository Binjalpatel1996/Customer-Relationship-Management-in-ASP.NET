<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="manage-slider.aspx.cs" Inherits="CRM.manage_slider" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">

        <div class="box col-md-12">
            <div class="box-inner">
                <div class="box-header well" data-original-title="">
                    <h2><i class="glyphicon glyphicon-user"></i>Slider Images Form</h2>
                    <div class="box-icon">
                        <a href="#" class="btn btn-minimize btn-round btn-default"><i
                            class="glyphicon glyphicon-chevron-up"></i></a>
                        
                    </div>
                </div>
                <div class="box-content">
                    <table>
                        <tr>
                            <td>Slider Image
                            </td>
                            <td>
                                <asp:FileUpload ID="UploadSliderimage" runat="server" />
                                <asp:Image ID="Image1" runat="server" Visible="false" Style="width: 100px; height: 100px" />
                                <asp:HiddenField ID="Hnfd" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>Slider Title</td>
                            <td>
                                <asp:TextBox ID="txtSlidertitle" runat="server" class="form-control" MaxLength="30" Width="418px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Slider Description
                            </td>
                            <td>
                                <asp:TextBox ID="txtsliderdes" runat="server" class="form-control" TextMode="MultiLine" MaxLength="50" Width="418px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="BtnSliderImage1" runat="server" Text="Add Image" class="btn btn-info btn-lg" Width="129px" OnClick="BtnSliderImage1_Click" />
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
                    <h2><i class="glyphicon glyphicon-user"></i>Slider Images</h2>

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
                                <th>Title</th>
                                <th>Description</th>
                                <th>Actions</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeaterid1" runat="server" OnItemCommand="Repeaterid1_ItemCommand">
                                <ItemTemplate>
                                    <tr>
                                        <td><%#Eval("SliderID") %></td>
                                        <td>
                                            <img alt="Image not available" style="width: 100px; height: 100px" src='<%#Eval("ImagePath") %>' />
                                        </td>
                                        <td><%#Eval("SliderTitle") %></td>
                                        <td><%#Eval("SliderDescription") %></td>

                                        <td class="center">
                                            <asp:Button ID="btnUpdate" class="btn btn-info" runat="server" Text="EDIT" CommandName="Update" CommandArgument='<%#Eval("SliderID") %>' />
                                           &nbsp;
                                            <asp:Button ID="btnDelete" runat="server" class="btn btn-danger" Text='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandName='<%#(Eval("Flag").ToString()=="A")?"Deactivate":"Activate" %>' CommandArgument='<%#Eval("SliderID") %>' />

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
