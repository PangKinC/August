/*var getName = { 
    firstname: "Kin", 
    surname: "Pang", 
    initials: "K.P",
    
    getFullName: function() { return this.firstname + " " + this.surname; }, 
    details: { nationality: "British", address: "29 Walpole Road" }      
};*/

function Room (company, subject, student) {
    this.company = company;
    this.subject = subject;
    this.student = student;    
    
    this.needComputers = function () {
        return student;
    }
}

var Room1 = new Room ('Willowfield Secondary School', 'Math', 50);
Room1.needComputers();

var event1 = document.getElementById("button1").addEventListener('click', inputOutput, false);


function inputOutput() {
    
    //window.prompt("Test");
    
    //Assigned new IT room for 50 students to Willowfield with 50 computers
    
    document.getElementById("result1").innerHTML = "Assigned new " + Room1.subject + " room for " + Room1.student + " students, to company: "
                                                    + Room1.company + " with " + Room1.needComputers() + " computers.";
    
    //document.getElementById("result1").innerHTML = getName.getFullName() + " has initials " + getName.initials + ".";
    //document.getElementById("result2").innerHTML = getName.getFullName() + " is " + getName.details.nationality + " and lives at " + getName.details.address + ".";
}

