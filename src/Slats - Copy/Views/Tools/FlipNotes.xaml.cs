using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
    public class Employee
    {
        public Employee(string name)
        {
            Name = name;
            Employees = new List<Employee>();
        }
        public string Name { get; set; }
        public IList<Employee> Employees { get; private set; }
    }
    /// <summary>
    /// Interaction logic for FlipNotes.xaml
    /// </summary>

/// <summary>
/// Interaction logic for FlipNotes.xaml
/// </summary>
public partial class FlipNotes : Page
{
    public List<Employee> Employees;
    public FlipNotes(FlipNotesVM viewmodel)
    {
        InitializeComponent();
        DataContext = viewmodel;

        cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
        cmbFontSize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

        FlipPage.AutoWordSelection = true;
        FlipPage.AcceptsTab = true;
        SetUpDataContext();

    }

    private void SetUpDataContext()
    {
        var manager1 = new Employee("Matt Manager");
        manager1.Employees.Add(new Employee("Sam"));
        manager1.Employees.Add(new Employee("Ella"));

        var manager2 = new Employee("Mel Aboss");
        manager2.Employees.Add(new Employee("Tim"));
        manager2.Employees.Add(new Employee("Tom"));

        var manager3 = new Employee("Mark Incharge");
        manager3.Employees.Add(new Employee("Jack"));
        manager3.Employees.Add(new Employee("Jill"));

        var manager4 = new Employee("Mike Planner");
        manager4.Employees.Add(new Employee("Rita"));
        manager4.Employees.Add(new Employee("Sue"));
        manager4.Employees.Add(new Employee("Bob"));

        var manager5 = new Employee("Matt Manager");
        manager5.Employees.Add(new Employee("Chaz"));
        manager5.Employees.Add(new Employee("Dave"));

        var director1 = new Employee("Jim Director");
        director1.Employees.Add(manager1);
        director1.Employees.Add(manager2);

        var director2 = new Employee("Pam Dictator");
        director2.Employees.Add(manager3);
        director2.Employees.Add(manager4);
        director2.Employees.Add(manager5);

        var md = new Employee("Martin Topboss");
        md.Employees.Add(director1);
        md.Employees.Add(director2);

        var pa = new Employee("Petra Peeyaa");

        DataContext = new List<Employee> { md, pa };
    }

    //private void FlipPage_LinkClicked(object sender, LinkClickedEventArgs e)
    //{
    //    Process.Start(e.LinkText);
    //}
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