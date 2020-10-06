




$(document).ready(function () {
    $("#calcu").click(function () {

        var q1 = document.getElementById("q1").value
      
        var q2 = document.getElementById("q2").value
        







        if ((q2 - 1317) > 0 && (q1 - 15) > 0)  {
            document.getElementById("gapfees").value = (q2 - 1317);
            document.getElementById("gaphours").value = ((q2 / q1) * (q1 - 15)).toFixed(2);
            document.getElementById("AnnualFee").value = (q2 - 1317);
            document.getElementById("TermFee").value = ((q2 - 1317) / 4).toFixed(2);
            document.getElementById("WeekFee").value = ((q2 - 1317) / 33.333).toFixed(2);
        }

        if ((q2 - 1317) <= 0 && (q1 - 15) <= 0) {
            document.getElementById("gapfees").value = 0;
            document.getElementById("gaphours").value = 0;
            document.getElementById("AnnualFee").value = 0;
            document.getElementById("TermFee").value = 0;
            document.getElementById("WeekFee").value = 0;
        }

        if ((q2 - 1317) > 0 && (q1 - 15) <=0) {
            document.getElementById("gapfees").value = (q2 - 1317);
            document.getElementById("gaphours").value = 0;
            document.getElementById("AnnualFee").value = (q2 - 1317);
            document.getElementById("TermFee").value = ((q2 - 1317) / 4).toFixed(2);
            document.getElementById("WeekFee").value = ((q2 - 1317) / 33.333).toFixed(2);
        }

        if ((q2 - 1317) <= 0 && (q1 - 15) > 0) {
            document.getElementById("gapfees").value = 0;
            document.getElementById("gaphours").value = (((q2 / 33.333) / 22) * (q1 - 15) * 33.333).toFixed(2);
            document.getElementById("AnnualFee").value = (((q2 / 33.333) / 22) * (q1 - 15) * 33.333).toFixed(2);;
            document.getElementById("TermFee").value = ((((q2 / 33.333) / 22) * (q1 - 15) * 33.333) / 4).toFixed(2);
            document.getElementById("WeekFee").value = ((((q2 / 33.333) / 22) * (q1 - 15) )).toFixed(2);
        }







        


        return true;
    });
});