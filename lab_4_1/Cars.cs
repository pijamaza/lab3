using System.Diagnostics;

namespace Lab_4_1;

internal class Cars
{
    public Cars()
    {
    }

    public Cars( string model, int year, string body, string brand)
    {
        Model = model;
        Year = year;
        Body = body;
        Brand = brand;
    }

    public string Model { get; set; }
    public int Year { get; set; }
    public string Body { get; set; }
    public string Brand { get;set; }

    public void Information()
    {
        
        Debug.WriteLine($"Имя ({Model.GetType()}): {Model}");
        Debug.WriteLine($"Возраст ({Year.GetType()}): {Year}");
        Debug.WriteLine($"Кузов ({Body.GetType()}): {Body}");
        Debug.WriteLine($"Марка ({Brand.GetType()}): {Brand}");
    }
}