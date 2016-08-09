var event1 = document.getElementById("button1"); 
event1.addEventListener('click', inputOutput, false);


function inputOutput() {
    
    calculateInterest();
    
}

function calculateInterest(){
    
    var amount = parseInt(document.getElementById("input1").value);
    var rate = parseInt(document.getElementById("input2").value);
    var time = parseInt(document.getElementById("input3").value);
    
    var total = (amount * (rate / 100) * time).toFixed(2);
    var monthly = (total / (time * 12)).toFixed(2);
    
    document.getElementById("result1").innerHTML = "The total amount of interest you will pay is: £" + total + ".";
    document.getElementById("result2").innerHTML = "Monthly payments will total: £" + monthly +".";
    
}
