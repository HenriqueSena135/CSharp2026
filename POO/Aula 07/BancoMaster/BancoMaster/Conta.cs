

namespace BancoMaster;

 internal class Conta
{
    private int numero;
    private string titular;
    private double saldo;

    public int Numero
    {
        get { return numero; }
        set { numero = value; }
    }

    public string Titular
    {
        get { return titular; }
        set { titular = value; }
    }

    public double Saldo
    {
        get { return saldo; }
        protected set { saldo = value; }
    }

    public Conta(int numero, string titular, double saldoInicial)
    {
        numero = numero;
        titular = titular;
        saldo = saldoInicial;
    }

    public virtual void Saque(double quantia)
    {
        saldo -= quantia + 5.0; // taxa
    }

    public void Deposito(double quantia)
    {
        saldo += quantia;
    }
}








