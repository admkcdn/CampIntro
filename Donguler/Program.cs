// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.KursunEgitmeni = "Engin Demiroğ";
kurs1.IzlenmeOranı = 88;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.KursunEgitmeni = "Engin Demiroğ";
kurs2.IzlenmeOranı = 78;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.KursunEgitmeni = "Engin Demiroğ";
kurs3.IzlenmeOranı = 98;

Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

Console.WriteLine("**********");

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + ": " + kurs.KursunEgitmeni + " - " + kurs.IzlenmeOranı);
}

class Kurs
{
    public string KursAdi { get; set; }
    public string KursunEgitmeni { get; set; }
    public int IzlenmeOranı { get; set; }
}

