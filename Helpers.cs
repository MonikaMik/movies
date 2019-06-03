using System;
namespace MoviePage
{
    public static class Helpers
    {
        public static string GetColor(double rating)
        {
            string color;
            if (rating >= 9) 
            {
                color = "rgb(50,205,50);";
            }else if (rating >= 8 && rating < 9) {
                color = "rgba(50,205,50,0.3);";
            }else if (rating >= 7 && rating < 8) {
                color = "rgba(50,205,50,0.1);";
            }else if (rating >= 6 && rating < 7) {
                color = "rgba(50,205,50,0.05);";
            }else if (rating >= 5 && rating < 6) {
                color = "rgba(255,228,181,0.1);";
            }else if (rating >= 4 && rating < 5) {
                color = "rgba(255,228,181,0.1);";
            }else if (rating < 4 && rating > 0) {
                color = "rgba(220,20,60,0.1);";
            }else {
                color = "none";
            }
            return color;
        }
    }
}
