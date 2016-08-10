var entries = [];
var outputString = ""; 

var event1 = document.getElementById("button1").addEventListener('click', addEntry, false);
var event2 = document.getElementById("button2").addEventListener('click', generateWinner, false);
    

function addEntry() {
    
    newName = document.getElementById("input1").value;
    nameCheck = entries.indexOf(newName);
    outputString = "";
    
    if (nameCheck >= 0) {
        document.getElementById("result1").innerHTML = "Rejected, " + newName + " has already been entered into the competition.";   
    }
    
    else  {
        if (newName != "") {
            entries.push(newName);
            document.getElementById("result1").innerHTML = newName + " has been added to the competiton!";    
            printArray();
        }    
    }
            
}

function generateWinner() {
    

    if (entries.length > 0) {
        
        var randomName = entries[Math.floor(Math.random() * entries.length)];
        document.getElementById("result1").innerHTML = "The winner of this competition is " + randomName + ", Congratulations!";
        
    }

    else {
        
        document.getElementById("result1").innerHTML = "No entries have been entered into the competition yet!";
    }
            
}

function printArray() {
    
    for (i = 0; i < entries.length; i++) {
        outputString += entries[i] + " | ";       
    }
        
    document.getElementById("names").innerHTML = outputString;
}