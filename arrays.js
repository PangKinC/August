var outputString = "";

//var inputArray = [];
/*var pokemonList = ["Bulbasaur", "Ivysaur", "Venusaur",
                    "Charmander", "Charmeleon", "Charizard",
                    "Squirtle", "Wartortle", "Blastoise", "Pikachu"];*/
var arrayList = ["Orange", "Apple", "Lemon"];

/*var countriesList = ["England", "France", "Italy", "Mexico", "Greece", 
                     "Poland", "Russia", "China", "Egypt", "India"];*/

printArray();

//var event1 = document.getElementById("button1").addEventListener('click', inputOutput, false);

var event1 = document.getElementById("button1").addEventListener('click', addToArray, false);
var event2 = document.getElementById("button2").addEventListener('click', removeFromArray, false);



function inputOutput() {
 
    //getInputArray();
    //pushingToArray();
    //showPokemon();
    //countryMatch();
    
}

function getInputArray() {
    
    inputArray[0] = document.getElementById("input1").value;
    inputArray[1] = document.getElementById("input2").value;
    inputArray[2] = document.getElementById("input3").value;

    printArray();
}

function pushingToArray() {
    
    inputArray.push(parseInt(document.getElementById("input1").value));
    inputArray.push(parseInt(document.getElementById("input2").value));
    inputArray.push(parseInt(document.getElementById("input3").value));
   
    printArray();
    document.getElementById("result2").innerHTML = inputArray.length;    
    
}

function addToArray() {
    
    arrayList.unshift(document.getElementById("input1").value);
    arrayList.push(document.getElementById("input2").value);
    
    printArray();
    document.getElementById("result2").innerHTML = "The Array is now " + arrayList.length + " items long.";
    document.getElementById("result3").innerHTML = "";
    document.getElementById("input3").value = arrayList.length;
    
}

function removeFromArray() {
    
    var shifted = arrayList.shift(document.getElementById("input1").value);
    var popped = arrayList.pop(document.getElementById("input2").value);
    
    printArray();
    document.getElementById("result2").innerHTML = "The Array is now " + arrayList.length + " items long.";
    document.getElementById("result3").innerHTML = "Removed " + shifted + " from the start of array, and " + popped + " from the end.";
    document.getElementById("input3").value = arrayList.length;
      
}

function addSplice() {
    
    var newElement = document.getElementById("input1").value;
    var addPos = parseInt((document.getElementById("input2").value) -1);
    
    if ((addPos >= 0) && (addPos <= arrayList.length)){
        arrayList.splice(addPos, 0, newElement);
    }
    else {
        alert("Please enter number that is equal or greater then 1, but less then " + arrayList.length + ".");
    }
        
    printArray();
    document.getElementById("result2").innerHTML = "The Array is now " + arrayList.length + " items long.";
    document.getElementById("result3").innerHTML = newElement + " was added at position " + (addPos +1) + " in the array.";
    
}

function removeSplice() {
    
    var removePos = parseInt((document.getElementById("input3").value) -1);
    outputString = "";
     
    if ((removePos >= 0) && (removePos <= arrayList.length)){
        arrayList.splice(removePos, 1);
    }
    else {
        alert("Please enter number that is equal or greater then 1, but less then " + arrayList.length + ".");
    }
        
    printArray();
    document.getElementById("result2").innerHTML = "The Array is now " + arrayList.length + " items long.";
    document.getElementById("result3").innerHTML = "Item at position: " + (removePos +1) + " was removed from the array.";

}

function showPokemon() {
    
    for (var i = 0; i < pokemonList.length; i++) {
        outputString += pokemonList[i] + " | ";
    }
        
    document.getElementById("showArray").innerHTML = outputString;    
}

function countryMatch() {
    
    var searchArray = document.getElementById("input1").value;
    var countriesResult = countriesList.indexOf(searchArray);
    
    if (countriesResult >= 0){
        document.getElementById("result1").innerHTML = "The country " + searchArray + " was found at position: " + countriesResult + " in the array."
    }
    else {
        document.getElementById("result1").innerHTML = "The country " + searchArray + " could not be found inside the array."
    }
    
}


function printArray() {
    
    outputString = "";
    
    /*for (var i = 0; i < inputArray.length; i++) {
        outputString += inputArray[i] + " | ";   
    }

    document.getElementById("result1").innerHTML = outputString;*/
    
    for (var i = 0; i < arrayList.length; i++) {
        outputString += arrayList[i] + " ";
    }
    
    document.getElementById("result1").innerHTML = outputString;
    
    /*for (var i = 0; i < arrayList.length; i++) {
        outputString += arrayList[i] + " | ";
    }
    
    document.getElementById("input4").value = outputString;
    document.getElementById("result1").innerHTML = outputString;*/
    
}