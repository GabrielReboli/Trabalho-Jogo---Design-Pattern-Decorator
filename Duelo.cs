using System;
using System.Collections.Generic;


public class Duelo
{
    public static readonly Random random = new Random();

    public static void Lutar(Personagem p1, Personagem p2)
    {
        Console.WriteLine("\nDuelo iniciado!\n");

        while (p1.Vida > 0 && p2.Vida > 0)
        {
            // Tenta dar uma esfera para o guerreiro com o Anel (p1)
            VerificarEConcederEsfera(p1);

            // Personagem 1 ataca Personagem 2
            bool criticoP1 = p1.AtaqueCritico();
            int danoP1 = Math.Max(0, p1.Ataque - p2.Defesa);

            if (criticoP1)
            {
                danoP1 *= 2;
                Console.WriteLine($"{p1.Nome} acertou um CRÍTICO!");
            }

            // Verifica esquiva do Personagem 2 após calcular o dano
            if (p2.Esquiva())
            {
                danoP1 = 0;
                Console.WriteLine($"{p2.Nome} esquivou!");
            }
            else
            {
                // Aplica o dano a p2 e imprime o resultado antes da reflexão
                p2.Vida -= danoP1;
                if (p2.Vida < 0) p2.Vida = 0;
                Console.WriteLine($"{p1.Nome} causa {danoP1} de dano a {p2.Nome}. Vida de {p2.Nome}: {p2.Vida}");

                // Verifica se Personagem 2 tem o Anel e reflete parte do dano
                if (p2 is AnelDecorator p2ComAnel && danoP1 > 0)
                {
                    int danoRefletido = (int)(danoP1 * p2ComAnel.PoderReflexivo);
                    p1.Vida -= danoRefletido;
                    Console.WriteLine($"{p2ComAnel.Nome} reflete {danoRefletido} de dano a {p1.Nome}!");
                }
            }

            if (p2.Vida <= 0)
            {
                Console.WriteLine($"\n{p2.Nome} foi derrotado! {p1.Nome} vence o duelo!");
                break;
            }

            // Tenta dar uma esfera para o guerreiro com o Anel (p2)
            VerificarEConcederEsfera(p2);

            // Personagem 2 ataca Personagem 1
            bool criticoP2 = p2.AtaqueCritico();
            int danoP2 = Math.Max(0, p2.Ataque - p1.Defesa);

            if (criticoP2)
            {
                danoP2 *= 2;
                Console.WriteLine($"{p2.Nome} acertou um CRÍTICO!");
            }

            // Verifica esquiva do Personagem 1 após calcular o dano
            if (p1.Esquiva())
            {
                danoP2 = 0;
                Console.WriteLine($"{p1.Nome} esquivou!");
            }
            else
            {
                // Aplica o dano a p1 e imprime o resultado antes da reflexão
                p1.Vida -= danoP2;
                if (p1.Vida < 0) p1.Vida = 0;
                Console.WriteLine($"{p2.Nome} causa {danoP2} de dano a {p1.Nome}. Vida de {p1.Vida}");

                // Verifica se Personagem 1 tem o Anel e reflete parte do dano
                if (p1 is AnelDecorator p1ComAnel && danoP2 > 0)
                {
                    int danoRefletido = (int)(danoP2 * p1ComAnel.PoderReflexivo);
                    p2.Vida -= danoRefletido;
                    Console.WriteLine($"{p1ComAnel.Nome} reflete {danoRefletido} de dano a {p2.Nome}!");
                }
            }

            if (p1.Vida <= 0)
            {
                Console.WriteLine($"\n{p1.Nome} foi derrotado! {p2.Nome} vence o duelo!");
            }
        }
    }

    private static void VerificarEConcederEsfera(Personagem personagem)
    {
        // Define uma chance de 30% de obter uma esfera a cada turno
        double chanceDeObterEsfera = 0.3;

        // Verifica se o personagem tem o AnelDecorator
        if (personagem is AnelDecorator anelDecorado)
        {
            // Gera um número aleatório e verifica se ele está dentro da chance
            if (random.NextDouble() < chanceDeObterEsfera)
            {
                Console.WriteLine($"{anelDecorado.Nome} obteve uma Esfera de Poder!"); // Mensagem de obtenção da esfera

                // Incrementa o poder reflexivo após exibir a mensagem de obtenção
                anelDecorado.AumentarPoderReflexivo(0.1);
            }
        }
    }
}



