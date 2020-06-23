using System;

namespace Lab4_4ArraysLoopsIfsImprovedSpamChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lab4_4ArrayLoopsIfsImprovedSpamChecker");

            // Now that we’ve learned about arrays, lists, and loops,
            // we can improve the Spam Checker from lesson 3.  In this 
            // lab, we want to write an improved version of the Spam Check 
            // that checks a list of words from the blacklist , and uses a 
            // for loop to check all words.

            // Here are the words for our new blacklist.
            // buy, viagra, XXX, free money, lifetime offer, send money, 
            // bank account, nigeria, online pharmacy, h8te, meet girls
            string[] blackList = {
            "buy", "viagra", "XXX", "free money",
                "lifetime offer", "send money", "bank account",
                "nigeria", "online pharmacy", "h8te", "meet girls" };

            string message = Console.ReadLine();
            bool isSpam = false;

            // Let’s also convert all of our messages to lower case 
            // so that things we don’t get missed hits due to capitalization. 
            message = message.ToLower();
            for (int i = 0; i < blackList.Length; i++)
            {
                if (message.Contains(blackList[i]))
                {
                    isSpam = true;
                }
            }


            if (isSpam == true)
            {
                Console.WriteLine("The message contained spam");
            }
            else
            {
                Console.WriteLine("The Message is Ok.");
            }
        }
    }
}

