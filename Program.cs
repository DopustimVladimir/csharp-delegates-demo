using System;
using System.Collections.Generic;

namespace Soup
{
    class President
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Party { get; set; }

        public President(int id, string name, string lastName, string party="") {
            Id = id;
            Name = name;
            LastName = lastName;
            Party = party;
        }

        public static bool IsMemberOfTheSdpkParty(President p) {
            return p.Party == "СДПК";
        }

        public static int CompareByName(President p1, President p2) {
            return String.Compare(p1.Name, p2.Name);
        }
    }

    class Program
    {
        static void Main()
        {
            List<President> presidents = new List<President> {
                new President(1, "Аскар", "Акаев"),
                new President(2, "Курманбек", "Бакиев"),
                new President(3, "Роза", "Отунбаева", "СДПК"),
                new President(4, "Алмазбек", "Атамбаев", "СДПК"),
                new President(5, "Сооронбай", "Жээнбеков", "СДПК"),
                new President(6, "Садыр", "Жапаров", "Мекенчил")
            };
            List<President> sdpkPresidents = presidents.FindAll(President.IsMemberOfTheSdpkParty);

            sdpkPresidents.Sort(President.CompareByName);

            foreach (President p in sdpkPresidents) {
                Console.WriteLine(p.Name);
            }
        }
    }
}
