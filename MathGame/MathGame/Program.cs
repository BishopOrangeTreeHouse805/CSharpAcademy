int index = 1;
string name = "John";
char initial = 'J';
int year = 2026;
decimal height = 1.78m;
bool doWeLoveToCode = true;


string myParagraph = $@"These are the most common data types: 
{index++} - string, example: {name}
{index++} - char, example: {initial}
{index++} - int, example: {year}
{index++} - decimal, example: {height}
{index++} - bool, example: {doWeLoveToCode}";

Console.WriteLine(myParagraph);
