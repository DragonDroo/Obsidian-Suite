using System;
using System.Collections.Generic;
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
    /// Interaction logic for ChartSpace.xaml
    /// </summary>
    public partial class ChartSpace : UserControl
    {
        public int x;
        public int Rotation;
        private int ActiveNode;
        private int ScaleRate;
        private OrgNodeT ActiveNodeT;
        Transform st; 
        List<OrgNodeT> OrgNodes;
        List<Connector> Connectors;
        public ChartSpace()
        {
            int x = 100;
            Rotation = 0;
            OrgNodes = new List<OrgNodeT>();
            Connectors = new List<Connector>();

            InitializeComponent();
        }

            private void canvas_MouseWheel(object sender, MouseWheelEventArgs e)
            {
            //    MeBob.RenderTransform = st;
            //    {
            //        if (e.Delta > 0)
            //        {                    
            //            st.ScaleX *= 2;
            //            st.ScaleY *= 2;
            //        }
            //        else
            //        {
            //            st.ScaleX /= 2;
            //            st.ScaleY /= 2;
            //        }
            //    }
            }

            private void N1_Click(object sender, RoutedEventArgs e)
            {
                ActiveNodeT.Move(-20, 0);
            }

            private void N2_Click(object sender, RoutedEventArgs e)
            {
                ActiveNodeT.Move(20, 0);

            }

            private void N3_Click(object sender, RoutedEventArgs e)
            {
                ActiveNodeT.Move(0, -20);
            }

            private void N4_Click(object sender, RoutedEventArgs e)
            {
                ActiveNodeT.Move(0, 20);
            }
            private void NewControl_Click(object sender, RoutedEventArgs e)
            {
                if (ActiveNodeT != null)
                {
                    //      OrgNodeT temp = OrgNodes[ActiveNode].AddChild();
                    OrgNodeT temp = ActiveNodeT.AddChild();
                    temp.MouseDown += Demon_MouseDown;
                    temp.tbHeader.Text = "Dustin"; // DateTime.Now.ToString();
                    temp.Positon.Text = "Position";
                    temp.Grade.Text = "GS6";
                    temp.Parent = ActiveNodeT;
                    ActiveNodeT = temp;
                }
                else
                {
                    if (OrgNodes.Count > 0)
                    {
                        //   MeBob.Children.Add(OrgNodes[OrgNodes.Count - 1]);
                    }
                    else
                    {
                        OrgNodeT demon = new OrgNodeT(MeBob, ActiveNodeT);
                        demon.MouseDown += Demon_MouseDown;
                        demon.ID = OrgNodes.Count;
                        OrgNodes.Add(demon);
                        ActiveNodeT = demon;
                        ActiveNodeT.tbHeader.Text = "Something";
                        ActiveNodeT.Positon.Text = "Position";
                        ActiveNodeT.Grade.Text = "GS6";
                    }
                    OrgNodes[0].OrderTheChildren();
                }

            }

            private void Demon_MouseDown(object sender, MouseButtonEventArgs e)
            {
                //     OrgNodeT sv = sender as OrgNodeT;
                //throw new NotImplementedException();
                ActiveNodeT = sender as OrgNodeT;
                ActiveNodeT.Select();
                //   MessageBox.Show(ActiveNodeT._XPos.ToString());
                //   ActiveNode = sv.ID;
                //   Temporary.Text = ActiveNode.ToString(); //sv.ID.ToString();
            }


            private void NewConnector_Click(object sender, RoutedEventArgs e)
            {


                //     Console.WriteLine("Coords:" + OrgNodes[0]._XPos.ToString() + " " + OrgNodes[0]._YPos.ToString() + " " + OrgNodes[1]._XPos.ToString() + " " + OrgNodes[1]._YPos.ToString());


                //      MeBob.Children.Add(Connectors[0].segments[0]);
            }


            private void slider1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
            {

            }
            private void DrawConnector_Click(object sender, RoutedEventArgs e)
            {

            }

            private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
            {
            }

            private void OrderChildren_Click(object sender, RoutedEventArgs e)
            {
                ActiveNodeT.OrderTheChildren();
                MessageBox.Show("Order Menu");
            }
    }
}
