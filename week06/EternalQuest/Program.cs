// Inorder to exceed requirements, I have taken the pains to implement robust error handling using:
// 1. Try and Catch - Exception clause
// 2. "throw new ArgumentException" to indicate the error that's keeping the code from executing
// I also keep track of the users score and make sure it's persisted even if the user quits as long as the goal is saved to file. I do this by:
// 1. Making sure the the score is saved to the first line of the file. See line 188 of Goal Manager's SaveGoals method: outputFile.WriteLine(_score);
// 2. Then, I always make sure to load the score from the first line of the file (see line 218 of the GoalManager's LoadGoals method), like so: _score = int.Parse(lines[0]);
// The score is loaded and added to subsequent scores using the RecordEvent method
// Finally, I display a brief info about each goal after it's loaded successfully from the file. See Goal manager: lines 246 - 257
using System;
using EternalQuest;

public class Program
// The GoalManager handles most of the interraction
{
    public static void Main(string[] args)
    {

        GoalManager goalManager = new GoalManager();

        goalManager.Start();
    }
}
