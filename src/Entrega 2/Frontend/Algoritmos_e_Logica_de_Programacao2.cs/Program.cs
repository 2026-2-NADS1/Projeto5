using System.Diagnostics;
using Spectre.Console;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// ===================== BANCO DE QUESTÕES =====================
string[] faixasEtarias = {
    "Até 12 anos", "13 a 17 anos", "18 a 24 anos",
    "25 a 39 anos", "40 anos ou mais", "Prefiro não informar"
};

string[] enunciados = {
    //faceis
    "Qual linha de chocolates da Arcor ficou conhecida por um divertido 'ritual' na hora de consumir o produto?",
    "De que país vem a Arcor?",
    "Qual marca da Arcor sabe contar até 7?",
    "Qual marca da Arcor é ideal para estourar bola de chiclete na cara do amigo?",
    "Qual bicho é o mascote da Tortuguita e nunca chega atrasado, porque nunca teve pressa?",
    "Qual sabor clássico de Poosh faz festa na boca?",
    "Qual personagem já virou ovo de Páscoa com fone de ouvido de brinde?",
    "Qual marca da Arcor é para quem acha que chocolate bom é (muito chocolate, muito recheio)?",
    "Qual bombom da Arcor é um abraço em forma de doce: wafer crocante, recheio cremoso e chocolate por fora?",
    //medias
    "Em 1996, um icônico comercial da Tortuguita foi ao ar em todo o Brasil, marcando uma geração. Qual foi o famoso bordão?",
    "A Tortuguita é parceira de qual projeto de proteção às tartarugas marinhas?",
    "Qual doce brasileiro de amendoim ganhou versão de Bon o Bon?",
    "Qual marca da Arcor fez gominhas em formato de fantasma para o Halloween?",
    "Quem fundou a Arcor?",
    "O Bon o Bon, que era só bombom, estreou no Brasil em qual categoria nova?",
    "Em 2026, o sabor 7Belo foi parar em qual produto 'de academia'?",
    "Além do chocolate ao leite, qual versão de chocolate a Tortuguita também tem?",
    "Qual sabor de 7Belo existe de verdade?",
    "A 7Belo é uma bala de que tipo?",
    //dificeis
    "Em que ano a Arcor iniciou suas atividades no Brasil?",
    "A Arcor está presente em cerca de quantos países?",
    "Em qual década a Arcor chegou ao Brasil?",
    "Qual dessas marcas a Arcor comprou da Nestlé?",
    "Em qual cidade paulista fica a fábrica de chocolates da Arcor?",
    "Em que ano a Arcor foi fundada?",
    "Em qual cidade nasceu a Arcor?",
    "A Arcor estreou em qual evento 'gamer' gigante do Brasil?",
    "Qual é o nome da linha de Mogul que chegou ao Brasil?",
    "As gominhas Mogul 360 chamam atenção por serem...?",

};


//NIVEL DO PROF
string[] niveis = { 
    "F", "F", "F", "F", "F", "F", "F", "F", "F", 
    "M", "M", "M", "M", "M", "M", "M", "M", "M", "M",
    "D", "D", "D", "D", "D", "D", "D", "D", "D", "D"
    
};


string[] dicas = {
    //faceis
    "Pense na marca ligada a um personagem animal e a uma brincadeira na hora de comer, não só ao sabor.",
    "É o vizinho do Brasil famoso por tango, mate e alfajor.",
    "O nome da marca já carrega um número.",
    "Pense em chiclete: só uma marca da lista é de goma de mascar",
    "Animal lento que carrega a casa nas costas. Pense no casco!",
    "O nome do sabor vem do italiano e significa, literalmente, “todas as frutas”.",
    "É o personagem mais famoso da Arcor no Brasil, o mesmo mascote que aparece nas versões de Páscoa.",
    "O nome lembra “bloco” em inglês, e a proposta da marca é ter chocolate de sobra.",
    "O nome brinca com a palavra “bom”, dita duas vezes. Wafer, recheio e chocolate: é o bombom clássico da marca.",
    //media
    "Pense em uma palavra engraçada, de xingamento leve e antigo.",
    "O nome do projeto é a junção de “tartaruga” com “marinha”. Ele atua no litoral brasileiro.",
    "É um doce tradicional de festas juninas, que se desmancha na boca.",
    "Gominhas de fantasma lembram jujubas.",
    "Elimine os nomes fictícios.",
    "Pense em algo seco e crocante vendido em pacote, que combina com o wafer do bombom. Nada de comida de prato.",
    "Em 2026, “academia” remete a suplementos. Pense naquele pó que o pessoal mistura na garrafinha antes do treino.",
    "Pense na versão mais clara do chocolate.",
    "É um sabor de fruta vermelha, parecido com morango, comum em doces. Elimine os sabores salgados.",
    "Pense na textura: uma bala que você mastiga. Líquida, de ferro e de fumaça não fazem sentido para bala.",
    //dificeis
    "Foi nos anos 80, bem no começo da década. Entre as opções, duas são dessa época: pense na mais próxima do início.",
    "Ela é multinacional de grande porte. Elimine os extremos.",
    "A Arcor já existia na Argentina desde meados do século XX, então chegou ao Brasil décadas depois, mas antes dos anos 2000.",
    "Entre as opções, três são chocolates muito conhecidos. A Arcor é forte em guloseimas, então pense em goma de mascar.",
    "Só uma das opções fica em São Paulo. As outras ficam no Sul, no Nordeste e no Norte do país.",
    "Foi em meados do século XX, depois da Segunda Guerra Mundial.",
    "Não é a capital nem uma grande cidade: é um município pequeno da província de Córdoba, na Argentina.",
    "Pense em um evento de games.",
    "O número no nome lembra um giro completo, em graus.",
    "A pergunta anterior dá a pista: a linha “360” sugere uma gominha que dá para ver por todos os lados. Elimine invisível, pneu e cantora",    

};


string[,] alternativas = {
    //faceis
    { "7Belo", "Tortuguita", "Bon o Bon", "Triunfo" },
    { "Chile", "Argentina ", "Itália", "Suíça" },
    { "Bon o Bon", "Tortuguita", "Poosh", "7Belo" },
    { "Triunfo", "Amor", "Butter Toffees", "Poosh"},
    { "Coelho", "Preguiça", "Tartaruga", "Caracol"},
    { "Feijoada", "Tutti frutti", "Cebola", "Churrasco"},
    { "Block", "Mogul", "7Belo", "Tortuguita"},
    { "Poosh", "Block", "Mogul", "7Belo"},
    { "Bon o Bon", "Poosh", "Mogul", "7Belo"},
    //medias
    { "Paspalho", "Estrupício", "Abestado", "Estúpida"},
    { "Tartarugas Ninja", "Projeto Casquinha", "Projeto Tamar", "Operação Casco"},
    { "Pão de queijo", "Coxinha", "Paçoca", "Cuscuz"},
    { "Poosh", "Block", "Tortuguita", "Mogul"},
    { "Willy Wonka", "Papai Noel", "Grinch", "Fulvio Pagani"},
    { "Macarrão", "Sopa", "Biscoito", "Feijão"},
    { "Halteres", "Esteira", "Creatina e pré-treino", "Cinta modeladora"},
    { "Branco", "Verde", "Invisível", "De feijão"},
    { "Framboesa", "Brócolis", "Sardinha", "Cebola"},
    { "Mastigável", "Líquida", "Feita de ferro", "Que vira fumaça"},
    //dificeis
    { "1971", "1981", "1984", "1993"},
    { "Só 3", "12", "Cerca de 120", "Só 1"},
    { "1950", "1980", "2000", "2020"},
    { "Kit Kat", "Poosh", "Bis", "Sonho de Valsa"},
    { "Gramado", "Bragança Paulista", "Fortaleza", "Manaus"},
    { "1851", "2021", "2001", "1951"},
    { "Arroyito", "Buenos Aires", "Rosário", "Mendoza"},
    { "Rock in Rio", "Brasil Game Show (BGS)", "Festa do Peão", "Feira do Livro"},
    { "Mogul 180", "Mogul 360", "Mogul 90", "Mogul 1000"},
    { "Quadradas e invisíveis", "Gigantes como pneus", "Capazes de cantar quando mordidas", "Translúcidas e em 3D"},
};


int[] corretas = { 
    1, 1, 3, 3, 2, 1, 3, 1, 0, 
    3, 2, 2, 3, 3, 2, 2, 0, 0, 0,
    1, 2, 1, 1, 1, 3, 0, 1, 1, 3,
    };

// ===================== INÍCIO DO JOGO =====================
MostrarAbertura();
string nickname = LerNickname();
string faixa = LerFaixaEtaria(faixasEtarias);

int totalQuestoes = enunciados.Length;
int[] questoesPorNivel = new int[3];
int[] acertosPorNivel = new int[3];
bool[] usouDica = new bool[totalQuestoes];
bool terminou = false;

Stopwatch cronometro = Stopwatch.StartNew();

for (int i = 0; i < totalQuestoes; i++)
{
    int segundos = (int)cronometro.Elapsed.TotalSeconds;
    int minutos = segundos / 60;
    int segs = segundos % 60;
    AnsiConsole.Write(new Rule($"Questão {i + 1} de {totalQuestoes} | Tempo: {minutos} min {segs} s"));

    string[] opcoes = ExtrairAlternativas(alternativas, i);
    int resultado = MostrarQuestao(enunciados[i], opcoes, corretas[i], dicas[i], usouDica, i);

    if (resultado == -1)
    {
        terminou = true;
        break;
    }

    int nivel = IndiceNivel(niveis[i]);
    questoesPorNivel[nivel]++;

    if (resultado == 1)
    {
        acertosPorNivel[nivel]++;
        AnsiConsole.MarkupLine("[green]Você acertou![/]");
    }
    else
    {
        AnsiConsole.MarkupLine("[red]Você errou.[/] Resposta certa: " + Markup.Escape(opcoes[corretas[i]]));
    }
}

cronometro.Stop();

if (terminou)
{
    AnsiConsole.MarkupLine("[yellow]Quiz encerrado pelo jogador. Até a próxima![/]");
}
else
{
    int tempo = (int)cronometro.Elapsed.TotalSeconds;
    int dicasUsadas = ContarDicas(usouDica);
    MostrarRelatorio(nickname, faixa, questoesPorNivel, acertosPorNivel, dicasUsadas, tempo);
}

// ===================== FUNÇÕES =====================

static void MostrarAbertura()
{
    Console.Clear();
    AnsiConsole.Write(new FigletText("Desafio das Marcas").Color(Color.Green));
    AnsiConsole.MarkupLine("[yellow]Bem-vindo ao quiz da Arcor![/]");
    AnsiConsole.MarkupLine("Use as setas para escolher a resposta e tecle Enter.");
    AnsiConsole.MarkupLine("Cada dica usada custa 5 pontos. Escolha TERMINAR para sair a qualquer momento.");
    Console.WriteLine();
}

static string LerNickname()
{
    return AnsiConsole.Ask<string>("Digite seu [green]nickname[/]:");
}

static string LerFaixaEtaria(string[] faixas)
{
    SelectionPrompt<string> prompt = new SelectionPrompt<string>();
    prompt.Title("Escolha sua [green]faixa etária[/]:");
    prompt.AddChoices(faixas);
    return AnsiConsole.Prompt(prompt);
}

static string[] ExtrairAlternativas(string[,] alternativas, int linha)
{
    int quantidade = alternativas.GetLength(1);
    string[] opcoes = new string[quantidade];
    for (int j = 0; j < quantidade; j++)
    {
        opcoes[j] = alternativas[linha,j];
    }
    return opcoes;
}

static int MostrarQuestao(string enunciado, string[] opcoes, int correta, string dica, bool[] usouDica, int indice)
{
    SelectionPrompt<string> prompt = new SelectionPrompt<string>();
    prompt.Title(Markup.Escape(enunciado));
    prompt.AddChoices(opcoes);
    prompt.AddChoices("MOSTRAR DICA", "TERMINAR");

    string escolha = AnsiConsole.Prompt(prompt);

    while (escolha == "MOSTRAR DICA")
    {
        usouDica[indice] = true;
        AnsiConsole.Status().Start("Buscando a dica...", ctx =>
        {
            Thread.Sleep(1500);
        });
        AnsiConsole.MarkupLine("[yellow]Dica:[/] " + Markup.Escape(dica));
        escolha = AnsiConsole.Prompt(prompt);
    }

    if (escolha == "TERMINAR")
    {
        return -1;
    }
    if (escolha == opcoes[correta])
    {
        return 1;
    }
    return 0;
}

static int IndiceNivel(string nivel)
{
    if (nivel == "F")
    {
        return 0;
    }
    else if (nivel == "M")
    {
        return 1;
    }
    return 2;
}

static int ContarDicas(bool[] usouDica)
{
    int total = 0;
    for (int i = 0; i < usouDica.Length; i++)
    {
        if (usouDica[i])
        {
            total++;
        }
    }
    return total;
}

static double Percentual(int acertos, int questoes)
{
    return acertos * 100.0 / questoes;
}

static int CalcularPontuacao(int[] acertosPorNivel, int dicas)
{
    int[] pesos = { 10, 20, 30 };
    int pontos = 0;
    for (int n = 0; n < 3; n++)
    {
        pontos = pontos + acertosPorNivel[n] * pesos[n];
    }
    pontos = pontos - dicas * 5;
    if (pontos < 0)
    {
        pontos = 0;
    }
    return pontos;
}

static int CalcularPontuacaoMaxima(int[] questoesPorNivel)
{
    int[] pesos = { 10, 20, 30 };
    int maximo = 0;
    for (int n = 0; n < 3; n++)
    {
        maximo = maximo + questoesPorNivel[n] * pesos[n];
    }
    return maximo;
}

static string Classificar(double percentual)
{
    if (percentual >= 90)
    {
        return "Mestre das Marcas";
    }
    else if (percentual >= 70)
    {
        return "Conhecedor de Marcas";
    }
    else if (percentual >= 50)
    {
        return "Aprendiz";
    }
    return "Iniciante";
}

static string GerarBarra(int acertos)
{
    string barra = "";
    for (int i = 0; i < acertos; i++)
    {
        barra = barra + "*";
    }
    return barra;
}

static string DefinirRitmo(double mediaPorQuestao)
{
    if (mediaPorQuestao <= 10)
    {
        return "Rápido (até 10 s)";
    }
    else if (mediaPorQuestao <= 20)
    {
        return "Normal (até 20 s)";
    }
    return "Pausado (acima de 20 s)";
}

static string MelhorNivel(int[] questoesPorNivel, int[] acertosPorNivel, string[] nomesNiveis)
{
    // DESAFIO B (opcional): percorra os 3 níveis com um for, ignore os níveis
    // não jogados e devolva o nome do nível de maior percentual.
    // Em caso de empate, vence o nível mais difícil.
    // Dica: use a função Percentual e o vetor nomesNiveis.
    return "(não calculado)";
}

static void MostrarRelatorio(string nickname, string faixa, int[] questoesPorNivel, int[] acertosPorNivel, int dicas, int tempo)
{
    string[] nomesNiveis = { "Fácil", "Médio", "Difícil" };

    int totalQuestoes = 0;
    int totalAcertos = 0;
    for (int n = 0; n < 3; n++)
    {
        totalQuestoes = totalQuestoes + questoesPorNivel[n];
        totalAcertos = totalAcertos + acertosPorNivel[n];
    }

    double percentualGeral = Percentual(totalAcertos, totalQuestoes);
    int pontos = CalcularPontuacao(acertosPorNivel, dicas);
    int maximo = CalcularPontuacaoMaxima(questoesPorNivel);
    double media = tempo / totalQuestoes;

    Console.WriteLine();
    Console.WriteLine("===== ARCOR – DESAFIO DAS MARCAS: RESUMO DA PARTIDA =====");
    Console.WriteLine("Jogador: " + nickname);
    Console.WriteLine("Faixa etária: " + faixa);
    Console.WriteLine();
    Console.WriteLine("Desempenho por nível:");
    for (int n = 0; n < 3; n++)
    {
        if (questoesPorNivel[n] == 0)
        {
            Console.WriteLine($"{nomesNiveis[n],-8}(0/0)  não jogado");
        }
        else
        {
            double p = Percentual(acertosPorNivel[n], questoesPorNivel[n]);
            Console.WriteLine($"{nomesNiveis[n],-8}({acertosPorNivel[n]}/{questoesPorNivel[n]})  {p,5:F1}%  {GerarBarra(acertosPorNivel[n])}");
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Total: {totalAcertos} acertos e {totalQuestoes - totalAcertos} erros em {totalQuestoes} questões ({percentualGeral:F1}%)");
    Console.WriteLine($"Pontuação: {pontos} de {maximo} pontos possíveis ({pontos * 100.0 / maximo:F1}%)");
    Console.WriteLine($"Dicas usadas: {dicas} (penalidade de {dicas * 5} pontos)");
    Console.WriteLine($"Tempo total: {tempo / 60} min {tempo % 60} s | Média: {media:F1} s por questão");
    Console.WriteLine("Ritmo: " + DefinirRitmo(media));
    Console.WriteLine("Melhor nível: " + MelhorNivel(questoesPorNivel, acertosPorNivel, nomesNiveis));
    Console.WriteLine("Classificação: " + Classificar(percentualGeral));
    Console.WriteLine("=========================================================");
}