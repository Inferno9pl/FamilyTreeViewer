namespace FamilyTreeViewer
{
    partial class FamilyTree
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.MyPictureBox = new System.Windows.Forms.PictureBox();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.NodeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajDzieckoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddParentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPartner = new System.Windows.Forms.Label();
            this.labelChilds = new System.Windows.Forms.Label();
            this.labelMaidenName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPartner = new System.Windows.Forms.TextBox();
            this.textBoxMaidenName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.checkBoxEdit = new System.Windows.Forms.CheckBox();
            this.ChildslistBox = new System.Windows.Forms.ListBox();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox)).BeginInit();
            this.NodeContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(113, 352);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(73, 23);
            this.LoadBtn.TabIndex = 0;
            this.LoadBtn.Text = "Wczytaj";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // MyPictureBox
            // 
            this.MyPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyPictureBox.Location = new System.Drawing.Point(12, 12);
            this.MyPictureBox.Name = "MyPictureBox";
            this.MyPictureBox.Size = new System.Drawing.Size(800, 400);
            this.MyPictureBox.TabIndex = 1;
            this.MyPictureBox.TabStop = false;
            this.MyPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPictureBox_Paint);
            this.MyPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyPictureBox_MouseClick);
            this.MyPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyPictureBox_MouseMove);
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.SystemColors.Control;
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogBox.Location = new System.Drawing.Point(8, 381);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(265, 22);
            this.LogBox.TabIndex = 2;
            // 
            // NodeContextMenu
            // 
            this.NodeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajDzieckoToolStripMenuItem,
            this.AddParentToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.NodeContextMenu.Name = "NodeContextMenu";
            this.NodeContextMenu.Size = new System.Drawing.Size(149, 70);
            // 
            // dodajDzieckoToolStripMenuItem
            // 
            this.dodajDzieckoToolStripMenuItem.Name = "dodajDzieckoToolStripMenuItem";
            this.dodajDzieckoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dodajDzieckoToolStripMenuItem.Text = "Dodaj dziecko";
            this.dodajDzieckoToolStripMenuItem.Click += new System.EventHandler(this.AddChildToolStripMenuItem_Click);
            // 
            // AddParentToolStripMenuItem
            // 
            this.AddParentToolStripMenuItem.Name = "AddParentToolStripMenuItem";
            this.AddParentToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.AddParentToolStripMenuItem.Text = "Dodaj rodzica";
            this.AddParentToolStripMenuItem.Click += new System.EventHandler(this.AddParentToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.DeleteToolStripMenuItem.Text = "Usuń";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(77, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(30, 15);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Imię";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(51, 39);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(57, 15);
            this.labelSurname.TabIndex = 4;
            this.labelSurname.Text = "Nazwisko";
            // 
            // labelPartner
            // 
            this.labelPartner.AutoSize = true;
            this.labelPartner.Location = new System.Drawing.Point(42, 97);
            this.labelPartner.Name = "labelPartner";
            this.labelPartner.Size = new System.Drawing.Size(65, 15);
            this.labelPartner.TabIndex = 5;
            this.labelPartner.Text = "Mąż / żona";
            // 
            // labelChilds
            // 
            this.labelChilds.AutoSize = true;
            this.labelChilds.Location = new System.Drawing.Point(69, 123);
            this.labelChilds.Name = "labelChilds";
            this.labelChilds.Size = new System.Drawing.Size(38, 15);
            this.labelChilds.TabIndex = 6;
            this.labelChilds.Text = "Dzieci";
            // 
            // labelMaidenName
            // 
            this.labelMaidenName.AutoSize = true;
            this.labelMaidenName.Location = new System.Drawing.Point(8, 68);
            this.labelMaidenName.Name = "labelMaidenName";
            this.labelMaidenName.Size = new System.Drawing.Size(100, 15);
            this.labelMaidenName.TabIndex = 7;
            this.labelMaidenName.Text = "Nazwisko rodowe";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(77, 211);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(30, 15);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Inne";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(113, 7);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(159, 23);
            this.textBoxName.TabIndex = 9;
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(113, 36);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.ReadOnly = true;
            this.textBoxSurname.Size = new System.Drawing.Size(159, 23);
            this.textBoxSurname.TabIndex = 10;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.TextBoxSurname_TextChanged);
            // 
            // textBoxPartner
            // 
            this.textBoxPartner.Location = new System.Drawing.Point(113, 94);
            this.textBoxPartner.Name = "textBoxPartner";
            this.textBoxPartner.ReadOnly = true;
            this.textBoxPartner.Size = new System.Drawing.Size(159, 23);
            this.textBoxPartner.TabIndex = 11;
            this.textBoxPartner.TextChanged += new System.EventHandler(this.TextBoxPartner_TextChanged);
            // 
            // textBoxMaidenName
            // 
            this.textBoxMaidenName.Location = new System.Drawing.Point(113, 65);
            this.textBoxMaidenName.Name = "textBoxMaidenName";
            this.textBoxMaidenName.ReadOnly = true;
            this.textBoxMaidenName.Size = new System.Drawing.Size(159, 23);
            this.textBoxMaidenName.TabIndex = 13;
            this.textBoxMaidenName.TextChanged += new System.EventHandler(this.TextBoxMaidenName_TextChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(113, 208);
            this.textBoxDescription.MinimumSize = new System.Drawing.Size(0, 100);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(159, 138);
            this.textBoxDescription.TabIndex = 14;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.TextBoxDescription_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(199, 352);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(73, 23);
            this.SaveBtn.TabIndex = 15;
            this.SaveBtn.Text = "Zapisz";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // checkBoxEdit
            // 
            this.checkBoxEdit.AutoSize = true;
            this.checkBoxEdit.Location = new System.Drawing.Point(8, 356);
            this.checkBoxEdit.Name = "checkBoxEdit";
            this.checkBoxEdit.Size = new System.Drawing.Size(60, 19);
            this.checkBoxEdit.TabIndex = 16;
            this.checkBoxEdit.Text = "Edycja";
            this.checkBoxEdit.UseVisualStyleBackColor = true;
            this.checkBoxEdit.CheckStateChanged += new System.EventHandler(this.CheckBoxEdit_CheckStateChanged);
            // 
            // ChildslistBox
            // 
            this.ChildslistBox.FormattingEnabled = true;
            this.ChildslistBox.ItemHeight = 15;
            this.ChildslistBox.Location = new System.Drawing.Point(113, 123);
            this.ChildslistBox.Name = "ChildslistBox";
            this.ChildslistBox.Size = new System.Drawing.Size(159, 79);
            this.ChildslistBox.TabIndex = 17;
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownX.Location = new System.Drawing.Point(8, 298);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(33, 23);
            this.numericUpDownX.TabIndex = 18;
            this.numericUpDownX.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.NumericUpDownX_ValueChanged);
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownY.Location = new System.Drawing.Point(8, 327);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownY.Size = new System.Drawing.Size(33, 23);
            this.numericUpDownY.TabIndex = 19;
            this.numericUpDownY.Tag = "";
            this.numericUpDownY.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.NumericUpDownX_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Y";
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.LoadBtn);
            this.ControlPanel.Controls.Add(this.LogBox);
            this.ControlPanel.Controls.Add(this.label1);
            this.ControlPanel.Controls.Add(this.label2);
            this.ControlPanel.Controls.Add(this.numericUpDownX);
            this.ControlPanel.Controls.Add(this.textBoxName);
            this.ControlPanel.Controls.Add(this.textBoxSurname);
            this.ControlPanel.Controls.Add(this.numericUpDownY);
            this.ControlPanel.Controls.Add(this.textBoxMaidenName);
            this.ControlPanel.Controls.Add(this.textBoxPartner);
            this.ControlPanel.Controls.Add(this.checkBoxEdit);
            this.ControlPanel.Controls.Add(this.ChildslistBox);
            this.ControlPanel.Controls.Add(this.SaveBtn);
            this.ControlPanel.Controls.Add(this.labelName);
            this.ControlPanel.Controls.Add(this.labelDescription);
            this.ControlPanel.Controls.Add(this.textBoxDescription);
            this.ControlPanel.Controls.Add(this.labelSurname);
            this.ControlPanel.Controls.Add(this.labelMaidenName);
            this.ControlPanel.Controls.Add(this.labelChilds);
            this.ControlPanel.Controls.Add(this.labelPartner);
            this.ControlPanel.Location = new System.Drawing.Point(818, 3);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(290, 420);
            this.ControlPanel.TabIndex = 22;
            // 
            // FamilyTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 426);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.MyPictureBox);
            this.MinimumSize = new System.Drawing.Size(500, 465);
            this.Name = "FamilyTree";
            this.Text = "Family Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.FamilyTree_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox)).EndInit();
            this.NodeContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button LoadBtn;
        private PictureBox MyPictureBox;
        private TextBox LogBox;
        private ContextMenuStrip NodeContextMenu;
        private ToolStripMenuItem AddParentToolStripMenuItem;
        private ToolStripMenuItem dodajDzieckoToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private Label labelName;
        private Label labelSurname;
        private Label labelPartner;
        private Label labelChilds;
        private Label labelMaidenName;
        private Label labelDescription;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxPartner;
        private TextBox textBoxMaidenName;
        private TextBox textBoxDescription;
        private Button SaveBtn;
        private CheckBox checkBoxEdit;
        private ListBox ChildslistBox;
        private NumericUpDown numericUpDownX;
        private NumericUpDown numericUpDownY;
        private Label label1;
        private Label label2;
        private Panel ControlPanel;
    }
}