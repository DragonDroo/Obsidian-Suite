﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace Slats.Converters
{
    /// <inheritdoc />
    /// <summary>
    /// <para>Expects a <see cref="bool" />.</para>
    /// <para>Returns <see cref="Visibility.Visible" /> if it is <see langword="true"/>.</para>
    /// <para>Returns <see cref="Visibility.Hidden" /> if <see langword="false"/> and "Hidden" was set as the parameter.</para>
    /// <para>Returns <see cref="Visibility.Collapsed" /> otherwise.</para>
    /// </summary>
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BoolToVisibilityConverter
#if NET35
        : IValueConverter
#else
        : MarkupExtension, IValueConverter
#endif
    {
        private static IValueConverter? _instance;

        /// <summary>
        /// Static instance of this converter.
        /// </summary>
        public static IValueConverter Instance => _instance ?? (_instance = new BoolToVisibilityConverter());

        /// <inheritdoc />
        public virtual object Convert(object value, Type targetType, object? parameter, CultureInfo? culture)
        {
            if (!(value is bool boolValue))
                return DependencyProperty.UnsetValue;

            if (boolValue)
                return Visibility.Visible;

            if ("Hidden".Equals(parameter as string, StringComparison.OrdinalIgnoreCase))
                return Visibility.Hidden;

            return Visibility.Collapsed;
        }

        /// <inheritdoc />
        public virtual object ConvertBack(object value, Type targetType, object? parameter, CultureInfo? culture)
        {
            if (!(value is Visibility visibilityValue))
                return DependencyProperty.UnsetValue;

            return visibilityValue == Visibility.Visible;
        }

#if !NET35
        /// <inheritdoc />
        public override object ProvideValue(IServiceProvider? serviceProvider)
        {
            return Instance;
        }
#endif
    }
}