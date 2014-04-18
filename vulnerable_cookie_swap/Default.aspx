<%@ Page Language="C#" Inherits="vulnerable_cookie_swap.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
		<asp:Label id="lblusername" runat="server" Text="Username:" />
		<asp:TextBox id="username" runat="server" />
		<br />
		<asp:Label id="lblpassword" runat="server" Text="Password:" /> <asp:TextBox id="password" runat="server" />
		<br />
		<asp:Button id="button1" runat="server" Text="Click me!" OnClick="button1Clicked" />
	</form>
</body>
</html>
