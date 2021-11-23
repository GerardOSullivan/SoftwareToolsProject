const mysql = require('mysql');
const { title } = require('process');

var config =
{
    host: 'dvdkiosk.mysql.database.azure.com',
    user: 'odhran',
    password: 'azureDatabase!!',
    database: 'kiosk',
    port: 3306,
    //ssl: true
};

const conn = new mysql.createConnection(config);

conn.connect(
    function (err) {
        if (err) {
            console.log("!!! Cannot connect !!! Error:");
            throw err;
        }
        else {
            console.log("Connection established.");
           // readData();
            pushTitlesIntoArray();
        }
    });

function readData() {
    conn.query('SELECT * FROM dvd',
        function (err, results, fields) {
            if (err) throw err;
            else console.log('Selected ' + results.length + ' row(s).');
            for (i = 0; i < results.length; i++) {
                console.log('Row: ' + JSON.stringify(results[i]));
            }
            console.log('Done.');
        })
    conn.end(
        function (err) {
            if (err) throw err;
            else console.log('Closing connection.')
        });
};

function pushTitlesIntoArray() {
    let titles = [];
    conn.query('SELECT title FROM dvd',
        function (err, results, fields) {
            if (err) throw err;
            else console.log('Selected ' + results.length + ' row(s).');
            for (i = 0; i < results.length; i++) {
                titles.push(results[i].title);
            }
            console.log(titles);
        })
    conn.end(
        function (err) {
            if (err) throw err;
            else console.log('Closing connection.')
        });
};