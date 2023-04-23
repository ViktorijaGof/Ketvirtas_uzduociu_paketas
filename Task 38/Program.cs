using System;

class Salis
{
    public string Pavadinimas;
    public string Prezidentas;
    public double Plotas;
    public int GyventojuSkaicius;
    public double VidutinisAtlyginimas;
    public int[] Augimas = new int[5];

    public Salis(string pavadinimas, string prezidentas, double plotas, int gyventojuSkaicius, double vidutinisAtlyginimas, int[] augimas)
    {
        Pavadinimas = pavadinimas;
        Prezidentas = prezidentas;
        Plotas = plotas;
        GyventojuSkaicius = gyventojuSkaicius;
        VidutinisAtlyginimas = vidutinisAtlyginimas;
        Augimas = augimas;
    }

    public Salis(string pavadinimas, double plotas, int gyventojuSkaicius, double vidutinisAtlyginimas)
    {
        Pavadinimas = pavadinimas;
        Plotas = plotas;
        GyventojuSkaicius = gyventojuSkaicius;
        VidutinisAtlyginimas = vidutinisAtlyginimas;
    }

    public Salis(string pavadinimas, string prezidentas, double plotas, int gyventojuSkaicius)
    {
        Pavadinimas = pavadinimas;
        Prezidentas = prezidentas;
        Plotas = plotas;
        GyventojuSkaicius = gyventojuSkaicius;
    }

    public Salis(string pavadinimas, double plotas)
    {
        Pavadinimas = pavadinimas;
        Plotas = plotas;
    }

    }

class Program
{
    static void Main(string[] args)
    {
        Salis s1 = new Salis("Lietuva", "Gitanas Nausėda", 65300, 2794700, 1200, new int[] { 0, 0, 0, 1, 1 });
    }
}
   