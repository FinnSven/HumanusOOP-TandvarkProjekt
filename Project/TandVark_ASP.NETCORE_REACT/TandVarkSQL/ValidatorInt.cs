using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TandVarkSQL
{
    public class ValidatorInt

    {
        public ValidationResult Validate(string value)
        {
            {
                int myInt;
                if (int.TryParse(value, out myInt)) //if user input is a number then
                {
                    return ValidationResult.ValidResult;
                }
                else
                {
                    value = null;
                }

                return new ValidationResult(false, "number cannot be left empty.");
            }
        }
    }
}




