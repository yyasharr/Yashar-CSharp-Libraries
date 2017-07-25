using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yashar
{
    namespace DataStructures
    {
        public class Trie //For solving Q208 from Leetcode
        {
            TrieNode root;

            /// <summary>
            /// Creates a new Trie data structure and creates an empty TrieNode as root which doens't hold any character.
            /// </summary>
            public Trie()
            {
                root = new TrieNode();
            }

            /// <summary>
            /// Inserts a word into the trie.
            /// </summary>
            /// <param name="word"></param>
            public void Insert(string word)
            {
                TrieNode[] children = root.Children;
                for (int i = 0; i < word.Length; i++)
                {
                    int ch = word[i] - 'a';
                    if (children[ch] != null) //if we have seen it before
                    {
                        if (i == word.Length - 1)
                            children[ch].IsLeaf = true;
                    }
                    //if we have not seen this at this level.
                    else
                    {
                        children[ch] = new TrieNode(word[i]);
                        if (i == word.Length - 1)//last char
                        {
                            children[ch].IsLeaf = true;
                        }
                    }
                    children = children[ch].Children;
                }
            }

            /// <summary>
            /// Retruns true if the given word is found in the trie, false otherwise.
            /// </summary>
            /// <param name="word"></param>
            /// <returns></returns>
            public bool Search(string word)
            {
                TrieNode[] children = root.Children;

                for (int i = 0; i < word.Length; i++)
                {
                    int ch = word[i] - 'a';
                    if (children[ch] == null)
                        return false;
                    else
                    {
                        if (i == word.Length - 1 && children[ch].IsLeaf == true)//last character
                            return true;

                        children = children[ch].Children;
                    }
                }
                return false;
            }

            /// <summary>
            /// Generates and returns the list of the suggestions, which are the words that can be created with the given prefix.
            /// </summary>
            /// <param name="prefix"></param>
            /// <returns></returns>
            public List<string> Suggestions(string prefix)
            {
                TrieNode current_node = getCurrentNode(prefix);
                List<string> result = new List<string>();

                if (current_node == null) //means we couldn't find the prefix in the trienode
                    return result;

                GenerateSuggestions(prefix, current_node, result);

                return result;

            }

            private void GenerateSuggestions(string prefix, TrieNode current_node, List<string> result)
            {
                for (int i = 0; i < 26; i++)
                {
                    if (current_node.Children[i] != null) //means we can continue from here
                    {
                        char ch = Convert.ToChar(i + 'a');
                        string new_prefix = prefix + ch;
                        if (current_node.Children[i].IsLeaf == true)
                        {
                            result.Add(new_prefix);
                        }
                        GenerateSuggestions(new_prefix, current_node.Children[i], result);
                    }
                }
            }

            private TrieNode getCurrentNode(string prefix)
            {
                TrieNode curr = root;

                for (int i = 0; i < prefix.Length; i++)
                {
                    int ch = prefix[i] - 'a';
                    if (curr.Children[ch] != null)
                    {
                        curr = curr.Children[ch];
                        if (i == prefix.Length - 1)//last char of prefix found!
                        {
                            return curr;
                        }
                    }
                    else
                        return null;
                }
                return null;
            }

            /// <summary>
            /// Returns true if there is any word in the trie that starts with the given prefix, false otherwise.
            /// </summary>
            /// <param name="prefix"></param>
            /// <returns></returns>
            public bool StartsWith(string prefix)
            {
                TrieNode[] children = root.Children;
                for (int i = 0; i < prefix.Length; i++)
                {
                    int ch = prefix[i] - 'a';
                    if (children[ch] == null)
                        return false;
                    else
                    {
                        if (i == prefix.Length - 1)
                            return true;
                    }
                    children = children[ch].Children;
                }
                return false;
            }
        }
    }
}
