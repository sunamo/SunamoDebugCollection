// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoDebugCollection;

public class DebugLongCollection : DebugCollection<long>
{
    public new void Add(long l)
    {
        base.Add(l);
#if DEBUG
        if (Count % 100 == 0)
        {
            var l2 = new List<long>();
            for (var i = Count - 1; i >= Count - 100; i--) l2.Add(this[i]);

            //var s = NH.CalculateMedianAverage(l2);
        }
#endif
    }
}