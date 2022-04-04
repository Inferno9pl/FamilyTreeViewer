namespace FamilyTreeViewer
{
    internal class Tree
    {
        readonly int posX = 20;
        readonly int posY = 20;

        internal int SpacingX { get; set; }
        internal int SpacingY { get; set; }
        internal Node Root { get; set; }
        internal Node? SelectedNode { get; set; }

        private List<int> levels = new();
        private List<Node> nodes = new();

        internal Tree(int spacingX, int spacingY)
        {
            SpacingX = spacingX;
            SpacingY = spacingY;
            SelectedNode = null;
            Root = new Node("WSPÓLNY", "PRZODEK", "", "", null, "Praprzodek wszystkich. Węzeł potrzebny aby drzewo było spójne i wychodziło od jednego korzenia.", new List<Node>(), posX, posY);
            nodes.Add(Root);
        }

        internal void DrawTree(Graphics g)
        {
            foreach (Node node in nodes)
            {
                node.Draw(g);
                if (node.Childs != null)
                {
                    foreach (Node child in node.Childs)
                    {
                        ConnectNodes(g, node, child);
                    }
                }
            }
        }
        internal bool IsNodeSelected(Point pos)
        {
            foreach (Node node in nodes)
            {
                if (node.Visual.IsClicked(pos))
                {
                    if (SelectedNode != null && SelectedNode != node)
                    {
                        SelectedNode.Visual.SetClicked(false);
                        SelectedNode = node;
                        node.Visual.SetClicked(true);
                    }
                    else if (SelectedNode == null)
                    {
                        node.Visual.SetClicked(true);
                        SelectedNode = node;
                    }
                    return true;
                }
            }

            if (SelectedNode != null)
            {
                SelectedNode.Visual.SetClicked(false);
            }
            SelectedNode = null;
            return false;
        }
        internal void RecalculateTree()
        {
            levels.Clear();
            RefreshNodePosition(Root);
        }
        internal Rectangle GetTreeSize()
        {
            Rectangle treeSize = new(0, 0, 0, 0);

            var mostRightNode = nodes.MaxBy(x => x.Visual.X);
            var mostDownNode = nodes.MaxBy(x => x.Visual.Y);

            treeSize.Width = posX + mostRightNode.Visual.X + mostRightNode.Visual.Width / 2;
            treeSize.Height = posY + mostDownNode.Visual.Y + mostDownNode.Visual.Height / 2;

            return treeSize;
        }

        internal void AddChildNode()
        {
            if (SelectedNode != null)
            {
                Node newNode = new();
                newNode.Name = "test" + nodes.Count;

                newNode.Parent = SelectedNode;
                nodes.Add(newNode);
                SelectedNode.Childs.Add(newNode);

                //select new node
                SelectedNode.Visual.SetClicked(false);
                SelectedNode = newNode;
                newNode.Visual.SetClicked(true);

                RecalculateTree();
            }
        }
        internal void AddParentNode()
        {
            if (SelectedNode != null && SelectedNode.Parent == null)
            {
                Node newNode = new();
                newNode.Name = "NewParent" + nodes.Count;

                newNode.Childs.Add(SelectedNode);
                SelectedNode.Parent = newNode;
                Root = newNode;
                nodes.Add(newNode);

                levels.Add(levels.Last<int>());

                RecalculateTree();
            }
        }
        internal void DeleteNode(Node node)
        {
            if (node != Root)
            {
                // delete this node childs
                for (int i = node.Childs.Count - 1; i >= 0; i--)
                {
                    DeleteNode(node.Childs[i]);
                }
                node.Childs.Clear();

                // this node is somebody child so delete this information
                if (node.Parent != null)
                {
                    node.Parent.Childs.Remove(node);
                }

                // delete this node
                node.Visual.SetClicked(false);
                nodes.Remove(node);

                RecalculateTree();
            }
        }

        private void RefreshNodePosition(Node node, int generation = 0)
        {
            if (Root != null)
            {
                //set Y position
                var correctedSpacingY = SpacingY + Root.Visual.Height;
                node.Visual.Y = posY + generation * correctedSpacingY;

                // determine new generations X position
                if (levels.Count <= generation)
                {
                    if (generation == 0)
                    {
                        levels.Add(posX - SpacingX);
                    }
                    else
                    {
                        levels.Add(levels.Max());
                    }
                }

                // placing parent above his children
                if (node.Childs.Count > 0)
                {
                    foreach (Node child in node.Childs)
                    {
                        RefreshNodePosition(child, generation + 1);
                    }

                    var firstChild = node.Childs[0];
                    var lastChild = node.Childs.Last<Node>();

                    node.Visual.X = (firstChild.Visual.X + lastChild.Visual.X) / 2;
                    CorrectLevels(generation, lastChild.Visual.X + lastChild.Visual.Width / 2);
                }

                //placing child
                else if (node.Childs.Count == 0)
                {
                    node.Visual.X = levels[generation] + SpacingX + node.Visual.Width / 2;
                    CorrectLevels(generation, levels[generation] + SpacingX + node.Visual.Width);
                }
            }
        }
        private static void ConnectNodes(Graphics g, Node node1, Node node2)
        {
            Point p1, p2;
            if (node1.Visual.Y <= node2.Visual.Y)
            {
                p1 = node1.Visual.GetSocket(false);
                p2 = node2.Visual.GetSocket(true);
                g.DrawLine(node1.Visual.Pen, p1, p2);

            }
            else
            {
                p1 = node1.Visual.GetSocket(true);
                p2 = node2.Visual.GetSocket(false);
                g.DrawLine(node2.Visual.Pen, p2, p1);
            }
        }
        private void CorrectLevels(int generation, int value)
        {
            levels[generation] = value;
            for (int i = generation; i < levels.Count; i++)
            {
                levels[i] = Math.Max(value, levels[i]);
            }
        }

        public override string ToString()
        {
            return "NODES: " + nodes.Count;
        }
    }
}


/*
 
 - muszę mieć mechanizm łączenia dwóch nodów w jeden (2 osoby biorą ślub)
 - jeśli jest na dobrej pozycji to nie liczy i nie zmienia - może to przyśpieszy co
 
 */