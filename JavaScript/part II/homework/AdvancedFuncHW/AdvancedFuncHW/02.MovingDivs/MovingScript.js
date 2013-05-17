function addDivToCircle(){
    var circle = document.getElementById('circle');

    style = circle.style;

    style.border = 1 + "px solid black"
    style.width = '250px';
    style.height = 250 + 'px';
    style.borderRadius = 175 + 'px';
    style.marginTop = 100 + 'px';
    style.marginLeft = 100 + 'px';

    (function createDiv() {
        var movableDiv = document.createElement('div');
        var textNode = document.createTextNode("Div");
        var divStyle = movableDiv.style;
        
        movableDiv.appendChild(textNode);
        circle.appendChild(movableDiv);        
        divStyle.border = 1 + "px solid black"
        divStyle.width = '50px';
        divStyle.height = 50 + 'px';
        divStyle.borderRadius = 35 + 'px';
        divStyle.marginTop = 10 + 'px';
        divStyle.marginLeft = 10 + 'px';

        //set background color
        var a = Math.floor((Math.random() * 255) + 1);
        var b = Math.floor((Math.random() * 255) + 1);
        var c = Math.floor((Math.random() * 255) + 1);

        divStyle.backgroundColor = 'rgb(' + a + ',' + b + ',' + c + ')';

        (function moveDiv() {
            var left = 0;//parseInt(centerTop + maximumSemiaxis * Math.sin(theta));                       
            var top = 0;//parseInt(centerTop - minorSemiaxis * Math.cos(theta));
            var i = 0;

            //for (i = 0; i < 360; i++) {
            //    left++;
            //    top++;
            //    divStyle.left = left + i + "px";
            //    divStyle.top = top + i + "px";
            //}
            left += 5;
            top += 5;

            divStyle.left = left + i + "px";
            divStyle.top = top + i + "px";
            

            //setInterval(function () { moveDiv() }, 1000);
        })();
    }());
}



function addDivToRectangle() {
    var rectangle = document.getElementById('rectangle');
    var movableDiv = document.createElement('div');
    var textNode = document.createTextNode("Div");
    var divStyle = movableDiv.style;    
    
    styleRec = rectangle.style;
    styleRec.display = 'inline-block';
    styleRec.position = 'absolute';
    styleRec.border = 1 + "px solid black"
    styleRec.width = '250px';
    styleRec.height = 250 + 'px';
    styleRec.marginTop = 100 + 'px';
    styleRec.marginLeft = 100 + 'px';
    movableDiv.appendChild(textNode);
    rectangle.appendChild(movableDiv);
    divStyle.border = 1 + "px solid black"
    divStyle.width = '50px';
    divStyle.height = 50 + 'px';
    divStyle.borderRadius = 35 + 'px';
    divStyle.marginTop = -20 + 'px';
    divStyle.marginLeft = -20 + 'px';

    //set background color
    var a = Math.floor((Math.random() * 255) + 1);
    var b = Math.floor((Math.random() * 255) + 1);
    var c = Math.floor((Math.random() * 255) + 1);

    divStyle.backgroundColor = 'rgb(' + a + ',' + b + ',' + c + ')';

    function moveDiv() {
        var topInRange = top >= 180 && top <= 445;
        var leftInRange = left >= -100 && left <= 545;
        var top = 100;
        var left = -180;

        if (!topInRange || !leftInRange) {
            degreeToMove = 5;
            top = 180;
            left = -100;
            style.top = 180 + 'px';
            style.left = -100 + 'px';
        }

        degreeToMove = degreeToMove + 5;
        top = top + degreeToMove;
        left = left + degreeToMove;

        divStyle.top = top - degreeToMove + 'px';
        divStyle.left = left + degreeToMove + 'px';

    };
    setInterval(function () { moveDiv() }, 1000);
}        