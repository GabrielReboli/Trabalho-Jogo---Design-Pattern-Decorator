using System;
using System.Collections.Generic;

public class ArmaduraDeFerro : PersonagemDecorator
{
    public ArmaduraDeFerro(Personagem p) : base(p)
    {
        Defesa += 20; // Aumenta a defesa
    }

    public override void ExibirHabilidades()
    {
        Console.WriteLine($"{Nome} com Armadura de Ferro - Ataque: {Ataque}, Defesa: {Defesa}, Vida: {Vida}");
    }
}