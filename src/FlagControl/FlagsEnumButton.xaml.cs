using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace FlagControl
{
    /// <summary>FlagsEnumButton interaction logic
    /// The FlagsEnumButton presents the values of a [Flags] Enum as a list of checkable options in a dropdown (i.e., context) menu.
    /// The Enum values can overlap, where selecting one value simultaneously selects other values.
    /// </summary>
    /// <remarks>
    /// ButtonLabelStyle - Selects what is shown as the button text. This can be a fixed text value or a list containing the selected values' 
    ///                    index position (1-based) in the dropdown [Default], actual value, or name (or Description attribute) in the Enum
    ///                    definition. When Names is selected, the names are stacked; positions and values are a comma-separated list.
    /// <para>ButtonLabel - Sets the fixed text for the button when that option is selected for ButtonLabelStyle.</para>
    /// <para>EmptySelectionLabel - Sets the text to display in the button when no values are selected. Default is "None."</para>
    /// <para>EnumValue - Gets/Sets the value of the bound Enum field. (Requires FlagsIntConverter.)</para>
    /// <para>ChoicesSource - Sets the Type of the Enum.</para>
    /// </remarks>
    public partial class FlagsEnumButton : Button
    {
        public enum ButtonLabelStyles { Indexes, Values, Names, FixedText }
        public FlagsEnumButton()
        {
            InitializeComponent();
            menu.ItemsSource = menuItems;
            buttonLabel.Text = ButtonLabel;
        }

        #region Properties

        public string ButtonLabel
        {
            get
            {
                var checkedItems = menuItems.Where(x => x.IsChecked);
                if (checkedItems.Count() == 0)
                    return EmptySelectionLabel;
                if (ButtonLabelStyle == ButtonLabelStyles.FixedText)
                    return fixedButtonLabel;
                {
                    IEnumerable<string> terms;
                    var delim = ", ";
                    switch (ButtonLabelStyle)
                    {
                        case ButtonLabelStyles.Values:
                            terms = checkedItems.Select(y => ((int)y.Tag).ToString());
                            break;
                        case ButtonLabelStyles.Names:
                            terms = checkedItems.Select(y => ((Enum)y.Tag).GetDescription());
                            delim = Environment.NewLine;
                            break;
                        default: //"Indexes" is the default
                            terms = checkedItems.Select(y => (menuItems.IndexOf(y) + 1).ToString());
                            break;
                    }
                    return string.Join(delim, terms);
                }
            }
            set
            {
                fixedButtonLabel = value;
            }
        }

        /// <summary>Sets the [Flags]enum type to be presented in the dropdown menu.
        /// </summary>
        public Type ChoicesSource
        {
            set
            {
                if (!value.IsEnum ||
                    value.GetCustomAttributes(typeof(FlagsAttribute), false).Length == 0)
                    throw new ArgumentException($"Type '{value.Name}' is not an enum with the [Flags] attribute.", nameof(ChoicesSource));
                if (menuItems.Count == 0)
                {
                    // Create a MenuItem for each defined value of the enum
                    foreach (var val in Enum.GetValues(value))
                    {
                        var menuitem = new MenuItem()
                        {
                            Header = ((Enum)val).GetDescription(),
                            IsCheckable = true,
                            StaysOpenOnClick = true,
                            Tag = Enum.ToObject(value, val)
                        };
                        menuitem.Click += Menuitem_Click;
                        menuItems.Add(menuitem);
                    }
                    // In an expandable grid row, EnumValue gets set before ChoicesSource is set.
                    // Repeat the assignment now to get the new menuItems appropriately checked and the button label updated.
                    if (EnumValue != 0)
                        EnumValue = (int)GetValue(EnumValueProperty); //This is intentionally a redundant assignment.
                }
                else
                    throw new InvalidOperationException("Cannot redefine ChoicesSource.");
            }
        }

        #region DependencyProperty EmptySelectionLabel
        public static readonly DependencyProperty EmptySelectionLabelProperty = DependencyProperty.Register("EmptySelectionLabel", typeof(string), typeof(FlagsEnumButton),
            new PropertyMetadata("None", new PropertyChangedCallback(EmptySelectionLabelChanged)));

        private static void EmptySelectionLabelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((FlagsEnumButton)d).buttonLabel.Text = ((FlagsEnumButton)d).ButtonLabel;
        }

        public string EmptySelectionLabel
        {
            get { return (string)GetValue(EmptySelectionLabelProperty); }
            set { SetValue(EmptySelectionLabelProperty, value); }
        }
        #endregion DependencyProperty EmptySelectionLabel

        #region DependencyProperty Check
        public static readonly DependencyProperty CheckHandlerProperty = DependencyProperty.Register("Check", typeof(RoutedEventHandler), typeof(FlagsEnumButton));

        /// <summary>The custom event handler to execute whenever a selection is checked/unchecked.
        /// </summary>
        public RoutedEventHandler Check
        {
            get { return (RoutedEventHandler)GetValue(CheckHandlerProperty); }
            set { SetValue(CheckHandlerProperty, value); }
        }
        #endregion DependencyProperty Check

        #region DependencyProperty EnumValue
        public static readonly DependencyProperty EnumValueProperty = DependencyProperty.Register("EnumValue", typeof(int), typeof(FlagsEnumButton),
            new PropertyMetadata(0, new PropertyChangedCallback(EnumValueChanged)));
        private static void EnumValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((FlagsEnumButton)d).EnumValue = (int)e.NewValue;
        }
        /// <summary>Gets and sets the int representation of the checked items. Bind to this, using the FlagsIntConverter.
        /// </summary>
        public int EnumValue
        {
            get { return (int)GetValue(EnumValueProperty); }
            set
            {
                if (menuItems.Count == 0)
                    return;
                SetValue(EnumValueProperty, value);
                foreach (var item in menuItems) //This is redundant when item.Click triggered it and no overlapping values exist.
                    item.IsChecked = (value & (int)item.Tag) == (int)item.Tag;
                buttonLabel.Text = ButtonLabel; //Update the text to reflect the new value.
            }
        }
        #endregion DependencyProperty EnumValue

        #region DependencyProperty ButtonLabelStyle
        public static readonly DependencyProperty ButtonLabelStyleProperty = DependencyProperty.Register("ButtonLabelStyle", typeof(ButtonLabelStyles), typeof(FlagsEnumButton),
            new PropertyMetadata(ButtonLabelStyles.Indexes));
        /// <summary>Gets and sets the labeling style to use for the button Content.
        /// </summary>
        public ButtonLabelStyles ButtonLabelStyle
        {
            get { return (ButtonLabelStyles)GetValue(ButtonLabelStyleProperty); }
            set
            {
                SetValue(ButtonLabelStyleProperty, value);
                buttonLabel.Text = ButtonLabel;
            }
        }
        #endregion DependencyProperty ButtonLabelStyle

        #endregion Properties

        /// <summary>Called whenever a dropdown item is clicked, changing its IsChecked state.
        /// </summary>
        private void Menuitem_Click(object sender, RoutedEventArgs e)
        {
            Check?.Invoke(sender, e); //Call any added Check handler.
            // Update EnumValue
            var item = sender as MenuItem;
            SetValue(EnumValueProperty, item.IsChecked ? EnumValue | (int)item.Tag : EnumValue & ~(int)item.Tag);
            // Update label
            buttonLabel.Text = ButtonLabel;
            e.Handled = true;
        }

        /// <summary>Called when the context menu closes. Update the source bound to EnumValue.
        /// </summary>
        private void Menu_Closed(object sender, RoutedEventArgs e)
        {
            GetBindingExpression(EnumValueProperty).UpdateSource();
        }

        /// <summary>Handle the button click event. Open the context menu if it was not already open.
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // IsOpen will always be false here, but IsVisible will give us the menu state at the time the button was clicked.
            if (!menu.IsVisible) menu.IsOpen = true;
        }

        //    #region Disable/Enable items
        //
        //    #region DependencyProperty DisabledValues
        //    public readonly static DependencyProperty DisabledValuesProperty =
        //    DependencyProperty.Register("DisabledValues", typeof(int), typeof(FlagsEnumButton), new PropertyMetadata(null, new PropertyChangedCallback(DisabledValuesChanged)));
        //
        //    private static void DisabledValuesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //    {
        //        (d as FlagsEnumButton).disabledValues = (int)e.NewValue;
        //    }
        //
        //    public int DisabledValues
        //    {
        //        get { return (int)GetValue(DisabledValuesProperty); }
        //        set { SetValue(DisabledValuesProperty, value); }
        //    }
        //
        //    private int disabledValues
        //    {
        //        get { return menuItems.Where(x => !x.IsEnabled).Select(y => (int)y.Tag).Aggregate(0, (s, c) => s + c); }
        //        set
        //        {
        //            foreach (MenuItem item in menuItems)
        //                item.IsEnabled = !((value & (int)item.Tag) == (int)item.Tag);
        //        }
        //    }
        //    #endregion DependencyProperty DisabledValues

        //   private void LockItem(MenuItem item, bool state)
        //   {
        //       item.IsChecked = state;
        //       item.IsEnabled = false;
        //       buttonLabel.Text = ButtonLabel;
        //   }
        //
        //   public void LockItem(string name, bool state = false)
        //   {
        //       MenuItem item = menuItems.FirstOrDefault(x => x.Header.ToString() == name);
        //       if (item != null) LockItem(item, state);
        //   }
        //
        //   public void LockItem(int value, bool state = false)
        //   {
        //       MenuItem item = menuItems.FirstOrDefault(x => (int)x.Tag == value);
        //       if (item != null) LockItem(item, state);
        //   }
        //
        //   public void UnlockItem(string name)
        //   {
        //       MenuItem item = menuItems.FirstOrDefault(x => x.Header.ToString() == name);
        //       if (item != null)
        //           item.IsEnabled = true;
        //   }
        //
        //   public void UnlockItem(int value)
        //   {
        //       MenuItem item = menuItems.FirstOrDefault(x => (int)x.Tag == value);
        //       if (item != null)
        //           item.IsEnabled = true;
        //   }
        //
        //   #endregion Disable/Enable items

        #region Fields
        private readonly ObservableCollection<MenuItem> menuItems = new ObservableCollection<MenuItem>();
        private string fixedButtonLabel = "Button";
        #endregion Fields
    }
}
