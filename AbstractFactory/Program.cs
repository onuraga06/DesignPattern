using AbstractFactory.Class;
using AbstractFactory.InterFace;
using System;

namespace AbstractFactory
{
    class Program
    {//İlişkili sınıfların oluşturulmasında kullanılır.Farklı ürünlerin fabrikalarının soyutlanması olarak tanımlanbılır.
        static void Main(string[] args)
        {
            ITeam ankaraGucu = TeamFactory.GetTeam(new AnkaragucuFactory());
            Console.WriteLine("STAD={0} \nRenkler={1}", ankaraGucu.getStadium(), ankaraGucu.getTeamColor());
            Console.WriteLine("************************");
            var galatasaray = TeamFactory.GetTeam(new GalatasarayFactory());
            Console.WriteLine("STAD={0} \nRenkler={1}", galatasaray.getStadium(), galatasaray.getTeamColor());
            Console.ReadLine();
        }
    }
}
