var event1 = document.getElementById("button1"); 
event1.addEventListener('click', inputOutput, false);

var inputArray = [];

function inputOutput() {
 
    getInputArray();
    
}

function getInputArray() {
    
    inputArray[0] = document.getElementById.("input1").value;
    inputArray[1] = document.getElementById.("input2").value;
    inputArray[2] = doucment.getElementById.("input3").value;
    var output = "";
    
    for (var i = 0; i < inputArray.length; i++) {
        output += inputArray[i] + " ";
    }
    
    document.getElementById("result").innerHTML = output;
}

