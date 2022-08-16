//Variable Decleration
string dogName;
int year;
int cost;
char dollarsign;
bool isAdopted;
decimal age;
double milesAway;

//Initializing Variables
dogName = "Apollo";
year = 2018;
cost = 20;
dollarsign = '$';
isAdopted = true;
age = 8.5m;
milesAway = 600;

Console.WriteLine($"I said, My dog's name is {dogName}, he is {age} years old. I got him in {year}");
Console.WriteLine($"Then they said, Is he adopted?");
Console.WriteLine($"Then I said, That is {isAdopted}, and he only cost {dollarsign}{cost}. He is the best dog I have ever had.");

//Second try where I am going to declare and initialize in one step
string myName = "Drew";
int yearmade = 2016;
double dayOfTheYear = 3;
decimal timePlayed = 6.25m;
bool favoriteGame = true;
char percent = '%';
int percent2 = 100;
string month = "May";

Console.WriteLine($"I said, My name is {myName}, and I have been playing Overwatch since it came out in {month} {dayOfTheYear}, {yearmade}.");
Console.WriteLine($"Then the asked, is it you favorite game?");
Console.WriteLine($"Then I answered, that is {percent2}{percent} {favoriteGame}");
   