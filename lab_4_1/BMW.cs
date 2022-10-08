using System.Diagnostics;

namespace Lab_4_1;

internal class BMW : Cars
{
    public BMW()
    {
    }

    public BMW(string model, int year, string body)
    {
        Model = model;
        Year = year;
        Body = body;
    }

    public void BInformation()
    {
        Debug.WriteLine($"Модель ({Model.GetType()}): {Model}");
        Debug.WriteLine($"Рік ({Year.GetType()}): {Year}");
        Debug.WriteLine($"Кузов ({Body.GetType()}): {Body}");
    }
}