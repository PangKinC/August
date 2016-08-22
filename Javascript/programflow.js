var event1 = document.getElementById("button1"); 
event1.addEventListener('click', inputOutput, false);

function inputOutput(){
    //Exercise 1
    /*var output = document.getElementById("input1").value;
    window.prompt(output);*/
    
    // Exercise 2
    /*var inputOne = parseInt(document.getElementById("input1").value);
    var inputTwo = parseInt(document.getElementById("input2").value);
    var inputThree = parseInt(document.getElementById("input3").value);

    var output = addThree(inputOne, inputTwo, inputThree);
    document.getElementById("result").innerHTML = output;*/
    
    // Exercise 3
    /*var sameNumber = 21;
    var outputOne = document.getElementById("result1").innerHTML = sameNumber;
    var outputTwo = document.getElementById("result2").innerHTML = retSameVar();*/
    
    //getDateTime();
    //forLoop();
    //whileLoop();
    //doWhileLoop();
    //nestedLoop();
    
}

function retSameVar(){
    sameNumber = 12;
    return sameNumber;
}

function addThree(x, y, z) {
    return x + y +z;
}

function myForLoop() {
    
    var stringOutput = "";
    
    for (i=1; i < 50; i++) {
        stringOutput += i + "<br>";
        document.getElementById("result1").innerHTML = stringOutput;    
    }
}

function getDateTime() {
    var day = "";
    var matchDate = new Date();
    
    switch (matchDate.getDay()){
    
        case 0: 
            day = "It's Sunday";
            break;
        case 1:
            day = "It's Monday";
            break;
        case 2:
            day = "It's Tuesday";
            break;
        case 3:
            day = "It's Wednesday";
            break;
        case 4:
            day = "It's Thursday";
            break;
        case 5:
            day = "It's Friday";
            break;
        case 6:
            day = "It's Saturday";
            break;
        default:
            day = "That's not a day"
            break;
    }
    
    var hours = matchDate.getHours();
    var minutes = matchDate.getMinutes();
    var time = hours + ":" + minutes;
    
    var output = document.getElementById("result1").innerHTML = day + " and the time is: " + time + ".";
        
}

function whileLoop (){
    var count = 0;    
    var stringOutput = "";
    
    while (count < 10) { 
        stringOutput += (count + 1) + "<br>";   
        count++;        
    }
   
    document.getElementById("result1").innerHTML = stringOutput;  
}

function doWhileLoop() {  
    var count = 0;    
    var stringOutput = "";
    
    do {
        stringOutput += (count + 1) + "<br>";   
        count++;        
    } while (count < 10);
   
    document.getElementById("result1").innerHTML = stringOutput;   
        
}

function nestedLoop() {
    
    var count = 0;    
    var output = "";
    
    while (count < 10) {      
        
        output += "Outer loop number: " + (count + 1) + "<br>";   
        count++;
        
        // &nbsp; = Non-breaking spaces    
        for (i=0; i < 10; i++) {
          output += "&nbsp; &nbsp; Inner loop number: " + (i + 1) + "<br>";
        }
                          
    }
   
    document.getElementById("result1").innerHTML = output;  
    
}


