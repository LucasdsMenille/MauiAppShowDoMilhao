using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao;

public partial class App : Application
{
    static List<Pergunta> perguntas_faceis = new()
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

    static List<Pergunta> perguntas_medias = new()
    {
        new Pergunta
        {
            Id = 21,
            Enunciado = "Quantos jogadores um jogo de vôlei reúne na quadra??",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "SEIS" },
                new Alternativa { Correta = true, Descricao = "OITO" },
                new Alternativa { Correta = false, Descricao = "ONZE" },
                new Alternativa { Correta = false, Descricao = "DOZE" }
            }

        },
        new Pergunta
        {
            Id = 22,
            Enunciado = "A cidade de Pompéia, que foi soterrada por um vulcão fica em qual desses países?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "JAPÃO" },
                new Alternativa { Correta = true, Descricao = "MÉXICO" },
                new Alternativa { Correta = false, Descricao = "ITÁLIA" },
                new Alternativa { Correta = false, Descricao = "BRASIL" }
            }
        },
        new Pergunta
        {
            Id = 23,
            Enunciado = "Qual o campeão da Copa do Mundo de Futebol de 1974?",
            Alternativas = new()
            {
                new Alternativa { Correta = true, Descricao = "ALEMANHA" },
                new Alternativa { Correta = false, Descricao = "FRANÇA" },
                new Alternativa { Correta = false, Descricao = "ITÁLIA" },
                new Alternativa { Correta = false, Descricao = "BRASIL" }
            }
        },

        new Pergunta
        {
            Id = 24,
            Enunciado = "O alpinismo é praticado em que lugar??",
            Alternativas = new()
            {
                new Alternativa { Correta = true, Descricao = "MAR" },
                new Alternativa { Correta = false, Descricao = "RIO" },
                new Alternativa { Correta = false, Descricao = "MONTANHA" },
                new Alternativa { Correta = false, Descricao = "PRAIA" }
            }
        },

        new Pergunta
        {
            Id = 25,
            Enunciado = "Que imperador pôs fogo em Roma?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "TRAJANO" },
                new Alternativa { Correta = false, Descricao = "BRUTOS" },
                new Alternativa { Correta = true, Descricao = "NERO" },
                new Alternativa { Correta = false, Descricao = "CALÍGULA" }
            }
        },
        new Pergunta
        {
            Id = 26,
            Enunciado = "A cidade de Pompéia, que foi soterrada por um vulcão fica em qual desses países?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "ESTADOS UNIDOS" },
                new Alternativa { Correta = false, Descricao = "ESPANHA" },
                new Alternativa { Correta = false, Descricao = "REINO UNIDO" },
                new Alternativa { Correta = true, Descricao = "ITALIA" }
            }
        },
        new Pergunta
        {
            Id = 27,
            Enunciado = "Como eram chamados os pilotos suicidas da Segunda Guerra?",
            Alternativas = new()
            {
                new Alternativa { Correta = true, Descricao = "CAMICASES" },
                new Alternativa { Correta = false, Descricao = "SASHIMIS" },
                new Alternativa { Correta = false, Descricao = "HARAQUIRIS" },
                new Alternativa { Correta = false, Descricao = "SUMÔS" }
            }
        },
        new Pergunta
        {
            Id = 28,
            Enunciado = "O Coliseu é um monumento histórico de que cidade européia?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "PARIS" },
                new Alternativa { Correta = false, Descricao = "COPENHAGU" },
                new Alternativa { Correta = true, Descricao = "ROMA" },
                new Alternativa { Correta = false, Descricao = "LONDRES" }
            }
        },
        new Pergunta
        {
            Id = 29,
            Enunciado = "Que rio corta a cidade de Paris, na França?",
            Alternativas = new()
            {
                new Alternativa { Correta = true, Descricao = "SENA" },
                new Alternativa { Correta = false, Descricao = "TÂMISA" },
                new Alternativa { Correta = false, Descricao = "RENO" },
                new Alternativa { Correta = false, Descricao = "AUBE" }
            }
        },
        new Pergunta
        {
            Id = 30,
            Enunciado = "Quantos quilates tem o ouro puro?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "18" },
                new Alternativa { Correta = false, Descricao = "20" },
                new Alternativa { Correta = true, Descricao = "24" },
                new Alternativa { Correta = false, Descricao = "30" }
            }
        },
        new Pergunta
        {
            Id = 31,
            Enunciado = "Que atriz protagonizou o filme “Titanic”?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "CAMERON DIAZ" },
                new Alternativa { Correta = true, Descricao = " KATE WINSLET" },
                new Alternativa { Correta = false, Descricao = " BRIDGET FONDA" },
                new Alternativa { Correta = false, Descricao = "ATHERINE ZETTA JONES" }
            }
        },
        new Pergunta
        {
            Id = 32,
            Enunciado = "Como é chamada a doença que causa perda desigual da melanina??",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "ASTIGMATISMO" },
                new Alternativa { Correta = false, Descricao = "TENDINITE" },
                new Alternativa { Correta = true, Descricao = "VITILIGO" },
                new Alternativa { Correta = false, Descricao = "VITINGA" }
            }
        },
        new Pergunta
        {
            Id = 33,
            Enunciado = "No filme, quem era parceiro de crimes da Bonnie??",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "BILL" },
                new Alternativa { Correta = true, Descricao = "CLYDE" },
                new Alternativa { Correta = false, Descricao = "JAMES" },
                new Alternativa { Correta = false, Descricao = "BUTCH" }
            }
        },
        new Pergunta
        {
            Id = 34,
            Enunciado = "Que planta era usada para fabricação de papel no antigo Egito?",
            Alternativas = new()
            {
                new Alternativa { Correta = true, Descricao = "PAPIRO" },
                new Alternativa { Correta = false, Descricao = "EUCALIPTO" },
                new Alternativa { Correta = false, Descricao = "OLIVEIRA" },
                new Alternativa { Correta = false, Descricao = "MILHO" }
            }
        },
        new Pergunta
        {
            Id = 35,
            Enunciado = "Que país europeu tem como atração a tourada?",
            Alternativas = new()
            {
                new Alternativa { Correta = true, Descricao = "ESPANHA" },
                new Alternativa { Correta = false, Descricao = "ITÁLIA " },
                new Alternativa { Correta = false, Descricao = "FRANÇA" },
                new Alternativa { Correta = false, Descricao = "ALEMANHA " }
            }
        },
        new Pergunta
        {
            Id = 36,
            Enunciado = "Quem pintou o quadro “La Gioconda”, conhecido como “Mona Lisa”?",
            Alternativas = new()
            {
                new Alternativa { Correta = true, Descricao = "LEONARDO DA VINC" },
                new Alternativa { Correta = false, Descricao = "TICIANO" },
                new Alternativa { Correta = false, Descricao = "RAFAEL" },
                new Alternativa { Correta = false, Descricao = "MICHELÂNGELO" }
            }
        },
        new Pergunta
        {
            Id = 37,
            Enunciado = "Quando começou e terminou a Primeira Guerra Mundial?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "1914-1918" },
                new Alternativa { Correta = false, Descricao = "1939-1945" },
                new Alternativa { Correta = false, Descricao = "1921-1932" },
                new Alternativa { Correta = true, Descricao = "1912-1915" }
            }
        },
        new Pergunta
        {
            Id = 38,
            Enunciado = "Qual é a letra do alfabeto que simboliza o número dez em algarismo romano?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "V" },
                new Alternativa { Correta = false, Descricao = "D" },
                new Alternativa { Correta = false, Descricao = "L " },
                new Alternativa { Correta = true, Descricao = "X" }
            }
        },
        new Pergunta
        {
            Id = 39,
            Enunciado = "Em que continente se situa o rio Nilo??",
            Alternativas = new()
            {
                new Alternativa { Correta = true, Descricao = "AFRICANO" },
                new Alternativa { Correta = false, Descricao = "EUROPEU" },
                new Alternativa { Correta = false, Descricao = "AMERICANO" },
                new Alternativa { Correta = false, Descricao = "ASIÁTICO" }
            }
        },
        new Pergunta
        {
            Id = 40,
            Enunciado = "Nova Delhi é a capital de que país?",
            Alternativas = new()
            {
                new Alternativa { Correta = false, Descricao = "ISLÂNDIA" },
                new Alternativa { Correta = false, Descricao = "PAQUISTÃO" },
                new Alternativa { Correta = true, Descricao = "ÍNDIA" },
                new Alternativa { Correta = false, Descricao = "MÉXICO" }
            }
        },
    };

    static List<Pergunta> perguntas_dificeis = new()
        {
            new Pergunta
            {
                Id = 41,
                Enunciado = "Quantos jogadores um jogo de vôlei reúne na quadra??",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "SEIS" },
                    new Alternativa { Correta = true, Descricao = "OITO" },
                    new Alternativa { Correta = false, Descricao = "ONZE" },
                    new Alternativa { Correta = false, Descricao = "DOZE" }
                }

            },
            new Pergunta
            {
                Id = 42,
                Enunciado = "A cidade de Pompéia, que foi soterrada por um vulcão fica em qual desses países?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "JAPÃO" },
                    new Alternativa { Correta = true, Descricao = "MÉXICO" },
                    new Alternativa { Correta = false, Descricao = "ITÁLIA" },
                    new Alternativa { Correta = false, Descricao = "BRASIL" }
                }
            },
            new Pergunta
            {
                Id = 43,
                Enunciado = "Qual o campeão da Copa do Mundo de Futebol de 1974?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "ALEMANHA" },
                    new Alternativa { Correta = false, Descricao = "FRANÇA" },
                    new Alternativa { Correta = false, Descricao = "ITÁLIA" },
                    new Alternativa { Correta = false, Descricao = "BRASIL" }
                }
            },

            new Pergunta
            {
                Id = 44,
                Enunciado = "O alpinismo é praticado em que lugar??",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "MAR" },
                    new Alternativa { Correta = false, Descricao = "RIO" },
                    new Alternativa { Correta = false, Descricao = "MONTANHA" },
                    new Alternativa { Correta = false, Descricao = "PRAIA" }
                }
            },

            new Pergunta
            {
                Id = 45,
                Enunciado = "Que imperador pôs fogo em Roma?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "TRAJANO" },
                    new Alternativa { Correta = false, Descricao = "BRUTOS" },
                    new Alternativa { Correta = true, Descricao = "NERO" },
                    new Alternativa { Correta = false, Descricao = "CALÍGULA" }
                }
            },
            new Pergunta
            {
                Id = 46,
                Enunciado = "A cidade de Pompéia, que foi soterrada por um vulcão fica em qual desses países?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ESTADOS UNIDOS" },
                    new Alternativa { Correta = false, Descricao = "ESPANHA" },
                    new Alternativa { Correta = false, Descricao = "REINO UNIDO" },
                    new Alternativa { Correta = true, Descricao = "ITALIA" }
                }
            },
            new Pergunta
            {
                Id = 47,
                Enunciado = "Como eram chamados os pilotos suicidas da Segunda Guerra?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "CAMICASES" },
                    new Alternativa { Correta = false, Descricao = "SASHIMIS" },
                    new Alternativa { Correta = false, Descricao = "HARAQUIRIS" },
                    new Alternativa { Correta = false, Descricao = "SUMÔS" }
                }
            },
            new Pergunta
            {
                Id = 48,
                Enunciado = "O Coliseu é um monumento histórico de que cidade européia?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PARIS" },
                    new Alternativa { Correta = false, Descricao = "COPENHAGU" },
                    new Alternativa { Correta = true, Descricao = "ROMA" },
                    new Alternativa { Correta = false, Descricao = "LONDRES" }
                }
            },
            new Pergunta
            {
                Id = 49,
                Enunciado = "Que rio corta a cidade de Paris, na França?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "SENA" },
                    new Alternativa { Correta = false, Descricao = "TÂMISA" },
                    new Alternativa { Correta = false, Descricao = "RENO" },
                    new Alternativa { Correta = false, Descricao = "AUBE" }
                }
            },
            new Pergunta
            {
                Id = 50,
                Enunciado = "Quantos quilates tem o ouro puro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "18" },
                    new Alternativa { Correta = false, Descricao = "20" },
                    new Alternativa { Correta = true, Descricao = "24" },
                    new Alternativa { Correta = false, Descricao = "30" }
                }
            },
            new Pergunta
            {
                Id = 51,
                Enunciado = "Que atriz protagonizou o filme “Titanic”?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CAMERON DIAZ" },
                    new Alternativa { Correta = true, Descricao = " KATE WINSLET" },
                    new Alternativa { Correta = false, Descricao = " BRIDGET FONDA" },
                    new Alternativa { Correta = false, Descricao = "ATHERINE ZETTA JONES" }
                }
            },
            new Pergunta
            {
                Id = 52,
                Enunciado = "Como é chamada a doença que causa perda desigual da melanina??",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ASTIGMATISMO" },
                    new Alternativa { Correta = false, Descricao = "TENDINITE" },
                    new Alternativa { Correta = true, Descricao = "VITILIGO" },
                    new Alternativa { Correta = false, Descricao = "VITINGA" }
                }
            },
            new Pergunta
            {
                Id = 53,
                Enunciado = "No filme, quem era parceiro de crimes da Bonnie??",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "BILL" },
                    new Alternativa { Correta = true, Descricao = "CLYDE" },
                    new Alternativa { Correta = false, Descricao = "JAMES" },
                    new Alternativa { Correta = false, Descricao = "BUTCH" }
                }
            },
            new Pergunta
            {
                Id = 54,
                Enunciado = "Que planta era usada para fabricação de papel no antigo Egito?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "PAPIRO" },
                    new Alternativa { Correta = false, Descricao = "EUCALIPTO" },
                    new Alternativa { Correta = false, Descricao = "OLIVEIRA" },
                    new Alternativa { Correta = false, Descricao = "MILHO" }
                }
            },
            new Pergunta
            {
                Id = 55,
                Enunciado = "Que país europeu tem como atração a tourada?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "ESPANHA" },
                    new Alternativa { Correta = false, Descricao = "ITÁLIA " },
                    new Alternativa { Correta = false, Descricao = "FRANÇA" },
                    new Alternativa { Correta = false, Descricao = "ALEMANHA " }
                }
            },
            new Pergunta
            {
                Id = 56,
                Enunciado = "Quem pintou o quadro “La Gioconda”, conhecido como “Mona Lisa”?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "LEONARDO DA VINC" },
                    new Alternativa { Correta = false, Descricao = "TICIANO" },
                    new Alternativa { Correta = false, Descricao = "RAFAEL" },
                    new Alternativa { Correta = false, Descricao = "MICHELÂNGELO" }
                }
            },
            new Pergunta
            {
                Id = 57,
                Enunciado = "Quando começou e terminou a Primeira Guerra Mundial?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "1914-1918" },
                    new Alternativa { Correta = false, Descricao = "1939-1945" },
                    new Alternativa { Correta = false, Descricao = "1921-1932" },
                    new Alternativa { Correta = true, Descricao = "1912-1915" }
                }
            },
            new Pergunta
            {
                Id = 58,
                Enunciado = "Qual é a letra do alfabeto que simboliza o número dez em algarismo romano?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "V" },
                    new Alternativa { Correta = false, Descricao = "D" },
                    new Alternativa { Correta = false, Descricao = "L " },
                    new Alternativa { Correta = true, Descricao = "X" }
                }
            },
            new Pergunta
            {
                Id = 59,
                Enunciado = "Em que continente se situa o rio Nilo??",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "AFRICANO" },
                    new Alternativa { Correta = false, Descricao = "EUROPEU" },
                    new Alternativa { Correta = false, Descricao = "AMERICANO" },
                    new Alternativa { Correta = false, Descricao = "ASIÁTICO" }
                }
            },
            new Pergunta
            {
                Id = 60,
                Enunciado = "Nova Delhi é a capital de que país?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ISLÂNDIA" },
                    new Alternativa { Correta = false, Descricao = "PAQUISTÃO" },
                    new Alternativa { Correta = true, Descricao = "ÍNDIA" },
                    new Alternativa { Correta = false, Descricao = "MÉXICO" }
                }
            },
        };

    static List<Pergunta> perguntas_finais = new()
        {
            new Pergunta
            {
                Id = 61,
                Enunciado = "Quantos jogadores um jogo de vôlei reúne na quadra??",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "SEIS" },
                    new Alternativa { Correta = true, Descricao = "OITO" },
                    new Alternativa { Correta = false, Descricao = "ONZE" },
                    new Alternativa { Correta = false, Descricao = "DOZE" }
                }

            },
            new Pergunta
            {
                Id = 62,
                Enunciado = "A cidade de Pompéia, que foi soterrada por um vulcão fica em qual desses países?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "JAPÃO" },
                    new Alternativa { Correta = true, Descricao = "MÉXICO" },
                    new Alternativa { Correta = false, Descricao = "ITÁLIA" },
                    new Alternativa { Correta = false, Descricao = "BRASIL" }
                }
            },
            new Pergunta
            {
                Id = 63,
                Enunciado = "Qual o campeão da Copa do Mundo de Futebol de 1974?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "ALEMANHA" },
                    new Alternativa { Correta = false, Descricao = "FRANÇA" },
                    new Alternativa { Correta = false, Descricao = "ITÁLIA" },
                    new Alternativa { Correta = false, Descricao = "BRASIL" }
                }
            },

            new Pergunta
            {
                Id = 64,
                Enunciado = "O alpinismo é praticado em que lugar??",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "MAR" },
                    new Alternativa { Correta = false, Descricao = "RIO" },
                    new Alternativa { Correta = false, Descricao = "MONTANHA" },
                    new Alternativa { Correta = false, Descricao = "PRAIA" }
                }
            },

            new Pergunta
            {
                Id = 65,
                Enunciado = "Que imperador pôs fogo em Roma?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "TRAJANO" },
                    new Alternativa { Correta = false, Descricao = "BRUTOS" },
                    new Alternativa { Correta = true, Descricao = "NERO" },
                    new Alternativa { Correta = false, Descricao = "CALÍGULA" }
                }
            },
            
            
        };

    static List<Pergunta> perguntas_sorteadas = new();



    public static Pergunta getRandomPerguntaFacil()
    {
        Random r = new Random();
        Pergunta pergunta_sorteada;
        while (true) 
        {
            int sorteado = r.Next(1, 20);
            pergunta_sorteada= perguntas_faceis[sorteado];
            if (!perguntas_sorteadas.Contains(pergunta_sorteada))
            {
                perguntas_sorteadas.Add(pergunta_sorteada);
                break;
            }
        }
        return pergunta_sorteada;
    }

    public static Pergunta getRandomPerguntaMedia()
    {
        Random r = new Random();
        Pergunta pergunta_sorteada;
        while (true)
        {
            int sorteado = r.Next(21, 40);
            pergunta_sorteada = perguntas_medias[sorteado];
            if (!perguntas_sorteadas.Contains(pergunta_sorteada))
            {
                perguntas_sorteadas.Add(pergunta_sorteada);
                break;
            }
        }
        return pergunta_sorteada;
    }

    public static Pergunta getRandomPerguntaDificil()
    {
        Random r = new Random();
        Pergunta pergunta_sorteada;
        while (true)
        {
            int sorteado = r.Next(41, 60);
            pergunta_sorteada = perguntas_dificeis[sorteado];
            if (!perguntas_sorteadas.Contains(pergunta_sorteada))
            {
                perguntas_sorteadas.Add(pergunta_sorteada);
                break;
            }
        }
        return pergunta_sorteada;
    }

    public static Pergunta getRandomPerguntaFinal()
    {
        Random r = new Random();
        Pergunta pergunta_sorteada;
        while (true)
        {
            int sorteado = r.Next(61, 65);
            pergunta_sorteada = perguntas_finais[sorteado];
            if (!perguntas_sorteadas.Contains(pergunta_sorteada))
            {
                perguntas_sorteadas.Add(pergunta_sorteada);
                break;
            }
        }
        return pergunta_sorteada;
    }



}