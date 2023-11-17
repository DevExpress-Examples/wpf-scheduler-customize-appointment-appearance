using DevExpress.Xpf.Core;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace CustomizeAppointmentExample {
    public class ConditionToImageSourceConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value != null) {
                if ((bool)value)
                    return DXImageHelper.GetImageSource(@"Office2013\Actions\Show_16x16.png");
            }
            return null;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            return value;
        }
    }

    public class ConditionToImageSourceConverterExtension : MarkupExtension {
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return new ConditionToImageSourceConverter();
        }
    }
}
