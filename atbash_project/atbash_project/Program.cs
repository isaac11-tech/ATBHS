namespace atbash_project
{
    internal class Program
    {
      static string decryptAtbash(string text)
        {
            string decryptTxt = "";
            var DecryptionKey = new Dictionary<char, char>() { { 'a', 'z' }, { 'b', 'y' }, { 'c', 'x' }, { 'd', 'w' }, { 'e', 'v' }, { 'f', 'u' }, { 'g', 't' }, { 'h', 's' }, { 'i', 'r' }, { 'j', 'q' }, { 'k', 'p' }, { 'l', 'o' }, { 'm', 'n' } };
            for(int i =0; i< text.Length;i++) 
            {
                
                if (char.IsLetter(text[i]))
                {
                    decryptTxt += DecryptionKey[char.ToLower(text[i])];
                }
           
            }
            return decryptTxt;
        }


        static string LevelOfDanger(int score) 
            {
            
            int rank = 0;
            if (score > 0 && score <= 5)
            {
                rank = 1;
            }
            else if (score > 0 && score >= 5 && score <= 10)
            {
                rank = 2;
            }
            else if(score > 0)
            {
                rank = 3;
            }
            switch (score)
            {
                case 1:
                    return "WARNING";
                case 2:
                    return "DANGER!";
                case 3:
                   return "ULTRA ALERT!";
            }
            return "not correct input please try again";

            }

        static void Main(string[] args)
        {








        }
    }
}
