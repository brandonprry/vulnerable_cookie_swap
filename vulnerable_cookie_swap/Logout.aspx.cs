using System.Web.Security;


namespace vulnerable_cookie_swap
{
	using System;
	using System.Web;
	using System.Web.UI;

	public partial class Logout : System.Web.UI.Page
	{
		protected override void OnLoad (EventArgs e)
		{
			base.OnLoad (e);

			FormsAuthentication.SignOut ();
			Response.Redirect ("Default.aspx");
		}
	}
}

