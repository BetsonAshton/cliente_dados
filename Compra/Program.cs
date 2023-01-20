using Compra.Entities;

Console.WriteLine("\n *** CADASTRO DO PEDIDO *** \n");

var pedido = new Pedido();
pedido.Cliente = new Cliente();
pedido.Endereco = new Endereco();

pedido.Id = Guid.NewGuid();



Console.Write("Informe a Data do Pedido....: ");
pedido.DataPedido = DateTime.Parse(Console.ReadLine());

Console.Write("Informe o valor do Pedido....: ");
pedido.ValorPedido = decimal.Parse(Console.ReadLine());

Console.WriteLine("\n Dados do Pedido do Cliente\n");

pedido.Cliente.Idcliente = Guid.NewGuid();

Console.Write("Informe o Nome do cliente...: ");
pedido.Cliente.Namecliente = Console.ReadLine();

Console.Write("Informe o Cpf do cliente...: ");
pedido.Cliente.Cpf = Console.ReadLine();

Console.Write("Informe o Email do Cliente....: ");
pedido.Cliente.Email = Console.ReadLine();

Console.Write("Informe o Telefone do Cliente....: ");
pedido.Cliente.Telefone = Console.ReadLine();

Console.WriteLine("\nInforme o Endereço do Cliente\n");

pedido.Endereco.IdEndereco = Guid.NewGuid();

Console.Write("Informe o Logradouro....: ");
pedido.Endereco.Logradouro = Console.ReadLine();

Console.Write("Informe o Complemento....: ");
pedido.Endereco.Complemento = Console.ReadLine();

Console.Write("Informe o Bairro....: ");
pedido.Endereco.Bairro = Console.ReadLine();

Console.Write("Informe a Cidade....: ");
pedido.Endereco.Cidade = Console.ReadLine();

Console.Write("Informe o Estado....: ");
pedido.Endereco.Estado = Console.ReadLine();

Console.Write("Informe o Cep...: ");
pedido.Endereco.Cep = Console.ReadLine();

Console.WriteLine("\nDados do Pedido\n");

Console.WriteLine($"\tId do Pedido....: {pedido.Id}");
Console.WriteLine($"\tData dp Pedido....: {pedido.DataPedido}");
Console.WriteLine($"\tValor do Pedido....: {pedido.ValorPedido}");

Console.WriteLine($"\tId do Cliente....: {pedido.Cliente.Idcliente}");
Console.WriteLine($"\tNome do Cliente....: {pedido.Cliente.Namecliente}");
Console.WriteLine($"\tCpf do Cliente....: {pedido.Cliente.Cpf}");
Console.WriteLine($"\tEmail do Cliente....: {pedido.Cliente.Email} ");
Console.WriteLine($"\tTelefone do Cliente....: {pedido.Cliente.Telefone}");

Console.WriteLine($"\tId do endereço....: {pedido.Endereco.IdEndereco}");
Console.WriteLine($"\tLogradouro .....: {pedido.Endereco.Logradouro}");
Console.WriteLine($"\tComplemento....: {pedido.Endereco.Complemento}");
Console.WriteLine($"\tBairro....: {pedido.Endereco.Bairro}");
Console.WriteLine($"\tCidade....: {pedido.Endereco.Cidade}");
Console.WriteLine($"\tEstado....:{pedido.Endereco.Estado}");
Console.WriteLine($"\tCep....: {pedido.Endereco.Cep}");

