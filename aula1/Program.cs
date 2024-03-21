// See https://aka.ms/new-console-template for more information

// instanciar um objeto da classe cliente

Console.WriteLine("Hello, World!");

cliente objCliente = new cliente();
cliente objCliente2 = new cliente();

objCliente.nome = "Pedro de Lara";
objCliente.cpf = "888";
objCliente.idade = 17;

Console.WriteLine(objCliente.nome);
Console.WriteLine(objCliente.cpf);

objCliente.salvar();

objCliente2.nome = "Araci de Almeida";
objCliente2.cpf = "888";
objCliente2.idade = 21;

Console.WriteLine(objCliente2.nome);
Console.WriteLine(objCliente2.cpf);

objCliente2.salvar();


