namespace Verwaltungssystem;

public class Benutzer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Rolle Rolle { get; set; }

    public Benutzer(int id, string name, Rolle rolle)
    {
        Id = id;
        Name = name;
        Rolle = rolle;
    }

}
