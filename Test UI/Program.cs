using System.ComponentModel;
using System.ComponentModel.Design;
using test_logic;

var cars = new DoubleList<Cars>();
cars.Add(new Cars("Jeep", "clase a", 2023, "black", 53000000));
cars.Add(new Cars("Rolls Royce", "clase x", 2019, "white", 240000000));
cars.Add(new Cars("Mercedes Benz", "clase g", 2018, "grey", 59999000));
cars.Add(new Cars("chevrolet", "clase a", 2020, "red", 60000000));
cars.Add(new Cars("chevrolet",  "clase a",  2018, "white",  50000000));
cars.Add(new Cars("Mercedes Benz", "clase g", 2020, "white", 35700000));
cars.Add(new Cars("Jeep", "clase x", 2020, "black", 130450000));
cars.Add(new Cars("chevrolet",  "clase g",  2023,  "white", 47800000));
cars.Add(new Cars("Rolls Royce", "clase s", 2019, "grey", 200850000));
cars.Add(new Cars("Mercedes Benz", "clase x", 2018, "white", 44584000));
cars.Add(new Cars("Mercedes Benz",  "clase s",  2020,  "red", 120000000));
cars.Add(new Cars("Jeep", "clase a", 2019, "black", 155300000));

Console.WriteLine("         ---All the cars in the Concessionaire---");
Console.WriteLine("");
Console.WriteLine(cars);

Console.WriteLine("»» Choose a car by the brand you want...");
Console.WriteLine(cars.GetBrand("chevrolet"));

Console.WriteLine("»» Choose a car by typing two years they were made...");
Console.WriteLine(cars.GetYear(2018, 2019));

Console.WriteLine("»» Choose a car by the price...");
Console.WriteLine(cars.GetPrice(60000000, 140000000));

var minMax = cars.GetMinMaxPrice(cars);
Console.WriteLine("»» Car with lower price...");
Console.WriteLine(minMax[0]);
Console.WriteLine("   ");
Console.WriteLine("»» Car with higher price...");
Console.WriteLine(minMax[1]);
Console.WriteLine("   ");

Console.WriteLine("»» Choose a Car With Different Filtters");
Console.WriteLine(cars.GetSeveralFilters("*", "*", "*", 2010, 2020));
 

