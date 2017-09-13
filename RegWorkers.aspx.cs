using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;


public partial class Admin_RegWorkers : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var dataa = (from t in dc.Areas select t).ToList();
            ddlArea.DataSource = dataa;
            ddlArea.DataTextField = "AreaName";
            ddlArea.DataValueField = "AreaId";
            ddlArea.DataBind();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        dc.User_Insert(3, txtFname.Text, txtLname.Text, txtAddress.Text, txtCntn.Text, int.Parse(txtPcode.Text), txtUname.Text, txtPwd.Text, txtEmailId.Text, Convert.ToDateTime(txtDOB.Text), FuImage.FileName, int.Parse(ddlArea.SelectedValue), true);
        Response.Write("<script>alert('Email Address & Password Successfully Sent.')</script>");

        var fun = (from fp in dc.Users
                   where fp.Email == txtEmailId.Text
                   select new
                   {
                       fp.Fname,
                       fp.Lname,
                       fp.Password
                   }).ToList();

        if (fun.Count == 1)
        {
            MailMessage email = new MailMessage();

            email.From = new MailAddress(txtEmailId.Text);
            email.To.Add(txtEmailId.Text);
            email.Subject = "Registration Information:";

            email.Body = "Hi,Your Name is:<h3> " + fun[0].Fname + "  " + " " + fun[0].Lname + "" + "</h3>Your Password is:<h1> " + fun[0].Password + "</h1>";
            email.IsBodyHtml = true;
            SmtpClient smtpc = new SmtpClient("smtp.gmail.com");
            smtpc.Port = 587;
            smtpc.UseDefaultCredentials = false;
            smtpc.EnableSsl = true;
            smtpc.Credentials = new NetworkCredential("assetsmanagementsystem@gmail.com", "ams1511har");
            smtpc.Send(email);
            //Response.Write("<script>alert('Email Address & Password Successfully Sent.')</script>");
        }
    }
}