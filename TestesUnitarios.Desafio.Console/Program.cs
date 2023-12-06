// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using TestesUnitarios.Desafio.Console.Services;

Console.WriteLine("Hello, World!");


ValidacoesLista validacoesLista = new ValidacoesLista();



var lista = new List<int> { 5, 7, 8, 9 };

var resultado = validacoesLista.MultiplicarNumerosLista(lista, 2);

Console.WriteLine(string.Join(',', resultado));