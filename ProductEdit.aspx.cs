using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ProductEdit : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                var datap = (from t in dc.Products
                             where t.Pid.Equals(Request.QueryString["Id"])
                             select t).ToList();
                if (datap.Count == 1)
                {
                    txtPname.Text = datap[0].Pname;
                    Image1.ImageUrl = "~/Images/" + datap[0].Pimg;
                    HiddenField1.Value = datap[0].Pimg;
                    if (datap[0].IsDisplay == true)
                    {
                        chkIsDisplay.Checked = true;
                    }
                }
            }
        }
    }



    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(Request.QueryString["Id"]))
        {
            //update
            if (FuImage.HasFile == true)
            {
                FuImage.SaveAs(Server.MapPath("Images") + FuImage.FileName);
                dc.Product_Update(int.Parse(Request.QueryString["Id"]), txtPname.Text, FuImage.FileName, chkIsDisplay.Checked);
                Response.Redirect("ProductList.aspx");
            }
            else
            {
                dc.Product_Update(int.Parse(Request.QueryString["Id"]), txtPname.Text, HiddenField1.Value, chkIsDisplay.Checked);
                Response.Redirect("ProductList.aspx");
            }
        }
        else
        {
            //Insert
            if (FuImage.HasFile == true)
            {
                FuImage.SaveAs(Server.MapPath("../Images/") + FuImage.FileName);
                dc.Product_Insert(txtPname.Text, FuImage.FileName, chkIsDisplay.Checked);
                Response.Redirect("ProductList.aspx");
            }
        }
    }
}