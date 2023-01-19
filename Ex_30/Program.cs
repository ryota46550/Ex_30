using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("17",DateTime.Today,"松本",50,169,20,60);
            Console.WriteLine($"名前{student.Name},番号{student.ID},重さ{student.weight}kg");
            Worker worker = new Worker("プログラマー",DateTime.Today,"田中",74,172,20,70);
            Console.WriteLine($"名前{worker.Name},職業{worker.occupation},重さ{worker.weight}kg");
            Fish fish = new Fish("宮城", DateTime.Today, "さんま", 70, 15, 2, 150);
            Console.WriteLine($"名前{fish.Name},産地{fish.from},重さ{fish.weight}g");
            Refrigerator refrigerator = new Refrigerator(15, "MR-MB45H", 685, 1800, 650, 70);
            Console.WriteLine($"名前{refrigerator.Name},値段{refrigerator.price}万円,重さ{refrigerator.weight}kg");
            Insect insect = new Insect("コガネムシ", DateTime.Today, "ヘラクレスオオカブト", 3, 4, 14, 85);
            Console.WriteLine($"名前{insect.Name},{insect.type}科,体長{insect.depth}cm,重さ{insect.weight}g");
            Car car = new Car(532, "SSC トゥアタラ", 2, 1, 4,1247);
            Console.WriteLine($"名前{car.Name},最高速度{car.speed},車両重量{car.weight}kg");
            Cat cat = new Cat("スコティッシュフォールド", DateTime.Today, "なな", 50, 25, 10, 10);
            Console.WriteLine($"名前{cat.Name},種類{cat.type},重さ{cat.weight}kg");
            Giant giant = new Giant(DateTime.Today, "超大型巨人", 0, 60, 0, 0);
            Console.WriteLine($"名前超大型巨人,体長約{giant.height}m");


        }
    }
}
