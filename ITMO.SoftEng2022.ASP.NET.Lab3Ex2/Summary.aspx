<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summary.aspx.cs" Inherits="AspNet.Summary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml"> 
<head runat="server"> 
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/> 
<title>Участники семинара</title> 
<link rel="stylesheet" href="Styles.css" /> 
</head> 
<body> 
<form id="form1" runat="server"> 
<div> 
<h2>Приглашения</h2> 
<h3>Выступающие с докладом: </h3> 
<table> 
<thead> 
<tr> 
<th>Имя</th> 
<th>Email</th> 
<th>Телефон</th> 
</tr> 
</thead> 
<tbody> 

 </table> 
<h3>Участники без доклада: </h3> 
<table> 
<thead> 
<tr> 
<th>Имя</th> 
<th>Email</th> 
<th>Телефон</th> 
</tr> 
</thead>
<tbody> 
<%= GetNoShowHtml()%> 
</tbody> 
</table> 
</body></html>

</tbody> 
</table> 
</div> 
</form> 
</body> 
</html> 

