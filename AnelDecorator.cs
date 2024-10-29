using System;
using System.Collections.Generic;

public class AnelDecorator : PersonagemDecorator
{
    private double poderReflexivo = 0.1;

    public AnelDecorator(Personagem p) : base(p) { }

    public override void ReceberDano(int dano, Personagem atacante, bool isReflective = false)
    {
        if (isReflective)
        {
            // Se o dano for refletido, o personagem apenas recebe o dano, sem refletir de volta.
            this.Vida -= dano;
            Console.WriteLine($"{Nome} recebeu {dano} de dano refletido.");
            return;
        }

        // Dano direto: aplica o poder reflexivo
        int danoRefletido = (int)(dano * poderReflexivo);

        // Aplica o dano total ao guerreiro, sem considerar o dano refletido
        this.Vida -= (dano - danoRefletido);

        Console.WriteLine($"{Nome} reflete {danoRefletido} de dano de volta para {atacante.Nome}!");

        // Aplica o dano refletido ao atacante como dano reflexivo
        atacante.ReceberDano(danoRefletido, this, true);
    }

    public void AumentarPoderReflexivo(double incremento)
    {
        if (poderReflexivo >= 1.0)
        {
            Console.WriteLine($"{Nome} já atingiu o poder reflexivo máximo de 100% e não pode mais coletar esferas.");
            return;
        }

        poderReflexivo = Math.Min(poderReflexivo + incremento, 1.0); // Limita o máximo a 1.0 (100%)
        Console.WriteLine($"{Nome} aumentou o poder reflexivo para {poderReflexivo * 100}%.");
    }

    public double PoderReflexivo => poderReflexivo;
}


