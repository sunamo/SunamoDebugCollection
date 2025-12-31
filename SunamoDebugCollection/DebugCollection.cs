namespace SunamoDebugCollection;

/// <summary>
///     Can be use also in production
/// </summary>
/// <typeparam name="T"></typeparam>
public class DebugCollection<T> : List<T>
{
    public List<T> DontAllow { get; set; } = new();

    public DebugCollection()
    {
    }

    public DebugCollection(IList<T> items) : base(items)
    {
    }

    public DebugCollection(int count) : base(count)
    {
    }

    public new T this[int i]
    {
        get => base[i];
        set
        {
            if (char.IsLower(value.ToString()[0]))
            {
            }

            base[i] = value;
        }
    }

    public new void Add(T item)
    {
        if (DontAllow.Contains(item))
        {
#if DEBUG
            //////DebugLogger.Break();
#endif
        }
        else
        {
            base.Add(item);
        }
    }
}