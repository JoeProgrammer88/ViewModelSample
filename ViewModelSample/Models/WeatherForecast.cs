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

    public Direction WindDirection { get; set; }

    public enum Direction
    {
        North, South, WestSouthWest
    }
    
    switch (direction) 
    {
        case int i when i >=<= 11.25:
            return "N";
            break;
        case <= 33.75:
            return "NNE";
            break;
        case <= 56.25:
            return "NE";
            break;
        case <= 78.25:
            return "ENE";
            break;
        case <= 101.25:
            return "E";
            break;
        case <= 123.75:
            return "ESE";
            break;
        case <= 146.25:
            return "SE";
            break;
        case <= 168.75:
            return "SSE";
            break;
        case <= 191.25:
            return "S";
            break;
        case <= 213.75:
            return "SSW";
            break;
        case <= 236.25:
            return "SW";
            break;
        case <= 258.75:
            return "WSW";
            break;
        case <= 281.25:
            return "W";
            break;
        case <= 303.75:
            return "WNW";
            break;
        case <= 326.25:
            return "NW";
            break;
        case <= 348.75:
            return "NNW";
            break;
        case <= 360:
            return "N";
            break;
        default:
            Console.WriteLine("Not a compass heading");
            break;
    }
}