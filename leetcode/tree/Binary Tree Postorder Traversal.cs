// var solution = new _145_Binary_Tree_Postorder_Traversal();
// var result = solution.PostorderTraversal(new TreeNode(1) {right = new TreeNode(2) {left = new TreeNode(3)}});
// Console.WriteLine(string.Join(", ", result));

public class _145_Binary_Tree_Postorder_Traversal {
    public IList<int> PostorderTraversal(TreeNode root) {
        var result = new List<int>();
        DFS(root, result);
        
        return result;
    }

    void DFS(TreeNode? node, List<int> result) {
        if (node == null) {
            return;
        }

        DFS(node.left, result);
        DFS(node.right, result);
        result.Add(node.val);
    }
}