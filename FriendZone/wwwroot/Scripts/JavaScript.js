var friendsId = 1;

$(document).ready(function () {
	$("#findFriend").click(function () {
		//var friendsId = $("#friendsId").val();
		
		$.ajax({
			url: "/Friends/DisplayInfoHTML/",
			type: "GET",
			data: { "id": friendsId },
			success: function (result) {
				//console.log(result);
				//var s = "<p style='color:red;'>" + result.firstName + "</p>";
				//$("#friendsInfo").html(s);
				$("#friendsInfo").html(result);
				console.log(result);
				friendsId++;
				//funkar det?
			}
		});
	});
});


