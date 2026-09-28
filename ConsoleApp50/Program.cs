Func<string, List<string>> GetWords = sentence => 
    sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

string sentence = "Hello world how are you";
List<string> words = GetWords(sentence);
