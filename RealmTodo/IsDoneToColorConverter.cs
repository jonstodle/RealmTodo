using System;
using System.Globalization;
using Xamarin.Forms;

namespace RealmTodo
{
	public class IsDoneToColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => (bool)value ? Color.FromRgba(0, 0, 0, 127) : Color.Black;

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
