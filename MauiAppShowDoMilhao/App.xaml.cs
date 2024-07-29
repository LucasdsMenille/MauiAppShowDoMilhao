using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao;

public partial class App : Application
{
    List<Pergunta> perguntas_faceis = new()
    {
        new Pergunta
        {
            Id = 1,
            Enunciado = "Qual o nome dado ao estado da água em forma de gelo?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "LÍQUIDO" },
                new Alternativa { Correta = true, Descricao = "SÓLIDO" },
                new Alternativa { Correta = false, Descricao = "GASOSO" },
                new Alternativa { Correta = false, Descricao = "VAPOROSO" }
            }

        },
        new Pergunta
        {
            Id = 2,
            Enunciado = "Quem a namorada do Mickey?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "MARGARIDA" },
                new Alternativa { Correta = true, Descricao = "MINNIE" },
                new Alternativa { Correta = false, Descricao = "A PEQUENA SEREIA" },
                new Alternativa { Correta = false, Descricao = "OLÍVIA PALITO" }
            }
        },
        new Pergunta
        {
            Id = 3,
            Enunciado = "Qual o campeão da Copa do Mundo de Futebol de 2022?",
            Alternativas = new()
            {
                new Alternativa { Correta = true, Descricao = "ARGENTINA" },
                new Alternativa { Correta = false, Descricao =  "FRANÇA" },
                new Alternativa { Correta = false, Descricao = "ITÁLIA" },
                new Alternativa { Correta = false, Descricao = "BRASIL" }
            }
        },

        new Pergunta
        {
            Id = 4,
            Enunciado = "Qual o campeão da Copa do Mundo de 2022?",
            Alternativas = new()
            {
                new Alternativa { Correta = true, Descricao = "ARGENTINA" },
                new Alternativa { Correta = false, Descricao =  "FRANÇA" },
                new Alternativa { Correta = false, Descricao = "ITÁLIA" },
                new Alternativa { Correta = false, Descricao = "BRASIL" }
            }
        },
    };
}


