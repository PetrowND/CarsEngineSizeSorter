using CarsSorter;

int n = int.Parse(Console.ReadLine());
List<Cars> cars = new List<Cars>();

for (int i = 0; i < n; i++)
{
    string data = Console.ReadLine();
    string[] dataParts = data.Split();

    string carBrand = dataParts[0];
    string carModel = dataParts[1];
    double carEngineSize = double.Parse(dataParts[2]);

    Cars car = new Cars(carBrand, carModel, carEngineSize);
    cars.Add(car);
}

cars = cars.OrderByDescending(s => s.CarEngineSize).ToList();

foreach (Cars car in cars)
{
    Console.WriteLine($"{car.CarBrand} {car.CarModel}: {car.CarEngineSize}");
}