// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Instanciar uma Universidade

Universidade UP = new Universidade();

UP.Nome = "Universidade Positivo";
UP.Localizacao = "praça Osório";
UP.AnoFundacao = 2016;

Console.WriteLine(UP.Nome);

// Criar um curso e adicionar na universidade

Curso ADS = new Curso();
ADS.Nome = " Análise e desenvolvimento de sistemas";
ADS.Area = "Computação";
ADS.Duracao = 2;

// Passo2: Adicionar o curso na Universidade
UP.AdiconarCurso(ADS);

Curso BSI = new Curso();
BSI.Nome = " BSI ";
BSI.Area = "Computação";
BSI.Duracao = 4;

UP.AdiconarCurso(BSI);

foreach(var Curso in UP.Cursos){
    Console.WriteLine(Curso.Nome +""+Curso.Area+"");
}