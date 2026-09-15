namespace Trie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Trie trie = new Trie();
            
            trie.Insert("dog");
            trie.Insert("cat");
            trie.Insert("cool");
            trie.Insert("catalitic");
            trie.Insert("cattapult");
            bool a = trie.Contains("cool");
            List<string> temp = trie.GetAllMatchingPrefix("cat");
            ;
        }
    }
}
