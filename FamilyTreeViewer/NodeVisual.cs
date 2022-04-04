using System.Drawing.Drawing2D;

namespace FamilyTreeViewer
{
    internal class NodeVisual
    {
        internal int X { get; set; }
        internal int Y { get; set; }
        internal int Width { get; set; }
        internal int Height { get; set; }
        internal int ArcSize { get; set; }

        internal Brush Brush { get; set; }
        internal Pen Pen { get; set; }
        internal Font Font { get; set; }

        private static readonly Brush normalBrush = Brushes.Black;
        private static readonly Pen normalPen = new(Brushes.Black, 2);
        private static readonly Font normalFont = new("Calibri", 10.0f);

        private static readonly Brush selectedBrush = Brushes.Black;
        private static readonly Pen selectedPen = new(Brushes.DarkOrange, 4);
        private static readonly Font selectedFont = new("Calibri", 12.0f, FontStyle.Bold);

        private const int nodeWidth = 200;
        private const int nodeHeight = 20;
        private const int arcSize = 10;

        internal NodeVisual(int x, int y, int width = nodeWidth, int height = nodeHeight, int arcSize = arcSize)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;

            //Validate Arc Size
            arcSize = 2 * (int)(arcSize / 2);
            if (arcSize * 2 > nodeHeight)
            {
                arcSize = nodeHeight / 2;
            }
            ArcSize = arcSize;

            Brush = normalBrush;
            Pen = normalPen;
            Font = normalFont;
        }

        internal void DrawNode(string fullname, Graphics g)
        {
            int horizontalLineSize = Width - ArcSize - ArcSize;
            int verticalLineSize = Height - ArcSize - ArcSize;

            g.SmoothingMode = SmoothingMode.AntiAlias;

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            g.DrawString(fullname, Font, Brush, new PointF(X, Y), stringFormat);
            //SizeF textSize = g.MeasureString(fullname, Font, nodeWidth, stringFormat);

            // ---
            g.DrawLine(Pen, new Point(X - (horizontalLineSize / 2), Y - (Height / 2)),
                new Point(X + (horizontalLineSize / 2) + 1, Y - (Height / 2)));

            // ___
            g.DrawLine(Pen, new Point(X - (horizontalLineSize / 2), Y + (Height / 2)),
                new Point(X + (horizontalLineSize / 2) + 1, Y + (Height / 2)));

            // |..
            g.DrawLine(Pen, new Point(X - (Width / 2), Y - (verticalLineSize / 2)),
                new Point(X - (Width / 2), Y + (verticalLineSize / 2) + 1));

            // ..|
            g.DrawLine(Pen, new Point(X + (Width / 2), Y - (verticalLineSize / 2)),
                new Point(X + (Width / 2), Y + (verticalLineSize / 2) + 1));

            g.DrawArc(Pen, new Rectangle(X - (Width / 2),
                Y - (Height / 2), ArcSize * 2, ArcSize * 2), 180, 90);
            g.DrawArc(Pen, new Rectangle(X + (Width / 2) - ArcSize - ArcSize,
                Y - (Height / 2), ArcSize * 2, ArcSize * 2), 270, 90);
            g.DrawArc(Pen, new Rectangle(X + (Width / 2) - ArcSize - ArcSize,
                Y + (Height / 2) - ArcSize - ArcSize, ArcSize * 2, ArcSize * 2), 0, 90);
            g.DrawArc(Pen, new Rectangle(X - (Width / 2),
                Y + (Height / 2) - ArcSize - ArcSize, ArcSize * 2, ArcSize * 2), 90, 90);
        }

        internal bool IsClicked(Point pos)
        {
            Rectangle area = new(X - (Width / 2), Y - (Height / 2), Width, Height);
            if (area.Contains(pos))
            {
                return true;
            }
            return false;
        }
        internal void SetClicked(bool state)
        {
            if (state)
            {
                ChangeToSelectedColor();
            }
            else
            {
                ChangeToNormalColor();
            }
        }
        internal Point GetSocket(bool upperSocket)
        {
            if (upperSocket)
            {
                return new Point(X, Y - (Height / 2));
            }
            else
            {
                return new Point(X, Y + (Height / 2));
            }
        }

        private void ChangeToNormalColor()
        {
            Brush = normalBrush;
            Pen = normalPen;
            Font = normalFont;
        }
        private void ChangeToSelectedColor()
        {
            Brush = selectedBrush;
            Pen = selectedPen;
            Font = selectedFont;
        }
    }
}
