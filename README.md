# CloudCommerceTechTest
Cloud Commerce Group C# Technical Test

I'm going to quote some of the requirements on the technical test that I've received and make some comments.

> Create a C# console application that can be given a CSV file and convert it to XML or JSON. 

Done. Just run the application with 

CloudCommerceTechTest.exe csvtojson Resources/source.csv
CloudCommerceTechTest.exe csvtoxml Resources/source.csv

I provide a csv file under Resources, but you can use your own. 
Number of headers must be at least 3. More than that, the app won't crash but only the first 3 will be worked on. I could have fixed this with Reflection but decided not to.

Output will be displayed on screen, file will be saved in bin/debug directory

> The idea is to show off your knowledge of C# and OOP principles, rather than to do it as quickly as possible.

I used the following OOP principles in my code:
abstract class
virtual, override, overload
inheritance
unit tests
I did not use any polymorphism, I found no scenario in this application to do so.

> Feel free to use a library or framework, e.g. to help handle the interaction with the command line.

I did not use a library for the commandline, but I did use 3rd party libraries for other stuff.

> Your solution should be written with possible future requirements in mind, e.g. converting back to
CSV from other XML or JSON, converting between XML and JSON, or possibly taking input from a
different source, e.g. a database.

I partially implemented the 'database to CSV' future requirements to show how I would do it (no connection to database, i'm using hardcoded values in the repository class)
The other types of conversion have their methods implemented, but without any code on them.

> CSV file format - The headings should form keys in the XML or JSON output
> CSV file format - Underscores should be used to group headings

It's not hard to that string manipulation, however since I implemented the classes for Person and Address, I decided to use the type names as the keys and not actually the string that comes from the first line of the csv.

Regarding the underscores to group the headings, since the class has two different fields I used those instead.

There's nothing in the Tech Test document that tells me how it should translate into XML (the format). I did the same way as json.
