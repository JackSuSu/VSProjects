<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>用户注册</title>
</head>
<body>
    <div>

        <form method="post">

        <table>

            <tr>
                <td>用户名</td><td><input type="text" name="username" /></td>
            </tr>

            <tr>
                <td>密码</td><td><input type="password" name="pwd" /></td>
            </tr>

            <tr><td colspan="2"><input type="submit" value="注册用户"  /></td></tr>

        </table>

            </form>
    </div>
</body>
</html>
