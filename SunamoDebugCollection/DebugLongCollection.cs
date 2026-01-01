// variables names: ok
namespace SunamoDebugCollection;

/// <summary>
/// A specialized debug collection for long integer values with statistical tracking capabilities.
/// </summary>
public class DebugLongCollection : DebugCollection<long>
{
    /// <summary>
    /// Adds a long value to the collection and tracks statistics every 100 items in debug mode.
    /// </summary>
    /// <param name="value">The long value to add to the collection.</param>
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