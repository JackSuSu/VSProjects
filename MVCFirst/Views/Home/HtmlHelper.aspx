<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>HtmlHelper</title>
</head>
<body>
    <div>
        <h1>网站首页</h1>

        <a href="<%: Url.Action("Index","UserInfo") %>">用户列表你页面</a>


        


    </div>
</body>
</html>
