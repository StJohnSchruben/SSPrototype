using SSMainControl.Model.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace SSMainControl.Views.Converters
{
    public class FileTypeToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility visibility = Visibility.Visible;
            SSObjectType fileType = (SSObjectType)value;
            switch (fileType)
            {
                case SSObjectType.UnknownFileType:
                case SSObjectType.SSProject:
                case SSObjectType.SSFolder:
                    visibility = Visibility.Collapsed;
                    break;
            };

            return visibility;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
