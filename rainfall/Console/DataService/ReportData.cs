
using Models;

namespace DataService;

public enum Classification { GREEN, RED, AMBER }
public enum Trend { INCREASING, DECREASING, FLAT }


public class ReportData : IBaseModel
{
    public string Id { get; set; }
    public string Location { get; set; }
    public string Name { get; set; }
    public double Avg { get; set; }
    public Classification Classification { get; set; }

    public Trend Trend { get; set; }

    public override string ToString()
    {
        return string.Format("Name: {4}\nDevice Id: {0}\nLocation: {5}\nClassification: {1}\nAverage Reading in Last 4 Hours: {2}\nTrend: {3}\n\n", Id, Classification.ToString(), Avg, Trend.ToString(), Name, Location);
    }

}