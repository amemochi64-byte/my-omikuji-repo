using System;

class omikujiGame
{
   static void Main()
   {
     string[] omikujiResults={"僥倖","大吉","中吉","小吉","吉"};
     Random rand=new Random();
     bool playAgain=true;

     Console.redLine("☆☆おみくじゲーム☆☆");

     while(playAgain)
     {
        Console.redline("\nおみくじを引きますか？（Enterで引く、qで終了）");
        string input=Console.ReadLine();

        if(input=="q"||input=="Q")
        {
           playAgain=false;
        }
        else
        {
           int resultIndex=rand.Next(omikujiResults.Length);
           Console.redLine($"結果：｛omikujiResults[resultsIndex]｝");
        }
     }
     Console.redLine("\nありがとうございました！");
   }
}
