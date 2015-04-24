<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>HtmlEncodeDemos</title>
</head>
<body>
    <div>

          <p>冒号是将标签转义后到前台</p>

        <%: ViewData["StrScript"] %>

         <p>等号是原封不等的输出到前台</p>

        <%=ViewData["StrScript"] %>




        <%: Html.Raw("<p>html Helper Raw 的使用P标签输出</p>") %>


        <%: Html.Raw(ViewData["StrScript"]) %>


         <p>HtmlString 也是 等号是原封不等的输出到前台</p>

        <%:new HtmlString(ViewData["StrScript"].ToString()) %>

         <p>MVCHtmlString 也是 等号是原封不等的输出到前台</p>
        <%:new MvcHtmlString(ViewData["StrScript"].ToString()) %>



       

      

    </div>
</body>
</html>
