string? valor;
double[] salario = new double[5];

//Declarar os salários
for (int i = 0; i < 5; i++)
{
    do
    {
        Console.WriteLine("Digite o " + (i + 1) + "º salário: ");
        valor = Console.ReadLine();
        Double.TryParse(valor, out salario[i]);
    } while (salario[i] < 0);
    if (salario[i] < 1000)
    {
        salario[i] += (salario[i] * 10)/100;
    }
}

Console.WriteLine("");

//Mostrar o salário
for (int j = 0; j < 5; j++)
{
    Console.WriteLine((j+1) + "º salário: " + salario[j]);
}

// Tem medo do escuro? É sábio - Cho'gath
