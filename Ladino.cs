using System;
using System.Collections.Generic;

public class Ladino : Personagem
{
    public Ladino(string nome)
    {
        Nome = nome;
        Ataque = 30;
        Defesa = 0;
        Vida = 50;
        ChanceCritico = 0.2;  
        ChanceEsquiva = 0.5;  
    }

    public override void ExibirHabilidades()
    {
        Console.WriteLine($"{Nome} - Ataque: {Ataque}, Defesa: {Defesa}, Vida: {Vida}, Chance de Crítico: {ChanceCritico * 100}%");
    }
}
