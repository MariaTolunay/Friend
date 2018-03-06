$(document).ready(function () {
	$("#findFriend").click(function () {
		var friendsId = $("#friendsId").val();
		$.ajax({
			url: "/Friends/Info/",
			type: "GET",
			data: { "id": friendsInfo },
			success: function (result) {
				$("#friendsInfo").html(result);
			}
		});
	});
});


