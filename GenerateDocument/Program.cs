

string characters = "aabbcc";
string document = "acacbcb";
bool result = solution(characters, document);
Console.Write(result);
Console.ReadKey();

//bool GenerateDocument(string character, string document)
//{
//    for (int i = 0; i < document.Length; i++)
//    {
//        int characterFrequency = countCharacterFrequency(document[i] ,characters);
//        int DocumentFrequency = countCharacterFrequency(document[i] ,document);
//        if(DocumentFrequency > characterFrequency)
//        {
//            return false;
//        }

//    }

//    return true;
//}

//int countCharacterFrequency(char chars, string target)
//{
//	int count = 0;
//	for (int i = 0; i < target.Length; i++)
//	{
//		if(chars == target[i])
//		{
//			count++;	
//		}
//	}
//	return count;
//}

bool GenerateDocument01(string characters, string document)
{
    foreach (char ch in document)
    {
        int docFrequecyCount = 0;
        int characterFrequencyCount = 0;
        docFrequecyCount = document.Count(it => it.Equals(ch));
        characterFrequencyCount = characters.Count(it => it.Equals(ch));
        if(docFrequecyCount > characterFrequencyCount)
        {
            return false;
        }
    }
    return true;
}
bool solution(string characters, string document)
{
    Dictionary<char, int> characterCounts = new Dictionary<char, int>();
    for (int i = 0; i < characters.Length; i++)
    {
        char ch = characters[i];
        if (!characterCounts.ContainsKey(ch))
        {
            characterCounts[ch] = 0;
        }
        characterCounts[ch]++;
    }
    for (int j = 0; j < document.Length; j++)
    {
        char ch = document[j];
        if (!characterCounts.ContainsKey(ch) || characterCounts[ch] == 0)
        {
            return false;
        }
        characterCounts[ch] = characterCounts[ch] - 1;
    }
    return true;
}
