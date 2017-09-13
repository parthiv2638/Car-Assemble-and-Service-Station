using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customer_CProfile : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

        var datau = (from t in dc.Users
                     join ta in dc.Areas on t.AreaId equals ta.AreaId
                     where t.Userid == int.Parse(Session["Userid"].ToString())
                     select new
                     {
                         t.Fname,
                         t.Lname,
                         t.Address,
                         t.Contno,
                         t.PostalCode,
                         t.Username,
                         t.Email,
                         t.Dob,
                         t.Userimg,
                         ta.AreaName
                     }).ToList();




        if (datau.Count == 1)
        {

            //string user = "Userid='" + Session["Userid"] + "'";


            txtFname.Text = datau[0].Fname;
            txtLname.Text = datau[0].Lname;
            txtAddress.Text = datau[0].Address;
            txtCntn.Text = datau[0].Contno;
            txtPcode.Text = datau[0].PostalCode.ToString();
            txtUname.Text = datau[0].Username;
            txtEmailId.Text = datau[0].Email;
            txtDOB.Text = datau[0].Dob.ToString();
            Userimg.ImageUrl = "/Images/" + datau[0].Userimg;
            txtArea.Text = datau[0].AreaName;
        }
    }
}
