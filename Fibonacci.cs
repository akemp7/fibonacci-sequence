using System;
using System.Collections.Generic;

class Program
{
  static void Main()
  {
      List<string> questions = new List<string>{};
      questions.Add("Display the n number of Fibonacci sequence (y/n)?");
      questions.Add("Calculate the Fibonacci number of a specific term (y/n)?");
      questions.Add("Display the Fibonacci sequence up to the  n number in the sequence (y/n)?");
      string thingToDo = "";

      Console.WriteLine("What do you want to do?");
      foreach(string question in questions){
          Console.WriteLine(question);
          string userResponse = Console.ReadLine();
          if(userResponse.ToLower() == "y"){
             thingToDo = question;
             break;
          } else if(questions.IndexOf(question) == questions.Count-1){
             Console.WriteLine("Nothing selected. Quitting.");
          }
      }
     if(thingToDo == questions[0]){
         Console.WriteLine("How many numbers to display?");
         string countString = Console.ReadLine();
         try{
             int count = int.Parse(countString);
            int fibNum = DisplayFibSeq(0, 1, count);
            Console.WriteLine(fibNum);
         } catch (FormatException){
             Console.WriteLine("Incorrect format. Please restart and try again.");
         }
     } else if (thingToDo == questions[1]){
         Console.WriteLine("Sorry, come again....");
     } else {
         Console.WriteLine("How many numbers to in the series?");
         string numString = Console.ReadLine();
         try{
             int num = int.Parse(numString);
         } catch (FormatException){
             Console.WriteLine("Incorrect format. Please restart and try again.");
         }
     }
  }

  public static int DisplayFibSeq(int prevNum, int currNum, int count){
      int prevHolder = currNum;
      currNum += prevNum;
      prevNum = prevHolder;
      count--;
      if(count != 0){
          return prevNum = DisplayFibSeq(prevNum, currNum, count);
      } 
      return prevNum;
  }
}