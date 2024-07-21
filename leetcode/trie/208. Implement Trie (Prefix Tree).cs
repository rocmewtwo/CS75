// 208. Implement Trie (Prefix Tree)
// https://leetcode.com/problems/implement-trie-prefix-tree/

public class TrieNode
{
    public Dictionary<char, TrieNode> children;
    public bool isWord;

    public TrieNode()
    {
        children = [];
        isWord = false;
    }
}

public class Trie
{
    private TrieNode root;

    public Trie()
    {
        root = new TrieNode();
    }

    public void Insert(string word)
    {
        var current = root;
        foreach (var c in word)
        {
            // if c not in current.children
            if (!current.children.TryGetValue(c, out var node))
            {
                node = new TrieNode();
                current.children.Add(c, node);
            }
            current = node;
        }
        current.isWord = true;
    }

    public bool Search(string word)
    {
        var current = root;
        foreach (var c in word)
        {
            if (!current.children.TryGetValue(c, out var node))
            {
                return false;
            }
            current = node;
        }
        return current.isWord;
    }

    public bool StartsWith(string prefix)
    {
        var current = root;
        foreach (var c in prefix)
        {
            if (!current.children.TryGetValue(c, out var node))
            {
                return false;
            }
            current = node;
        }
        return true;
    }
}