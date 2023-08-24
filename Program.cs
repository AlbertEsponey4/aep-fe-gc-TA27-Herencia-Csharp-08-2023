

// M5 : JOBS
abstract class Employee
{
    public string nom;
    public double salari;
    public double salariBrut;

    public Employee(string nom, double salariBrut)
    {
        this.nom = nom;
        salari = 0;
        this.salariBrut = salariBrut;
    }

    public abstract double CalcularSalari(double salari);

    public void BonusSalarial()
    {
        salari = salari * 1.1;
    }
}

class Manager : Employee
{
    public Manager(string nom, double salariBrut) : base(nom, salariBrut) {
        salari = CalcularSalari(salariBrut * 0.74); // calculem el salari final a partir del salari brut havent tret l'IRPF del 26%
    }

    public override double CalcularSalari(double salari)
    {
        return salari * 1.1;
    }
}

class Boss : Employee
{
    public Boss(string nom, double salariBrut) : base(nom, salariBrut) {
        salari = CalcularSalari(salariBrut * 0.68); // IRPF del 32%
    }

    public override double CalcularSalari(double salari)
    {
        if (salari < 8000)
            throw new Exception("Ha de cobrar mes de 8000€");
        return salari * 1.5;
    }
}

class Junior : Employee
{
    public Junior(string nom, double salariBrut) : base(nom, salariBrut) {
        salari = CalcularSalari(salariBrut * 0.98); // IRPF del 2%
    }

    public override double CalcularSalari(double salari)
    {
        if (salari < 900 || salari > 1600)
            throw new Exception("El sou ha d'estar entre 900 i 1600€");
        return salari * 0.85;
    }
}

class Mid : Employee
{
    public Mid(string nom, double salariBrut) : base(nom, salariBrut) {
        salari = CalcularSalari(salariBrut * 0.85); // IRPF del 15%
    }

    public override double CalcularSalari(double salari)
    {
        if (salari < 1800 || salari > 2500)
            throw new Exception("El salari ha d'estar entre 1800 i 2500€");
        return salari * 0.9;
    }
}

class Senior : Employee
{
    public Senior(string nom, double salariBrut) : base(nom, salariBrut) {
        salari = CalcularSalari(salariBrut * 0.76); // IRPF del 24%
    }

    public override double CalcularSalari(double salari)
    {
        if (salari < 2700 || salari > 4000)
            throw new Exception("El salari ha de ser entre 2700 i 4000€");

        return salari * 0.95;
    }
}

class Volunteer : Employee
{
    public double ajuda;

    public Volunteer(string nom, double ajuda) : base(nom, 0) 
    {
        this.ajuda = ajuda;
    }

    public override double CalcularSalari(double salari)
    {
        return 0;
    }
}

// M6 EXERCICI VEHICLES



class Porgrama
{
    static void Main(string[] args)
    {

    }
}