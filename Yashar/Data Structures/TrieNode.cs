using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yashar
{
    namespace DataStructures
    {
        class TrieNode
        {
            char _c;
            TrieNode[] _children;
            bool _isLeaf;

            /// <summary>
            /// Creates a new TrieNode which doesn't have any character and only used as the root of the trie.
            /// </summary>
            public TrieNode()
            {
                _children = new TrieNode[26];
            }

            /// <summary>
            /// Creates a new TrieNode and assigns the character ch to the node.
            /// </summary>
            /// <param name="ch"></param>
            public TrieNode(char ch)
            {
                _c = ch;
                _children = new TrieNode[26];
            }

            /// <summary>
            /// Gets the character assigned to this node.
            /// </summary>
            public char C
            {
                get { return _c; }
            }

            /// <summary>
            /// Gets the list of the children mappings for this node.
            /// </summary>
            public TrieNode[] Children
            {
                get { return _children; }
            }
            
            /// <summary>
            /// Return true if this current node (character) ends up to a complete word.
            /// </summary>
            public bool IsLeaf
            {
                get { return _isLeaf; }
                set { _isLeaf = value; }
            }

            
        }
    }
}
