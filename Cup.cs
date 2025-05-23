namespace CupOfT;

/// <summary>
/// Objects of the Cup<T> class hold 1 value of type T
/// </summary>
public class Cup<T>
{
    private T _dataValue;

    /// <summary>
    /// GetDataValue() method
    /// Purpose: Return the value of the data member _dataValue
    /// </summary>
    public T GetDataValue()
    {
        return _dataValue;
    }
    
    /// <summary>
    /// SetDataValue() method
    /// Purpose: Store a value in _dataValue
    /// </summary>
    /// <param name="dataValue"></param>
    public void SetDataValue(T dataValue)
    {
        _dataValue = dataValue;
    }
    
    /// <summary>
    /// Parameterized Constructor
    /// Purpose: Initialize _dataValue when an object is created
    /// </summary>
    /// <param name="dataValue"></param>
    public Cup(T dataValue)
    {
        _dataValue = dataValue;
    }
    
    public String ToString()
    {
        return "Cup of " + _dataValue.ToString() + " tea";
    }
}