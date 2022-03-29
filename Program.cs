
string inputPath = @"C:\Users\patri\Downloads\theMachineStops.txt";

FileInfo inputFile = new FileInfo(inputPath);

string outputPath = @"C:\Users\patri\Downloads\TelegramCopy.txt";

FileInfo outputFile = new FileInfo(outputPath);

if (inputFile.Exists)
{
    try
    {

        string correctedString;
      
        using (StreamReader reader = inputFile.OpenText())
        {


            string inputText = reader.ReadToEnd();
            correctedString = inputText.Replace(".", "STOP");
        }



        if (outputFile.Exists)
        {

            outputFile.Delete();
        }


        using (StreamWriter writer = outputFile.CreateText())
        {


         writer.Write(correctedString);

        }
    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
}


//if (inputFile.Exists)
//{
//    try
//    {
//        Dictionary<string, int> wordCount;
//        using (StreamReader reader = inputFile.OpenText())
//        {
//            string inputText = reader.ReadToEnd().ToLower().ReplaceLineEndings(" ");
//            string sanitizedText = new String(inputText.Where(c => !char.IsPunctuation(c)).ToArray());
//            string[] words = sanitizedText.Split(' ');
//            wordCount = MakeWordCount(words);
//        }
//        if (outputFile.Exists)
//        {
//            outputFile.Delete();
//        }
//        using (StreamWriter writer = outputFile.CreateText())
//        {
//            foreach (KeyValuePair<string, int> wc in wordCount)
//            {
//                writer.WriteLine($"{wc.Key}: {wc.Value}");
//            }
//        }
//    }
//    catch (IOException ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}

//Dictionary<string, int> MakeWordCount(string[] words)
//{
//    Dictionary<string, int> wordCount = new Dictionary<string, int>();
//    Array.Sort(words);
//    foreach (string word in words)
//    {
//        if (!String.IsNullOrEmpty(word))
//        {
//            if (!wordCount.ContainsKey(word))
//            {
//                wordCount.Add(word, 1);
//            }
//            else
//            {
//                wordCount[word]++;
//            }
//        }
//    }
//    return wordCount;
//}





