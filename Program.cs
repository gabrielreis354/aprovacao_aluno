/*
    3 notas, as duas maiores compõe a média simples do semestre;

    inferior a 4 => reprovado diretamente;
    igual ou superior 4 e inferior a 6.9 => em exame com oportunidade de uma nova prova de avaliação;
    superior a 7 => aprovado diretamente;

    exame: a média simples da nota do semestre com a nota do novo exame;
    inferior a 5 => reprovado;
    igual ou superior a 5 => aprovado;
*/

static double Solicitar_Nota(string msg) 
{
    Console.WriteLine($"{msg}");
    double nota = double.Parse(Console.ReadLine() ?? "");

    if (nota is >= 0 and <= 10)
    {
        return nota;
    }
    else
    {
        return -1;
    }    
}

static double CalcularMediaSemestre(double nota1, double nota2, double nota3)
{
    List<double> notas = [nota1, nota2, nota3];
    double menor_nota = 10;

    for (var i = 0; i < 3; i++)
    {
        if (menor_nota > notas[i]) 
            menor_nota = notas[i];
    };

    return (nota1 + nota2 + nota3 - menor_nota) / 2;
}

static double Media_Final(double mediaSemestre ) 
{
    double nota_exame = Solicitar_Nota("Informe a nota tirada do exame: ");
    return (mediaSemestre  + nota_exame) / 2;

}

double nota1 = Solicitar_Nota("Digite sua primeira nota: ");
double nota2 = Solicitar_Nota("Digite sua segunda nota: ");
double nota3 = Solicitar_Nota("Digite sua terceira nota: ");

double mediaSemestre = CalcularMediaSemestre(nota1, nota2, nota3);

if (mediaSemestre < 4) 
{
    Console.WriteLine($"Você foi reprovado diretamente com a nota semestral de {mediaSemestre:N2}");
    
} else if (mediaSemestre is >= 4 and <= 6.9)
{
    Console.WriteLine($"\nVocê está em exame com nota semestral de {mediaSemestre:N2}");
    double mediaExame = Media_Final(mediaSemestre);

    if (mediaExame < 5)
        Console.WriteLine($"Você foi reprovado com a nota final de {mediaExame:N2}");
    else 
        Console.WriteLine($"Parabéns !! Você foi aprovado com a nota final de {mediaExame:N2}");

} else {
    Console.WriteLine($"Parabéns !! Você foi aprovado diretamente com a nota final de {mediaSemestre:N2}");
};

