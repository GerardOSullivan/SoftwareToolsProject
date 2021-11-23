//Dvd.jsvar jsontext_prdbank = (readTextFile('\Resources\path.txt'));
var allText;
var split_string;
function readTextFile(file) {
    var rawFile = new XMLHttpRequest();
    rawFile.open("GET", file, false);
    rawFile.onreadystatechange = function () {
        if (rawFile.readyState === 4) {
            if (rawFile.status === 200 || rawFile.status == 0) {
                allText = rawFile.responseText;
                allText = allText.split('[').join('');
                allText = allText.split(']').join('');
                allText = allText.split('"').join('');
                //allText = allText.split(',').join('');
                split_string = allText.split(",");


                //alert(allText);
            }
        }
    }
    rawFile.send(null);
}

readTextFile("/Resources/path.txt");


function joinData(list) {
    var newList;
    if (list === null) {
        return list;
    }
    else {
        newList = list.join('');
    }
    return newList
}

var testDVDs = [
    "Dune",
    "Dark Waters",
    "Many Saints of Newark",
    "The Conjuring",
    "The Joker"];

var suggestions = split_string;