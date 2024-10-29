using System;
using System.Collections.Generic;

public class ArcoDivino : PersonagemDecorator
{
    public ArcoDivino(Personagem p) : base(p)
    {
        Ataque += 15; 
        ChanceCritico += 0.30;
    }

    public override void ExibirHabilidades()
    {
        Console.WriteLine($"{Nome} com Arco Divino - Ataque: {Ataque}, Defesa: {Defesa}, Vida: {Vida}");
    }
}