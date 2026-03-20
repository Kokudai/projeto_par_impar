using System;
using System.Globalization;
using System.Linq;
public class Program
{
	public static void Main()
	{
        Console.WriteLine("Bem vindo(a) ao meu primeiro projeto pessoal, prazer! me chamo Henzo Kokudai da Silva e sou aluno da CUFSA - Centro Universitário Fundação Santo André!");
		Console.WriteLine();
		Console.WriteLine("Digite um número:");
		int A;
		string entradaA = Console.ReadLine();
		while (!int.TryParse(entradaA, out A))
			   {
			Console.WriteLine();
		    Console.WriteLine("Entrada inválida, responda somente com números:");
		    entradaA = Console.ReadLine();
			   }

		Console.WriteLine();
		Console.WriteLine($"Números de 0 até {A} reveleando se são par ou ímpar:");
		Console.WriteLine("");
		for (int i = 0; i <=A ; i++)
		{
			bool par = (i % 2 == 0);
			if (par)
			{
				Console.WriteLine(i + " É par ");
			}
			else
			{
				Console.WriteLine(i + " É impar ");
			}
		}
		Console.WriteLine("");
		Console.WriteLine($"Tabuada do {A}:");
		Console.WriteLine("");
		for (int i = 1; i <=10; i++)
		{
			int resultado = A * i;
			bool par2 = (resultado % 2 == 0);
			if (par2)
			{
				Console.WriteLine(A + " x " + i + " = " + resultado + " É par");
			}
			else
			{
				Console.WriteLine(A + " x " + i + " = " + resultado + " É impar");
			}
		}

 
		Console.WriteLine("");
		Console.WriteLine("Prontinho, a tabuada e a contagem, te mostrando todos os impares e pares!");
		Console.WriteLine("");
		Console.WriteLine($"{A} é um número grande?");
		Console.WriteLine("");
		bool grande = (A > 20);
			if (grande)
			{
				Console.WriteLine("É grande já, lá ele!");
			}
			else
			{
			 	Console.WriteLine("Ainda não, tá de boa");

		       	}
		Console.WriteLine("");
		Console.WriteLine("Agora vamos verificar se você manja mesmo de par e impar, digite um novo número abaixo:");
			int num;
		    string entradaB = Console.ReadLine();
		while (!int.TryParse(entradaB, out num))
		{
			Console.WriteLine();
			Console.WriteLine("Entrada invalida, digite apenas números:");
			entradaB = Console.ReadLine();
		}
		Console.WriteLine();
		Console.WriteLine("Agora dígite se ele é par ou ímpar:");
		string resposta = Console.ReadLine().ToLower();

         while (string.IsNullOrWhiteSpace(resposta) ||
         resposta.Any(c => char.IsDigit(c)) ||
         (resposta != "par" && resposta != "impar"))
			{
			    Console.WriteLine();
				Console.WriteLine("Entrada inválida, responda somente com par ou impar:");
				resposta = Console.ReadLine().ToLower();
			   Console.WriteLine();
			}
		bool ehpar = (num % 2 == 0);
		if (ehpar && resposta == "par")
		{
			Console.WriteLine();
			Console.WriteLine("Isso ai mano, certinho! Qual o nome do gênio?");
			string nome = Console.ReadLine();	
			while (string.IsNullOrWhiteSpace(nome) || nome.Any(c => char.IsDigit(c)))
			{
				Console.WriteLine();
				Console.WriteLine("Entrada inválida, digite apenas letras (ex: Neymar Jr):");
				nome = Console.ReadLine();
			}
			Console.WriteLine("");
			Console.WriteLine($"Ai sim, {nome} é o TOUCA MASTER");
		}
		else if (!ehpar && resposta == "impar")
		{
			Console.WriteLine("isso ai mano, é impar touca, me fala seu nome, ou melhor, o nome do Gênio:");
			string nome2 = Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine($"Ai sim, {nome2} é o(a) TOUCA MASTER");
		}	
		else 
		{
			Console.WriteLine();
			Console.WriteLine("ERROU SEU TOUCA, TÁ DE TOUCA MESMO");
			Console.WriteLine();
		}
		Console.WriteLine("");
		Console.WriteLine("Agora, me fale a sua idade e a sua altura:");
		Console.WriteLine("");
		Console.WriteLine("idade:");
		int idade;
		string entradaE = Console.ReadLine();
		while (!int.TryParse(entradaE, out idade))
			   {
			       Console.WriteLine();
				   Console.WriteLine("Entrada inválida, responda somente com números:");
				   entradaE = Console.ReadLine();
		           Console.WriteLine("");
			   }
		while (idade >= 95)
		{
			Console.WriteLine();
			Console.WriteLine("Para de mentir mano kkkkkk, coloca a sua idade de verdade ai:");
			entradaE = Console.ReadLine();
			Console.WriteLine();
			
		while (!int.TryParse(entradaE, out idade))
		{
			Console.WriteLine();
			Console.WriteLine("Entrada inválida, digite uma altura válida(ex: 1.75)");
			entradaE = Console.ReadLine();
		}
		  }		
			if (idade >= 18)
		{
		Console.WriteLine();
		Console.WriteLine("Oloco, já é de maior, ai sim");
		Console.WriteLine("");
		}
		else
		{
			Console.WriteLine("Vish de menor ainda, kid");
			Console.WriteLine("");
		}

		Console.WriteLine("");
		Console.WriteLine("Altura:");
		double altura;
		string entradaD = Console.ReadLine();
		
		while (!double.TryParse(entradaD, NumberStyles.Any,CultureInfo.InvariantCulture, out altura))
		{
			Console.WriteLine();
			Console.WriteLine("Entrada inválida, digite uma altura válida (ex: 1.75):");
			entradaD = Console.ReadLine();
		}
		
		while (altura > 2.10)
		{
			Console.WriteLine();
			Console.WriteLine("Fala a verdade em kkkkkkkkkk, vc não é um poste não");
			Console.WriteLine();
			entradaD = Console.ReadLine();
			
			
			while (!double.TryParse(entradaD, NumberStyles.Any,CultureInfo.InvariantCulture, out altura))
		{
			Console.WriteLine();
			Console.WriteLine("Entrada inválida, digite uma altura válida (ex: 1.75):");
			entradaD = Console.ReadLine();
		}
		}

 
		if (altura >= 1.70)
		{
			Console.WriteLine();
			Console.WriteLine("Ah, não é um anão, menos mal");
			Console.WriteLine();
		}
		else
		{
			Console.WriteLine();
			Console.WriteLine("ish, anão kkkk");
			Console.WriteLine();
		}

		Console.WriteLine();
		Console.WriteLine("Agora, vamos para a sua provinha pra ver se você é inteligente mesmo!");
		Console.WriteLine();
		Console.WriteLine("QUESTÃO 1:");
		Console.WriteLine();
		Console.WriteLine("Qual o número da camisa ultilizada pelo jogador Cristiano Ronaldo?");
		Console.WriteLine();
		Console.WriteLine("Sua resposta:");
		int respostaquestUM;
		string entradaF = Console.ReadLine();
		int okquest1 = 0;
		while (!int.TryParse(entradaF, out respostaquestUM))
			   {
				   Console.WriteLine("Entrada inválida, responda somente com números:");
				   entradaF = Console.ReadLine();
			   }

		if (respostaquestUM == 7)
		{
			Console.WriteLine();
			Console.WriteLine("Párabens, você acertou"); okquest1++;
			Console.WriteLine();
		}
		else
		{
			Console.WriteLine();
			Console.WriteLine("Você errou, que pena!");
			Console.WriteLine();
			Console.WriteLine("A resposta correta era: 7");
			Console.WriteLine();
		}
		Console.WriteLine("QUESTÃO 2:");
		Console.WriteLine();
		Console.WriteLine("Quantos cavalos tem o carro CHEVROLET CLASSIC CORSA no documento?");
		Console.WriteLine();
		Console.WriteLine("a) 68");
		Console.WriteLine();
		Console.WriteLine("b) 65");
		Console.WriteLine();
		Console.WriteLine("c) 72");
		Console.WriteLine();
		Console.WriteLine("d) 90");
		Console.WriteLine();

		Console.WriteLine("Sua resposta:");
		string respostaquestDOIS = Console.ReadLine();
		while (string.IsNullOrWhiteSpace(respostaquestDOIS) || respostaquestDOIS.Any(c => char.IsDigit(c)))
			   {
		          Console.WriteLine();
				   Console.WriteLine("Entrada inválida, digite apenas a alternativa correta (a, b, c ou d):");
					respostaquestDOIS = Console.ReadLine();
			   }

		if (respostaquestDOIS == "c")
		{
			Console.WriteLine();
			Console.WriteLine("Ai sim, você sabe de carros também, menino(a) esperto(a)!"); okquest1++;
			Console.WriteLine();
		}
		else if (respostaquestDOIS =="C")
		{
			Console.WriteLine();
			Console.WriteLine("Ai sim, você sabe de carros também, menino(a) esperto(a)"); okquest1++;
			Console.WriteLine();
		}
		else
		{
			Console.WriteLine();
			Console.WriteLine("Você errou, que pena!");
			Console.WriteLine();
		}
		Console.WriteLine("QUESTÃO 3:");
		Console.WriteLine();
		Console.WriteLine("Qual o foi o país que os Estados Unidos jogou duas bombas nucleares?");
		Console.WriteLine();
		Console.WriteLine("a) Brasil");
		Console.WriteLine();
		Console.WriteLine("b) Chile");
		Console.WriteLine();
		Console.WriteLine("c) Japão");
		Console.WriteLine();
		Console.WriteLine("d) Vanuatu");
		Console.WriteLine();
		Console.WriteLine("Sua resposta:");
		string respostaquestTRES = Console.ReadLine();
		while (string.IsNullOrWhiteSpace(respostaquestTRES) || respostaquestTRES.Any(c => char.IsDigit(c)) || (respostaquestTRES != "a" && respostaquestTRES != "b" && respostaquestTRES != "c" && respostaquestTRES != "d"))
		{
			Console.WriteLine();
			Console.WriteLine("Entrada inválida, digite apenas a alternativa correta (a, b, c ou d):");
			respostaquestTRES = Console.ReadLine();
		}
		if (respostaquestTRES == "c")
		{
			Console.WriteLine();
			Console.WriteLine("Isso ai! Você sabe tudo de conhecimentos gerais mesmo, mas calma! Ainda não acabou..."); okquest1++;
			Console.WriteLine();
		}
		else if (respostaquestTRES == "japao")
		{
			Console.WriteLine();
			Console.WriteLine("Era pra por a letra da alternativa burrão, mas mesmo assim vou aceitar porque eu sou daora! Você sabe tudo de conhecimentos gerais mesmo, mas calma! Ainda não acabou..."); okquest1++;
			Console.WriteLine();
		}
		else
		{
			Console.WriteLine();
			Console.WriteLine("Voce errou, que pena!");
			Console.WriteLine();
			Console.WriteLine("A resposta correrta era: c) Japão, mas calma! ainda não acabou...");
			Console.WriteLine();
		}
		Console.WriteLine("QUESTÃO 4:");
		Console.WriteLine();
		Console.WriteLine("Qual o ano de fabricação da primeira cg 125?");
		Console.WriteLine();
		Console.WriteLine("Sua resposta:");
		int respostaquestQUATRO;
		string entradaC = Console.ReadLine();
		while (!int.TryParse(entradaC, out respostaquestQUATRO))
		{
			Console.WriteLine("Entrada invalida, digite apenas números:");
			entradaC = Console.ReadLine();
		}
		if (respostaquestQUATRO == 1976)
		{
			Console.WriteLine();
			Console.WriteLine("UAU!");
			Console.WriteLine("Isso foi impressionante, você acertou!"); okquest1++;
			Console.WriteLine();
		}
		else
		{
		    Console.WriteLine();
			Console.WriteLine("Infelizmente você errou, mas essa era díficil mesmo, não esquenta!");
			Console.WriteLine();
			Console.WriteLine("A resposta era: 1976");
			Console.WriteLine();
		}
		Console.WriteLine("QUESTÃO 5:");
		Console.WriteLine();
		Console.WriteLine("Quantas vidas tem um gato?");
		Console.WriteLine();
		Console.WriteLine("Sua resposta:");
		string respostaquestCINCO = Console.ReadLine();

		if (respostaquestCINCO == "1")
		{
			Console.WriteLine();
			Console.WriteLine("Ai sim, não caiu na pegadinha"); okquest1++;
			Console.WriteLine();
		}
		else if (respostaquestCINCO == "uma")
		{
			Console.WriteLine();
			Console.WriteLine("Ai sim, não caiu na pegadinha"); okquest1++;
			Console.WriteLine();
		}
		else
		{
			Console.WriteLine();
			Console.WriteLine("Opaaaa, caiu no bait, a resposta certa era: 1");
			Console.WriteLine();			
		}
		Console.WriteLine("QUESTÃO 6:");
		Console.WriteLine();
		Console.WriteLine("Em qual ano a empresa Galpão Motoparts foi fundada?");
		Console.WriteLine();
		Console.WriteLine("a) 2020");
		Console.WriteLine();
		Console.WriteLine("b) 2018");
		Console.WriteLine();
		Console.WriteLine("c) 2011");
		Console.WriteLine();
		Console.WriteLine("d) 2015");
		Console.WriteLine();
		Console.WriteLine("e) 2017");
		Console.WriteLine();
		Console.WriteLine("Sua resposta:");
		string respostaquestSEIS = Console.ReadLine();
		if (respostaquestSEIS == "2017")
		{
			Console.WriteLine();
			Console.WriteLine("Era pra por a letra da alternativa seu touca, mas como eu sou daora vou aceitar kkkkkkk, certa resposta"); okquest1++;
			Console.WriteLine();
		}
		else if (respostaquestSEIS == "e")
		{
			Console.WriteLine();
			Console.WriteLine("Certa resposta mano!, isso ai");
		}
		else
		{
			Console.WriteLine();
			Console.WriteLine("Tá errado mano, ta de touca mesmo, a resposta certa era: 2017");
			Console.WriteLine();
		}

		int totalQuest = 6;
		int nota = okquest1;
		double mediaprova = ((double)okquest1 / totalQuest) *10;
		double porcentagem = ((double)okquest1 / totalQuest) *100;
		Console.WriteLine("=== RESULTADO FINAL DA PROVA ===");
		Console.WriteLine();
		Console.WriteLine($"Acertos: {okquest1} de {totalQuest}");
		Console.WriteLine();
		Console.WriteLine($"Nota final: {mediaprova:F1} /10");
		Console.WriteLine();
		Console.WriteLine($"Porcentagem: {porcentagem:F0}%");
		if (mediaprova >= 7)
		{
			Console.WriteLine();
			Console.WriteLine("==== PARABÉNS, VOCÊ FOI MUITO BEM! ===");
		}
		else if (mediaprova >= 5)
		{
			Console.WriteLine();
			Console.WriteLine("Quase lá! você foi bem mas ainda dá pra melhorar!");
		}
		else
		{
			Console.WriteLine();
			Console.WriteLine("Putz... Tá de touca mesmo kkkkkk, treina mais!");
		}



    }
}
