var event1 = document.getElementById("button1"); 
event1.addEventListener('click', inputOutput, false);

var randomNum = Math.floor((Math.random() * 100) +1);
document.getElementById("input2").value = randomNum;

var input = "";
var count = 0;

function inputOutput() {

    checkNumber();
    
}

function checkNumber() {
    
    input = document.getElementById("input1").value;
    count++;
    
    if (input == randomNum) {
        document.getElementById("result1").innerHTML = randomNum;
        document.getElementById("result2").innerHTML = "Number of guesses: " + count;
        document.getElementById("result3").innerHTML = "Well done! - Guess was correct!";
    }
    
    else if (input > randomNum) {
        document.getElementById("result1").innerHTML = "The number is smaller then your guess.";
        document.getElementById("input3").value = count;
    }
    
    else {
        document.getElementById("result1").innerHTML = "The number is bigger then your guess.";
        document.getElementById("input3").value = count;
    }
            
}