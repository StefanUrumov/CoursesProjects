    function onButtonClick(event, arguments) {

        var myTab = window;
        var browserName = myTab.navigator.appCodeName;
        
        var isMozzilla = (browserName == "Mozilla");
        if (isMozzilla) {
            alert("Yes");
        }
        else {
            alert("No");
        }
    }