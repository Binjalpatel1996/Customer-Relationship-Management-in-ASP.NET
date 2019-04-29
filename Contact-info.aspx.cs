using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using DAL;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace CRM
{
    public partial class Contact_info : System.Web.UI.Page
    {
        Prop objvalue = new Prop();
        InteractionMethod objinteraction = new InteractionMethod();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }
        private void BindData()
        {
            try
            {
                ds = objinteraction.ContactUsSelectAll();
                Repeater1.DataSource = ds;
                Repeater1.DataBind();
            }
            catch (Exception)
            {

            }
        }

        protected void btnSave1_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSave1.Text == "Save")
                {
                    String FilePath = "";
                    if (Uploadcompanylogo.HasFile)
                    {
                        String FileDirectory;
                        FileDirectory = Server.MapPath("/images/Contactinfo/");
                        if (!Directory.Exists(FileDirectory))
                        {
                            Directory.CreateDirectory(FileDirectory);
                        }
                        FilePath = "/images/Contactinfo/" + Uploadcompanylogo.FileName;
                        Uploadcompanylogo.SaveAs(Server.MapPath(FilePath));

                    }
                    objvalue.CompanyLogo = FilePath;
                    objvalue.Streetname = txtStreetName.Text;
                    objvalue.CompanyName = txtCompanyname.Text;
                    objvalue.City = txtCity.Text;
                    objvalue.State = txtstate.Text;
                    objvalue.Country = txtCountry.Text;
                    objvalue.Contact1 = txtContact1.Text;
                    objvalue.Contact2 = txtContact2.Text;
                    objvalue.Zipcode = txtZipcode.Text;
                    objvalue.Email = txtEmail.Text;
                    objvalue.Timing = txtTiming.Text;
                    objvalue.Map = txtMap.Text;
                    objvalue.CreatedDate = DateTime.Now;
                    objinteraction.ContactInsert(objvalue);
                    DataBind();
                    clearData();

                }
                else
                {
                    String FilePath1 = "";
                    if (Uploadcompanylogo.HasFile)
                    {
                        String FileDirectory;
                        FileDirectory = Server.MapPath("/images/ContectInfo/");
                        if (!Directory.Exists(FileDirectory))
                        {
                            Directory.CreateDirectory(FileDirectory);
                        }
                        FilePath1 = "/images/ContectInfo/" + Uploadcompanylogo.FileName;
                        Uploadcompanylogo.SaveAs(Server.MapPath(FilePath1));
                    }
                    else
                    {
                        FilePath1 = hnfd.Value;

                    }
                    objvalue.CID = Convert.ToInt32(hnId.Value);
                    objvalue.CompanyLogo = FilePath1;
                    objvalue.Streetname = txtStreetName.Text;
                    objvalue.CompanyName = txtCompanyname.Text;
                    objvalue.City = txtCity.Text;
                    objvalue.State = txtstate.Text;
                    objvalue.Country = txtCountry.Text;
                    objvalue.Contact1 = txtContact1.Text;
                    objvalue.Contact2 = txtContact2.Text;
                    objvalue.Zipcode = txtZipcode.Text;
                    objvalue.Email = txtEmail.Text;
                    objvalue.Timing = txtTiming.Text;
                    objvalue.Map = txtMap.Text;
                    objvalue.UpdatedDate = DateTime.Now;
                    objinteraction.ContactUpdate(objvalue);
                    DataBind();
                    clearData();

                }
            }
            catch (Exception)
            { }
            }

          private void clearData()
         {
            Image1.ImageUrl = "";
 	        txtCompanyname.Text = "";
            txtContact1.Text = "";
            txtContact2.Text = "";
            txtEmail.Text = "";
            txtTiming.Text = "";
            txtMap.Text = "";
            txtZipcode.Text = "";
            txtCity.Text = "";
            txtStreetName.Text = "";
            txtstate.Text = "";
            txtCountry.Text = "";
        } 
        

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Deactivate")
                {
                    objvalue.CID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "D";
                    objinteraction.ContactDelete(objvalue);
                    BindData();
                }
                else if (e.CommandName == "Activate")
                {
                    objvalue.CID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "A";
                    objinteraction.ContactDelete(objvalue);
                    BindData();
                }
                else if (e.CommandName == "Update")
                {
                    hnId.Value = e.CommandArgument.ToString();
                    objvalue.CID = Convert.ToInt32(e.CommandArgument);
                    ds = objinteraction.ContactSelectById(objvalue);
                    txtCompanyname.Text = ds.Tables[0].Rows[0]["CompanyName"].ToString();
                    txtContact1.Text = ds.Tables[0].Rows[0]["Contact1"].ToString();
                    txtContact2.Text = ds.Tables[0].Rows[0]["Contact2"].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                    txtTiming.Text = ds.Tables[0].Rows[0]["Timing"].ToString();
                    txtMap.Text = ds.Tables[0].Rows[0]["Map"].ToString();
                    txtStreetName.Text = ds.Tables[0].Rows[0]["Streetname"].ToString();
                    txtCity.Text = ds.Tables[0].Rows[0]["City"].ToString();
                    txtstate.Text = ds.Tables[0].Rows[0]["State"].ToString();
                    txtCountry.Text = ds.Tables[0].Rows[0]["Country"].ToString();
                    txtZipcode.Text = ds.Tables[0].Rows[0]["Zipcode"].ToString();
                    Image1.ImageUrl = ds.Tables[0].Rows[0]["CompanyLogo"].ToString();
                    objvalue.UpdatedDate = DateTime.Now;
                    Image1.Visible = true;

                    btnSave1.Text = "Update";

                }
            }
            catch (Exception)
            { }
         }
    }
}