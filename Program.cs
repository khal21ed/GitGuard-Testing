// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;
using System.Linq;

string API_KEY = "My_API_KEY";

string DB_ConnectionString = "Server=localhost;Database=mydb;User Id=myuser;Password=mypassword;";

var segments = "/hi/hello//hihi".Split('/', StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < segments.Length; i++)
{
    Console.WriteLine(segments[i]);
}