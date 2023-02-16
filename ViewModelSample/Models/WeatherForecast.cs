using System.ComponentModel.DataAnnotations;

namespace ViewModelSample.Models
{
    /// <summary>
    /// Weather for a single day
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Chance of precipitation, between 0 and 1
        /// </summary>
        [Range(0, 1)]
        public double PrecipitationChance { get; set; }

        /// <summary>
        /// Date of the forecast
        /// </summary>
        public DateOnly Date { get; set; }

        /// <summary>
        /// Average temperature in Fahrenheit 
        /// </summary>
        public double AverageTemperature { get; set; }

        /// <summary>
        /// Name of the location ex. City, State
        /// </summary>
        public string Location { get; set; } = null!;

        /// <summary>
        /// Low temperature in Fahrenheit
        /// </summary>
        public double LowTemperature { get; set; }

        /// <summary>
        /// High temperature in Fahrenheit
        /// </summary>
        public double HighTemperature { get; set; }

        /// <summary>
        /// Humidity percentage between 0 and 1
        /// </summary>
        [Range(0, 1)]
        public double Humidity { get; set; }

        /// <summary>
        /// The wind speed in miles per hour
        /// </summary>
        public double WindSpeed { get; set; }

        /// <summary>
        /// Converts a temperature in Fahrenheit to a temperature in Celsius
        /// </summary>
        /// <param name="temperature">The temperature in Fahrenheit to be converted</param>
        /// <returns>A temperature in Celsius</returns>
        public static double ConvertFahrenheitToCelsius(double temperature)
        {
            return (temperature - 32) * (5 / 9);
        }

        /// <summary>
        /// Converts a temperature in Celsius to a temperature in Fahrenheit
        /// </summary>
        /// <param name="temperature">The temperature in Celsius to be converted</param>
        /// <returns>A temperature in Fahrenheit</returns>
        public static double ConvertCelsiusToFahrenheit(double temperature) 
        {
            return (temperature * (9/5)) + 32;
        }

        /// <summary>
        /// Converts a speed from meters per second to miles per hour
        /// </summary>
        /// <param name="speed">Speed in meters per second</param>
        /// <returns>Speed in miles per hour</returns>
        public static double MetersPerSecondToMilesPerHour(double speed)
        {
            return speed * 2.23694;
        }
    }
}

public class WindSpeed
{
    public double Speed { get; set; }

    public double WindDirection { get; set; }

    public enum Direction
    {
        North, South, WestSouthWest
    }

    

    public string WindDirectionLetters(double WindDirection)
    {
		switch (WindDirection)
        {
            case double i when i >= 0 && i <= 11.25:
                return "N";
            case double i when i > 11.25 && i <= 33.75:
                return "NNE";
            case double i when i > 33.75 && i <= 56.25:
				return "NE";
            case double i when i > 56.25 && i <= 78.25:
				return "ENE";
            case double i when i > 78.25 && i <= 101.25:
				return "E";
            case double i when i > 101.25 && i <= 123.75:
				return "ESE";
            case double i when i > 123.75 && i <= 146.25:
				return "SE";
            case double i when i > 146.25 && i <= 168.75:
				return "SSE";
            case double i when i > 168.75 && i <= 191.25:
				return "S";
            case double i when i > 191.25 && i <= 213.75:
				return "SSW";
            case double i when i > 213.75 && i <= 236.25:
				return "SW";
            case double i when i > 236.25 && i <= 258.75:
				return "WSW";
            case double i when i > 258.75 && i <= 281.25:
				return "W";
            case double i when i > 281.25 && i <= 303.75:
				return "WNW";
            case double i when i > 303.75 && i <= 326.25:
				return "NW";
            case double i when i > 326.25 && i <= 348.75:
				return "NNW";
            case double i when i > 348.75 && i <= 360:
                return "N";
            default:
                Console.WriteLine("Not a compass heading");
				return "N/A";
		}
    }
}