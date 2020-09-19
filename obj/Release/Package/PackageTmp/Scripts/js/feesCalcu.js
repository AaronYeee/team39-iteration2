function submitAnswers() {

    //get user input

    var q1 = document.forms["quizForm"]["q1"].value;
    console.log(q1)
    var q2 = document.forms["quizForm"]["q2"].value;
    console.log(q2)



    if ((q2 - 1317) > 0) {
        document.getElementById("gapfees").innerHTML = (q2 - 1317);
    }

    if ((q1 - 15) > 0) {
        document.getElementById("gaphours").innerHTML = (q2/q1)*(q1-15);
    }
    else {
        document.getElementById("gaphours").innerHTML = "None";
        document.getElementById("gapfees").innerHTML = "None";
    }
    




    return false;
}