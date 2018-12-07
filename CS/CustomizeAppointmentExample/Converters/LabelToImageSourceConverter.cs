using DevExpress.Utils.Design;
using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace CustomizeAppointmentExample
{
    #region #ConditionToImageSourceConverter
    public class ConditionToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((bool)value)
                    return DXImageHelper.GetImageSource(@"Office2013\Actions\Show_16x16.png");
            }
            return null;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
    #endregion #ConditionToImageSourceConverter

    #region #ConditionToImageSourceConverterExtension
    public class ConditionToImageSourceConverterExtension : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return new ConditionToImageSourceConverter();
        }
    }
    #endregion #ConditionToImageSourceConverterExtension
}
