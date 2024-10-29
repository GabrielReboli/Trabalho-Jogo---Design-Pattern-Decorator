using System;
using System.Collections.Generic;

public class EspadaFlamejante : PersonagemDecorator
{
    public EspadaFlamejante(Personagem p) : base(p)
    {
        Ataque += 20; 
        ChanceCritico += 0.05;
    }

    public override void ExibirHabilidades()
    {
        Console.WriteLine($"{Nome} com Espada Flamejante - Ataque: {Ataque}, Defesa: {Defesa}, Vida: {Vida}");
    }
}