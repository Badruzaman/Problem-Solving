

string characters = "Bste!hetsi ogEAxpelrt x ";
string document = "AlgoExpert is the Best!";
bool result = GenerateDocument(characters, document);
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

bool GenerateDocument(string characters, string document)
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