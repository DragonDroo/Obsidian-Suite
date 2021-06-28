using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Charting
{
    /// <summary>
    /// Interaction logic for OrgNodeT.xaml
    /// </summary>

        public enum OrgStruct : int
        {
            VerticalTree = 1,
            HorizontalTree = 2,
            HorizontalLine = 3,
            VerticalLine = 4
        }
        public partial class OrgNodeT : UserControl, INotifyPropertyChanged
        {
            public int X { get { return _XPos; } set { _XPos = value; } }
            public int Y { get { return _YPos; } set { _YPos = value; } }
            //    public string Header { get { return Header; } set { Header = value; } }
            //    public event PropertyChangedEventHandler NotifyPropertyChanged;
            public event PropertyChangedEventHandler PropertyChanged;

            private string _Header;

            public string Header
            {
                get { return _Header; }
                set
                {
                    if (value != _Header)
                    {
                        _Header = value;
                        NotifyPropertyChanged("Header");
                    }
                }
            }

            private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }

            public void Place(int x, int y)
            {
                _XPos = x;
                _YPos = y;
                TermBottom = new Point(_XPos + 75, _YPos + 40);
                TermTop = new Point(_XPos + 75, _YPos);
                TermLeft = new Point(_XPos, _YPos + 20);

                int i = 0;
                foreach (OrgNodeT t in this.Children)
                {
                    t.Place(x, y);
                    //        Connectors[0].MoveConnector(_XPos, _YPos, t._XPos, t._YPos);
                    Connectors[i].Move(this, t);
                    i++;
                }
                redraw();
            }

            public void Move(int x, int y)
            {
                _XPos = _XPos + x;
                _YPos = _YPos + y;

                TermBottom = new Point(_XPos + 75, _YPos + 40);
                TermTop = new Point(_XPos + 75, _YPos);
                TermLeft = new Point(_XPos, _YPos + 20);


                int i = 0;
                foreach (OrgNodeT t in this.Children)
                {
                    t.Move(x, y);
                    Connectors[i].Move(this, t);
                    i++;
                }

                redraw();
            }

            public OrgNodeT(Canvas canvas, OrgNodeT parent)
            {
                InitializeComponent();
                _XPos = 20;
                _YPos = 20;
                _Height = 40;
                _Width = 150;
                _Name = "New";
                //    _Child = null;
                _selected = false;
                TermBottom = new Point(_XPos + (_Width / 2), _YPos + _Height);
                TermTop = new Point(_XPos + (_Width / 2), _YPos);
                TermLeft = new Point(_XPos, _YPos + 20);
                //    TermBottom.X = _XPos + (_Width / 2);
                //            TermTop.X = _XPos + (_Width / 2);
                //    TermBottom.Y = _YPos + _Height;
                //           TermTop.Y = _YPos;

                Children = new List<OrgNodeT>();
                Parent = parent;
                Connectors = new List<Connector>();

                canvas.Children.Add(this);
                _canvas = canvas;
                _orgStruct = OrgStruct.VerticalTree;

            }

            private int _GridX;
            private int _GridY;
            public int _XPos;
            public int _YPos;
            public int _Height;
            public int _Width;
            public string _Name;
            public int ID;
            private Canvas _canvas;
            public OrgStruct _orgStruct;
            public bool _selected;
            public Point TermBottom;
            public Point TermTop;
            public Point TermLeft;
            public Point TermRight;

            //   OrgNode _Child;

            public List<OrgNodeT> Children;
            public List<Connector> Connectors;
            public OrgNodeT Parent;
            public void OrderTheChildren()
            {
                switch (_orgStruct)
                {
                    case OrgStruct.VerticalTree:
                        //MessageBox.Show(this.Children.Count.ToString());
                        int Yline = _YPos + 60;
                        int XWidth = (Children.Count * 150) + ((Children.Count - 1) * 20);
                        int XStart = _XPos - (XWidth / 2) + 75;
                        int i = 0;
                        int x = 0;
                        int y = 0;

                        foreach (OrgNodeT t in this.Children)
                        {
                            x = XStart + (i * 170);
                            y = Yline;
                            t.Place(x, y);
                            t.redraw();
                            t.OrderTheChildren();
                            Connectors[i].Move(this, t);
                            i++;
                        }
                        break;
                    case OrgStruct.VerticalLine:
                        //MessageBox.Show(this.Children.Count.ToString());
                        int Xline = _XPos + 60;
                        //     int XWidth = (Children.Count * 150) + ((Children.Count - 1) * 20);
                        //     int XStart = _XPos - (XWidth / 2) + 75;
                        x = 0;
                        y = 0;
                        i = 0;
                        foreach (OrgNodeT t in this.Children)
                        {
                            //                        x = Xline + (i * 170);
                            y = this._YPos + ((i + 1) * 60);
                            t.Place(this.TermBottom.X + 20, y);
                            t.redraw();
                            t.OrderTheChildren();
                            Connectors[i].Move(this, t);
                            i++;

                        }
                        break;
                }
            }
            public void redraw()
            {
                Canvas.SetTop(this, _YPos);
                Canvas.SetLeft(this, _XPos);
                //foreach (Connector c in Connectors)
                //{
                //    foreach(Line l in c.segments)
                //    {
                //        Canvas.SetLeft(l, l.X1);
                //        Canvas.SetRight(l, l.X2);
                //        Canvas.SetTop(l, l.Y1);
                //        Canvas.SetBottom(l, l.Y2);
                //    }
                //}
                //            Canvas.SetTop(OrgNodes[ActiveNode], OrgNodes[ActiveNode]._YPos);
            }

            private void DrawConnector_Click(object sender, RoutedEventArgs e)
            {
                foreach (Connector c in Connectors)
                {
                    foreach (Line l in c.segments)
                    {
                        //         MeBob.Children.Add(l);
                        //      Console.WriteLine(l.X1.ToString());
                    }
                }
            }

            public void SetX(int i)
            {

            }

            public void Select()
            {
                if (_selected == true)
                {
                    _selected = false;
                    this.Background = Brushes.Transparent;

                }
                else
                {
                    _selected = true;

                    SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                    mySolidColorBrush.Color =
                        Color.FromArgb(
                            255, // Specifies the transparency of the color.
                            255, // Specifies the amount of red.
                            0, // specifies the amount of green.
                            0); // Specifies the amount of blue.

                    this.Background = mySolidColorBrush;
                    //  NodeBorder.BorderBrush. = new Brushes.Goldenrod; //   "FFEDB5BF"
                }
            }

            public OrgNodeT AddChild()
            {
                Children.Add(new OrgNodeT(_canvas, this));
                AddConnector(Children[Children.Count - 1]);
                if (this.Parent != null)
                {
                    try
                    {
                        this.Parent.OrderTheChildren();
                    }
                    catch { }
                }
                else
                {
                    try
                    {
                        this.OrderTheChildren();
                    }
                    catch { }
                }
                return Children[Children.Count - 1];

            }

            public Connector AddConnector(OrgNodeT child)
            {
                Connectors.Add(new Connector(this, child, _canvas));
                return Connectors[Connectors.Count - 1];
            }

            public void Draw()
            {

            }

            private void TextBox_MouseDown(object sender, MouseButtonEventArgs e)
            {

            }

            private void Layout_Click(object sender, RoutedEventArgs e)
            {
                //            if (_orgStruct.GetHashCode >= 3) { _orgStruct = 0; } else { _orgStruct++; }
                switch (_orgStruct)
                {
                    case OrgStruct.VerticalTree:
                        Layout.Content = "Horizontal Tree";
                        _orgStruct = OrgStruct.HorizontalTree;
                        break;
                    case OrgStruct.HorizontalTree:
                        Layout.Content = "Horizontal Line";
                        _orgStruct = OrgStruct.HorizontalLine;
                        break;
                    case OrgStruct.HorizontalLine:
                        Layout.Content = "Vertical Line";
                        _orgStruct = OrgStruct.VerticalLine;
                        break;
                    case OrgStruct.VerticalLine:
                        Layout.Content = "Vertical Tree";
                        _orgStruct = OrgStruct.VerticalTree;
                        break;
                }
                OrderTheChildren();
            }
        }
    }