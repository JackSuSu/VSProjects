<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
    <script src="../../Scripts/jquery-1.8.2.js"></script>
    <style type="text/css">

        .CssName {
        
            background:red;

        }

    </style>

    <script type="text/javascript">

        $(function () {
            
            $("a:contains('删除')").click(function () {

                return confirm("请确认是否删除此用户？");

            });

        });

    </script>



</head>
<body>
    <div>
        <%
            
            System.Data.DataTable dt = ViewData["dt"] as System.Data.DataTable;
            
             %>


        <table border="1">

            <tr>
                <th>编号</th><th>用户名</th><th>别称</th><th>删除</th><th>编辑</th>
            </tr>

            <% foreach (System.Data.DataRow item in dt.Rows)
               {%>
                   
            <tr>
                <td><%: item["Uid"] %></td>
                <td><%: item["Uname"] %></td>
                <td><%: item["UPwd"] %></td>

                <td><%:Html.ActionLink("删除", "Delete", "UserInfo", new { Id = item["Uid"] }, new { })%></td>

                <td><%: Html.ActionLink("编辑","Edit","UserInfo",new{Id=item["Uid"]},new{}) %></td>

            </tr>
                   
                   
               <%} %>


            

        </table>


        <a href="<%: Url.Action("Add","UserInfo") %>">添加用户(URL.Action)</a>

        <br />

     <%: Html.ActionLink("htmlActionLink添加用户", "Add", "UserInfo", new { name = "sulongfeng" }, new { @class="CssName"})%>


        <%: Html.ActionLink("添加用户","Add","UserInfo",new {name="sulongdan"},new{ @class="CssName"}) %>


        <%:Html.TextBox("username","1234",new{@class="CssName"}) %>

        <%:Html.CheckBox("男",true,new{@class="CssName"}) %>

     

    </div>
</body>
</html>
