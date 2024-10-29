using System;
using System.Collections.Generic;

public abstract class PersonagemDecorator : Personagem
{
    protected Personagem personagem;

    public PersonagemDecorator(Personagem p)
    {
        personagem = p;
        Nome = personagem.Nome;
        Ataque = personagem.Ataque;
        Defesa = personagem.Defesa;
        Vida = personagem.Vida;
        ChanceCritico = personagem.ChanceCritico;
        ChanceEsquiva = personagem.ChanceEsquiva;
    }

    public override void ExibirHabilidades()
    {
        personagem.ExibirHabilidades();
    }
}