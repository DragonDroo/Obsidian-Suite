using System;
using System.Collections.Generic;
using System.Linq;
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

namespace RtfEditor
{
    /// <summary>
    /// Interaction logic for RtfEditor.xaml
    /// </summary>
    public partial class RtfEditor : UserControl
    {
        public RtfEditor()
        {
            InitializeComponent();
            cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            cmbFontSize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

            FlipPage.AutoWordSelection = true;
            FlipPage.AcceptsTab = true;
        }
        private void ForegroundColor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FlipPage_Click(object sender, RoutedEventArgs e)
        {
            //Process.Start(e.LinkText);
            //e.
        }

        private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFontFamily.SelectedItem != null)
                FlipPage.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);

        }

        private void cmbFontSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            FlipPage.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.Text);
        }

        private void FlipPage_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object temp = FlipPage.Selection.GetPropertyValue(Inline.FontWeightProperty);
            btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));
            temp = FlipPage.Selection.GetPropertyValue(Inline.FontStyleProperty);
            btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
            temp = FlipPage.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            btnUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));

            temp = FlipPage.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            cmbFontFamily.SelectedItem = temp;
            temp = FlipPage.Selection.GetPropertyValue(Inline.FontSizeProperty);
            cmbFontSize.Text = temp.ToString();
        }

        private void btnBold_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)btnBold.IsChecked)
            {
                FlipPage.Selection.ApplyPropertyValue(Inline.FontWeightProperty, FontWeights.Bold);
            }
            else
            {
                FlipPage.Selection.ApplyPropertyValue(Inline.FontWeightProperty, FontWeights.Normal);
            }
        }

        private void btnItalic_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)btnItalic.IsChecked)
            {
                FlipPage.Selection.ApplyPropertyValue(Inline.FontStyleProperty, FontStyles.Italic);
            }
            else
            {
                FlipPage.Selection.ApplyPropertyValue(Inline.FontStyleProperty, FontStyles.Normal);
            }
        }

        private void btnUnderline_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)btnUnderline.IsChecked)
            {
                FlipPage.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
            }
            else
            {
                FlipPage.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
            }
        }

        private void btnUndo_Click(object sender, RoutedEventArgs e)
        {
            if (FlipPage.CanUndo)
            {
                FlipPage.Undo();
                //    FlipPage.ClearUndo();
            }
        }

        private void btnRedo_Click(object sender, RoutedEventArgs e)
        {
            if (FlipPage.CanRedo == true)
            {
                //           if (FlipPage.RedoActionName != "Delete")
                FlipPage.Redo();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                FlipPage.Paste();
            }
        }

        private void ZoomIn_Click(object sender, RoutedEventArgs e)
        {
            //       FlipPage.ZoomFactor = 3.0f;
        }

        private void ZoomOut_Click(object sender, RoutedEventArgs e)
        {
            //        FlipPage.ZoomFactor = 1.0f;
        }
        //**********************************************************
    }
}
