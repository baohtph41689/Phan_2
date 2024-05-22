abstract class product
{
    public double price { get; set; }

    public abstract void getInfor();

}

 class iphone : product
{
    public iphone() {
        price = 2000;
    }
    public override void getInfor()
    {
        Console.WriteLine("this is a iphone 15 promax");
        Console.WriteLine($"gia iphone la :{price}$ ");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
      iphone IP = new iphone();
        IP.getInfor();
    }
}