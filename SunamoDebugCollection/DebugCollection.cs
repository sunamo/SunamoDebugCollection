namespace SunamoDebugCollection;

/// <summary>
/// Represents the debug collection t type.
/// </summary>
public class DebugCollection<T> : List<T>
{
    /// <summary>
    /// Gets or sets the dont allow.
    /// </summary>
    public List<T> DontAllow { get; set; } = new();

    /// <summary>
    /// Debug collection.
    /// </summary>
    /// <returns>The debug collection result.</returns>
    public DebugCollection()
    {
    }

    /// <summary>
    /// Debug collection.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <returns>The debug collection result.</returns>
    public DebugCollection(IList<T> list) : base(list)
    {
    }

    /// <summary>
    /// Debug collection.
    /// </summary>
    /// <param name="count">The count.</param>
    /// <returns>The debug collection result.</returns>
    public DebugCollection(int count) : base(count)
    {
    }

    /// <summary>
    /// The this int.
    /// </summary>
    public new T this[int index]
    {
        get => base[index];
        set => base[index] = value;
    }

    /// <summary>
    /// Add.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The add result.</returns>
    public new void Add(T value)
    {
        if (!DontAllow.Contains(value))
        {
            base.Add(value);
        }
    }
}
