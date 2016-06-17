<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<% var name = new string[]{"Jack", "Tom", "Rose"};%>
<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>AspxView</title>
</head>
<body>
        <h1>列出 <% = name.Length %> 个名字。</h1>
        <ul>
            <%foreach (var item in name) { %>
                <li>这个名字是：<% = item %></li>
            <% } %>
        </ul>
</body>
</html>
