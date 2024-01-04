
public class Car : IVehicle
{
    public int Kolich;
    public Car(int carkolich)
    {
        Kolich = carkolich;
    }

    public void Drive()
    {
        if (Kolich > 0)
        {
            System.Console.WriteLine("Вождение");
        }
    }
    public bool Refuel(int reful)
    {
        Kolich += reful;
        return true;
    }

    bool IVehicle.Refuel()
    {
        throw new NotImplementedException();
    }

    public Car() { }
}