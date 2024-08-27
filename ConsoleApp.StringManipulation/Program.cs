// See https://aka.ms/new-console-template for more information

// Initialise with a regulat string literal
string s1 = "This is a literal string"; // preferred 'common s'
String s2 = "This is a literal string";

Console.WriteLine($"{nameof(s1)}:{s1}");
Console.WriteLine($"{nameof(s2)}:{s2}");

// Declare without initialising (possible null exception)
string s3;

// Initialise to null (possible null exception)
string? s4 = null;
Console.WriteLine($"{nameof(s4)}:{s4}");

// Initialise as an empty string
string s5 = string.Empty; // safer option
string s6 = "";
Console.WriteLine($"{nameof(s5)}:{s5}");
Console.WriteLine($"{nameof(s6)}:{s6}");


// Escape sequences and characters
// She said, "I have your phone"
string sentence = "She said, \"I have your phone\" \r\n This is the next line";

// Verbatim string literal
string oldPath = "C:\\program files\\programfolder\\";
string newPath = @"C:\program files\programfolder\"; // Verbatim String

// Use a const string to prevent modifiaction to a string
const string path = "C:\\program files\\programfolder\\";
// path = "new value"; // Illegal operation against a constant

// Raw string literals
string rawLiteral = """ She said, "I have your phone" """; // ignores escape characters. \r\n will be treated as text
// for string literals with mulitple lines:
string rawLiteral1 = """
    She said, "I have your phone"
    This is the next line
    And another one
    Path = "C:\program files\programfolder\"
    """;

// Review concatenation and interpolation
s1 += s2;
string newString = $"{s1} {s2} Some randon literal text";
string newString1 = s1 + $"{s1} {s2} Some randon text";
string newString2 = string.Format("Literal string {0} {1}", s1 , s2);

/* String Manipulation methods*/

// Null or empty checks
// find the length of a string
Console.WriteLine($"{nameof(s1)} has a length of {s1.Length}");
// Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}"); // Will cause a null exception
// Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");
Console.WriteLine($"{nameof(s6)} has a length of {s6.Length}");


if (!string.IsNullOrEmpty(s4))
{
    Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");
}
if (string.IsNullOrEmpty(s5)==false)
{
    Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");
}


// Substring
string subString = s1.Substring(5);
Console.WriteLine($"{nameof(subString)} : {subString}");
subString = s1.Substring(5, 5);
Console.WriteLine($"{nameof(subString)} : {subString}");

// Splitting Strings
var splitStrings = s2.Split(' ');
for (int i = 0; i < splitStrings.Length; i++)
{
    Console.WriteLine(splitStrings[i]);
}

// Replace
string replacements1 = s1.Replace('s', 'V');
Console.WriteLine($"{nameof(replacements1)} : {replacements1}");
string replacements2 = s1.Replace("string", "chicken");
Console.WriteLine($"{nameof(replacements2)} : {replacements2}");

// Convert to string
// string salary = Convert.ToString(123.456);
string salary = 123.456.ToString();

int value = 741852963;
string strValue = value.ToString();
Boolean isChosen = true;
strValue = isChosen.ToString();

// Changing Format
Console.WriteLine($"{nameof(salary)} : {salary:C}");
Console.WriteLine(nameof(salary) + " : " + value.ToString("C"));
