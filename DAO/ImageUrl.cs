

using System.Collections.Generic;

namespace DAO
{
    public static class ImageUrl
    {      
        public static string getFirstImageUrl(string imageURL)
        {
            string result = "";           
               
                string[] images = imageURL.Split(' ');
                if(images != null)
                {
                    result = images[0];
                }
            
            return result;
        }

        public static List<string> getImageUrl(string url)
        {
            List<string> str = new List<string>();
            string[] images = url.Split(' ');
            foreach (var item in images)
            {
                str.Add(item);
            }            

            return str;
        }
    }
}
