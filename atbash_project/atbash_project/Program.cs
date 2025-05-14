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


        static void Main(string[] args)
        {








        }
    }
}
