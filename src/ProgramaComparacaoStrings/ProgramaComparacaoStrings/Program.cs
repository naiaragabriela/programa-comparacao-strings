Console.WriteLine("Digite a primeira palavra para comparação");
string palavra1= Console.ReadLine();

Console.WriteLine("Digite a segunda palavra para comparação");
string palavra2= Console.ReadLine();

void ComparacaoString()
{
    if (palavra1 != palavra2)
    {
        
        Console.WriteLine("As palavras não são iguais");
    }
    else
    { 

        Console.WriteLine("As palavras são iguais");
    }
}
ComparacaoString();