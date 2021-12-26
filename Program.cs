
List<President> presidents = new List<President> {
    new President(1, "Askar", "Akayev"),
    new President(2, "Kurmanbek", "Bakiyev"),
    new President(3, "Roza", "Otunbayeva", "SDPK"),
    new President(4, "Almazbek", "Atambayev", "SDPK"),
    new President(5, "Sooronbay", "Jeenbekov", "SDPK"),
    new President(6, "Sadyr", "Japarov", "Mekenchil")
};
List<President> sdpkPresidents = presidents.FindAll(President.IsMemberOfTheSdpkParty);

sdpkPresidents.Sort(President.CompareByName);

foreach (President p in sdpkPresidents) {
    Console.WriteLine(p.Name);
}

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
