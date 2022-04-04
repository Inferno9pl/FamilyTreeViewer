using System.Diagnostics;
using System.Drawing.Imaging;

namespace FamilyTreeViewer
{
    internal partial class FamilyTree : Form
    {
        private static int treeWidth = 10;
        private static int treeHeight = 10;
        private readonly Tree tree;

        private Image treeImage = new Bitmap(1, 1);
        private Rectangle imageRectangle = new(0, 0, treeWidth, treeHeight);
        private float imageScale = 1.0f;

        private Point prevMouseLocation = Point.Empty;
        

        public FamilyTree()
        {
            InitializeComponent();
            tree = new((int)numericUpDownX.Value * 10, (int)numericUpDownY.Value * 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyPictureBox.BackColor = Color.LightSlateGray;
            this.MouseWheel += new MouseEventHandler(MyPictureBox_MouseWheel);

            //init tree and place it on the pictureBox center
            tree.RecalculateTree();
            var treeSize = tree.GetTreeSize();

            imageRectangle.X = MyPictureBox.Width / 2 - treeSize.Width / 2;
            imageRectangle.Y = MyPictureBox.Height / 2 - treeSize.Height / 2;

            RefreshAll();
        }
        private void Log(string text)
        {
            LogBox.Text = text;
        }
        private void RefreshAll()
        {
            //reset values
            treeWidth = 10;
            treeHeight = 10;

            Rectangle treeSize = tree.GetTreeSize();

            treeWidth = treeSize.Width > treeWidth ? treeSize.Width : treeWidth;
            treeHeight = treeSize.Height > treeHeight ? treeSize.Height : treeHeight;

            treeImage = new Bitmap(treeWidth, treeHeight);

            imageRectangle.Width = (int)(treeWidth * imageScale);
            imageRectangle.Height = (int)(treeHeight * imageScale);

            using (Graphics gr = Graphics.FromImage(treeImage))
            {
                gr.Clear(Color.WhiteSmoke);
                tree.DrawTree(gr);
            }

            if (tree.SelectedNode != null)
            {
                textBoxName.Text = tree.SelectedNode.Name;
                textBoxSurname.Text = tree.SelectedNode.Surname;
                textBoxMaidenName.Text = tree.SelectedNode.MaidenName;
                textBoxPartner.Text = tree.SelectedNode.Partner;
                textBoxDescription.Text = tree.SelectedNode.Desc;

                ChildslistBox.Items.Clear();
                if (tree.SelectedNode != null)
                {
                    foreach (Node node in tree.SelectedNode.Childs)
                    {
                        ChildslistBox.Items.Add(node.Name + " " + node.Surname);
                    }
                }
            }
            else
            {
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxMaidenName.Text = "";
                textBoxPartner.Text = "";
                textBoxDescription.Text = "";

                ChildslistBox.Items.Clear();
            }
            Refresh();
        }

        private void MyPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickPos = new(e.Location.X - imageRectangle.X, e.Location.Y - imageRectangle.Y);

            clickPos.X = (int)(clickPos.X / imageScale);
            clickPos.Y = (int)(clickPos.Y / imageScale);

            tree.IsNodeSelected(clickPos);

            if (e.Button == MouseButtons.Right && tree.SelectedNode != null)
            {
                if (tree.SelectedNode == tree.Root)
                {
                    AddParentToolStripMenuItem.Enabled = true;
                    DeleteToolStripMenuItem.Enabled = false;
                    AddParentToolStripMenuItem.Visible = true;
                    DeleteToolStripMenuItem.Visible = false;
                }
                else
                {
                    AddParentToolStripMenuItem.Enabled = false;
                    DeleteToolStripMenuItem.Enabled = true;
                    AddParentToolStripMenuItem.Visible = false;
                    DeleteToolStripMenuItem.Visible = true;
                }
                NodeContextMenu.Show(MousePosition);
            }
            RefreshAll();
        }
        private void MyPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (prevMouseLocation != Point.Empty)
                {
                    imageRectangle.X -= (prevMouseLocation.X - e.Location.X);
                    imageRectangle.Y -= (prevMouseLocation.Y - e.Location.Y);
                }
                prevMouseLocation = e.Location;
            }
            else
            {
                prevMouseLocation = Point.Empty;
            }
            Refresh();
        }
        private void MyPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(treeImage, imageRectangle);
        }
        private void MyPictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            const float scale_per_delta = 0.25f / 120;

            imageScale += e.Delta * scale_per_delta;

            imageScale = (float)(Math.Round(imageScale * 100) / 100);
            if (imageScale < 0.25f) imageScale = 0.25f;
            if (imageScale > 2.0f) imageScale = 2.0f;

            var prevWidth = imageRectangle.Width;
            var prevHeight = imageRectangle.Height;

            float relativeMousePosX = (float)(e.Location.X - imageRectangle.X) / imageRectangle.Width;
            float relativeMousePosY = (float)(e.Location.Y - imageRectangle.Y) / imageRectangle.Height;

            imageRectangle.Width = (int)(treeWidth * imageScale);
            imageRectangle.Height = (int)(treeHeight * imageScale);

            var difWidth = prevWidth - imageRectangle.Width;
            var difHeight = prevHeight - imageRectangle.Height;

            imageRectangle.X += (int)(relativeMousePosX * difWidth);
            imageRectangle.Y += (int)(relativeMousePosY * difHeight);

            Refresh();
        }

        private void CheckBoxEdit_CheckStateChanged(object sender, EventArgs e)
        {
            var state = !checkBoxEdit.Checked;
            textBoxName.ReadOnly = state;
            textBoxSurname.ReadOnly = state;
            textBoxMaidenName.ReadOnly = state;
            textBoxPartner.ReadOnly = state;
            textBoxDescription.ReadOnly = state;
        }
        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null && checkBoxEdit.Checked && !textBoxName.Text.Equals("System.EventArgs"))
            {
                tree.SelectedNode.Name = textBoxName.Text;
            }
        }
        private void TextBoxSurname_TextChanged(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null && checkBoxEdit.Checked)
            {
                tree.SelectedNode.Surname = textBoxSurname.Text;
            }
        }
        private void TextBoxMaidenName_TextChanged(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null && checkBoxEdit.Checked)
            {
                tree.SelectedNode.MaidenName = textBoxMaidenName.Text;
            }
        }
        private void TextBoxPartner_TextChanged(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null && checkBoxEdit.Checked)
            {
                tree.SelectedNode.Partner = textBoxPartner.Text;
            }
        }
        private void TextBoxDescription_TextChanged(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null && checkBoxEdit.Checked)
            {
                tree.SelectedNode.Desc = textBoxDescription.Text;
            }
        }

        private void AddChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree.AddChildNode();
            RefreshAll();
        }
        private void AddParentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree.AddParentNode();;
            RefreshAll();
        }
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                tree.DeleteNode(tree.SelectedNode);
                RefreshAll();
            }
        }

        private void NumericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            tree.SpacingX = (int)numericUpDownX.Value * 10;
            tree.SpacingY = (int)numericUpDownY.Value * 10;
            tree.RecalculateTree();
            RefreshAll();
        }
        private void FamilyTree_SizeChanged(object sender, EventArgs e)
        {
            ControlPanel.Location = new Point(this.Size.Width - 300, ControlPanel.Location.Y);
            MyPictureBox.Size = new Size(this.Size.Width - 314, this.Size.Height - 65);
        }
        
        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new();
            fileDialog.Filter = " BMP (*.BMP)|*.bmp| JPG (*.JPG)|*.jpg| PNG (*.PNG)|*.png| XML (*.XML)|*.xml";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if(fileDialog.FilterIndex == 3)
                {
                    FileManager.SaveToXML(fileDialog.FileName, tree);
                }
                else
                {
                    FileManager.SaveImageToFile(fileDialog.FileName, treeImage);
                }
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new();
            fileDialog.Filter = " XML (*.XML)|*.xml";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
