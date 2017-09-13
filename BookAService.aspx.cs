using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

public partial class Customer_BookAService : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        var data = (from t in dc.VehicleNumbers
                    where t.Userid.Equals(Session["Userid"])
                    select t).ToList();
        ddlVehl.DataSource = data;
        ddlVehl.DataTextField = "Vnumber";
        ddlVehl.DataValueField = "Vnumberid";
        ddlVehl.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        var data1 = (from t in dc.Services
                     where t.Aregistereddate.Equals(txtDate.Text)
                     select t).ToList();
        if (data1.Count < 20)
        {
            dc.Service_Insert(txtDesc.Text, int.Parse(ddlVehl.SelectedValue), int.Parse(Session["Userid"].ToString()), false, Convert.ToDateTime(txtDate.Text), true);
            Response.Write("<script>alert('Your Package Successfully Activeted.')</script>");

            var data2 = (from t in dc.Users
                         where t.Userid.Equals(Session["Userid"])
                         select t).ToList();

            //mail
            MailMessage email = new MailMessage();

            email.From = new MailAddress(data2[0].Email);
            email.To.Add(data2[0].Email);
            email.Subject = "Your Appoinmnet Booked:";

            email.Body = "Hi,Your Name is:<h3> " + data2[0].Fname + "" + data2[0].Lname + "" + "</h3>Your Appointmnet is sucessfully Booked:<h3> " + "</h1>";
            email.IsBodyHtml = true;
            SmtpClient smtpc = new SmtpClient("smtp.gmail.com");
            smtpc.Port = 587;
            smtpc.UseDefaultCredentials = false;
            smtpc.EnableSsl = true;
            smtpc.Credentials = new NetworkCredential("assetsmanagementsystem@gmail.com", "ams1511har");
            smtpc.Send(email);
            //Response.Redirect("CHome.aspx");
        }
        else
        {
            lblMsg.Text = "Today's appointment is Full so choose another date...Thank You..!";
        }
        Response.Redirect("Customerhome.aspx");
    }
}
