
(function startup() {

    //var ele = $("#userName");
    //ele.text("Mohamed Sharif");


    //var main = $("#main");
    
    //main.on("mouseenter", function () {
    //    main.style ="background-color: #888"
    //});

    //main.on("mouseleave", function () {
    //    main.style = "";
    //});
    console.log("")
    var $SidebarAndWrapper = $("#sidebar,#wrapper");
    
    $("#sidebarToggle").on("click", function () {
        console.log("this button works")
        $SidebarAndWrapper.toggleClass("hide-sidebar")

        if ($SidebarAndWrapper.hasClass("hide-sidebar")) {
            $(this).text("Show Sidebar")
        } else {
            $(this).text("Hide Sidebar")
        }
    });

})();

