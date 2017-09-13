using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;


public partial class Admin_AdminProfile : System.Web.UI.Page
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
            //string str = "<div class='row'>";
            //str += "<div class='col-md-12'>";

            //str += "<div class='profile-sidebar' style='width:250px;'>";
            //str += "<div class='portlet light profile-sidebar-portlet'>";
            //str += "<div class='profile-userpic'>";
            //str += "<img src='../Images/" + datau[0].Userimg + "'>";
            //str += "</div>";

            //str += "<div class='profile-usertitle'>";
            //str += "<div class='profile-usertitle-name'>";
            //str += datau[0].Fname;
            //str += "</div>";
            //str += "</div>";

            //str += "</div>";
            //str += "</div>";
            //str += "</div>";


            //str += "</div>";
            //str += "</div>";
            string user = "Userid='" + Session["Userid"] + "'";


            txtFname.Text = datau[0].Fname;
            txtLname.Text = datau[0].Lname;
            txtAddress.Text = datau[0].Address;
            txtCntn.Text = datau[0].Contno;
            txtPcode.Text = datau[0].PostalCode.ToString();
            //txtUname.Text = datau[0].Username;
            txtEmailId.Text = datau[0].Email;
            txtDOB.Text = datau[0].Dob.ToString();
            Image1.ImageUrl = "~/Images/" + datau[0].Userimg;
            //txtArea.Text = datau[0].AreaName;

        }
    }
    protected void btnChngPwd_Click(object sender, EventArgs e)
    {
        var datap = (from t in dc.Users
                     where t.Userid.Equals(Session["Userid"]) && t.Password.Equals(txtOldPwd.Text)
                     select t).ToList();
        if (datap.Count == 1)
        {
            if (txtNewPwd.Text == txtReNewPwd.Text)
            {
                dc.Change_Pwd(int.Parse(Session["Userid"].ToString()), txtNewPwd.Text);
                MailMessage email = new MailMessage();
                email.From = new MailAddress(txtEmailId.Text);
                email.To.Add(txtEmailId.Text);
                email.Subject = "Change Password Information:";

                email.Body = "Hi,</h1> Your Password Successfully Changed.Thank you.";
                email.IsBodyHtml = true;
                SmtpClient smtpc = new SmtpClient("smtp.gmail.com");
                smtpc.Port = 587;
                smtpc.UseDefaultCredentials = false;
                smtpc.EnableSsl = true;
                smtpc.Credentials = new NetworkCredential("assetsmanagementsystem@gmail.com", "ams1511har");
                smtpc.Send(email);
                Response.Write("<script>alert('Your Password Successfully Changed.')</script>");
            }
            else
            {
                // lblMsg.text= "Please correct same password";
            }
        }
    }
}
