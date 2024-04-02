string[][] synonyms =
{
    new [] {"abadiy", "mangu","umurbod", "doimiy", "toabat"}, 
    new [] {"abadiylashtirmoq", "mangulashtirmoq","barqarorlashtirmoq"},
    new []{"abadiylashmoq","barqarorlashmoq","mangulik"},
    new []{"abadiylik", "barhayotlik", "barqarorlik", "mangulik", "doimiylik"},
    new []{"doimo", "abadulabad "},
    new []{"abzats", "xatboshi", "satrboshi"},
    new []{"evara", "abira"},
    new []{"nochor", "xarob", "majruh", "afgor"},
    new []{"abssess", "chipqon"},
    new []{"bulut", "abr"},
    new []{"pachoq", "abjaq", "yaroqsiz"},
    new []{"avaylamoq", "ayamoq","ehtiyotlamoq"},
    new []{"avval", "ilgari","oldin"},
    new []{"avvalgi", "oldingi", "ilgarigi", "burungi"},
    new []{"chevara", "avag‘a"},
    new []{"mavhum", "abstrakt", "xayoliy", "mujmal"},
    new []{"absolyut", "mutlaq"},
    new []{"sarguzasht", "avantyura"},
    new []{"avtomobil", "mashina", "avtomashina"},
    new []{"advokat", "himoyachi", "oqlovchi"},
    new []{"tartibsizlik", "ajiotaj", "alg‘ov-dalg‘ov"},
    new []{"absorbsiya", "yutilish", "shimilish", "singish"},
    new []{"husnixat", "sarxat", "kalligrafiya"},
    new []{"avvaldan", "ilgaridan", "oldindan"},
    new []{"avtomat", "mashina"},
    new []{"avariya", "falokat"},
    new []{"avtoritet", "prestij"},
    new []{"avvalo", "avval", "avvalambor"},
    new []{"avlod", "bo‘g‘in", "sulola", "zot"},
    new []{"agar", "agarda", "mabodo"},
    new []{"agent", "ayg‘oqchi", "josus"},
    new []{"bosqinchi", "bosmachi", "agressor"},
    new []{"agressiv", "bosqinchi", "tajovuzkor"},
    new []{"otdosh", "adash", "ismdosh"},
    new []{"adolat", "odillik", "adl"},
    new []{"adolatli", "odil", "barhaq"},
    new []{"adolatsizlik", "haqsizlik", "qonunsizlik", "bedodlik"},
    new []{"rahm", "shafqat", "omon"},
    new []{"ayol", "xotin", "xotin-qiz"},
    new []{"ajablanmoq", "taajjublanmoq", "hayron"},
    new []{"ajin", "tirish", "burish"},
    new []{"ajratmoq", "ayirmoq"},
    new []{"farqlamoq", "ajratmoq", "ayirmoq"},
    new []{"kampir", "momoy", "onaxon"},
    new []{"qaror", "jazm", "azimat"},
    new []{"azobli","jafoli", "uqubatli"},
    new []{"ayb", "gunoh", "jinoyat"},
    new []{"ayyorona", "mug‘ombirona", "makkorona"},
    new []{"almashmoq", "ayirboshlamoq", "ayirbosh qilmoq"}
};

Console.Write("Input Text: ");
string? text = Console.ReadLine();
string[]? words = text?.Split(' ', StringSplitOptions.RemoveEmptyEntries);

if (words != null)
{
    for (int i = 0; i < words.Length; i++)
    {
        foreach (var synonymGroup in synonyms)
        {
            if (synonymGroup.Contains(words[i]))
            {
                int index = Array.IndexOf(synonymGroup, words[i]);
                words[i] = synonymGroup[(index + 1) % synonymGroup.Length];
                break;
            }
        }
    }
}

// Print the modified sentence
Console.WriteLine(string.Join(" ", words));



