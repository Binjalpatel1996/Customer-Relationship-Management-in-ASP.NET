using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using DAL;
using System.Data;
using System.IO;

namespace CRM
{
   public partial class User_Profile : System.Web.UI.Page
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
                ds = objinteraction.userSelectAll();
                Repeaterid1.DataSource = ds;
                Repeaterid1.DataBind();
            }
            catch (Exception)
            {

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSubmit.Text == "Submit")
                {
                    String FilePath = "";
                    if (UploadProfile.HasFile)
                    {
                        String FileDirectory;
                        FileDirectory = Server.MapPath("/images/User Profile/");
                        if (!Directory.Exists(FileDirectory))
                        {
                            Directory.CreateDirectory(FileDirectory);
                        }
                        FilePath = "/images/User Profile/" + UploadProfile.FileName;
                        UploadProfile.SaveAs(Server.MapPath(FilePath));

                    }
                    objvalue.Name = txtName.Text;
                    objvalue.ImagePath = FilePath;
                    objvalue.Email = TxtEmail.Text;
                    objvalue.Username = txtUsername.Text;
                    objvalue.Password = txtPassword.Text;
                    objvalue.Contact = txtContact.Text;
                    objvalue.CreatedDate = DateTime.Now;
                    objvalue.Flag = objvalue.Flag;
                    objinteraction.userInsert(objvalue);
                    BindData();
                    clearFormData();
                }
                else
                {
                    String FilePath1 = "";
                    if (UploadProfile.HasFile)
                    {
                        String FileDirectory;
                        FileDirectory = Server.MapPath("/images/User Profile/");
                        if (!Directory.Exists(FileDirectory))
                        {
                            Directory.CreateDirectory(FileDirectory);
                        }
                        FilePath1 = "/images/User Profile/" + UploadProfile.FileName;
                        UploadProfile.SaveAs(Server.MapPath(FilePath1));

                    }
                    else
                    {
                        FilePath1 = hnfd.Value;

                    }

                    objvalue.UserProfileID = Convert.ToInt32(hnId.Value);
                    objvalue.Name = txtName.Text;
                    objvalue.ImagePath = FilePath1;
                    objvalue.Email = TxtEmail.Text;
                    objvalue.Username = txtUsername.Text;
                    objvalue.Password = txtPassword.Text;
                    objvalue.Contact = txtContact.Text;
                    objvalue.UpdatedDate = DateTime.Now;
                    objinteraction.userUpdate(objvalue);
                    BindData();
                    clearFormData();

                }
            }
            catch (Exception)
            { }
        }

        private void clearFormData()
        {
            txtName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
        }

        protected void Repeaterid1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Deactivate")
                {
                    objvalue.UserProfileID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "D";
                    objinteraction.userDelete(objvalue);
                    BindData();
                }
                else if (e.CommandName == "Activate")
                {
                    objvalue.UserProfileID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "A";
                    objinteraction.userDelete(objvalue);
                    BindData();

                }
                else if (e.CommandName == "Update")
                {
                    hnId.Value = e.CommandArgument.ToString();

                    objvalue.UserProfileID = Convert.ToInt32(e.CommandArgument);
                    ds = objinteraction.userSelectById(objvalue);
                    txtName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                    TxtEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                    txtUsername.Text = ds.Tables[0].Rows[0]["Username"].ToString();
                    txtPassword.Text = ds.Tables[0].Rows[0]["Password"].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0]["Contact"].ToString();
                    Image1.ImageUrl = ds.Tables[0].Rows[0]["ImagePath"].ToString();
                    hnfd.Value = ds.Tables[0].Rows[0]["ImagePath"].ToString();
                    objvalue.UpdatedDate = DateTime.Now;
                    Image1.Visible = true;
                    btnSubmit.Text = "Update";


                }
            }
            catch (Exception)
            { }

        }
    }
}