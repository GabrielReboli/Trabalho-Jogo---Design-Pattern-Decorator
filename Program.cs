using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criação dos guerreiros e aplicação de decoradores
        Personagem guerreiro1 = new AnelDecorator(new Guerreiro("Jasão"));
        Personagem guerreiro2 = new Guerreiro("Ajax");
        Personagem arqueiro1 = new Arqueiro("Atalanta");

        // Aplica decoradores ao guerreiro 1 e 2
        guerreiro1 = new ArmaduraDeFerro(guerreiro1);
        guerreiro1 = new EspadaFlamejante(guerreiro1);
        guerreiro1 = new AnelDecorator(guerreiro1);

        guerreiro2 = new EspadaFlamejante(guerreiro2);
        guerreiro2 = new ArmaduraDeFerro(guerreiro2);

        arqueiro1 = new ArmaduraDeFerro(arqueiro1);
        arqueiro1 = new ArcoDivino(arqueiro1);
        

        // Exibe o status inicial dos guerreiros antes do duelo
        Console.WriteLine("Status dos personagens antes do duelo:");
        guerreiro1.ExibirHabilidades();
        guerreiro2.ExibirHabilidades();

        // Simula o duelo entre os guerreiros
        Duelo.Lutar(guerreiro2, guerreiro1);
    }
}

