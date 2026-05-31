Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua idade:");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Você trabalha? (s/n)");
string resposta = Console.ReadLine().ToLower();
if(resposta == "s")
{
    Console.WriteLine("Digite sua profissao:");
    string profissao = Console.ReadLine();

    Console.WriteLine($"Olá, {nome}! Você tem {idade} anos e trabalha como {profissao}.");

}
else if(resposta =="n")
{
    Console.WriteLine($"Olá, {nome}! Você tem {idade} anos e não trabalha.");
}
else
{
    Console.WriteLine("Resposta inválida. Por favor, responda com 's' ou 'n'.");
}

Console.WriteLine("Programa encerrado! Tenha um bom dia!");
