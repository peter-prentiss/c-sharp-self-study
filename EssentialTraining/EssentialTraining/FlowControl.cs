using System;
namespace EssentialTraining
{
    public class FlowControl
    {
        public string IsYourNameNotBruce(string yourName)
        {
            if(yourName.ToLower() != "Bruce")
            {
                return "Can we call you Bruce for the simplicity?";
            }
            else
            {
                return "G'day Bruce!";
            }
        }

        public string GradeLetter(int score)
        {
            if (score > 90)
            {
                return "A";
            }
            else if (score > 79 && score <= 90)
            {
                return "B";
            }
            else if (score > 69 && score <= 79)
            {
                return "C";
            }
            else if (score > 59 && score <= 69)
            {
                return "D";
            }
            else
            {
                return "F";    
            }
        }

        public string PrimaryOrSecondaryCompound(string color)
        {
            if (color.ToLower() == "red" || color.ToLower() == "yellow" || color.ToLower() == "blue")
            {
                return "Primary";
            }
            else 
            {
                return "Secondary";
            }
        }

        public string SecondaryOrPrimary(string color)
        {
            var result = "";
            switch (color.ToLower())
            {
                case "red":
                    result = "Primary";
                    break;
                case "yellow":
                    result = "Primary";
                    break;
                case "blue":
                    result = "Primary";
                    break;
                default:
                    result = "Secondary";
                    break;
            }

            return result;
        }

        public string PrimaryOrSecondary(string color)
        {
            var result = "";
            if (color.ToLower() == "red")
            {
                result = "Primary";
            }
            else if (color.ToLower() =="blue")
            {
                result = "Primary";
            }
            else if (color.ToLower() == "yellow")
            {
                result = "Primary";
            }
            else
            {
                result = "Secondary";
            }

            return result;
        }

        public bool IsYourFavoriteColorYellow(string color)
        {
            return color.ToLower() == "yellow";
        }

        public bool IsYourFavoriteColorGreen(string color)
        {
            return (color.ToLower() == "green") ? true : false;
        }

        public bool IsYourFavoriteColorRed(string color)
        {
            if (color.ToLower() == "red") return true;
            return false;
        }

        public bool IsYourFavoriteColorBlue(string color) {
            if (color.ToLower() == "blue")
            {
                return true;
            }
            else{
                return false;
            }
        }
    }
}
