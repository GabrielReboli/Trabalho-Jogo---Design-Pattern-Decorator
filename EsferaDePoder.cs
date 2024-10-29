using System;
using System.Collections.Generic;

public class EsferaDePoder
{
    private const double incrementoReflexao = 0.1;  // Cada esfera aumenta 10%

    // Método para permitir que guerreiros com anel coletem a esfera
    public void Coletar(Personagem guerreiro)
    {
        // Verifica se o guerreiro tem o AnelDecorator
        if (guerreiro is AnelDecorator)
        {
            AnelDecorator guerreiroComAnel = (AnelDecorator)guerreiro;
            guerreiroComAnel.AumentarPoderReflexivo(incrementoReflexao);
            Console.WriteLine($"{guerreiroComAnel.Nome} coletou uma Esfera de Poder!");
        }
        else
        {
            Console.WriteLine($"{guerreiro.Nome} não pode coletar a Esfera de Poder sem o Anel!");
        }
    }
}
