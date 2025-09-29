// int[] sophiaScores = new int[5];
int currentAssignments = 5;

int[] sophia = new int[]{90,56,2,23};
int[] andrew = new int[] { 92, 56, 121 };
int[] emma = new int[] { 90, 64 };
int[] morgan = new int[] { 13, 51 };

int sum = 0;

decimal sophiaScore;

foreach (int score in sophia)
{
    sum += score;
}

sophiaScore = (decimal) sum / currentAssignments;



Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

