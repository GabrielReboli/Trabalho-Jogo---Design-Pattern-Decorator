/// <summary>
/// Classe base abstrata que representa um personagem genérico no jogo,
/// com atributos e métodos essenciais como ataque crítico e esquiva.
/// </summary>

using System;
using System.Collections.Generic;

public abstract class Personagem
{
    public string Nome { get; set; }
    public int Ataque { get; set; }
    public int Defesa { get; set; }
    public int Vida { get; set; }
    public double ChanceCritico { get; set; }  
    public double ChanceEsquiva { get; set; }  

    public abstract void ExibirHabilidades();

    public bool AtaqueCritico()
    {
        return Duelo.random.NextDouble() < ChanceCritico;  
    }

    public bool Esquiva()
    {
        return Duelo.random.NextDouble() < ChanceEsquiva; 
    }

    public virtual void ReceberDano(int dano, Personagem atacante, bool isReflective = false)
    {
        this.Vida -= dano;
    }
}

