namespace apbd_cw1_git_s33286;

public class StatisticsHelper
{
    private int[] values;

    public StatisticsHelper(int[] values)
    {
        this.values = values;
    }
    
    public double CalculateAverage()
    {
        if (values == null)
            return 0;

        double sum = 0;
        foreach (var v in values)
            sum += v;

        return sum / values.Length;
    }
}