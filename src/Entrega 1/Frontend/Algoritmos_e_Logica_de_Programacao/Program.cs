//-----------------------------------------------------------------------NICKNAME----------------------------------------------------------------------------------------------------

Console.Clear();

string? playerNickName;

Console.WriteLine(new string('-', 50));
Console.WriteLine("Seja bem Vindo ao Jogo da Tortuguita");
Console.WriteLine(new string('-', 50));
Console.WriteLine("Digite seu nome:");
playerNickName = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(playerNickName))
{
    Console.Clear();
    Console.WriteLine(new string('-', 50));
    Console.WriteLine($"Seja bem Vindo, {playerNickName}!");
}
else
{
    Console.Clear();
    Console.WriteLine("ERRO na entrada 1 (nickname): nome vazio.");
    Environment.Exit(1);
}

//-----------------------------------------------------------------------IDADE----------------------------------------------------------------------------------------------------

string? playerAge = "", playerAgeQuestion;
int playerAgeQuestionNumber;

Console.WriteLine(new string('-', 50));
Console.WriteLine("Qual é a sua faixa etária? [1 a 6]");
playerAgeQuestion = Console.ReadLine();
Console.WriteLine(new string('-', 50));

if (!int.TryParse(playerAgeQuestion, out playerAgeQuestionNumber))
{
    Console.Clear();
    Console.WriteLine("ERRO na entrada 2 (faixa etária): valor mal formado.");
    Environment.Exit(1);
}

if (playerAgeQuestionNumber < 1 || playerAgeQuestionNumber > 6)
{
    Console.Clear();
    Console.WriteLine("ERRO na entrada 2 (faixa etária): valor fora do intervalo de 1 a 6.");
    Environment.Exit(1);
}

if (playerAgeQuestionNumber == 1)
{
    playerAge = "até 12 anos";
}
else if (playerAgeQuestionNumber == 2)
{
    playerAge = "13 a 17 anos";
}
else if (playerAgeQuestionNumber == 3)
{
    playerAge = "18 a 24 anos";
}
else if (playerAgeQuestionNumber == 4)
{
    playerAge = "25 a 39 anos";
}
else if (playerAgeQuestionNumber == 5)
{
    playerAge = "40 anos ou mais";
}
else if (playerAgeQuestionNumber == 6)
{
    playerAge = "Prefiro não informar";
}

Console.Clear();
Console.WriteLine(new string('-', 50));
Console.WriteLine($"{playerNickName}, sua faixa etária é {playerAge}");
Console.WriteLine(new string('-', 50));

//-----------------------------------------------------------------------FACIL----------------------------------------------------------------------------------------------------

int easyQuestions, playerResultEasy;

Console.WriteLine(new string('-', 50));
Console.WriteLine("Quantas questões fáceis foram apresentadas?");
string? linha1 = Console.ReadLine();

if (!int.TryParse(linha1, out easyQuestions))
{
    Console.Clear();
    Console.WriteLine($"ERRO na entrada 3 (questões fáceis): valor '{linha1}' mal formado.");
    Environment.Exit(1);
}

if (easyQuestions < 0)
{
    Console.Clear();
    Console.WriteLine("ERRO na entrada 3 (questões fáceis): a quantidade não pode ser negativa.");
    Environment.Exit(1);
}

Console.WriteLine(new string('-', 50));
Console.WriteLine($"Tudo bem {playerNickName}, de {easyQuestions} questões fáceis quantas você acertou?");
string? linha2 = Console.ReadLine();

if (!int.TryParse(linha2, out playerResultEasy))
{
    Console.Clear();
    Console.WriteLine($"ERRO na entrada 4 (acertos fáceis): valor '{linha2}' mal formado.");
    Environment.Exit(1);
}

if (playerResultEasy > easyQuestions || playerResultEasy < 0)
{
    Console.Clear();
    Console.WriteLine($"ERRO na entrada 4 (acertos fáceis): valor fora do intervalo de 0 a {easyQuestions}.");
    Environment.Exit(1);
}

int EasyQuestionsScore = playerResultEasy * 10;

//-----------------------------------------------------------------------MÉDIAS----------------------------------------------------------------------------------------------------

int MediumQuestions, playerResultMedium;

Console.Clear();
Console.WriteLine("Quantas questões médias foram apresentadas?");
string? linha3 = Console.ReadLine();

if (!int.TryParse(linha3, out MediumQuestions))
{
    Console.Clear();
    Console.WriteLine($"ERRO na entrada 5 (questões médias): valor '{linha3}' mal formado.");
    Environment.Exit(1);
}

if (MediumQuestions < 0)
{
    Console.Clear();
    Console.WriteLine("ERRO na entrada 5 (questões médias): a quantidade não pode ser negativa.");
    Environment.Exit(1);
}

Console.WriteLine(new string('-', 50));
Console.WriteLine($"Tudo bem {playerNickName}, de {MediumQuestions} questões médias quantas você acertou?");
string? linha4 = Console.ReadLine();

if (!int.TryParse(linha4, out playerResultMedium))
{
    Console.Clear();
    Console.WriteLine($"ERRO na entrada 6 (acertos médias): valor '{linha4}' mal formado.");
    Environment.Exit(1);
}

if (playerResultMedium > MediumQuestions || playerResultMedium < 0)
{
    Console.Clear();
    Console.WriteLine($"ERRO na entrada 6 (acertos médias): valor fora do intervalo de 0 a {MediumQuestions}.");
    Environment.Exit(1);
}

int MediumQuestionsScore = playerResultMedium * 20;

//-----------------------------------------------------------------------DIFÍCEIS----------------------------------------------------------------------------------------------------

int HardQuestions, playerResultHard;

Console.Clear();
Console.WriteLine(new string('-', 50));
Console.WriteLine("Quantas questões difíceis foram apresentadas?");
string? linha5 = Console.ReadLine();

if (!int.TryParse(linha5, out HardQuestions))
{
    Console.Clear();
    Console.WriteLine($"ERRO na entrada 7 (questões difíceis): valor '{linha5}' mal formado.");
    Environment.Exit(1);
}

if (HardQuestions < 0)
{
    Console.Clear();
    Console.WriteLine("ERRO na entrada 7 (questões difíceis): a quantidade não pode ser negativa.");
    Environment.Exit(1);
}

int TotalQuestions = easyQuestions + MediumQuestions + HardQuestions;

if (TotalQuestions < 1)
{
    Console.Clear();
    Console.WriteLine("ERRO na entrada 7 (questões difíceis): a partida precisa ter pelo menos uma questão no total.");
    Environment.Exit(1);
}

Console.WriteLine(new string('-', 50));
Console.WriteLine($"Tudo bem {playerNickName}, de {HardQuestions} questões difíceis quantas você acertou?");
string? linha6 = Console.ReadLine();

if (!int.TryParse(linha6, out playerResultHard))
{
    Console.Clear();
    Console.WriteLine($"ERRO na entrada 8 (acertos difíceis): valor '{linha6}' mal formado.");
    Environment.Exit(1);
}

if (playerResultHard > HardQuestions || playerResultHard < 0)
{
    Console.Clear();
    Console.WriteLine($"ERRO na entrada 8 (acertos difíceis): valor fora do intervalo de 0 a {HardQuestions}.");
    Environment.Exit(1);
}

int HardQuestionsScore = playerResultHard * 30;

//-----------------------------------------------------------------------TIME----------------------------------------------------------------------------------------------------

int gameplayTime;
Console.WriteLine(new string('-', 50));
Console.WriteLine("Quantos segundos foram usados para completar o jogo?");
string? linha7 = Console.ReadLine();

if (!int.TryParse(linha7, out gameplayTime))
{
    Console.Clear();
    Console.WriteLine("ERRO na entrada 9 (tempo): o valor deve ser inteiro.");
    Environment.Exit(1);
}

if (gameplayTime <= 0)
{
    Console.Clear();
    Console.WriteLine("ERRO na entrada 9 (tempo): o tempo deve ser maior que zero.");
    Environment.Exit(1);
}

//-----------------------------------------------------------------------QUESTIONS----------------------------------------------------------------------------------------------------

int TipsUsed;
Console.WriteLine(new string('-', 50));
Console.WriteLine("Durante a partida, quantas dicas você usou?");
string? linha8 = Console.ReadLine();

if (!int.TryParse(linha8, out TipsUsed))
{
    Console.Clear();
    Console.WriteLine("ERRO na entrada 10 (dicas usadas): o valor deve ser inteiro.");
    Environment.Exit(1);
}

if (TipsUsed < 0 || TipsUsed > TotalQuestions)
{
    Console.Clear();
    Console.WriteLine($"ERRO na entrada 10 (dicas usadas): valor fora do intervalo de 0 a {TotalQuestions}.");
    Environment.Exit(1);
}
else
{
    Console.Clear();
}

//-----------------------------------------------------------------------RESULTS----------------------------------------------------------------------------------------------------

TotalQuestions = easyQuestions + MediumQuestions + HardQuestions;
int TotalCorrect = playerResultEasy + playerResultMedium + playerResultHard;
int TotalErrors = TotalQuestions - TotalCorrect;

double EasyLevelPercent = 0.0;
double MediumLevelPercent = 0.0;
double HardLevelPercent = 0.0;

if (easyQuestions > 0)
{
    EasyLevelPercent = playerResultEasy * 100.0 / easyQuestions;
}

if (MediumQuestions > 0)
{
    MediumLevelPercent = playerResultMedium * 100.0 / MediumQuestions;
}

if (HardQuestions > 0)
{
    HardLevelPercent = playerResultHard * 100.0 / HardQuestions;
}

double MaxLevelPercent = TotalCorrect * 100.0 / TotalQuestions;

double RealScore = EasyQuestionsScore + MediumQuestionsScore + HardQuestionsScore - TipsUsed * 5;

if (RealScore < 0)
{
    RealScore = 0;
}

double ScoreMax = easyQuestions * 10 + MediumQuestions * 20 + HardQuestions * 30;
double ScorePerfomance = RealScore * 100.0 / ScoreMax;

double gameplayMinutes = gameplayTime / 60;
double gameplaySeconds = gameplayTime % 60;

double QuestionsTime = gameplayTime * 1.0 / TotalQuestions;

string? Rythim = "";

double PercentEasy = EasyLevelPercent;
double PercentMedium = MediumLevelPercent;
double PercentHard = HardLevelPercent;

//-----------------------------------------------------------------------REPORT----------------------------------------------------------------------------------------------------

Console.WriteLine("===== ARCOR – DESAFIO DAS MARCAS: RESUMO DA PARTIDA =====");
Console.WriteLine($"Jogador: {playerNickName}");
Console.WriteLine($"Faixa etária: {playerAge}");
Console.WriteLine();
Console.WriteLine("Desempenho por nível:");

//-----------------------------------------------------------------------EASYQUESTIONS----------------------------------------------------------------------------------------------------

if (easyQuestions != 0)
{
    Console.Write($"Fácil ({playerResultEasy}/{easyQuestions}) {PercentEasy:F1}% ");

    for (int i = 0; i < playerResultEasy; i++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
else
{
    Console.WriteLine($"Fácil ({playerResultEasy}/{easyQuestions}) não jogado");
}

//-----------------------------------------------------------------------MEDIUMQUESTIONS----------------------------------------------------------------------------------------------------

if (MediumQuestions != 0)
{
    Console.Write($"Médio ({playerResultMedium}/{MediumQuestions}) {PercentMedium:F1}% ");

    for (int i = 0; i < playerResultMedium; i++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
else
{
    Console.WriteLine($"Médio ({playerResultMedium}/{MediumQuestions}) não jogado");
}

//-----------------------------------------------------------------------HARDQUESTIONS----------------------------------------------------------------------------------------------------

if (HardQuestions != 0)
{
    Console.Write($"Difícil ({playerResultHard}/{HardQuestions}) {PercentHard:F1}% ");

    for (int i = 0; i < playerResultHard; i++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
else
{
    Console.WriteLine($"Difícil ({playerResultHard}/{HardQuestions}) não jogado");
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Console.WriteLine();
Console.WriteLine($"Total: {TotalCorrect} acertos e {TotalErrors} erros em {TotalQuestions} questões ({MaxLevelPercent:F1}%)");
Console.WriteLine($"Pontuação: {RealScore:F0} de {ScoreMax:F0} pontos possíveis ({ScorePerfomance:F1}%)");
Console.WriteLine($"Dicas usadas: {TipsUsed} (penalidade de {TipsUsed * 5} pontos)");
Console.WriteLine($"Tempo total: {gameplayMinutes:F0} min {gameplaySeconds:F0} s | Média: {QuestionsTime:F1} s por questão");

if (QuestionsTime <= 10.0)
{
    Rythim = "Rápido";
}
else if (QuestionsTime <= 20.0)
{
    Rythim = "Normal";
}
else
{
    Rythim = "Pausado";
}

Console.WriteLine($"Ritmo: {Rythim}");

string? MaxHardLevel;
double BestLevelPercent;

if (HardQuestions > 0)
{
    MaxHardLevel = "Difícil";
    BestLevelPercent = PercentHard;
}
else if (MediumQuestions > 0)
{
    MaxHardLevel = "Médio";
    BestLevelPercent = PercentMedium;
}
else
{
    MaxHardLevel = "Fácil";
    BestLevelPercent = PercentEasy;
}

if (MediumQuestions > 0 && PercentMedium > BestLevelPercent)
{
    MaxHardLevel = "Médio";
    BestLevelPercent = PercentMedium;
}

if (easyQuestions > 0 && PercentEasy > BestLevelPercent)
{
    MaxHardLevel = "Fácil";
    BestLevelPercent = PercentEasy;
}

Console.WriteLine($"Melhor nível: {MaxHardLevel}");

string? playerClassification;

if (MaxLevelPercent >= 90.0)
{
    playerClassification = "Mestre das Marcas";
}
else if (MaxLevelPercent >= 70.0)
{
    playerClassification = "Conhecedor de Marcas";
}
else if (MaxLevelPercent >= 50.0)
{
    playerClassification = "Aprendiz";
}
else
{
    playerClassification = "Iniciante";
}

Console.WriteLine($"Classificação: {playerClassification}");
Console.WriteLine("=========================================================");
