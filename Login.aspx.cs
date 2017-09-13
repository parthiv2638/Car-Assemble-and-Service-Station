using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

public partial class Login_Login : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    //protected void btnLogin_Click(object sender, EventArgs e)
    //{
    //    var data = (from t in dc.Users
    //                where t.Username.Equals(txtUname.Text) 
    //                && t.Password.Equals(txtPwd.Text) select t).ToList();
    //    if (data.Count == 1)
    //    {
    //        if (data[0].IsAuth == true)
    //        {
    //            Session["Userid"] = data[0].Userid;
    //            if (data[0].Did == 1)
    //            {
    //                Response.Redirect("~/Admin/Adminhome.aspx");
    //            }
    //            else if (data[0].Did == 2)
    //            {
    //                Response.Redirect("~/Operator/Operatohome.aspx");
    //            }
    //            else if (data[0].Did == 3)
    //            {
    //                Response.Redirect("~/Workers/Workerhome.aspx");
    //            }
    //            else if (data[0].Userid == 4)
    //            {
    //                Response.Redirect("~/Customer/Customerhome.aspx");
    //            }
    //        }
    //        else
    //        {
    //            lblMsg.Text = "Your Account is Disable";
    //        }
    //    }
    //    else
    //    {
    //        lblMsg.Text = "Registration First";
    //    }
    //}
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        var data = (from t in dc.Users
                    where t.Username.Equals(txtUname.Text)
                    && t.Password.Equals(txtPwd.Text)
                    select t).ToList();
        if (data.Count == 1)
        {
            if (data[0].IsAuth == true)
            {
                Session["Userid"] = data[0].Userid;
               // Session["Username"] = data[0].Username;
                if (data[0].Did == 1)
                {
                    Response.Redirect("~/Admin/Adminhome.aspx");
                }
                else if (data[0].Did == 2)
                {
                    Response.Redirect("~/Operator/Operatohome.aspx");
                }
                else if (data[0].Did == 3)
                {
                    Response.Redirect("~/Workers/Workerhome.aspx");
                }
                else if (data[0].Did == 4)
                {
                    Response.Redirect("~/Customer/CHome.aspx");
                }
            }
            else
            {
                lblMsg.Text = "Your Account is Disable";
            }
        }
        else
        {
            Response.Write("<script>alert('Username & Password Do Not Match...').</script>");
        }
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        var fun = (from t in dc.Users
                    where t.Email.Equals(txtEmail.Text)
                    select new
                    {
                        t.Fname,
                        t.Lname,
                        t.Password
                    }).ToList();




        MailMessage email = new MailMessage();

        email.From = new MailAddress(txtEmail.Text);
        email.To.Add(txtEmail.Text);
        email.Subject = "Your Forrget Password:";

        email.Body = "Hi,Your Name is:<h3> " + fun[0].Fname + "  " + " " + fun[0].Lname + "" + "</h3>Your Password is:<h1> " + fun[0].Password + "</h1>";
        email.IsBodyHtml = true;
        SmtpClient smtpc = new SmtpClient("smtp.gmail.com");
        smtpc.Port = 587;
        smtpc.UseDefaultCredentials = false;
        smtpc.EnableSsl = true;
        smtpc.Credentials = new NetworkCredential("assetsmanagementsystem@gmail.com", "ams1511har");
        smtpc.Send(email);
        lblMsg.Text = "Your password has been sent to your email address";
    }
}
