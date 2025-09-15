using System.ComponentModel.DataAnnotations;

namespace MetricSystemApp.Models
{
    public class TempModel
    {
        [Required(ErrorMessage = "Please enter a Fahrenheit value.")]
        [Range(32, 212, ErrorMessage = "Fahrenheit value must be between 32 and 212.")]
        public double? FahrenheitValue { get; set; }

        public double? ConvertToCelsius { get; set; }

        public double? Celsius
        {
            get
            {
                if (FahrenheitValue.HasValue)
                    return (FahrenheitValue.Value - 32) * 5 / 9;
                return null;
            }
        }
    }
}
