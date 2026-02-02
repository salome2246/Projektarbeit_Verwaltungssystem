using Verwaltungssystem;

namespace TestsVerwaltungssystem;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        Benutzer benutzer1 = new Benutzer(1,"salome",Rolle.Projektleiter);
        
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}