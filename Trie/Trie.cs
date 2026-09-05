using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace Trie
{
    public class Trie
    {


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

            Insert(curr, word, 0);
        } // Add a word to the Trie   
        private Trie Insert(TrieNode curr, string word, int index)
        {

            if (index <= word.Length - 1 && curr.Children.ContainsKey(word[index]))
            {
                Insert(curr.Children[word[index]], word, index + 1);
            }
            else if (index <= word.Length - 1 && index < word.Length)
            {
                curr.Children.Add(word[index], new TrieNode(word[index]));
                Insert(curr.Children[word[index]], word, index + 1);
            }
            if (index > word.Length - 1)
            {
                curr.IsWord = true;
            }

            return null;
        }


        public void SearchNode(string prefix)
        {
            TrieNode curr = root;
            SearchNode(curr, prefix,0);
        }
        private TrieNode SearchNode(TrieNode curr,string prefix, int index)
        {
            if (curr.Children.ContainsKey(prefix[index]))
            {
                SearchNode(curr.Children[prefix[index]], prefix, index + 1);
            }
        } // Find the node at the end of this prefix. Use this function WHENEVER you need to find a node.

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
