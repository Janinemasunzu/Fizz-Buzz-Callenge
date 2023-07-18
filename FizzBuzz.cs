//Write a public method that accepts a number
public string FizzBuzz(int number)
{
//when the number is divisible by 3 return the word fizz
var num = "";
if(number % 3 == 0)
{
    num = "fizz"
}
//when the number is divisible by 5 return the word buzz
if(number % 5 == 0)
{
    num += "buzz";
}
//when the number is divisible by both, return the word fizzbuzz
return num

}
