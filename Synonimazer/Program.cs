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
    new []{"almashmoq", "ayirboshlamoq", "ayirbosh qilmoq"},
    new []{"ajratmoq", "ayirmoq", "judo qilmoq"},
    new []{"aynimoq", "achimoq", "buzilmoq"},
    new []{"ayniqsa", "xususan", "jumladan"},
    new []{"ayriliq", "judolik", "hijron"},
    new []{"janjallashmoq", "aytishmoq", "koyishmoq mojarolashmoq"},
    new []{"aytmaslik", "yashirmoq", "bekitmoq"},
    new []{"aytmoq","demoq", "bayon qilmoq"},
    new []{"aytmoq", "talaffuz qilmoq"},
    new []{"taklif qilmoq", "chaqirmoq"},
    new []{"kuylamoq", "aytmoq", "xirgoyi qilmoq"},
    new []{"aka", "og‘a", "birodar"},
    new []{"teskari", "aks", "qarshi"},
    new []{"aktyor", "artist"},
    new []{"alay-balay", "u-bu", "g‘ing-ping"},
    new []{"alam", "dard", "iztirob"},
    new []{"alanga", "yolqin", "lova"},
    new []{"albatta", "shubhasiz", "muqarrar"},
    new []{"aldamoq", "laqillatmoq", "avramoq"},
    new []{"firibgar", "aldamchi", "qallob", "tovlamachi"},
    new []{"yolg‘onchi", "aldoqchi", "aldamchi"},
};

string[] qoshimchalar = { "siga", "ga", "lar" };

        Console.Write("Input Text: ");
        string? text = Console.ReadLine();
        string[]? words = text?.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (words != null)
        {
            // Dictionary to store original words and their replacements
            Dictionary<string, string> wordReplacements = new Dictionary<string, string>();

            for (int i = 0; i < words.Length; i++)
            {
                string cutString = "";
                foreach (var qoshimcha in qoshimchalar)
                {
                    if (words[i].Contains(qoshimcha))
                    {
                        int index = words[i].IndexOf(qoshimcha);
                        cutString = words[i].Substring(index);
                        words[i] = words[i].Replace(qoshimcha, "");
                        break;
                    }
                }

                foreach (var synonymGroup in synonyms)
                {
                    if (synonymGroup.Contains(words[i]))
                    {
                        int index = Array.IndexOf(synonymGroup, words[i]);
                        string changedWord = words[i];
                        string replacementWord = synonymGroup[(index + 1) % synonymGroup.Length];
                        words[i] = replacementWord;

                        if (!string.IsNullOrEmpty(cutString))
                        {
                            // Add the cutString back after swapping the word
                            words[i] += cutString;
                        }

                        wordReplacements.Add(words[i], replacementWord + cutString);
                        break;
                    }
                }
            }

            // Print the modified sentence with changed words in different color
            Console.Write("Modified Text: ");
            foreach (var word in words)
            {
                if (wordReplacements.ContainsKey(word))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(wordReplacements[word] + " ");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(word + " ");
                }
            }
        }





