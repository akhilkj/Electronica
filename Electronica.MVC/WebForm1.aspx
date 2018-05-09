<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Electronica.MVC.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.0.0.slim.js"></script>
    <script src="~/Scripts/jquery-3.0.0.min.js"></script>
    <link rel="stylesheet" type="text/css" href="//cdn.datatables.net/1.10.10/css/jquery.dataTables.min.css"/>  
<script src="//cdn.datatables.net/1.10.10/js/jquery.dataTables.min.js"></script> 
    <script  type="text/javascript" >

        $(document).ready(function () {
            $.ajax({
                url: 'EventWebService.asmx/GetEvents',
                method: 'post',
                datatype: 'json',
                success: function (data) {
                    console.log(data);
                    $("#dataTable").dataTable({
                        data: data,
                        columns: [
                            { 'data': 'Event ID' },
                            { 'data': 'Event Name' },
                            { 'data': 'Start Date' }
                        ]
                    });
                }

            });
        });

    </script>

</head>
<body style="font-family:Arial">
    <form id="form1" runat="server">
        <table id="dataTable">
            <thead>
                <tr>
                <th>Event ID</th>
                <th>Event Name</th>
                <th>Start Date</th>
                </tr>
            </thead>
        </table>
        
    </form>
</body>
</html>
