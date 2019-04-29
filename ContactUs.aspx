<%@ Page Title="" Language="C#" MasterPageFile="~/ClientMasterPage.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="CRM.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="http://maps.googleapis.com/maps/api/js?sensor=false" type="text/javascript"></script>
    <script>
        var initializeMap;

        initializeMap = function () {
            var iw1, latlng, map, marker, options;

            latlng = new google.maps.LatLng(37.331686, -122.030656);
            options = {
                scrollwheel: false,
                zoom: 16,
                center: latlng,
                mapTypeId: google.maps.MapTypeId.ROADMAP,
                mapTypeControl: true
            };

            map = new google.maps.Map(document.getElementById("map-canvas"), options);

            marker = new google.maps.Marker({
                position: latlng,
                map: map
            });

            iw1 = new google.maps.InfoWindow({
                content: "Here we are!"
            });

            return google.maps.event.addListener(marker, "click", function (e) {
                return iw1.open(map, this);
            });
        };

        google.maps.event.addDomListener(window, 'load', initializeMap);
      </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id='main-content-header'>
        <div class='container'>
            <div class='row'>
                <div class='col-sm-12'>
                    <h1 class='title'>Contact
                </h1>
                    <ol class='breadcrumb'>
                        <li>
                            <a href="Default.aspx">
                                <i class='fa fa-home'></i>
                            </a>
                        </li>
                        <li class='active'>Contact</li>


                    </ol>
                </div>
            </div>
        </div>
    </div>
    <div id='main-content'>
        <div class='container'>
            <div class='row'>
                <div class='col-sm-12'>
                    <p class='lead text-center no-mg-b'>Quisque nunc sapien, malesuada vitae luctus in, blandit eu erat. Cras fringilla eros eget justo dictum convallis.</p>
                </div>
            </div>
            <div class='row'>
                <div class='col-sm-12'>
                    <div class='page-header page-header-with-icon'>
                        <i class='fa fa-map-marker'></i>
                        <h2>Our location
                  </h2>
                    </div>
                    <div class='map-container'>
                        <iframe src='<%#Eval("Map") %>' runat="server" id="abcd" style="width: 100%; height: 400px; border: 0"></iframe>

                    </div>
                </div>
            </div>
            <div class='row'>
                <div class='col-sm-12'>
                    <div class='page-header page-header-with-icon'>
                        <i class='fa fa-info-circle'></i>
                        <h2>Contact info
                  </h2>
                    </div>
                    <div class='row text-center'>
                        <div class='col-sm-3'>
                            <div class='icon-wrap icon-circle contrast-bg icon-md'>
                                <i class='fa fa-map-marker text-white'></i>
                            </div>
                            <h3>Address</h3>
                            <ul class='list-unstyled'>
                                <li>
                                    <asp:Label ID="lblStreetname" runat="server" Text="Label"></asp:Label></li>
                                <li>
                                    <asp:Label ID="lblCity" runat="server" Text="Label"></asp:Label>,
                                    <asp:Label ID="lblZipcode" runat="server" Text="Label"></asp:Label></li>
                                <li>
                                    <asp:Label ID="lblState" runat="server" Text="Label"></asp:Label>,
                                    <asp:Label ID="lblCountry" runat="server" Text="Label"></asp:Label></li>
                            </ul>
                        </div>
                        <div class='col-sm-3'>
                            <div class='icon-wrap icon-circle contrast-bg icon-md'>
                                <i class='fa fa-phone text-white'></i>
                            </div>
                            <h3>Telephone</h3>
                            <ul class='list-unstyled'>
                                <li><a runat="server" id="acontact1">
                                    <asp:Label ID="lblContact1" runat="server" Text="Label"></asp:Label></a></li>
                                <li><a runat="server" id="acontact2">
                                    <asp:Label ID="lblContact2" runat="server" Text="Label"></asp:Label></a></li>

                            </ul>
                        </div>
                        <div class='col-sm-3'>
                            <div class='icon-wrap icon-circle contrast-bg icon-md'>
                                <i class='fa fa-envelope-o text-white'></i>
                            </div>
                            <h3>E-Mail</h3>
                            <ul class='list-unstyled'>
                                <li>
                                    <a runat="server" id="amailid">
                                        <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label></a></li>

                            </ul>
                        </div>
                        <div class='col-sm-3'>
                            <div class='icon-wrap icon-circle contrast-bg icon-md'>
                                <i class='fa fa-clock-o text-white'></i>
                            </div>
                            <h3>Business hours</h3>
                            <ul class='list-unstyled'>
                                <li>
                                    <asp:Label ID="lblTiming" runat="server" Text="Label"></asp:Label></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class='row'>
                <div class='col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2'>
                    <div class='page-header page-header-with-icon'>
                        <i class='fa fa-envelope'></i>
                        <h2>Contact form</h2>
                    </div>
                    <div role="form" class='form form-validation form-contact'>
                        <div class='row'>
                            <div class='col-sm-12'>
                                <div class='alert alert-success form-contact-success hidden'>Thanks! Your message has been successfully sent!</div>
                                <div class='alert alert-danger form-contact-error hidden'>Ooops! There was an error sending your message.</div>
                            </div>
                        </div>
                        <div class='row'>
                            <div class='col-sm-6'>
                                <div class='form-group control-group'>

                                    <asp:TextBox ID="txtName" runat="server" MaxLength="50" data-rule-required='true' type='text' placeholder='Name' class='form-control'></asp:TextBox>
                                    <!-- / this field is required for simple anti spam function, don't remove it! -->

                                </div>
                            </div>

                            <div class='col-sm-6'>
                                <div class='form-group control-group'>
                                    <asp:TextBox ID="txtEmail" runat="server" data-rule-email='true' data-rule-required='true' MaxLength="50" class='form-control' placeholder='E-Mail' type='email'></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class='row'>
                            <div class='col-sm-12'>
                                <div class='form-group control-group'>
                                    <asp:TextBox ID="TextBox1" runat="server" data-rule-number='true' data-rule-required='true' MaxLength="10" placeholder='Phone' class='form-control'></asp:TextBox>

                                </div>
                            </div>
                            <div class='col-sm-12'>
                                <div class='form-group control-group'>
                                    <asp:TextBox ID="TextBox2" runat="server" data-rule-required='true' MaxLength="50" class='form-control' placeholder='Subject'></asp:TextBox>
                                </div>
                            </div>
                            <div class='col-sm-12'>
                                <div class='form-group control-group'>
                                    <asp:TextBox ID="txtmessage" runat="server" data-rule-required='true' TextMode="MultiLine" class='form-control' placeholder='Write Your Message here..'></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class='row'>
                            <div class='col-sm-12'>
                                <asp:Button ID="btnSubmit" runat="server" Text="Send" class='btn btn-contrast btn-block form-contact-submit' OnClick="btnSubmit_Click" />


                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
