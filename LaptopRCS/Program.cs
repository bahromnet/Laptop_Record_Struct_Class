using LaptopRCS.Houses;
using LaptopRCS.Laptop;
using LaptopRCS.Laptop.Enum;

namespace LaptopRCS
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            Music.playMusic("music.wav");

            var laptopClass = new LaptopC()
            {
                Model = "Asus",
                Display = "15,6 Dyum HD",
                CPU = "Intel(R) Core(TM) i3-3217U CPU @ 1.80GHz",
                VideoAdapter = "Radeon Vega 3 Graphics 2GB",
                Ram = 8,
                SSD = 256,
                HDD = 512,
                Color = Colors.Black,
            };

            var laptopRecord = new LaptopR()
            {
                Model = "Lenovo",
                Display = "15,6 Dyum HD TN",
                CPU = "Intel Celeron N4020 1.10GHz Turbo 2.80GHz ",
                VideoAdapter = "INTEGRATED",
                Ram = 4,
                SSD = 256,
                HDD = 0,
                Color = Colors.White,
            };

            var laptopRecordWith = laptopRecord with
            {
                Model = "Acer",
                CPU = "Intel Core i7-1065G7 | 10-Pokoleniya Turbo 3.90GHz",
                VideoAdapter = " Intel Iris Plus Graphics |+NVIDIA GeForce MX330 2GB",
                Ram = 16,
            };

            var laptopStruct = new LaptopS()
            {
                Model = "Hp",
                Display = "15,6 Dyum FHD IPS",
                CPU = "Intel Core i5-1135G7 | 11-Pokoleniya 2.40GHz",
                VideoAdapter = "Intel Iris Graphics",
                Ram = 8,
                SSD = 512,
                HDD = 0,
                Color = Colors.Black,
            };

            bool isTrue = true;
            while (isTrue)
            {
                Console.WriteLine();
                Console.WriteLine("|-LAPTOPS-------------------------|");
                Console.WriteLine("|1 -> Asus                        |");
                Console.WriteLine("|2 -> Lenovo                      |");
                Console.WriteLine("|3 -> Hp                          |");
                Console.WriteLine("|4 -> Acer                        |");
                Console.WriteLine("|5 -> Exit                        |");
                Console.WriteLine("|---------------------------------|");

                int a = int.Parse(Console.ReadLine()!);

                switch (a)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(laptopClass.on());
                        Console.WriteLine(laptopClass.ToString());
                        Console.WriteLine(laptopClass.restart());
                        Console.WriteLine();
                        Console.WriteLine(laptopClass.off());
                        Console.WriteLine("---------------------------------------------------");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(laptopRecord.on());
                        Console.WriteLine(laptopRecord.ToString());
                        Console.WriteLine(laptopRecord.restart());
                        Console.WriteLine();
                        Console.WriteLine(laptopRecord.off());
                        Console.WriteLine("---------------------------------------------------");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(laptopStruct.on());
                        Console.WriteLine(laptopStruct.ToString());
                        Console.WriteLine(laptopStruct.restart());
                        Console.WriteLine();
                        Console.WriteLine(laptopStruct.off());
                        Console.WriteLine("---------------------------------------------------");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine(laptopRecordWith.ToString());
                        Console.WriteLine("---------------------------------------------------");
                        break;
                    case 5:
                        isTrue = false;
                        break;
                    default:
                        Console.WriteLine("Qaytadan urining...");
                        break;
                }
            }
            Console.WriteLine();
            var lapRec = laptopRecord;
            var lapRec2 = new LaptopR();
            Console.WriteLine(laptopRecord.Equals(lapRec));
            Console.WriteLine(ReferenceEquals(laptopRecord, lapRec));
            Console.WriteLine(laptopRecord == laptopRecordWith);
            Console.WriteLine(ReferenceEquals(laptopRecord, laptopRecordWith));
            //Console.WriteLine(lapRec2.ToString());

            Console.WriteLine("---------------------------------------------------");

            var house = new House(Colors.White, 4, 2);
            Console.WriteLine(house.ToString());
            Console.ReadKey();
        }
    }
}