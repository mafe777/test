using System.ComponentModel.Design;
using test_logic;

Console.WriteLine("*...Concessionaire...*");
var cars = new DoubleList<Cars>();
cars.Add(new Cars { Brand = "Jeep", Model = "clase a", Year = 2023, Color = "black", Price = 53000000});
cars.Add(new Cars { Brand = "Rolls Royce", Model = "clase x", Year = 2019, Color = "white", Price = 240000000 });
cars.Add(new Cars { Brand = "Mercedes Benz", Model = "clase g", Year = 2018, Color = "grey", Price = 59999000});
cars.Add(new Cars { Brand = "chevrolet", Model = "clase a", Year = 2020, Color = "red", Price = 60000000 });
cars.Add(new Cars { Brand = "chevrolet", Model = "clase a", Year = 2018, Color = "white", Price = 50000000 });
cars.Add(new Cars { Brand = "Mercedes Benz", Model = "clase g", Year = 2020, Color = "white", Price = 35700000 });
cars.Add(new Cars { Brand = "Jeep", Model = "clase x", Year = 2020, Color = "black", Price = 130450000});
cars.Add(new Cars { Brand = "Rolls Royce", Model = "clase s", Year = 2019, Color = "grey", Price = 200850000});
cars.Add(new Cars { Brand = "Mercedes Benz", Model = "clase x", Year = 2018, Color = "red", Price = 44584000});
cars.Add(new Cars { Brand = "Mercedes Benz", Model = "clase s", Year = 2020, Color = "red", Price = 120000000  });
cars.Add(new Cars { Brand = "chevrolet", Model = "clase g", Year = 2023, Color = "white", Price = 47800000 });
cars.Add(new Cars { Brand = "Jeep", Model = "clase a", Year = 2019, Color = "black", Price = 155300000});
Console.WriteLine(cars);

int option;
do
{
    option = Menu();
    switch (option)
    {
        case 1: choosecarsbybrand(); break;
        case 2: choosecarsbyyear(); break;
        case 3: choosecarsbyprice(); break;
    }
} while (option != 0);

void choosecarsbyprice()
{
    throw new NotImplementedException();
}

void choosecarsbyyear()
{
    throw new NotImplementedException();
}

void choosecarsbybrand()
{
    throw new NotImplementedException();
}

int Menu()
{
    Console.WriteLine("1.Choose a Car By The Brand");
    Console.WriteLine("2.Choose a Car By The Year");
    Console.WriteLine("3.Choose a Car By The Price");
    Console.WriteLine("0.Exit");
    var option = Console.ReadLine();
    return Convert.ToInt32(option);
}