// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;
using System.Linq;

string API_KEY = "My_API_KEY";

string DB_ConnectionString = "Server=localhost;Database=mydb;User Id=myuser;Password=mypassword;";
string githubToken = "ghp-aBcDeFgHiJkLmNoPqRsTuVwXyZ123456Ab"; // dash instead of underscore
string awsKey = "AKIAIOSFODNN7EXAMPLEKEY!"; // invalid character at the end


var segments = "/hi/hello//hihi".Split('/', StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < segments.Length; i++)
{
    Console.WriteLine(segments[i]);
}
