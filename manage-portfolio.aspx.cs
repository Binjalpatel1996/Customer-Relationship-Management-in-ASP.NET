using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BAL;
using System.Data;
using System.IO;

namespace CRM.Admin
{
    public partial class manage_portfolio : System.Web.UI.Page
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
                ds = objinteraction.PortfolioSelectAll();
                Repeaterid1.DataSource = ds;
                Repeaterid1.DataBind();
            }
            catch (Exception)
            { }
        }


        protected void Repeaterid1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Deactivate")
                {
                    objvalue.PortfolioID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "D";
                    objinteraction.PortfolioDelete(objvalue);
                    BindData();
                }
                else if (e.CommandName == "Activate")
                {
                    objvalue.PortfolioID = Convert.ToInt32(e.CommandArgument);
                    objvalue.Flag = "A";
                    objinteraction.PortfolioDelete(objvalue);
                    BindData();
                }
                else if (e.CommandName == "Update")
                {
                    hnId.Value = e.CommandArgument.ToString();
                    objvalue.PortfolioID = Convert.ToInt32(e.CommandArgument);
                    ds = objinteraction.PortfolioSelectById(objvalue);
                    objvalue.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                    Image1.ImageUrl = ds.Tables[0].Rows[0]["CoverImage"].ToString();
                    Hnfd.Value = ds.Tables[0].Rows[0]["CoverImage"].ToString();
                    objvalue.UpdatedDate = DateTime.Now;
                    Image1.Visible = true;

                    btnAdd.Text = "Update";


                }
            }
            catch (Exception)
            { }

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAdd.Text == "Add")
                {
                    String FilePath = "";
                    if (UploadPortfolio.HasFile)
                    {
                        String FileDirectory;
                        FileDirectory = Server.MapPath("/images/Portfolio/");
                        if (!Directory.Exists(FileDirectory))
                        {
                            Directory.CreateDirectory(FileDirectory);
                        }
                        FilePath = "/images/Portfolio/" + UploadPortfolio.FileName;
                        UploadPortfolio.SaveAs(Server.MapPath(FilePath));

                    }

                    objvalue.Name = txtName.Text;
                    objvalue.CoverImage = FilePath;
                    objvalue.CreatedDate = DateTime.Now;
                    objvalue.Flag = objvalue.Flag;
                    objinteraction.PortfolioInsert(objvalue);
                    DataBind();
                    clearData();

                }
                else
                {
                    String FilePath1 = "";
                    if (UploadPortfolio.HasFile)
                    {
                        String FileDirectory;
                        FileDirectory = Server.MapPath("/images/Portfolio/");
                        if (!Directory.Exists(FileDirectory))
                        {
                            Directory.CreateDirectory(FileDirectory);
                        }
                        FilePath1 = "/images/Portfolio/" + UploadPortfolio.FileName;
                        UploadPortfolio.SaveAs(Server.MapPath(FilePath1));

                    }
                    else
                    {

                        FilePath1 = Hnfd.Value;

                    }
                    objvalue.PortfolioID = Convert.ToInt32(hnId.Value);
                    objvalue.Name = txtName.Text;
                    objvalue.CoverImage = FilePath1;
                    objvalue.UpdatedDate = DateTime.Now;
                    objinteraction.PortfolioUpdate(objvalue);
                    BindData();
                    clearData();
                    btnAdd.Text = "Add";


                }
            }
            catch (Exception)
            { }
            
            }

             private void clearData()
               {
 	                txtName.Text = "";
                    Image1.ImageUrl = "";
               }

        }
}
