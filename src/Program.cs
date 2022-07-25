using Geometry;
using FirstAccount;

class Program
{
    static void Main()
    {
        Geometry.Geometry geometry = new Geometry.Geometry();
        geometry.DrawGeometricShapes();
    
        Bank bank = new Bank();
        bank.GetBankAccount();
    }
}