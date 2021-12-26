
namespace DelegatesDemo;

class President
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Party { get; set; }

    public President(int id, string name, string lastName, string party="")
    {
        Id = id;
        Name = name;
        LastName = lastName;
        Party = party;
    }

    public static bool IsMemberOfTheSdpkParty(President p)
    {
        return p.Party == "SDPK";
    }

    public static int CompareByName(President p1, President p2)
    {
        return String.Compare(p1.Name, p2.Name);
    }
}
