
interface IHinhhoc
{
    public double chuVi();
    public double dienTich();

}

class hcn : IHinhhoc
{   
    double a {  get; set; }
    public double b { get; set; }
    public hcn(double _a , double _b)
    {
        a= _a;
        b = _b;
    }
    public double chuVi()
    {
      return 2*(a+b);
    }

    public double dienTich()
    {
        return a*b;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        hcn hinhHoc = new hcn(4.5,5.5);
       
        Console.WriteLine("chu vi la: {0}",hinhHoc.chuVi());
        Console.WriteLine("dien tich la : {0}",hinhHoc.dienTich());
    }
}