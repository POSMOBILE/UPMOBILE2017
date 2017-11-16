using System;
using Xamarin.Forms;
using System.Globalization;

namespace MyContacts
{
	public class GenderToIndexConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			Gender gender = (Gender)value;
			if (targetType != typeof(int))
				throw new Exception("GenderConverter.Convert expected integer targetType.");
			return (int)gender;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			int index = (int)value;
			if (targetType != typeof(Gender))
				throw new Exception("GenderConverter.ConvertBack expected Gender targetType");
			return (Gender)index;
		}
	}
}

