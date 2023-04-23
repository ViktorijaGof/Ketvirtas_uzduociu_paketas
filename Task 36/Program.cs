using System;
using System.Collections.Generic;

class Mokinys
{
    // Kintamieji
    public string vardas;
    public string pavardė;
    public int amžius;
    public string klasė;
    public List<int> pažymiai;

    // Konstruktorius
    public Mokinys(string vardas, string pavardė, int amžius, string klasė, List<int> pažymiai)
    {
        this.vardas = vardas;
        this.pavardė = pavardė;
        this.amžius = amžius;
        this.klasė = klasė;
        this.pažymiai = pažymiai;
    }

    // Metodas, kuris išveda visą informaciją apie mokinį
    public void IšvestiInformaciją()
    {
        Console.WriteLine("Vardas: " + vardas);
        Console.WriteLine("Pavardė: " + pavardė);
        Console.WriteLine("Amžius: " + amžius);
        Console.WriteLine("Klasė: " + klasė);
        Console.WriteLine("Pažymiai: " + string.Join(", ", pažymiai));
    }

    // Metodas, kuris išveda, už kiek metų mokinys baigs mokyklą
    public void BaigimoMetai()
    {
        int metai = 12 - amžius;
        if (metai == 0)
        {
            Console.WriteLine("Mokinys mokyklą baigs šiais metais.");
        }
        else
        {
            Console.WriteLine("Mokinys mokyklą baigs po " + metai + " metų.");
        }
    }

    // Metodas, kuris suskaičiuoja kiek pažymių didesnių už 4
    public int DidesniUzKeturi()
    {
        int skaičius = 0;
        foreach (int pažymys in pažymiai)
        {
            if (pažymys > 4)
            {
                skaičius++;
            }
        }
        return skaičius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Sukuriam 3 objektus
        Mokinys mokinys1 = new Mokinys("Jonas", "Jonaitis", 16, "10B", new List<int> { 8, 7, 9, 6, 8 });
        Mokinys mokinys2 = new Mokinys("Petras", "Petraitis", 15, "9A", new List<int> { 7, 8, 6, 5, 9 });
        Mokinys mokinys3 = new Mokinys("Ona", "Onaitė", 17, "11C", new List<int> { 9, 9, 10, 8, 7 });

        // Išvedam informaciją apie kiekvieną mokinį
        Console.WriteLine("Mokinys 1:");
        mokinys1.IšvestiInformaciją();
        Console.WriteLine();

        Console.WriteLine("Mokinys 2:");
        mokinys2.IšvestiInformaciją();
    }
}