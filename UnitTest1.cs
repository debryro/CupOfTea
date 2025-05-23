namespace TeaTester;
using NUnit.Framework;
using CupOfT;
public class Tests
{

    [Test]
// CupTest1
// Scenario: Create a cup of herbal tea and see if the constructor works
// expected result: "Cup of herbal tea"
    public void CupTest1()
    {
        var cupOfT = new Cup<string>("herbal");
        Assert.That(cupOfT.ToString(), Is.EqualTo("Cup of herbal tea"));
    }
    
    [Test]
// CupTest2
// Scenario: Update the value of dataValue to "honey"
// expected result: "Cup of honey tea"
    public void CupTest2()
    {
        var cupOfT = new Cup<string>("herbal");
        cupOfT.SetDataValue("honey lemon");
        Assert.That(cupOfT.ToString(), Is.EqualTo("Cup of honey lemon tea"));
    }
    
    [Test]
// CupTest2
// Scenario: Create a cup of "milk tea" and test getter
// expected result: "milk"
    public void CupTest3()
    {
        var cupOfT = new Cup<string>("milk");
        Assert.That(cupOfT.GetDataValue(), Is.EqualTo("milk"));
    }
}