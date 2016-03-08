$(document).ready(function () {

    var url = "https://morilddata.azurewebsites.net/_api/database/orders"

    $.getJSON(url,
    function (json) {
        var tr;
        for (var i = 0; i < json.length; i++) {
            tr = $('<tr/>');
            tr.append("<td>" + json[i].CompanyName + "</td>");
            tr.append("<td>" + json[i].CompanyId + "</td>");
            tr.append("<td>" + json[i].OrderId + "</td>");
            tr.append("<td>" + json[i].PriorityNumber + "</td>");
            tr.append("<td>" + json[i].DateCreated + "</td>");
            tr.append("<td>" + json[i].Deadline + "</td>");
            tr.append("<td>" + json[i].ContactPerson + "</td>");
            $('table').append(tr);
        }
    });
});