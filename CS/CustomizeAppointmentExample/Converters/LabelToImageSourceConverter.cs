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
    #region #LabelToImageSourceConverter
    public class LabelToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((int)value == 1)
                return DXImageHelper.GetImageSource(@"Office2013\Tasks\Status_16x16.png");
            else
                return DXImageHelper.GetImageSource(@"Office2013\Support\Info_16x16.png");
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
    #endregion #LabelToImageSourceConverter

    #region #LabelToImageSourceConverterExtension
    public class LabelToImageSourceConverterExtension : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return new LabelToImageSourceConverter();
        }
    }
    #endregion #LabelToImageSourceConverterExtension
}
