using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;


public partial class Customer_PackagesLists : System.Web.UI.Page
{
    DataClassesDataContext dc = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
        {
            DateTime todaysDate = System.DateTime.Now;
            DateTime oneyearDate = DateTime.Now.AddDays(+365);

            dc.PackageDetails_Insert(int.Parse(Session["Userid"].ToString()), int.Parse (Request.QueryString["Id"]),Convert .ToDateTime ( todaysDate) ,Convert .ToDateTime (oneyearDate ));
            Response.Write("<script>alert('Your Package Successfully Activeted.')</script>");


            var data1 = (from t in dc.Users
                        where t.Userid.Equals(Session["Userid"])
                        select t).ToList();

            //mail
            MailMessage email = new MailMessage();

            email.From = new MailAddress(data1[0].Email);
            email.To.Add(data1[0].Email);
            email.Subject = "Your Package Successfully Activated:";

            email.Body = "Hi,Your Name is:<h3> " + data1[0].Fname + "" + data1[0].Lname + "" + "</h3>Your Package is sucessfully activated:<h3> " + "</h1>";
            email.IsBodyHtml = true;
            SmtpClient smtpc = new SmtpClient("smtp.gmail.com");
            smtpc.Port = 587;
            smtpc.UseDefaultCredentials = false;
            smtpc.EnableSsl = true;
            smtpc.Credentials = new NetworkCredential("assetsmanagementsystem@gmail.com", "ams1511har");
            smtpc.Send(email);
            //Response.Redirect("CHome.aspx");
        }



        var data = (from t in dc.PackageTypes select t).ToList();
        string str = "<div class='container clearfix'>";
        str += "<div class='content'>";
        str += "<div class='entry'>";
        str += "<div class='pricing_box'>";
        str += "<ul>";
        foreach (var item in data)
        {
            str += "<li class='price_col price_col_light_red' style='width: 227.5px;'>";
            str += "<div class='price_item'>";
            str += "<div class='price_col_head'>";
            str += "<strong>" +item.Packname + "</strong>";
            str += "<span class='price'>";
            str += "<em>$</em>" + item.Packamt + "</span>";

            string s = item.IsDisplay == true ? "Yes" : "No";
           // str += "<tr><td>" + item.Packname + "</td><td>" + item.Packamt + "</td><td> <img src='../Images/" + item.Packimg + "' height ='100px' width ='100px' /></td><td>" + item.Packdes + "</td></tr>";
            str += "</div>";

            str += "<div class='price_col_body'>";
            str += "<ul style='height: 203px;'>";
            //for (int i = 0; i < data.Count; i++)
            //{
                str += "<li>" + item.Packdes1;
                str += "<li>" + item.Packdes2;
                str += "<li>" + item.Packdes3;
                str += "<li>" + item.Packdes4;
                str += "</li>";
            //}
            str += "</ul>";
            str += "<div class='price_body_bot'>";
            str += "<strong>Best for:</strong>";
            str += item.Packbest;
            str += "</div>";
            str += "</div>";
            str += "<div class='price_col_foot'>";
            str += "<a href='#' hidefocus='true' style='outline: medium none;'>";
            str += "<a href='PackagesLists.aspx?Id="+item.Packtid+"'> Select <strong> Pack</strong></a>";
            str += "</a>";
            str += "</div>";
            str += "</div>";
            str += "</li>";
        }
        str += "</ul>";
        str += "</div>";
        str += "</div>";
        str += "</div>";
        str += "</div>";
        dis.InnerHtml = str;
    }
}
