/// <reference path="../Scripts/DVDs.js" />
/// <reference path="../Scripts/jasmine/jasmine.js" />
/// <reference path="../Scripts/searchScript.js" />

describe("search_Tests", function () {

    it("joinData_Test", function () {

        var list = ["Batman", "Dune", "Spiderman"];
        var expectedTextOutcome = "BatmanDuneSpiderman";
        var actual = joinData(list);

        expect(expectedTextOutcome).toBe(actual);


    });

    //Test to check that the correct DVDs and quantity are return from DVDs.js file 
    it("DVDSuggestions_Tests", function () {

        var actual = [];
        var expected = ["Dune", "Dark Waters", "Many Saints of Newark", "The Conjuring", "The Joker"];

        //testDVDs comes from DVDs.js file
        actual = testDVDs;
        expect(expected).toEqual(actual);

    });


});
