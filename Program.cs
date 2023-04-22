Console.WriteLine("--- Colonia de bacterias ---\n");

Console.Write("Digite o número de indivíduos na colônia de bactérias: ");
double n = double.Parse(Console.ReadLine()!);

double t = 2 * Math.Log2(n / 2000);

Console.WriteLine($"A colônia de bactérias atinge {n} indivíduos em {t} horas.");