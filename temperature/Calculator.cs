using System;

namespace temperature {
    public class TempCalculator {

        #region สูตรการแปลงอุณหภูมิ
        // °F = (1.8 × °C) + 32
        // °F = °K × 1.8 − 459.67
        // °C = °K - 273.15
        // °C = (°F - 32) x 5/9
        // °K = °C + 273.15          
        // °K = (°F + 459.67) / (1.8)           
        #endregion

        /// <summary>
        /// เปลี่ยนค่า องศา Fahrenheit ให้เป็น Celsius
        /// °C = (°F - 32) x 5/9
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns></returns>
        public double ConvertFahrenheitToCelsius (double fahrenheit) {
            double FCel = (fahrenheit - 32) * 5/9 ;
            return FCel;
        }
        /// <summary>
        /// เปลี่ยนค่า องศา Kelvin ให้เป็น Celsius
        ///  °C = °K - 273.15
        /// </summary>
        /// <param name="kelvin"></param>
        /// <returns></returns>
        public double ConvertKelvinToCelsius (double kelvin) {
            double KCel = kelvin - 273.15 ;
            return KCel;
        }

        /// <summary>
        /// เปลี่ยนค่า องศา celsius ให้เป็น Fahrenheit
        /// °F = (1.8 × °C) + 32
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public double ConvertCelsiusToFahrenheit (double celsius) {
            double CFah = (1.8*celsius) + 32 ;
            return CFah;
        }
        /// <summary>
        /// เปลี่ยนค่า องศา Kelvin ให้เป็น Fahrenheit
        /// °F = °K × 1.8 − 459.67
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <returns></returns>
        public double ConvertKelvinToFahrenheit (double kelvin) {
            double KFah = (kelvin*1.8) - 459.67 ;
            return KFah;
        }
        /// <summary>
        /// เปลี่ยนค่า องศา Fahrenheit ให้เป็น Kelvin
        /// °K = (°F + 459.67) / (1.8)      
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns></returns>
        public double ConvertFahrenheitToKelvin (double fahrenheit) {
            double FKel = (fahrenheit + 459.67) / (1.8) ;
            return FKel;
        }
        /// <summary>
        /// เปลี่ยนค่า องศา celsius ให้เป็น Kelvin
        /// °K = °C + 273.15    
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public double ConvertCelsiusToKelvin (double celsius) {
            double CKel = celsius + 273.15 ;
            return CKel;
        }

    }
}