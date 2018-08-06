using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Assignment_18_07_2018_03
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PizzaOrder> list = new List<PizzaOrder> {
                new PizzaOrder { order_id =1001, order_date = DateTime.Now.Date, pizza_type = "Veg", pizza_size = 'S', toppings ="Sweet Corn", qty = 5 , price = 5000 },
                new PizzaOrder { order_id =1002, order_date = DateTime.Now.Date, pizza_type = "Non Veg", pizza_size = 'M', toppings ="Chicken", qty = 9 , price = 9600 },
                new PizzaOrder { order_id =1009, order_date = DateTime.Now.Date, pizza_type = "Non Veg", pizza_size = 'L', toppings ="Egg", qty = 6 , price = 5800 },
                new PizzaOrder { order_id =1003, order_date = DateTime.Now.Date, pizza_type = "Veg", pizza_size = 'M', toppings ="Onion", qty = 3 , price = 950 },
                new PizzaOrder { order_id =1007, order_date = DateTime.Now.Date, pizza_type = "Veg", pizza_size = 'L', toppings ="Capsicum", qty = 2 , price = 500 },
                new PizzaOrder { order_id =1006, order_date = DateTime.Now.Date, pizza_type = "Non Veg", pizza_size = 'L', toppings ="Chicken", qty = 5 , price = 2500 },
                new PizzaOrder { order_id =1008, order_date = DateTime.Now.Date, pizza_type = "Veg", pizza_size = 'M', toppings ="Tomato", qty = 8 , price = 7500 },
                new PizzaOrder { order_id =1005, order_date = DateTime.Now.Date, pizza_type = "Non Veg", pizza_size = 'S', toppings ="Egg", qty = 4 , price = 1900 }

            };

            Console.WriteLine("//*******************************************************************************************************//");
            Console.WriteLine("Display all pizza ordered");
            Console.WriteLine();
            foreach (var a in list)
                Console.WriteLine(" OrderID= " + a.order_id + " Order_Date= "+ a.order_date+ " Pizza_Type= "+a.pizza_type+" Pizza_Size= "+a.pizza_size+" Toppings= "+a.toppings+" Quantity= "+a.qty+" Price= "+a.price);
            Console.WriteLine();
            Console.WriteLine("//*******************************************************************************************************//");
            Console.WriteLine("Display Pizza based on PizzaType and PizzaSize");
            Console.WriteLine();
            var data = list.Where(x => x.pizza_size=='S' && x.pizza_type=="Non Veg");
            foreach (var a in data)
                Console.WriteLine(" OrderID= " + a.order_id + " Order_Date= " + a.order_date + " Pizza_Type= " + a.pizza_type + " Pizza_Size= " + a.pizza_size + " Toppings= " + a.toppings + " Quantity= " + a.qty + " Price= " + a.price);
            Console.WriteLine();
            Console.WriteLine("//*******************************************************************************************************//");
            Console.WriteLine("Display Count of Pizza Sold,");
            Console.WriteLine();
            var data1 = list.Count();
            Console.WriteLine("Count of the sold pizza = "+data1);
            Console.WriteLine();
            Console.WriteLine("//*******************************************************************************************************//");
            Console.WriteLine("Display Count of Pizza Sold, Amount Collected group by PizzaType");
            Console.WriteLine();
            var data2 = list.GroupBy(x => x.pizza_type).Select(x => new { Pizza_Type = x.Key, Amount_Collected = x.Sum(z => z.price) ,Count = x.Count()});
            foreach (var a in data2)
                Console.WriteLine("Pizza Type = "+a.Pizza_Type+ " Amount = "+a.Amount_Collected+" Count =  "+a.Count);
            Console.WriteLine();
            Console.WriteLine("//*******************************************************************************************************//");
            Console.WriteLine("Display Count of Pizza Sold , Amount Collected group by Pizza Size");
            Console.WriteLine();
            var data3 = list.GroupBy(x => x.pizza_size).Select(x => new { Pizza_Size = x.Key, Amount_Collected = x.Sum(z => z.price), Count = x.Count() });
            foreach (var a in data3)
                Console.WriteLine("Pizza Size = " + a.Pizza_Size  + " Amount = " + a.Amount_Collected + " Count =  " + a.Count);

            Console.WriteLine();
            Console.WriteLine("//*******************************************************************************************************//");
            Console.WriteLine("Display only PizzaType and Toppings where PizzaSize=’M’");
            Console.WriteLine();
            var data4 = list.Where(x => x.pizza_size == 'M').Select(x=> new { Pizza_Type = x.pizza_type , Toppings = x.toppings});
            foreach (var a in data4)
                Console.WriteLine("Pizza Type = " + a.Pizza_Type + " Toppings = " + a.Toppings );
            Console.WriteLine();
            Console.WriteLine("//*******************************************************************************************************//");
            Console.WriteLine("Display the Pizza Details which has the Max Price");
            Console.WriteLine();
            var data5 = list.Where(x => x.price == list.Max(y => y.price));
            foreach (var a in data5)
                Console.WriteLine(" Pizza_Size = "+a.pizza_size+" Pizza_Type = "+a.pizza_type + " Price = "+a.price+" Toppings =  "+a.toppings);
            Console.WriteLine();
            Console.WriteLine("//*******************************************************************************************************//");
            Console.WriteLine("Display the Pizza Details which has the Min Price");
            Console.WriteLine();

            var data6 = list.Where(x => x.price == list.Min(y => y.price));
            foreach (var a in data6)
                Console.WriteLine(" Pizza_Size = " + a.pizza_size + " Pizza_Type = " + a.pizza_type + " Price = " + a.price + " Toppings =  " + a.toppings);

            Console.WriteLine("END OF PROJECT!!!!");
            Console.WriteLine();
            Console.WriteLine("//*******************************************************************************************************//");
           
        }
    }
}
