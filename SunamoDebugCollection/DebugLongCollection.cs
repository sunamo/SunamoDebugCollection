namespace SunamoDebugCollection;

public class DebugLongCollection : DebugCollection<long>
{
    public new void Add(long value)
    {
        base.Add(value);
#if DEBUG
        if (Count % 100 == 0)
        {
            var recentValues = new List<long>();
            for (var i = Count - 1; i >= Count - 100; i--) recentValues.Add(this[i]);

            //var s = NH.CalculateMedianAverage(recentValues);
        }
#endif
    }
}