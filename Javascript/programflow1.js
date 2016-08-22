var event = document.getElementById("button1").addEventListener('click', output, false);

function output() 
{
    
    var inputOne = parseInt(document.getElementById("input1").value);
    var inputTwo = parseInt(document.getElementById("input2").value);
    var inputThree = parseInt(document.getElementById("input3").value);
    
    var result = addNumbers(inputOne, inputTwo, inputThree);
    document.getElementById("result1").innerHTML = result;
    
} 

function addNumbers (x, y, z) {
    var sum = x + y + z;
    return sum
}