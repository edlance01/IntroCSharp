
class Shipper : Object
{
    //public static void Main(string[] args)
    //{
    //    Shipper shipper = new Shipper();
    //    shipper.ShipStandard(2.2);
    //    shipper.ShipStandard(2.2, true);

    //    int estimatedDays = shipper.AirMail(2);
    //    System.Console.WriteLine(estimatedDays);
    //}

    internal void ShipStandard(double weight)
    {
        Console.WriteLine($"Your {weight} lb package is being shipped");
    }

    //Overloading ShipStandard
    internal void ShipStandard(double weight, bool insured)
    {
        Console.WriteLine($"Shipping your {weight} package.  Insured = {insured}");
    }

    internal int AirMail(int days)
    {
        Console.WriteLine($"Your package will arrive in {days} days(s).");
        return days;
    }
}