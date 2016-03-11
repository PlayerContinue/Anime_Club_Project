using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Anime_Club_Files.Convertors
{
    /**
    A converter class which will convert a given paramter by the values provided
    */
    public class ConverterClass : IValueConverter
    {
        /**
        Converts a set value by a set of parameters passed in
            @param value - The value passed by the system
            @param targetType - The type of the object which this value has been bound to
            @param parameter - List of math functions and numbers to performed them on. I.e. /;2;/;x is divide the value by 2 then divide it by the initial value of x

            */
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            String[] string_list = ((string)parameter).Split(';');

            double x = System.Convert.ToDouble(value);
            double initial = x;
            double y;
            for (int i = 0; i < string_list.Length; i += 2)
            {
                if (((string)string_list[i + 1])== "x"){
                    y = initial;
                }
                else
                {
                    y = double.Parse((string)string_list[i + 1]);
                }
                
                switch (string_list[i])
                {
                    case "+":
                        x += y;
                        break;

                    case "-":
                        x -= y;
                        break;
                    case "*":
                        x *= y;
                        break;
                    case "/":
                        x /= y;
                        break;
                    case "Multiply":
                        x *= y;
                        break;
                    case "Add":
                        x += y;
                        break;
                    case "Divide":
                        x /= y;
                        break;
                    case "Subtract":
                        x -= y;
                        break;
                    default: throw new Exception("invalid logic");
                }
            }
            return x;

            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /**
   A converter class which will convert a given paramter by the values provided
   */
    public class ChangeOnNumberOfItems : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            String[] string_list = ((string)parameter).Split(';');

            double x = (Int32)value;
            double y;
            for (int i = 0; i < string_list.Length; i += 2)
            {
                y = double.Parse((string)string_list[i + 1]);
                switch (string_list[i])
                {
                    case "+":
                        x += y;
                        break;

                    case "-":
                        x -= y;
                        break;
                    case "*":
                        x *= y;
                        break;
                    case "/":
                        x /= y;
                        break;
                    case "Multiply":
                        x *= y;
                        break;
                    case "Add":
                        x += y;
                        break;
                    case "Divide":
                        x /= y;
                        break;
                    case "Subtract":
                        x -= y;
                        break;
                    default: throw new Exception("invalid logic");
                }
            }
            return x;

            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
