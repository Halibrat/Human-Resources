
var net;
var brut;
document.getElementById("bas").click(function () {
    console.log("bas");
    brut = $('#text').val();
    $('#ocak1').text((brut * (0.14)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#ocak2').text((brut * (1 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#ocak3').text((brut - (brut * (14 / 100) + brut * (1 / 100))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#ocak4').text(([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100)).toFixed(2).replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#ocak5').text((brut * (0.759 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#ocak6').text((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#ocak7').text((brut - ((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100)))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,")))
    $('#ocak8').text((brut * (19.5 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#ocak9').text((brut * (2 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))

    $('#subat1').text((brut * (0.14)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#subat2').text((brut * (1 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#subat3').text((brut - (brut * (14 / 100) + brut * (1 / 100))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#subat4').text(([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100)).toFixed(2).replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#subat5').text((brut * (0.759 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#subat6').text((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#subat7').text((brut - ((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100)))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,")))
    $('#subat8').text((brut * (19.5 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#subat9').text((brut * (2 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))

    $('#mart1').text((brut * (0.14)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#mart2').text((brut * (1 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#mart3').text((brut - (brut * (14 / 100) + brut * (1 / 100))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#mart4').text(([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100)).toFixed(2).replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#mart5').text((brut * (0.759 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#mart6').text((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#mart7').text((brut - ((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100)))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,")))
    $('#mart8').text((brut * (19.5 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#mart9').text((brut * (2 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))

    $('#nisan1').text((brut * (0.14)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#nisan2').text((brut * (1 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#nisan3').text((brut - (brut * (14 / 100) + brut * (1 / 100))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#nisan4').text(([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100)).toFixed(2).replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#nisan5').text((brut * (0.759 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#nisan6').text((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#nisan7').text((brut - ((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100)))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,")))
    $('#nisan8').text((brut * (19.5 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#nisan9').text((brut * (2 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))

    $('#mayıs1').text((brut * (0.14)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#mayıs2').text((brut * (1 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#mayıs3').text((brut - (brut * (14 / 100) + brut * (1 / 100))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#mayıs4').text(([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100)).toFixed(2).replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#mayıs5').text((brut * (0.759 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#mayıs6').text((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#mayıs7').text((brut - ((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100)))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,")))
    $('#mayıs8').text((brut * (19.5 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#mayıs9').text((brut * (2 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))

    $('#haziran1').text((brut * (0.14)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#haziran2').text((brut * (1 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#haziran3').text((brut - (brut * (14 / 100) + brut * (1 / 100))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#haziran4').text(([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100)).toFixed(2).replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#haziran5').text((brut * (0.759 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#haziran6').text((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#haziran7').text((brut - ((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100)))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,")))
    $('#haziran8').text((brut * (19.5 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#haziran9').text((brut * (2 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))

    $('#temmuz1').text((brut * (0.14)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#temmuz2').text((brut * (1 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#temmuz3').text((brut - (brut * (14 / 100) + brut * (1 / 100))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#temmuz4').text(([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100)).toFixed(2).replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#temmuz5').text((brut * (0.759 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#temmuz6').text((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#temmuz7').text((brut - ((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100)))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,")))
    $('#temmuz8').text((brut * (19.5 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#temmuz9').text((brut * (2 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))

    $('#agustos1').text((brut * (0.14)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#agustos2').text((brut * (1 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#agustos3').text((brut - (brut * (14 / 100) + brut * (1 / 100))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#agustos4').text(([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100)).toFixed(2).replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#agustos5').text((brut * (0.759 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#agustos6').text((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#agustos7').text((brut - ((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100)))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,")))
    $('#agustos8').text((brut * (19.5 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#agustos9').text((brut * (2 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))

    $('#eylül1').text((brut * (0.14)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#eylül2').text((brut * (1 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#eylül3').text((brut - (brut * (14 / 100) + brut * (1 / 100))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#eylül4').text(([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100)).toFixed(2).replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#eylül5').text((brut * (0.759 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#eylül6').text((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#eylül7').text((brut - ((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100)))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,")))
    $('#eylül8').text((brut * (19.5 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#eylül9').text((brut * (2 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))

    $('#ekim1').text((brut * (0.14)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#ekim2').text((brut * (1 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#ekim3').text((brut - (brut * (14 / 100) + brut * (1 / 100))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#ekim4').text(([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100)).toFixed(2).replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#ekim5').text((brut * (0.759 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#ekim6').text((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#ekim7').text((brut - ((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100)))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,")))
    $('#ekim8').text((brut * (19.5 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#ekim9').text((brut * (2 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))

    $('#kasım1').text((brut * (0.14)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#kasım2').text((brut * (1 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#kasım3').text((brut - (brut * (14 / 100) + brut * (1 / 100))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#kasım4').text(([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100)).toFixed(2).replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#kasım5').text((brut * (0.759 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#kasım6').text((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#kasım7').text((brut - ((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100)))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,")))
    $('#kasım8').text((brut * (19.5 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#kasım9').text((brut * (2 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))

    $('#aralık1').text((brut * (0.14)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#aralık2').text((brut * (1 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#aralık3').text((brut - (brut * (14 / 100) + brut * (1 / 100))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#aralık4').text(([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100)).toFixed(2).replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#aralık5').text((brut * (0.759 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#aralık6').text((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#aralık7').text((brut - ((brut * (14 / 100) + (brut * (1 / 100)) + ([brut - (brut * (14 / 100) + brut * (1 / 100))] * (15 / 100) + ((brut * (0.759 / 100)))))).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,")))
    $('#aralık8').text((brut * (19.5 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))
    $('#aralık9').text((brut * (2 / 100)).toFixed(2).toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,"))

    console.log($('#text').val());
    $.ajax({
        type: "Post",
        url: '/Payroll/Add',
        data: {
            GrossSalary: $('#text').val(),
            LaborShare: $('#ocak1').val(),
            UIShare: parseFloat('#ocak2').text,
            IncomeTaxBase: parseFloat('#ocak3').text,
            IncomeTaxAmount: parseFloat('#ocak4').text,
            StampDutAmount: parseFloat('#ocak5').text,
            SumOfDeductions: parseFloat('#ocak6').text,
            NetWage: parseFloat('#ocak7').text,
            EmployerShare: 2000,
            UIEShare: 3000,
        },

    });

})
//$('#bilgim').html('<center><img src="images/loading.gif" /></center>');
//var payrols = { Id: 1, };

