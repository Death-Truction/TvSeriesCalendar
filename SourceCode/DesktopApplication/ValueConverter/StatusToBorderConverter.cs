﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace TvSeriesCalendar.ValueConverter
{
    public class StatusToBorderConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string status = (string) values[0];
            DateTime? nextSeasonReleaseDate = (DateTime?) values[1];
            if (nextSeasonReleaseDate != null)
                return new SolidColorBrush(Colors.Green);
            if (status == "Returning Series")
                return new SolidColorBrush(Colors.Orange);
            if (status == "Ended" || status == "Canceled")
                return new SolidColorBrush(Colors.Red);
            return new SolidColorBrush(Colors.Purple);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}