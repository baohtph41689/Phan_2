
using System.Linq;
using System.Threading.Channels;
using productCar;
internal class Program

{
        private static void Main(string[] args)
    {
        car camrry = new car();
        camrry.Name = "Camrry";
        camrry.Color = "black";
        camrry.Power = 500;
        camrry.getInfor();
    }
}