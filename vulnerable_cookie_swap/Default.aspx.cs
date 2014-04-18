
using System;
using System.Web;
using System.Web.UI;
using System.Web.Security;

namespace vulnerable_cookie_swap
{

	public partial class Default : System.Web.UI.Page
	{
		protected override void OnLoad (EventArgs e)
		{
			if (this.User.Identity.IsAuthenticated) {
				if (this.User.Identity.Name == "admin") {
					Response.Write ("Hey admin, what's up?<br />");
					Response.Write ("<a href=\"AdminPassword.aspx\">See my password</a><br />");
					Response.Write ("<a href=\"Logout.aspx\">Logout</a>");

					username.Visible = false;
					password.Visible = false;
					button1.Visible = false;
				} else {
					Response.Write ("Hey username, it is " + DateTime.Now.ToString () + "<br />");
					Response.Write ("<a href=\"Logout.aspx\">Logout</a>");

					username.Visible = false;
					password.Visible = false;
					button1.Visible = false;
				}
			}
		}
		public void button1Clicked (object sender, EventArgs args)
		{
			if (username.Text == "admin" && password.Text == "abc123") {
				FormsAuthentication.RedirectFromLoginPage ("admin", false);
			} else if (username.Text == "username" && password.Text == "password") {

				FormsAuthentication.RedirectFromLoginPage ("username", false);
			}
		}
	}
}

