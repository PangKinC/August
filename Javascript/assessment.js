// Declares and instantiates button input on click
var event1 = document.getElementById("button1").addEventListener('click', calculateTax, false);

// Declaring some variables and initialising with empty values
// var allowance is set a static 11000, to represent £11,000
var getInput = "";

var allowance = 0;
var twenty = 0;
var forty = 0;
var fortyFive = 0;

var grossSalary = 0;
var salaryNet = 0;

var taxTwenty = 0;
var taxForty = 0;
var taxFortyFive = 0;

var maxGross = 0;
var calcAllowance = 0;
var newAllowance = 0;

// function tax calculations starts here on button click
function calculateTax() 
{
    // Changes the getInput empty text to input typed by user in textbox
    getInput = document.getElementById("input").value;
    
    // This initial if statement is placed, just to check that the value inputted by the user is not empty or blank
    if (getInput != "")
    {        
        // This uses ParseInt to change the user input into a integer (number)
        grossSalary = parseInt(getInput);
        allowance = parseInt(getInput);
        
        // This if statement is needed to limited the personal allowance to 11000 max
        if (allowance >= 11000) { allowance = 11000; }  
        
        // Always show the salary gross AKA value typed in by user on salarygross span defined in HTML
        document.getElementById("salarygross").innerHTML = "£" + grossSalary.toFixed(2);
    
        // First two conditional if statement takes priority, this checks if the gross salary was over 11000 but also less then 43000
        if ((grossSalary > allowance) && (grossSalary <= 43000)) {
            // If the statement is true, we set the variable twenty to the salary minus 11000 then multiplies by 0.2 (20%)    
            twenty = grossSalary - allowance;
            taxTwenty = twenty * 0.2;
            
            // We change the Salary to reflect its new total after tax
            salaryNet = grossSalary - taxTwenty;
        
            // This block of text is to change up the results which appears on the screen after the calculations are done.
            // Note that span forty field is still empty.
            document.getElementById("free").innerHTML = "£" + allowance.toFixed(2);
            document.getElementById("twenty").innerHTML = "£" + taxTwenty.toFixed(2); 
            document.getElementById("forty").innerHTML = "";
            document.getElementById("fortyfive").innerHTML = "";
            document.getElementById("salarynet").innerHTML = "£" + salaryNet.toFixed(2);
            document.getElementById("error").innerHTML = "";
        }
        
        // This else if block checks for whether the gross salary is over 150000.
        else if (grossSalary > 150000) {
            // This calls for the decreaseAllowance function (check below)
            decreaseAllowance();
    
            //Here forty is limited to 107000 because the band is at a higher tier at this point
            forty = 107000;
            taxForty = forty * 0.4;
            
            // We set these variables to values so that we can calculate the 45% tax
            fortyFive = grossSalary - forty - twenty;
            // Multiple by .45 to represent the 45% tax
            taxFortyFive = fortyFive * 0.45;
            
            // We change the Salary to reflect its new total after tax
            salaryNet = grossSalary - taxFortyFive - taxForty - taxTwenty;
            
            // We only change these two results because the others have been produced from decreaseAllowance function
            document.getElementById("forty").innerHTML = "£" + taxForty.toFixed(2);
            document.getElementById("fortyfive").innerHTML = "£" + taxFortyFive.toFixed(2);
            document.getElementById("salarynet").innerHTML = "£" + salaryNet.toFixed(2);  
            
        }
        
        else if (grossSalary > 100000) {
            // This calls the decreaseAllowance function to do some calculations
            decreaseAllowance();
        }
        
        // The else if statement checks if the userinput or salary was over 43000
        else if (grossSalary > 43000) { 
            // If the conditions was met we set twenty to a static value of 32000, as we dont want it increasing anymore then its multiplied by 20%
            twenty = 32000;
            taxTwenty = twenty * 0.2;
        
            // Here forty is the total value after the gross salary deducts 32000 and 11000 from its total, then multiplied by 40% for the tax (0.4)
            forty = grossSalary - twenty - allowance;
            taxForty = forty * 0.4;
        
            // We change the Salary to reflect its new total after tax
            salaryNet = grossSalary - taxForty - taxTwenty;
            
            // We need another block of coding to change up the results, in case the user reuses the calculatate tax button more then once
            // It updates all the fields accordingly to the calculations done
            document.getElementById("free").innerHTML = "£" + allowance.toFixed(2);
            document.getElementById("twenty").innerHTML = "£" + taxTwenty.toFixed(2); 
            document.getElementById("forty").innerHTML = "£" + taxForty.toFixed(2);
            document.getElementById("fortyfive").innerHTML = "";
            document.getElementById("salarynet").innerHTML = "£" + salaryNet.toFixed(2);
            document.getElementById("error").innerHTML = "";
        }
        // The else block here is to represent if the salary was less or equal to 11000
        else {
            // At this point the previous if statements didnt go through, so the gross and net salary would just be 11000
            // Again the other results would have to be updated incase the user decides to push the button more then once
            document.getElementById("free").innerHTML = "£" + allowance.toFixed(2); 
            document.getElementById("twenty").innerHTML = "";
            document.getElementById("forty").innerHTML = "";
            document.getElementById("fortyfive").innerHTML = "";
            document.getElementById("salarynet").innerHTML = "£" + allowance.toFixed(2);
            document.getElementById("error").innerHTML = "";
        }
    }
    
    else {
            // Finally we have one last code block to update all other results to blank if button was pushed more then once.
            // And since the if statement took condition of input not being blank, the error message reflects what it would display if input was blank
            document.getElementById("free").innerHTML = "";
            document.getElementById("twenty").innerHTML = "";
            document.getElementById("forty").innerHTML = "";
            document.getElementById("fortyfive").innerHTML = "";
            document.getElementById("salarynet").innerHTML = "";
        
            document.getElementById("error").style.fontSize = "x-large";
            document.getElementById("error").innerHTML = "<b>" + "Please enter your salary into the text box." + "</b>";
    }
}

// This function is called when you have to decrease the personal allowance after a gross salary exceeds 100000.
function decreaseAllowance() 
{
    // If the conditions was met we set twenty to a static value of 32000, as we dont want it increasing anymore then its multiplied by 20%
    twenty = 32000;
    taxTwenty = twenty * 0.2;
    
    // Here forty is the total value after the gross salary deducts 32000 and 11000 from its total, then multiplied by 40% for the tax (0.4)
    forty = grossSalary - twenty - allowance;
    taxForty = forty * 0.4;
    
    // We change the Salary to reflect its new total after tax
    salaryNet = grossSalary - taxForty - taxTwenty;
    
    // This is where the calculations for decreasing the personal allowance takes place
    // Simply put after exceed 100000, we have it set to maxGross so we can deduct 100000 from our gross salary
    // We then divide it by 2 to represent the by every £1 earned your personal allowance deducts £2
    // We then simply subtract what we now have from our calculations above from our current allowance to get our new allowance
    maxGross = 100000;
    calcAllowance = ((grossSalary - maxGross) / 2);
    newAllowance = allowance - calcAllowance;
    
    // This if and else statements dictates what is shown in the tax free text fields, we don't want value to be lower to 0.
    // This also still updates our salary and tax results but doesnt show the 45% tax, because that is done seperately in the above if statements block.
    if (newAllowance <= 0) {
        document.getElementById("free").innerHTML = "£0.00";
        document.getElementById("twenty").innerHTML = "£" + taxTwenty.toFixed(2); 
        document.getElementById("forty").innerHTML = "£" + taxForty.toFixed(2);
        document.getElementById("fortyfive").innerHTML = "";
        document.getElementById("salarynet").innerHTML = "£" + salaryNet.toFixed(2);  
        document.getElementById("error").innerHTML = "";  
    }
    
    else {
        document.getElementById("free").innerHTML = newAllowance.toFixed(2);
        document.getElementById("twenty").innerHTML = "£" + taxTwenty.toFixed(2); 
        document.getElementById("forty").innerHTML = "£" + taxForty.toFixed(2);
        document.getElementById("fortyfive").innerHTML = "";
        document.getElementById("salarynet").innerHTML = "£" + salaryNet.toFixed(2);  
        document.getElementById("error").innerHTML = "";  
    }   
}

