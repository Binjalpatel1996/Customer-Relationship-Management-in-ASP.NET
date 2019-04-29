using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DAL;
using BAL;
using System.IO;

namespace CRM
{
    public partial class About_us : System.Web.UI.Page
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
                ds = objinteraction.AboutusSelectAll();
                Repeaterid1.DataSource = ds;
                Repeaterid1.DataBind();
            }
            catch (Exception)
            {

            }
        }

        protected void btnAboutus_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAboutus.Text == "Add")
                {
                    String FilePath1 = "";
                    if (FileUpload1.HasFile)
                    {
                        String FileDirectory;

                        FileDirectory = Server.MapPath("images/AboutUs/");
                        if (!Directory.Exists(FileDirectory))
                        {
                            Directory.CreateDirectory(FileDirectory);
                        }
                        FilePath1 = "images/AboutUs/" + FileUpload1.FileName;
                        FileUpload1.SaveAs(Server.MapPath(FilePath1));

                    }


                    objvalue.ImagePath = FilePath1;
                    objvalue.WCContent = TextBox1.Text;

                    objvalue.CreatedDate = DateTime.Now;
                    objvalue.MissionVisionContent = TextBox2.Text;
                    objinteraction.AboutInsert(objvalue);
                    BindData();
                    ClearFormField();
                }


                else if (btnAboutus.Text == "Update")
                {
                    String FilePath2 = "";
                    if (FileUpload1.HasFile)
                    {
                        String FileDirectory;

                        FileDirectory = Server.MapPath("images/AboutUs/");
                        if (!Directory.Exists(FileDirectory))
                        {
                            Directory.CreateDirectory(FileDirectory);
                        }
                        FilePath2 = "images/AboutUs/" + FileUpload1.FileName;
                        FileUpload1.SaveAs(Server.MapPath(FilePath2));

                    }
                    else
                    {
                        FilePath2 = Hnfd.Value;

                    }

                    objvalue.AID = Convert.ToInt32(hnId.Value);
                    objvalue.ImagePath = FilePath2;
                    objvalue.WCContent = TextBox1.Text;

                    objvalue.UpdatedDate = DateTime.Now;
                    objvalue.MissionVisionContent = TextBox2.Text;
                    objinteraction.AboutUpdate(objvalue);
                    BindData();
                    ClearFormField();
                    btnAboutus.Text = "Add";
                }
            }
            catch (Exception)
            { }
            }
        
        

        private void ClearFormField()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            Image1.ImageUrl = "";
           
        }


        protected void Repeaterid1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Deactivate")
                {
                    objvalue.AID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "D";
                    objinteraction.AboutDelete(objvalue);
                    BindData();
                }
                if (e.CommandName == "Activate")
                {
                    objvalue.AID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "A";
                    objinteraction.AboutDelete(objvalue);
                    BindData();

                }
                if (e.CommandName == "Update")
                {
                    hnId.Value = e.CommandArgument.ToString();
                    objvalue.AID = Int32.Parse(e.CommandArgument.ToString());
                    ds = objinteraction.AboutSelectById(objvalue);
                    TextBox1.Text = ds.Tables[0].Rows[0]["WCContent"].ToString();
                    TextBox2.Text = ds.Tables[0].Rows[0]["MissionVisionContent"].ToString();
                    Image1.ImageUrl = ds.Tables[0].Rows[0]["ImagePath"].ToString();
                    Hnfd.Value = ds.Tables[0].Rows[0]["ImagePath"].ToString();
                    Image1.Visible = true;

                    btnAboutus.Text = "Update";

                }
            }
            catch (Exception)
            { }
        }


    }
}