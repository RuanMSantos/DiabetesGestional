/*
Segundo a Sociedade Brasileira de Diabetes¹, a avaliação de Diabetes em grávidas é realizada através de um exame de glicemia comparado com a tabela abaixo:
*/

Console.Clear();

Console.WriteLine("\n-----Teste o nível de sua glicose-----\n");

int glicose;

Console.Write("Escreva o nível de sua glicose: ");
glicose = Convert.ToInt32(Console.ReadLine());

if (glicose < 92)
{
    Console.WriteLine("Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
}

else if (glicose >= 92 && glicose < 126)
{
    Console.WriteLine("Compatível com Diabetes Gestacional");
}

else
{
    Console.WriteLine("Diabetes Mellitus na Gravidez");
}