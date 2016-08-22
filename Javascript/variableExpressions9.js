// Variables and expressions - ex3 - take user input and display it on the page

var event1 = document.getElementById("button1"); 
event1.addEventListener('click', myFirst, false);

function myFirst() 
{
    var userInput1 = parseInt(document.getElementById("input1").value);
    
    if (userInput1 < 1) {
        document.getElementById("demo").innerHTML = "That number is a negative";  
    }
    else if (userInput1 < 10) {
        document.getElementById("demo").innerHTML = "That number is less then 10."; 
    }
    else if (userInput1 > 10) {
        document.getElementById("demo").innerHTML = "That number is greater then 10.";
    }
    else if (userInput1 == 10) {
        document.getElementById("demo").innerHTML = "That is number 10.";
    }
    
}
