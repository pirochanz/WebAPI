$(function () {

    $("#comDelete").click(function () {
        var ret = confirm("削除してもよろしいですか？");
        if (!ret) {
            return false;
        }
    });

})