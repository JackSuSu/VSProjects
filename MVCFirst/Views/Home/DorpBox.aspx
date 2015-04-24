<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<%@ Import Namespace="MVCFirst.Models" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>DorpBox</title>
</head>
<body>
    <div>

        <%: Html.DropDownList("city") %>

        
        <%:Html.TextBox("Demo") %>

        <%:Html.Label("Demo") %>

        <%:Html.RadioButton("gender","1",false) %>
        女
         <%:Html.RadioButton("gender","2",true) %>
        男
        
     



    </div>
</body>
</html>
