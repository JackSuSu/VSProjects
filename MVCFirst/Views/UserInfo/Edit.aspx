<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCFirst.Models.UserInfo>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Edit</title>
</head>
<body>
    <div>


      <% using(Html.BeginForm())
         {%>
                 

        <table>

            <tr><td>用户编号</td><td><%:Model.UId %><%:Html.HiddenFor(u=>u.UId) %></td></tr>

            <tr><td>用户名</td><td><%:Html.TextBoxFor(u=>u.UName) %></td></tr>

            <tr><td>密码</td><td><%: Html.TextBoxFor(u=>u.UPwd) %></td></tr>

              <tr><td>密码</td><td><%: Html.TextBoxFor(u=>u.UGid) %></td></tr>

            <tr><td colspan="2"><input type="submit" /></td><td></td></tr>

          <%--  <tr><td>用户编号</td><td><%:Html.TextBoxFor(u=>u.UGid) %></td></tr>--%>
        </table>


          <%} %>

        
    </div>
</body>
</html>
