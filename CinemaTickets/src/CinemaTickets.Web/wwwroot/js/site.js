
$(function () {
    //script for modal window for display movie trailer
    $("#trailer-modal").on("show.bs.modal",
        function() {
            var src = $("#videowrapper").attr("src");

            var index = src.indexOf("?");

            src = src.substring(0, index);

            src += "?autoplay=1";

            $("#videowrapper").attr("src", src);
        });
    $("#trailer-modal").on("hide.bs.modal",
        function() {
            var src = $("#videowrapper").attr("src");

            var index = src.indexOf("?");

            src = src.substring(0, index + 1);

            $("#videowrapper").attr("src", "");

            $("#videowrapper").attr("src", src);
        });
});
