var event1 = document.getElementById("button1"); 
event1.addEventListener('click', myFirst, false);

function myFirst() 
{
    var userInput1 = parseInt(document.getElementById("input1").value) + 1;
    var userInput2 = parseInt(document.getElementById("input1").value) - 1;


    document.getElementById("demo").innerHTML = userInput1;
    document.getElementById("demo2").innerHTML = userInput2;
        
}