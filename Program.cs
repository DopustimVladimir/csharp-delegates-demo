
using DelegatesDemo;

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
