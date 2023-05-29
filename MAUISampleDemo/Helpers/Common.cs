using Microsoft.Maui.Graphics;
using System.Text.RegularExpressions;

namespace MAUISampleDemo.Helpers
{
    public class Common
    {
        public static bool ValidateEmail(string value)
        {
            Regex emailRegExp = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
            bool isEmail = emailRegExp.IsMatch(value);
            return isEmail;
        }

        public static bool ValidatePassword(string value)
        {
            Regex passwordRegExp = new Regex("((?=.*\\d)(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{8,16})");
            bool isPassword = passwordRegExp.IsMatch(value);
            return isPassword;
        }

        public static List<Color> _randomColorList = new List<Color>()
        {
            Colors.Orange,
            Colors.Yellow,
            Colors.Green,
            Colors.Blue,
            Colors.LightGray,
        };

        public static Color GetRandomColor()
        {
            return _randomColorList[new Random().Next(_randomColorList.Count())];
        }
    }
}
