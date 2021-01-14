using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3_laba.Class_interface
{
    public class menu
    {
        public List<bludo> list_of_order = new List<bludo>();
        public menu()
        {
            bludo Okroshka_with_kvass = new cold_food("Окрошка с квасом", 100, 30, 300, 10);
            bludo Okroshka_with_kefir = new cold_food("Окрошка с кефиром", 100, 30, 300, 10);
            bludo Sushi = new cold_food("Суши", 250, 25, 150, 15);
            bludo Beetroot = new cold_food("Свекольник", 100, 25, 300, 10);
            bludo Cold_ear = new cold_food("Холодная уха", 100, 40, 300, 10);

            bludo Water = new drink("Вода", 10, 0, 300, 0);
            bludo Beer = new drink("Пиво", 150, 75, 300, 0);
            bludo Vodka = new drink("Водка", 100, 25, 50, 2);
            bludo Green_tea = new drink("Зелёный чай", 100, 25, 300, 5);
            bludo Black_tea = new drink("Чёрный чай", 100, 25, 300, 5);

            bludo Risoto = new hot_food("Ризото", 250, 100, 300, 10);
            bludo Rise = new hot_food("Рис", 50, 10, 150, 8);
            bludo Meat = new hot_food("Мясо", 100, 25, 50, 2);
            bludo Fisch = new hot_food("Рыба", 100, 25, 50, 2);
            bludo karrot = new hot_food("Морковка", 30, 5, 50, 3);

            bludo Cheese_balls = new snak("Сырные шарики", 100, 25, 100, 5);
            bludo Toast = new snak("Гренки", 50, 5, 100, 5);
            bludo Fried_onion = new snak("Луковые кольца", 50, 5, 50, 5);
            bludo Fried_potatoes = new snak("Картошка фри", 50, 5, 100, 5);
            bludo Fish_straw = new snak("Рыбная соломка", 60, 5, 50, 0);

            bludo Ice_cream = new sweets("Мороженное", 75, 10, 250, 0);
            bludo Jelly = new sweets("Желе", 60, 10, 50, 0);
            bludo Cheesecake = new sweets("Чизкейк", 100, 25, 75, 0);
            bludo Sponge_cake = new sweets("Бисквитный торт", 100, 25, 75, 0);
            bludo Milk_shake = new sweets("Молочный коктель", 75, 15, 200, 5);

            list_of_order.Add(Okroshka_with_kvass);  
            list_of_order.Add(Okroshka_with_kefir);
            list_of_order.Add(Sushi);
            list_of_order.Add(Beetroot);
            list_of_order.Add(Cold_ear);

            list_of_order.Add(Water);
            list_of_order.Add(Beer);
            list_of_order.Add(Vodka);
            list_of_order.Add(Green_tea);
            list_of_order.Add(Black_tea);

            list_of_order.Add(Risoto);
            list_of_order.Add(Rise);
            list_of_order.Add(Meat);
            list_of_order.Add(Fisch);
            list_of_order.Add(karrot);

            list_of_order.Add(Cheese_balls);
            list_of_order.Add(Toast);
            list_of_order.Add(Fried_onion);
            list_of_order.Add(Fried_potatoes);
            list_of_order.Add(Fish_straw);

            list_of_order.Add(Ice_cream);
            list_of_order.Add(Jelly);
            list_of_order.Add(Cheesecake);
            list_of_order.Add(Sponge_cake);
            list_of_order.Add(Milk_shake);
        }
    }
}
