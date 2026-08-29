using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace Trie
{
    public class Trie
    {

        public int index = 0;
        TrieNode root = new TrieNode(default);
        static int count = 0;
        public void Clear() // Delete all data in the Trie
        {
            root.Children.Clear();
        } 
        

        public void Insert(string word) 
        {
            TrieNode curr = root;
            count++;
           
            Insert(curr,word);
        } // Add a word to the Trie   
        private Trie Insert(TrieNode curr,string word)
        {
            
                if (curr.Children.ContainsKey(word[index]) && index < word.Length)
                {
                    index++;
                    Insert(curr.Children[word[index]], word);
                
                }
                else if(index < word.Length)
                {
                    curr.Children.Add(word[index], curr);
                    index++;
                    Insert(curr.Children[word[index]], word);
                
                }
            
            
            return null;
        }

        //private TrieNode SearchNode(string prefix)
        //{
            
        //} // Find the node at the end of this prefix. Use this function WHENEVER you need to find a node.

        //public bool Contains(string word) 
        //{
            
        //} // Return if a given word exists (use SearchNode)

        //public List<string> GetAllMatchingPrefix(string prefix) 
        //{
            
        //} // Get every word after a given prefix

        //public bool Remove(string word) 
        //{
            
        //} // Remove a given word if it exists, and return if you found it
    }
}
