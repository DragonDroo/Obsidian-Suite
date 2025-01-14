﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Slats.Converters
{
    /// <inheritdoc />
    /// <summary>
    /// <para>Expects an <see cref="object" />.</para>
    /// <para>Returns <see langword="false"/> if <see cref="object.ToString" /> equals the given parameter.</para>
    /// <para>Returns <see langword="true"/> otherwise.</para>
    /// </summary>
    [ValueConversion(typeof(object), typeof(bool))]
    public class ObjectToStringEqualsParameterToInverseBoolConverter
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
        public static IValueConverter Instance => _instance ?? (_instance = new ObjectToStringEqualsParameterToInverseBoolConverter());

        /// <inheritdoc />
        public virtual object Convert(object? value, Type targetType, object? parameter, CultureInfo? culture)
        {
            return value?.ToString() != parameter as string;
        }

        /// <inheritdoc />
        /// <exception cref="NotSupportedException">This operation is not supported.</exception>
        public virtual object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo? culture)
        {
            throw new NotSupportedException();
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