var score = 0;
var outputString = "";

var event1 = document.getElementById("button1").addEventListener('click', answerCheck, false);

function Question(questionText, answerOne, answerTwo, answerThree, answerFour, correct) {
    this.questionText = questionText;
    this.answerOne = answerOne;
    this.answerTwo = answerTwo;
    this.answerThree = answerThree;
    this.answerFour = answerFour;
    this.correct = correct;
}

var questionOne = new Question('Which of these is not a handheld console?', 'Playstation Portable', 'Nintendo DS', 'Nintendo Wii', 'Game Boy Advance', 3);
var questionTwo = new Question('Which of these is not part of the original 151 Pokemon?', 'Kangaskhan', 'Bulbasaur', 'Pikachu', 'Suicune', 4);
var questionThree = new Question('Which of these series is not a franchise belonging to Nintendo?', 'Pokemon', 'Final Fantasy', 'Legend of Zelda', 'Metroid', 2);
var questionFour = new Question('Which of the following Final Fantasy did not launch on the Super Nintendo?', 'Final Fantasy III', 'Final Fantasy IV', 'Final Fantasy V', 'Final Fantasy VI', 1);
var questionFive = new Question('Which of the following Legend of Zelda titles is on a handheld system?', 'Ocarina of Time', 'Twilight Princess', 'Minish Cap', 'Wind Waker', 3);

var questionList = [];

questionList.push(questionOne);
questionList.push(questionTwo);
questionList.push(questionThree);
questionList.push(questionFour);
questionList.push(questionFive);

questionTags = ['question1', 'question2', 'question3', 'question4', 'question5'];
answerListTags = ['answerList1', 'answerList2', 'answerList3', 'answerList4', 'answerList5'];
inputTags = ['answer1', 'answer2', 'answer3', 'answer4', 'answer5'];

for (var i = 0; i < questionList.length; i++) {
    document.getElementById(questionTags[i]).innerHTML = questionList[i].questionText;
    document.getElementById(answerListTags[i]).innerHTML = "<li>" + questionList[i].answerOne + "</li>" + 
                                                            "<li>" + questionList[i].answerTwo + "</li>" +
                                                            "<li>" + questionList[i].answerThree + "</li>" + 
                                                            "<li>" + questionList[i].answerFour + "</li>";
}


function answerCheck() {
    
    outputString = "";
    score = 0;

    
    var stringCheck = "";
    var matchAnswer = 0;
    
    //var inputCheck = document.getElementById(inputTags.).value;
    
    //window.prompt("test");
    
    /*for (var i = 0; i < questionList.length; i++) {
        
        matchAnswer = parseInt(document.getElementById(inputTags[i]).value);
        
        if ((matchAnswer === questionList[i].correct) && (matchAnswer != "")){
            outputString += "That was the correct answer to Question " + (i + 1) + ", congratulations!" + "</br>";
            score++;
        }
        
        else if (matchAnswer != "") {
            outputString +=  "Wrong answer to Question " + (i + 1) + ", please try again." + "</br>";
            document.getElementById(inputTags[i]).value = "";
        }
        
        scoreResult();
        
    }*/
    
    

    for (var i = 0; i < questionList.length; i++) {
        
        stringCheck = document.getElementById(inputTags[i]).value;
        
        if (stringCheck != "") {
            
            matchAnswer = parseInt(stringCheck);
            
            if ((matchAnswer === questionList[i].correct) && (score < questionList.length)) {
                outputString += "That was the correct answer to Question " + (i + 1) + ", congratulations!" + "</br>";
                score++;
            }
            else {
                outputString +=  "Wrong answer to Question " + (i + 1) + ", please try again." + "</br>";
                document.getElementById(inputTags[i]).value = "";     
            }     
            
            scoreResult(); 
        } 
        else {
            document.getElementById("result1").innerHTML = "Please enter a answer into all the fields";
            document.getElementById("result2").innerHTML = "";
            document.getElementById("result3").innerHTML = "";
        } 
           
    }
        
}

function scoreResult () {
        
    document.getElementById("result1").innerHTML = outputString + "<br/>";
    document.getElementById("result2").innerHTML = "In total, you scored " + score + " out of " + questionList.length + ".";
    
    if (score === questionList.length) {
        document.getElementById("result3").innerHTML = "You got all the questions right! What a pro!";
    }
    else if (score === 0) {
        document.getElementById("result3").innerHTML = "Everything was incorrect! Brush up your knowledge and try again later.";
    }        
    else if (score >= Math.ceil(questionList.length / 2)) {
        document.getElementById("result3").innerHTML = "That was close! You're nearly there!";
    }
    else {
       document.getElementById("result3").innerHTML = "Not a bad attempt! Give it another shot!";
    }
    
}