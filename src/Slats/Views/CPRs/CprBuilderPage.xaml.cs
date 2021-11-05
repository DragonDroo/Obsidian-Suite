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
using Slats.ViewModels;

namespace Slats.Views
{
    /// <summary>
    /// Interaction logic for CprBuilderPage.xaml
    /// </summary>
    public partial class CprBuilderPage : Page
    {
        public CprBuilderPage(CprBuilderVM viewmodel)
        {
            InitializeComponent();
            DataContext = viewmodel;

            //cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            //cmbFontSize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            //Todo: Add ability to edit formatting of questions in RTF format
            
            //RtfBox.AutoWordSelection = true;
            //RtfBox.AcceptsTab = true;
        }

        private void RtfBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            //object temp = RtfBoxQ.Selection.GetPropertyValue(Inline.FontWeightProperty);
            //btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));
            //temp = RtfBox.Selection.GetPropertyValue(Inline.FontStyleProperty);
            //btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
            //temp = RtfBox.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            //btnUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));

            //temp = RtfBox.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            //cmbFontFamily.SelectedItem = temp;
            //temp = RtfBox.Selection.GetPropertyValue(Inline.FontSizeProperty);
            //cmbFontSize.Text = temp.ToString();
        }
        private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (cmbFontFamily.SelectedItem != null)
            //    FlipPage.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);

        }
        private void ForegroundColor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmbFontSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            //FlipPage.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.Text);
        }

        private void btnBold_Click(object sender, RoutedEventArgs e)
        {
            //if ((bool)btnBold.IsChecked)
            //{
            //    FlipPage.Selection.ApplyPropertyValue(Inline.FontWeightProperty, FontWeights.Bold);
            //}
            //else
            //{
            //    FlipPage.Selection.ApplyPropertyValue(Inline.FontWeightProperty, FontWeights.Normal);
            //}
        }

        private void btnItalic_Click(object sender, RoutedEventArgs e)
        {
            //if ((bool)btnItalic.IsChecked)
            //{
            //    FlipPage.Selection.ApplyPropertyValue(Inline.FontStyleProperty, FontStyles.Italic);
            //}
            //else
            //{
            //    FlipPage.Selection.ApplyPropertyValue(Inline.FontStyleProperty, FontStyles.Normal);
            //}
        }

        private void btnUnderline_Click(object sender, RoutedEventArgs e)
        {
            //if ((bool)btnUnderline.IsChecked)
            //{
            //    FlipPage.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
            //}
            //else
            //{
            //    FlipPage.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
            //}
        }

        private void btnUndo_Click(object sender, RoutedEventArgs e)
        {
            //if (FlipPage.CanUndo)
            //{
            //    FlipPage.Undo();
            //    //    FlipPage.ClearUndo();
            //}
        }

        private void btnRedo_Click(object sender, RoutedEventArgs e)
        {
            //if (FlipPage.CanRedo == true)
            //{
            //    //           if (FlipPage.RedoActionName != "Delete")
            //    FlipPage.Redo();
            //}
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                //FlipPage.Paste();
            }
        }
    }
}
