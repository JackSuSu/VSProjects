<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCFirst.Models.UserInfo>" %>

<%@ Import Namespace="MVCFirst.Models" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Show</title>
</head>
<body>
    <div>


        <h3>ViewData 传值转换</h3>
        
        <% UserInfo User = ViewData["userinfo"] as UserInfo; %>


        <%if (User != null) { %>
        
        <table>

            <tr><td>ID</td><td><%: User.UId %></td></tr>

            <tr><td>用户名</td><td><%: User.UName %></td></tr>

            <tr><td>密码</td><td><%: User.UPwd %></td></tr>

            <tr><td>所属组</td><td><%: User.UGid %></td></tr>

        </table>


        <%: Html.TextBoxFor(u=>u.UName) %>

        
        <%}%>

        <p>TextBoxFor 当前Model的实体类</p>


        <h3>Model 强类型视图</h3>

         <table>

            <tr><td>ID</td><td><%: Model.UId %></td></tr>

            <tr><td>用户名</td><td><%: Model.UName %></td></tr>

            <tr><td>密码</td><td><%: Model.UPwd %></td></tr>

            <tr><td>所属组</td><td><%: Model.UGid %></td></tr>

           

        </table>


        <%--<%: MyHtmlHelperExt.MyLabel("我是好人") %>--%>

     
        
    </div>
</body>
</html>
