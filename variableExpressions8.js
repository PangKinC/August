var event1 = document.getElementById("button1"); 
event1.addEventListener('click', myFirst, false);

function myFirst() 
{
    var result1 = (parseInt(document.getElementById("input1").value) 
                        + parseInt(document.getElementById("input2").value)) 
                        * parseInt(document.getElementById("input3").value);
    var result2 = parseInt(document.getElementById("input1").value) 
                        + parseInt(document.getElementById("input2").value)
                        + parseInt(document.getElementById("input3").value);


    document.getElementById("demo").innerHTML = userInput1;
    document.getElementById("demo2").innerHTML = userInput2;
        
}