<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">

    <meta name="viewport" content="width=device-width" />

    <title>Index2</title>

</head>
<body>
    <div>
        <h3>Index2 页面</h3>
      
        <p><%: ViewData["Key1"] %></p>

    </div>
</body>
</html>
