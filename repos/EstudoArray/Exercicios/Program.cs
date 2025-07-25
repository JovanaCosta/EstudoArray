using System;
using Exercicios;


//var exemplo = new Exemplo();
//exemplo.Execute(4, 6, 10);

var calculoService = new CalculosService();
calculoService.Execute(35,15,89,90,91);

List<int> numeros = new List<int>();

numeros.Add(10);
numeros.Add(15);
numeros.Add(20);

calculoService.OrdenandoDeFormaCrescente(numeros);