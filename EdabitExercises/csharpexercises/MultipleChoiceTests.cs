public interface ITestpaper
{
    string Subject { get; }
    string[] MarkScheme { get; }
    string PassMark { get; }
}

public interface IStudent
{
    string[] TestsTaken { get; }
    void TakeTest(ITestpaper paper, string[] answers);
}

public class Testpaper : ITestpaper
{
    public string Subject { get; }
    public string[] MarkScheme { get; }
    public string PassMark { get; }

    public Testpaper(string subject, string[] markScheme, string passMark)
    {
        Subject = subject;
        MarkScheme = markScheme;
        PassMark = passMark;
    }
}

public class Student : IStudent
{
    private List<string> testsTaken = new List<string>();
    public string[] TestsTaken
    {
        get
        {
            if (testsTaken.Count == 0)
                return new string[] { "No tests taken" };
            else
                return testsTaken.ToArray();
        }
    }

    public void TakeTest(ITestpaper paper, string[] answers)
    {
        // Compare answers
        int rightAnswers = 0;
        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == paper.MarkScheme[i])
                rightAnswers++;
        }

        // Round total to the nearest whole number
        double gradePercentage = (double)rightAnswers / answers.Length * 100;
        int studentGrade = (int)Math.Round(gradePercentage, MidpointRounding.AwayFromZero);

        // Check if test passed
        int targetGrade = int.Parse(string.Concat(paper.PassMark.Where(char.IsDigit)));
        string testResult = studentGrade >= targetGrade ? "Passed" : "Failed";

        // Add record for the test
        testsTaken.Add($"{paper.Subject}: {testResult}! ({studentGrade}%)");

        // Sort records by subject
        testsTaken.Sort();
    }
}
