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
    /// Interaction logic for RtfCompact.xaml
    /// </summary>
    [System.ComponentModel.DefaultBindingProperty("")]
    // Todo: Implement DataBinding
    public partial class RtfCompact : UserControl
    {
        public RtfCompact()
        {
            InitializeComponent();
            cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            cmbFontSize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

            RTF.AutoWordSelection = true;
            RTF.AcceptsTab = true;
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
                RTF.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);

        }

        private void cmbFontSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            RTF.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.Text);
        }

        private void RTF_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object temp = RTF.Selection.GetPropertyValue(Inline.FontWeightProperty);
            btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));
            temp = RTF.Selection.GetPropertyValue(Inline.FontStyleProperty);
            btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
            temp = RTF.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            btnUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));

            temp = RTF.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            cmbFontFamily.SelectedItem = temp;
            temp = RTF.Selection.GetPropertyValue(Inline.FontSizeProperty);
            cmbFontSize.Text = temp.ToString();
        }

        private void btnBold_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)btnBold.IsChecked)
            {
                RTF.Selection.ApplyPropertyValue(Inline.FontWeightProperty, FontWeights.Bold);
            }
            else
            {
                RTF.Selection.ApplyPropertyValue(Inline.FontWeightProperty, FontWeights.Normal);
            }
        }

        private void btnItalic_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)btnItalic.IsChecked)
            {
                RTF.Selection.ApplyPropertyValue(Inline.FontStyleProperty, FontStyles.Italic);
            }
            else
            {
                RTF.Selection.ApplyPropertyValue(Inline.FontStyleProperty, FontStyles.Normal);
            }
        }

        private void btnUnderline_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)btnUnderline.IsChecked)
            {
                RTF.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
            }
            else
            {
                RTF.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
            }
        }

        private void btnUndo_Click(object sender, RoutedEventArgs e)
        {
            if (RTF.CanUndo)
            {
                RTF.Undo();
                //    FlipPage.ClearUndo();
            }
        }

        private void btnRedo_Click(object sender, RoutedEventArgs e)
        {
            if (RTF.CanRedo == true)
            {
                //           if (FlipPage.RedoActionName != "Delete")
                RTF.Redo();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                RTF.Paste();
            }
        }
    }
}
