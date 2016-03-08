$(function (){

	var $orders = $('#orders');
	var $CompanyName = $('#CompanyName');
	var $CompanyId = $('#CompanyId');
	var $OrderId = $('#OrderId');
	var $PriorityNumber = $('#PriorityNumber');
	var $DateCreated = $('#DateCreated');
	var $Deadline = $('#Deadline');
	var $ContactPerson = $('#ContactPerson');
	var $Description = $('#Description');
	var url2 = 'https://morilddata.azurewebsites.net/_api/database/orders/';

	function addOrder(data) {
		var tr; 
		    tr = $('<tr/>');
            tr.append("<td>" + data.CompanyName + "</td>");
            tr.append("<td>" + data.CompanyId + "</td>");
            tr.append("<td>" + data.OrderId + "</td>");
            tr.append("<td>" + data.PriorityNumber + "</td>");
            tr.append("<td>" + data.DateCreated.Date + "</td>");
            tr.append("<td>" + data.Deadline.Date + "</td>");
            tr.append("<td>" + data.ContactPerson + "</td>");
            $('table').append(tr);
	}

	$('#getOrder').on('click', function(){

			var order = {
				OrderId: $OrderId.val(), 
				
			};

	$.ajax({
		type: 'GET',
		url: url2 + order.OrderId,  
		success: function(json){
			$.get(url2 + order.OrderId, function(data){
				addOrder(data); 
			});
		},
		error:function(){
			alert('error loading');
		}
	});
	});
});
   