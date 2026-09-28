using WebaruhazApp;

Termek termek1 = new Termek("Monitor", 80000);
AkciosTermek termek2 = new AkciosTermek("Billentyűzet", 20000, 20);

termek1.NettoAr = -5000;
termek2.KedvezmenySzazalek = 150;

Console.WriteLine(termek1);
Console.WriteLine(termek2);

Console.WriteLine($"Összes termék: {Termek.OsszesTermekSzama}");