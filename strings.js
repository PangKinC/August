//document.getElementById("error").innerHTML = "";

//var outputString = "";

var event1 = document.getElementById("button1").addEventListener('click', buttonOutput, false);
//var event1 = document.getElementById("button1").addEventListener('click', cutString, false);
//var event2 = document.getElementById("button2").addEventListener('click', resetString, false );

function buttonOutput() {
        
    //diffOutput();
    searchString();
    //displayString();
    //addToString();
    //replaceString();
    //replaceLetter();
    //roundNumber();
    //roundDecimal();
    
}

function roundDecimal() {
    
    var numInput = document.getElementById("input1").value;
    var decInput = document.getElementById("input2").value;

    if ((numInput != "") && (decInput != "")) {   
        
        var getNum = parseFloat(numInput);
        var getDec = parseInt(decInput);
        var newNum = Number(Math.round(getNum + 'e' + getDec) + 'e-' + getDec);
    
        document.getElementById("result1").innerHTML = "The value: " + getNum + " rounded by " + getDec + " decimal places would equal: " + newNum + ".";
          
    }
    
    else if ((numInput != "") || (decInput != "")) {
        document.getElementById("result1").innerHTML = "Please enter a value into both fields."
    }
    
    else {  
        document.getElementById("result1").innerHTML = "Please enter some values."
    }
    
}

function roundNumber() {
    
    var getNum = parseFloat(document.getElementById("input1").value);
    
    var roundNum = Math.round(getNum);
    var ceilNum = Math.ceil(getNum);
    var floorNum = Math.floor(getNum);
    
    document.getElementById("result1").innerHTML = "The value: " + getNum + " rounded to the nearest integer would equal: " + roundNum + ".";
    document.getElementById("result2").innerHTML = "The value: " + getNum + " rounded up to the nearest integer would equal: " + ceilNum + ".";
    document.getElementById("result3").innerHTML = "The value: " + getNum + " rounded down to the nearest integer would equal: " + floorNum + ".";
    
}

function replaceLetter() {
    
    var getString = document.getElementById("input1").value;
    var getChar = document.getElementById("input2").value;
    var newChar = document.getElementById("input3").value;
    
    var stringArray = getString.split("");
    
    for (i = 0; i < stringArray.length; i++) {
        if ((stringArray[i] === getChar) && (getString != "")){
             stringArray[i] = newChar;
        }         
    }
    
    var displayString = stringArray.join("");
    document.getElementById("result1").innerHTML = "String has been changed, it is now: " 
    document.getElementById("result2").innerHTML = displayString + ".";
 
}

function replaceString() {
    
    var getString = document.getElementById("input1").value;
    var replaceString = document.getElementById("input2").value;
    var newString = document.getElementById("input3").value;
    
    var displayString = getString.replace(replaceString, newString);
    document.getElementById("result1").innerHTML = "String has been changed, it is now: " 
    document.getElementById("result2").innerHTML = displayString + ".";

}

function addToString() {
    
    var getString = document.getElementById("input1").value;
    var getChar = document.getElementById("input2").value;
    var getPos = parseInt(document.getElementById("input3").value);
    
    var stringArray = getString.split("");
    stringArray[getPos - 1] = getChar;
    
    var rejoinedString = stringArray.join("");
    document.getElementById("result1").innerHTML = "Your string is now: " + rejoinedString + ".";
    
}

function displayString() {

    var getString = document.getElementById("input1").value;
    
    for (i = 0; i < getString.length; i++){
        outputString += getString.charAt(i) + "<br/>";   
    }
    
    document.getElementById("stringoutput").innerHTML = outputString;

}

function searchString() {
    
    var getSentence = document.getElementById("input1").value;
    var getString = document.getElementById("input2").value;
    
    var sentenceArray = getSentence.split();
    var stringArray = getString.split();
    
    var index = 0;
    
    //index = getSentence.indexOf(getString);
    index = getSentence.lastIndexOf(getString);
    
    if ((index >= 0) && (getString != "")){
        //document.getElementById("result1").innerHTML = getString + " found in the sentence, is at position: " + (index + 1) + ".";
        document.getElementById("result1").innerHTML = "Last occurence of " + getString + " found in the sentence at position: " + (index + 1) + ".";
    }
    else {
        if (getString != "") {
            document.getElementById("result1").innerHTML = getString + " was not found in the sentence.";
        }
    }
    
}

function diffOutput() {
    
    var getInput = document.getElementById("input1").value;
    document.getElementById("input2").value = getInput;
    document.getElementById("input3").value = getInput.toUpperCase();
    document.getElementById("input4").value = getInput.toLowerCase();
        
}

function cutString() {
    
    var stringInput = document.getElementById("input1").value;
    var numberInput = parseInt(document.getElementById("input2").value);
    
    var stringChar = stringInput.split("");
    
    if ((numberInput >= 0) && (numberInput <= stringChar.length)) {
    
        document.getElementById("error").innerHTML = "";
        var charIndex = stringChar.slice(numberInput -1, numberInput);
        var remainString = stringChar.slice(numberInput);
        var joinedString = remainString.join("");
        
        document.getElementById("stringinput").innerHTML = stringInput;
        document.getElementById("numberinput").innerHTML = charIndex;
        document.getElementById("leftover").innerHTML = joinedString;
            
    }
    
    else {
        
        document.getElementById("error").innerHTML = "There is no character at that specified position, try again.";
        
    }
    
}

function resetString() {
    
    document.getElementById("input1").value = "";
    document.getElementById("input2").value = "";
    document.getElementById("stringinput").innerHTML = "";
    document.getElementById("numberinput").innerHTML = "";
    document.getElementById("leftover").innerHTML = "";
    
}