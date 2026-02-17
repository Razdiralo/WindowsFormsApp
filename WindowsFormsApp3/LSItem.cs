namespace WindowsFormsApp3
{
    public class LSItem
    {
        public string Name { get; set; } = "";

        public List<string> Commands { get; set; } = new();

        public TreeNode Node { get; set; } = null!;
    }
}