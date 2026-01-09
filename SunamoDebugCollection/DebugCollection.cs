// variables names: ok
namespace SunamoDebugCollection;

/// <summary>
/// A debug-friendly collection that can be used in both development and production environments.
/// Provides functionality to prevent adding specific items to the collection.
/// </summary>
/// <typeparam name="T">The type of elements in the collection.</typeparam>
public class DebugCollection<T> : List<T>
{
    /// <summary>
    /// Gets or sets the list of items that should not be allowed to be added to this collection.
    /// </summary>
    public List<T> DontAllow { get; set; } = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="DebugCollection{T}"/> class.
    /// </summary>
    public DebugCollection()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DebugCollection{T}"/> class with items from an existing collection.
    /// </summary>
    /// <param name="list">The collection whose elements are copied to the new collection.</param>
    public DebugCollection(IList<T> list) : base(list)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DebugCollection{T}"/> class with a specified capacity.
    /// </summary>
    /// <param name="count">The initial capacity of the collection.</param>
    public DebugCollection(int count) : base(count)
    {
    }

    /// <summary>
    /// Gets or sets the element at the specified index.
    /// </summary>
    /// <param name="index">The zero-based index of the element to get or set.</param>
    /// <returns>The element at the specified index.</returns>
    public new T this[int index]
    {
        get => base[index];
        set => base[index] = value;
    }

    /// <summary>
    /// Adds an item to the collection if it is not in the DontAllow list.
    /// </summary>
    /// <param name="value">The value to add to the collection.</param>
    public new void Add(T value)
    {
        if (!DontAllow.Contains(value))
        {
            base.Add(value);
        }
    }
}