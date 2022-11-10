using SOLID.ISP.Common;

namespace SOLID.ISP.Incorrect;

public interface ITax
{
    Invoice GenerateInvoce();
    double GenerateTax(double value);
}

public class Iss : ITax
{
    public Invoice GenerateInvoce() => new Invoice();

    public double GenerateTax(double value) => value * 0.1;
}

public class Ixmx : ITax
{
    public Invoice GenerateInvoce() => throw new NotSupportedException();

    public double GenerateTax(double value) => value * 0.2;
}

// A interface ITax não é coesa
// A interface ITax está obrigado a classe Ixmx implementar algo que não é preciso