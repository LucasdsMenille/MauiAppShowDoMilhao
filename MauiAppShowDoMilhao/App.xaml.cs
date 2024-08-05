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
            Enunciado = "Qual é o país com mais medalhas na história das olímpiadas?",
            Alternativas = new()
            {
                new Alternativa { Correta = true, Descricao = "ESTADOS UNIDOS" },
                new Alternativa { Correta = false, Descricao =  "FRANÇA" },
                new Alternativa { Correta = false, Descricao = "ITÁLIA" },
                new Alternativa { Correta = false, Descricao = "BRASIL" }
            }
        },

         new Pergunta
        {
            Id = 5,
            Enunciado = "Qual é o maior país da América do Sul?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "ARGENTINA" },
                new Alternativa { Correta = false, Descricao =  "ESTADOS UNIDOS" },
                new Alternativa { Correta = false, Descricao = "URUGUAI" },
                new Alternativa { Correta = true, Descricao = "BRASIL" }
            }
        },
          new Pergunta
        {
            Id = 6,
            Enunciado = "Quem proclamou a república do Brasil em 1889?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS" },
                new Alternativa { Correta = false, Descricao =  "MARECHAL RONDON" },
                new Alternativa { Correta = false, Descricao = "DOM PEDRO II" },
                new Alternativa { Correta = true, Descricao = "MARECHAL DEODORO" }
            }
        },
           new Pergunta
        {
            Id = 7,
            Enunciado = "Quem fundou a fábrica de automóveis Ford?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "HARRISON FORD" },
                new Alternativa { Correta = false, Descricao =  "GERALD FORD" },
                new Alternativa { Correta = true, Descricao = "HENRY FORD" },
                new Alternativa { Correta = false, Descricao = "ANNA FORD" }
            }
        },
            new Pergunta
        {
            Id = 8,
            Enunciado = "Quando é comemorado o dia da Independência do Brasil?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "21 DE ABRIL" },
                new Alternativa { Correta = false, Descricao =  "12 DE OUTUBRO" },
                new Alternativa { Correta = true, Descricao = "7 DE SETEMBRO" },
                new Alternativa { Correta = false, Descricao = "11 DE SETEMBRO" }
            }
        },
             new Pergunta
        {
            Id = 9,
            Enunciado = "Quem foi o grande amor de Julieta?",
            Alternativas = new()
            {
                new Alternativa { Correta = true, Descricao = "ROMEU" },
                new Alternativa { Correta = false, Descricao =  "ORFEU" },
                new Alternativa { Correta = false, Descricao = "HAMLET" },
                new Alternativa { Correta = false, Descricao = "MARIO" }
            }
        },
              new Pergunta
        {
            Id = 10,
            Enunciado = "Como se chama o lugar onde são armazenadas as balas de um revólver?",
            Alternativas = new()
            {
                new Alternativa { Correta = true, Descricao = "CANO" },
                new Alternativa { Correta = false, Descricao =  "TAMBOR" },
                new Alternativa { Correta = false, Descricao = "AGULHA" },
                new Alternativa { Correta = false, Descricao = "GATILHO" }
            }
        },
                new Pergunta
        {
            Id = 11,
            Enunciado = "Qual personagem da Turma da Mônica tem apenas cinco fios de cabelo?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "MÔNICA" },
                new Alternativa { Correta = true, Descricao =  "CEBOLINHA" },
                new Alternativa { Correta = false, Descricao = "MAGALI" },
                new Alternativa { Correta = false, Descricao = "CASCÃO" }
            }
        },
                  new Pergunta
        {
            Id = 12,
            Enunciado = "Quem fundou a Microsoft?",
            Alternativas = new()
            {
                new Alternativa { Correta = true, Descricao = "BILL GATES" },
                new Alternativa { Correta = false, Descricao =  "ELON MUSK" },
                new Alternativa { Correta = false, Descricao = "PABLO MARÇAL" },
                new Alternativa { Correta = false, Descricao = "MARK ZUCKERBERG" }
            }
        },
                    new Pergunta
        {
            Id = 13,
            Enunciado = "Qual o ano da última Copa do Mundo de futebol que o Brasil ganhou?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "1994" },
                new Alternativa { Correta = false, Descricao =  "2006" },
                new Alternativa { Correta = true, Descricao = "2002" },
                new Alternativa { Correta = false, Descricao = "2010" }
            }
        },
                    new Pergunta
        {
            Id = 14,
            Enunciado = "Como se chama o lugar onde guarda vinhos?",
            Alternativas = new()
            {
                new Alternativa { Correta = true, Descricao = "ADEGA" },
                new Alternativa { Correta = false, Descricao =  "BIBLIOTECA" },
                new Alternativa { Correta = false, Descricao = "SÓTÃO" },
                new Alternativa { Correta = false, Descricao = "BUDEGA" }
            }
        },
                    new Pergunta
        {
            Id = 15,
            Enunciado = "Qual é o maior medalhista Olímpico do Brasil?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "Neymar" },
                new Alternativa { Correta = false, Descricao =  "Isaquias Queiroz" },
                new Alternativa { Correta = true, Descricao = "Rebecca Andrade" },
                new Alternativa { Correta = false, Descricao = "Raysa leal" }
            }
        },
         new Pergunta
        {
            Id = 16,
            Enunciado = "Quantos dias tem um ano bissexto?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "364" },
                new Alternativa { Correta = false, Descricao =  "365" },
                new Alternativa { Correta = true, Descricao = "366" },
                new Alternativa { Correta = false, Descricao = "367" }
            }
        },
         new Pergunta
        {
            Id = 17,
            Enunciado = "Quantos centavos equivalem a um real?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "DEZ" },
                new Alternativa { Correta = false, Descricao =  "MIL" },
                new Alternativa { Correta = false, Descricao = "CINQUENTA" },
                new Alternativa { Correta = true, Descricao = "CEM" }
            }
        },
         new Pergunta
        {
            Id = 18,
            Enunciado = "Quem foi o técnico da seleção brasileira na Copa do Mundo de 2022?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "Dunga" },
                new Alternativa { Correta = false, Descricao =  "Dorival Jr." },
                new Alternativa { Correta = false, Descricao = "Abel Ferrreira" },
                new Alternativa { Correta = true, Descricao = "Tite" }
            }
        },
         new Pergunta
        {
            Id = 19,
            Enunciado = "Qual é a área da medicina que trata de crianças?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "GERIATRA" },
                new Alternativa { Correta = false, Descricao =  "INFANTOLOGIA" },
                new Alternativa { Correta = true, Descricao = "PEDIATRA" },
                new Alternativa { Correta = false, Descricao = "BIOLOGIA" }
            }
        },
         new Pergunta
        {
            Id = 20,
            Enunciado = "Segundo a Bíblia quem foi morto por Caim?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "ADÃO" },
                new Alternativa { Correta = false, Descricao =  "ISAAC" },
                new Alternativa { Correta = true, Descricao = "ABEL" },
                new Alternativa { Correta = false, Descricao = "ABRAÃO" }
            }
        },



    };
}


