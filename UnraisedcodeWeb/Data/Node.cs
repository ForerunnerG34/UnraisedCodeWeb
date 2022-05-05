namespace UnraisedcodeWeb.Data
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }
        public double Position { get; set; }
        public string ArrowDirection { get; set; } = string.Empty;
        public Node(int data)
        {
            Data = data;
        }
    }
}
