namespace VSTestSample
{
    public static class ChatBot
    {
        public static string Greet(string name)
        {
            return $"Hello, {name}!";
        }
        
        public static string AskQuestion(string name)
        {
            return "How are you?";
            // return $"How are you, {name}?";
        }
    }
}
