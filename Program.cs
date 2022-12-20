using DIO_intro.NET.Models;

Pessoa varPerson = new Pessoa();
Calculadora varCalc = new Calculadora();
Chuva varChuva = new Chuva();

varPerson.Name = "Pedro";
varPerson.Age = 22;

varPerson.Apresentar();

varPerson.HorarioeDia();

varCalc.Main();

varChuva.Passear();