using System;
namespace EssentialTraining
{
    public class FlowControl
    {
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
