public class SolveForTheRedArea
{
    public static double RedArea(int r)
    {
        decimal triangleArea = r * 2M * r * 0.5M;
        decimal cornerArea = r * r - 0.25M * (decimal)Math.PI * r * r;
        decimal circleArea = (r * r) / 2M * (decimal)Math.PI - r*r * (decimal)Math.Atan(0.5) - r* r * 0.4M;

        return Math.Round((double)(triangleArea - cornerArea - circleArea), 3);
    }
}