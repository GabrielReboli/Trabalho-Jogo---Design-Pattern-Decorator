using System;
using System.Collections.Generic;

public class Arqueiro : Personagem
{
    public Arqueiro(string nome)
    {
        Nome = nome;
        Ataque = 5;
        Defesa = 0;
        Vida = 50;
        ChanceCritico = 0.5;  
        ChanceEsquiva = 0.5;
    }

    public override void ExibirHabilidades()
    {
        Console.WriteLine($"{Nome} - Ataque: {Ataque}, Defesa: {Defesa}, Vida: {Vida}, Chance de Crítico: {ChanceCritico * 100}%");
    }
}
