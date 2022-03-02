using System;
using System.Collections.Generic;

namespace PrototypePattern
{
    class Program
    { //bir objenin özelliklerine sahip olan aynı tipte bir obje yaratmak istiyorsak kullanırız. Yeni clonelanacak nesne orjinal nesnenin özelliklerini etkilemez.
        static void Main(string[] args)
        {
            //var dailymeetingmorning = new DailyMeeting()
            //{
            //    StarTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy.MM.dd 08:00")),
            //    EndTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy.mm.dd 08:15")),
            //    Location = "Balat-302",
            //    Materials = new List<string>
            //{
            //    "projeksiyon cihazı","laptop","notepad"
            //},
            //    Participants = new List<string>
            //{
            //        "Eda","Leyla","Sinem","Mehmet"
            //},
            //    Summary = "Toplantıda alınan kararlar..."

            //};

            //var dailymeetingmoon = dailymeetingmorning.Clone();
            //dailymeetingmoon.StarTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy.mm.dd 12:00"));

            //dailymeetingmoon.EndTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy.mm.dd 12:15"));
            //var dailymeetingNight = dailymeetingmorning.Clone();
            //dailymeetingNight.StarTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy.mm.dd 20:00"));

            //dailymeetingNight.EndTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy.mm.dd 20:15"));
            //Console.WriteLine(string.Format("Sabah oturumu :{0}-{1}", dailymeetingmorning.StarTime, dailymeetingmorning.EndTime));
            //Console.WriteLine(string.Format("Öğlen oturumu :{0}-{1}", dailymeetingmoon.StarTime, dailymeetingmoon.EndTime));
            //Console.WriteLine(string.Format("Akşam oturumu :{0}-{1}", dailymeetingNight.StarTime, dailymeetingNight.EndTime));


            //Kolandıgımız Nesne her zaman sabit kalır degısım olmaz
            //Her Colandıgımız nesneye verdıgımız ozellıklere gore degısıtır
            //Verdıgımız ozellık degısıtır dıgerlerı aynı kalır. Ilk Kolon Sabt Kalır
            //1 Kolondan Aldıgı ozellıkler 2 kolana dırek gecer. Kolanlardan Ozellık Alında degıstıreln kısım sadece degısır dıger kısımlar aynı Kalır
            //1 Kolon 2 Kolondan yada 5 ıncı Kolon Dıger Herhangı bır kolondan ornek Alablır.
            var gamings = new Gamings()
            {
                Name = "PUBG ",
                Size = 50,
                Tur="Aksiyon",
                Materials = new List<string>
            {
                "Sound","Sensivitiy","Grafik"
            },
                Katılımcılar = new List<string>
            {
                    "Onur","Faruk","Orkun","Kadir"
            },
                Summary = "Oyun içi Buglar..."

            };
            //Degısterılecek Ogelerı New yapmadan Clonlayarak devam edıyoruz.
            var gamingsname = gamings.Clone();
            gamingsname.Name = "PUBG NEW STATE ";
            gamingsname.Size = 500;
            var gamingName2 = gamings.Clone();
            gamingName2.Tur = "Video Oyun Serisi";

            Console.WriteLine("###Oyun Versiyon 2.0 Bilgileri### \nGame={0} \nTur={1} \nSize={2}GB", gamings.Name, gamings.Tur, gamings.Size);
            Console.WriteLine("************");
            Console.WriteLine("###Oyun Versiyon 4.0 Bilgileri### \nGame={0}  \nTur={1} \nSize={2}GB", gamingsname.Name,gamingsname.Tur, gamingsname.Size);
            Console.WriteLine("************");
            Console.WriteLine("###Oyun Versiyon 6.0 Bilgileri### \nGame={0}  \nTur={1} \nSize={2}GB", gamingName2.Name, gamingName2.Tur, gamingName2.Size);
            Console.WriteLine("************");
            foreach (var item in gamings.Katılımcılar)
            {
                Console.WriteLine("Gamer List=" + item);
            }
            Console.WriteLine("************");
            foreach (var item in gamingsname.Materials)
            {
                Console.WriteLine("Gaming List=" + item);
            }
            Console.WriteLine("************");
            Console.WriteLine("Oyun ile Hakkında Araştırma=" + gamings.Summary);
            Console.ReadLine();
        }
    }
}