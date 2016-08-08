// Variables and expressions - ex3 - take user input and display it on the page

var event1 = document.getElementById("button1"); 
event1.addEventListener('click', myFirst, false);

function myFirst() 
{
    var userInput1 = parseInt(document.getElementById("input1").value);
    var userInput2 = parseInt(document.getElementById("input2").value);
    
    if (userInput1 > userInput2) {
        document.getElementById("demo").innerHTML = userInput1  
    }
    else {
        document.getElementById("demo").innerHTML = userInput2 
    }
    
}
