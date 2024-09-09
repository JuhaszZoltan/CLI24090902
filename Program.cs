using CLI24090902;

List<Keres> keresek = [];
using StreamReader sr = new(@"..\..\..\src\NASAlog.txt");
while (!sr.EndOfStream) keresek.Add(new(sr.ReadLine()));

Console.WriteLine($"5. feladat: keresek szama: {keresek.Count}");

int? osszMeret = keresek.Sum(k => k.Meret);
Console.WriteLine($"6. feladat: valaszok osszes merete: {osszMeret} byte");

int vanDomain = keresek.Count(k => k.Domain);
Console.WriteLine($"8. feladat: domain-es keresek: " +
    $"{vanDomain / (float)keresek.Count * 100:0.00}%");

var staisztika = keresek.GroupBy(k => k.Kod);
Console.WriteLine("9. feladat: statisztika:");
foreach (var grp in staisztika)
{
    Console.WriteLine($"\t{grp.Key}: {grp.Count()} db");
}