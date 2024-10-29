
# Jogo de Batalha com Padrão Decorator

Este projeto é uma simulação de jogo de combate entre guerreiros, implementando o padrão de design **Decorator** para aplicar habilidades e melhorias flexíveis aos personagens.

## Estrutura do Projeto

O projeto está estruturado nas seguintes classes:

### Classes Base e de Personagens
- **Personagem.cs**: Classe base abstrata que define atributos e métodos essenciais dos personagens.
- **Guerreiro.cs**: Classe concreta que representa o guerreiro padrão.
- **Arqueiro.cs** e **Ladino.cs**: Classes de personagens adicionais com características próprias.

### Decoradores
- **PersonagemDecorator.cs**: Classe base para todos os decoradores.
- **EspadaFlamejante.cs**: Decorador que aumenta o ataque do guerreiro.
- **ArmaduraDeFerro.cs**: Decorador que aumenta a defesa do guerreiro.
- **AnelDecorator.cs**: Decorador que adiciona a habilidade de refletir dano ao guerreiro.
- **ArcoDivino.cs**: Decorador que incrementa atributos específicos do Arqueiro.
- **EsferaDePoder.cs**: Classe que representa esferas coletadas pelo guerreiro para aumentar o poder reflexivo do anel.

### Gerenciamento de Combate
- **Duelo.cs**: Classe que gerencia o combate em turnos entre dois personagens, aplicando as mecânicas de crítico, esquiva e dano reflexivo.
- **Program.cs**: Classe principal que configura os personagens e inicia o duelo.

## Funcionalidades

- **Combate em Turnos**: Os guerreiros se alternam em turnos de ataque com a possibilidade de crítico, esquiva e reflexo de dano.
- **Aplicação de Decoradores**: Permite modificar e adicionar habilidades a um personagem, como aumentar o ataque, defesa ou refletir dano.
- **Reflexo de Dano**: O anel permite refletir 10% do dano, incrementado em 10% para cada esfera de poder coletada até o limite de 100%.

## Instruções para Execução

1. Compile o projeto ou use o arquivo `Program.exe` incluído.
2. Execute o jogo para simular um combate entre personagens com atributos e decoradores aplicados.
3. A saída exibirá o resultado dos turnos e a interação das habilidades aplicadas.

## Exemplo de Saída

A execução exibirá os atributos iniciais dos personagens e mostrará o combate turno a turno, incluindo dano, crítico, esquiva e reflexão, até que um dos personagens vença.

## Estrutura de Arquivos

- `Trabalho_Jogo/AnelDecorator.cs` - Decorador para refletir dano.
- `Trabalho_Jogo/ArcoDivino.cs`, `Trabalho_Jogo/EspadaFlamejante.cs`, `Trabalho_Jogo/ArmaduraDeFerro.cs` - Decoradores para diferentes habilidades.
- `Trabalho_Jogo/Personagem.cs`, `Trabalho_Jogo/PersonagemDecorator.cs` - Estrutura base dos personagens e decoradores.
- `Trabalho_Jogo/Duelo.cs` - Gerencia o combate entre personagens.
- `Trabalho_Jogo/Program.cs` - Arquivo principal de execução.

## Autor

Desenvolvido como parte de um projeto acadêmico para aplicar conceitos de Padrões de Projeto, em especial o padrão **Decorator**.
