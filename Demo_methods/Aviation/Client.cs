

namespace Aviation
{
    internal class Client
    {
        public static void Main(string[] args)
        {
            Shipper shipper = new Shipper();
            shipper.ShipStandard(2.2);
            shipper.ShipStandard(2.2, true);

            int estimatedDays = shipper.AirMail(2);
            System.Console.WriteLine(estimatedDays);
        }
    }
}
