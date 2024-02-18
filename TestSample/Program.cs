using TestSample.Dictionary;
using TestSample.Zeroes_Move;
using TestSample.LongestConsecutiveSubsequence;
using TestSample.ArrayProblem;
using TestSample.RomanProblems;
using TestSample.LinkedListProblems;
using TestSample.Longest_Substring_Without_Repeating_Characters;
using TestSample.Public_Bank_Malaysia;
using TestSample.StringProblem;


// remove duplicate word from a string
string teststring = "this is a book is on the table";
string output = IString.removeDuplicateWord(teststring);
Console.WriteLine($" the orginal string is {teststring} and output is {output}");
// hacker rank problems
List<int> numberlist = new List<int> { 1,2,3,4,5,6};
int k = 5;
int numofCount =IPublicBank.CountPairsDivisibleByK(numberlist, k);
Console.WriteLine("count " + numofCount);


string str1 = "abcabcbb";
var result = ILongestSubstring.getLongestSubstring(str1);
Console.WriteLine($"input string is {str1} and count is {result}");

DictionaryProblemExample dictionaryProblemExample = new DictionaryProblemExample();
string str = "aavvddd";
var res = dictionaryProblemExample.getMaxOccuringCharacter(str);
Console.WriteLine($" string of {str} its key is {res.Item1} value is {res.Item2}");

var res01 = dictionaryProblemExample.getMaxOccuringCharacter_01(str);
Console.WriteLine($" key is {res.Item1} value is {res.Item2}");

int num = 15223;
var resNum = dictionaryProblemExample.getMaxOccuringNumber(num);
Console.WriteLine($" first method key is {resNum}");

var resNum01 = dictionaryProblemExample.getMaxOccuringNumber_01(num);
Console.WriteLine($" second method key is {resNum01}");

var resNum02 = dictionaryProblemExample.getMaxOccuringNumber_02(num);
Console.WriteLine($" third method key is {resNum02}");

Console.WriteLine("Zeros move");
AllZerosMove allZerosMove = new AllZerosMove();
int[] nums = { 1, 1, 0, 8, 0, 3, 0, 0, 9, 4 };
//int[] result = allZerosMove.MoveAllZerosToRight(nums);
//Console.Write(string.Join(",", result));

Console.WriteLine();
int[] result1 = allZerosMove.MoveAllZerosToRight_01(nums);
Console.Write(string.Join(",", result1));

string s = "rat";
string t = "car";
//bool sfdd = allZerosMove.CheckAnagram(s, t);
//Console.WriteLine(sfdd);
LongestConsecutiveSubsequenceSolution solution = new LongestConsecutiveSubsequenceSolution();
int[] numbers = { 1, 9, 3, 10, 4, 20, 2 };
int longest = solution.getLongestConsecutiveSubsequence(numbers);
Console.WriteLine();
Console.WriteLine($"Longest Consecutive is {longest}");

// Palindrome check number 
Console.WriteLine();
ArrayProblemSolution arrayProblemSolution = new ArrayProblemSolution();
bool isPalindrome = arrayProblemSolution.CheckPalindrome(1221);
Console.WriteLine($"The number is {isPalindrome}");
str = "A man, a plan, a canal: Panama";
bool isPalindrome1 = arrayProblemSolution.CheckPalindrome(str);
Console.WriteLine($"The number is {isPalindrome1}");
// Roman To Integer
string roman = "XVI";
int romanNum = IRoman.GetRomanToInteger(roman);
Console.WriteLine($"roman string is {roman} and integer is  {romanNum}");

IlinkedList.NodeConstruction();
Console.ReadKey();