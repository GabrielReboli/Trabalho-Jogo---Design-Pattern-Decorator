using System;
using System.Collections.Generic;

public class Guerreiro : Personagem
{
    public Guerreiro(string nome)
    {
        Nome = nome;
        Ataque = 20;
        Defesa = 5;
        Vida = 100;
        ChanceCritico = 0.05;  
        ChanceEsquiva = 0.0;  
    }

    public override void ExibirHabilidades()
    {
        Console.WriteLine($"{Nome} - Ataque: {Ataque}, Defesa: {Defesa}, Vida: {Vida}, Chance de Crítico: {ChanceCritico * 100}%");
    }
}
