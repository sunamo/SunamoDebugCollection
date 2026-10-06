namespace SunamoDebugCollection;

public class DebugCollection<T> : List<T>
{
    public List<T> DontAllow { get; set; } = new();

    public DebugCollection()
    {
    }

    public DebugCollection(IList<T> list) : base(list)
    {
    }

    public DebugCollection(int count) : base(count)
    {
    }

    public new T this[int index]
    {
        get => base[index];
        set => base[index] = value;
    }

    public new void Add(T value)
    {
        if (!DontAllow.Contains(value))
        {
            base.Add(value);
        }
    }
}
