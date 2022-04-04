namespace FamilyTreeViewer
{
    internal class Node
    {
        internal string Name { get; set; }
        internal string Surname { get; set; }
        internal string MaidenName { get; set; }
        internal string Partner { get; set; }
        internal Node? Parent { get; set; }
        internal List<Node> Childs { get; set; }
        internal string Desc { get; set; }

        internal NodeVisual Visual { get; set; }

        internal Node()
        {
            Name = "";
            Surname = "";
            MaidenName = "";
            Partner = "";
            Parent = null;
            Desc = "";
            Childs = new List<Node>();
            Visual = new(0, 0);
        }
        internal Node(string name, string surname, string maidenName, string partner, Node? parent, string desc, List<Node> childs, int x, int y)
        {
            Name = name;
            Surname = surname;
            MaidenName = maidenName;
            Partner = partner;
            Parent = parent;
            Desc = desc;
            Childs = childs;

            Visual = new(x, y);
        }

        internal void Draw(Graphics g)
        {
            Visual.DrawNode(Name + " " + Surname, g);
        }
    }
}
