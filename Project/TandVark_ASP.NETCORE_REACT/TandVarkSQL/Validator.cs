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
    class Validator 
    {// Work in progress! Herate Mich! å

        public ValidationResult Validate
      (String value)

        {
            
            {
                if (value == null)
                    return new ValidationResult(false, "value cannot be empty.");
                else
                {
                    if (value.ToString().Length < 5)
                        return new ValidationResult
                        (false, "Input cannot be less than 5 characters long.");
                }
                return ValidationResult.ValidResult;

                

            }
        }
    }
}
