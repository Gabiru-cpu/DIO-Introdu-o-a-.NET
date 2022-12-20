using BibliotecaDeClasses.common.Models;

Pessoa varPerson = new Pessoa();
Calculadora varCalc = new Calculadora();
Chuva varChuva = new Chuva();





/*
varPerson.Name = "Pedro";
varPerson.Age = 22;

varPerson.Apresentar();

varPerson.HorarioeDia();

varCalc.Main();

varChuva.Passear();


//desafio 2
class ProgramaPaulinho{
  static void Main(string[] args) 
  {
    int qt = int.Parse(Console.ReadLine());
    string[] v = new string[2];
    
    for (int n = 0; n < qt; ++n) {
      v = Console.ReadLine().Split(" ");
      string a = v[0];
      string b = v[1];

      if (b.Length > a.Length)
        Console.WriteLine("nao encaixa");
      else if (a.EndsWith(b))
        Console.WriteLine("encaixa");
      else
        Console.WriteLine("nao encaixa");
    }
  }
}

//desafio 1
int n = int.Parse(Console.ReadLine());
        int p = 1, s = 0;
        while (n > 0){
             int l = n % 10;
// TODO: Crie as outras condições necessárias para a resolução do desafio:
             p *= l;
             s += l;
             n /= 10;
           }

           Console.WriteLine(p-s);
/*
int n = int.Parse(Console.ReadLine());
    int p = 1, s = 0;
    
    while (n > 0)
    {
      int l = n % 10;
      // TODO: Crie as outras condições necessárias para a resolução do desafio:
      p *= l;
      s += l;
      n /= 10;
    }
    
    Console.WriteLine($"Resultado do Produto dos digitos{p}");
    Console.WriteLine($"Resultado do Soma dos digitos{s}");
    Console.WriteLine($"Resultado da subtração do Produto dos digitos e a soma dos digitos {p-s}");* /


//atividade Lista
List<string> listaString = new List<string>();
listaString.Add("SP"); listaString.Add("BA"); listaString.Add("MG"); 

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}"); 
listaString.Add("SC"); 
Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}"); 
listaString.Remove("MG"); 
Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");



Console.WriteLine("Percorrendo Lista com For");
for(int contador = 0; contador < listaString.Count; contador++)
{ 
    Console.WriteLine($"Posição N. {contador} = {listaString[contador]}"); 
} 

Console.WriteLine("Percorrendo Lista com Foreach");
int cont=0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição N. {cont} = {item}");
    cont++;
}


//atividade Array
int[] myArray = {15, 24, 33, 45};

Console.WriteLine("Percorrendo Array com For");
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($"{i + 1}° posição possui o valor = {myArray[i]}");
}

Console.WriteLine("Percorrendo Array com Foreach");
int contA = 0;
foreach (var item in myArray)
{
    Console.WriteLine($"{contA + 1}° posição possui o valor = {item}");
    contA++;
}
Console.WriteLine("Aumentando a capacidade maxima do Array para mais 2");
Array.Resize(ref myArray, myArray.Length + 2);

myArray [4] = 12; myArray [5] = 60;
Console.WriteLine("Copiando o conteudo de um Array para outro");
int[] myArrayCopy = new int [myArray.Length + 2];
Array.Copy(myArray, myArrayCopy, myArray.Length);
*/