using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Charting
{
    public class Connector
    {
        Point _origin;
        Point _destination;
        public List<Line> segments;
        Canvas _canvas;


        void AddLine(int x1, int y1, int x2, int y2)
        {
            Line line = new Line();
            line.Visibility = System.Windows.Visibility.Visible;
            line.StrokeThickness = 2;
            line.Stroke = System.Windows.Media.Brushes.Black;
            line.X1 = x1;
            line.X2 = x2;
            line.Y1 = y1; 
            line.Y2 = y2;
            segments.Add(line);
        }

        void MoveLine(Line l, int x1, int y1, int x2, int y2)
        {
            l.X1 = x1;
            l.X2 = x2;
            l.Y1 = y1;
            l.Y2 = y2;
        }

        public void Move(OrgNodeT p, OrgNodeT c)
        {
            int xd = Convert.ToInt32((c.TermTop.X - p.TermBottom.X) / 2);
            int yd = Convert.ToInt32((c.TermTop.Y - p.TermBottom.Y) / 2);

            switch (p._orgStruct)
            {
                case OrgStruct.VerticalTree:
                    MoveLine(segments[0], p.TermBottom.X, p.TermBottom.Y, p.TermBottom.X, c.TermTop.Y - yd);
                    MoveLine(segments[1], c.TermTop.X, p.TermBottom.Y + yd, p.TermBottom.X, p.TermBottom.Y + yd);
                    MoveLine(segments[2], c.TermTop.X, p.TermBottom.Y + yd, c.TermTop.X, c.TermTop.Y - 5);
                    MoveLine(segments[3], c.TermTop.X - 5, c.TermTop.Y - 5, c.TermTop.X, c.TermTop.Y);
                    MoveLine(segments[4], c.TermTop.X + 5, c.TermTop.Y - 5, c.TermTop.X, c.TermTop.Y);
                    MoveLine(segments[5], c.TermTop.X - 5, c.TermTop.Y - 5, c.TermTop.X + 5, c.TermTop.Y - 5);
                    break;
                case OrgStruct.VerticalLine:
                    MoveLine(segments[0], p.TermBottom.X, p.TermBottom.Y, p.TermBottom.X, c.TermLeft.Y);
                    MoveLine(segments[1], p.TermBottom.X, c.TermLeft.Y, c.TermLeft.X - 5, c.TermLeft.Y);
                    MoveLine(segments[2], c.TermLeft.X - 5, c.TermLeft.Y - 5, c.TermLeft.X - 5, c.TermLeft.Y + 5);
                    MoveLine(segments[3], c.TermLeft.X - 5, c.TermLeft.Y - 5, c.TermLeft.X, c.TermLeft.Y);
                    MoveLine(segments[4], c.TermLeft.X - 5, c.TermLeft.Y + 5, c.TermLeft.X, c.TermLeft.Y);
                    MoveLine(segments[5], 0, 0, 0, 0);
                    break;
            }
        }

        public Connector(OrgNodeT p, OrgNodeT c, Canvas canvas)
        {
            _canvas = canvas;
            segments = new List<Line>();

            int xd = Convert.ToInt32((c.TermTop.X - p.TermBottom.X) / 2);
            int yd = Convert.ToInt32((c.TermTop.Y - p.TermBottom.Y) / 2);

            switch (p._orgStruct)
            {
                case OrgStruct.VerticalTree:
                    AddLine(p.TermBottom.X, p.TermBottom.Y, p.TermBottom.X, c.TermTop.Y - yd);
                    AddLine(c.TermTop.X, p.TermBottom.Y + yd, p.TermBottom.X, p.TermBottom.Y + yd);
                    AddLine(c.TermTop.X, p.TermBottom.Y + yd, c.TermTop.X, c.TermTop.Y - 5);
                    AddLine(c.TermTop.X - 5, c.TermTop.Y - 5, c.TermTop.X, c.TermTop.Y);
                    AddLine(c.TermTop.X + 5, c.TermTop.Y - 5, c.TermTop.X, c.TermTop.Y);
                    AddLine(c.TermTop.X - 5, c.TermTop.Y - 5, c.TermTop.X + 5, c.TermTop.Y - 5);
                    break;
                case OrgStruct.VerticalLine:
                    AddLine(p.TermBottom.X, p.TermBottom.Y, p.TermBottom.X, c.TermLeft.Y);
                    AddLine(p.TermBottom.X, c.TermLeft.Y, c.TermLeft.X - 5, c.TermLeft.Y);
                    AddLine(c.TermLeft.X - 5, c.TermLeft.Y - 5, c.TermLeft.X - 5, c.TermLeft.Y + 5);
                    AddLine(c.TermLeft.X - 5, c.TermLeft.Y - 5, c.TermLeft.X, c.TermLeft.Y);
                    AddLine(c.TermLeft.X - 5, c.TermLeft.Y + 5, c.TermLeft.X, c.TermLeft.Y);
                    AddLine(0, 0, 0, 0);
                    break;
            }
            //}
            Draw();
        }

        public void Draw()
        {
            foreach (Line l in segments)
            {
                _canvas.Children.Add(l);
            }
        }

    }
}