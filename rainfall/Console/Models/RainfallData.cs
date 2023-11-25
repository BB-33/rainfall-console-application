
using CsvHelper.Configuration.Attributes;

namespace Models;

public class RainfallData : IBaseModel
{
    [Index(0)]
    public string Id { get; set; }
    [Index(1)]

    public DateTime Time { get; set; }
    [Index(2)]

    public double Rainfall { get; set; }

    public override string ToString()
    {

        return string.Format("Id: {0} Time: {1} Rainfall: {2}", this.Id, this.Time, this.Rainfall);
    }

}