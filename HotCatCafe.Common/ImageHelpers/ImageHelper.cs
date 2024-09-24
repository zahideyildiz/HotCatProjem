namespace HotCatCafe.Common.ImageHelpers
{
    public static class ImageHelper
    {
        //Instance almadan doğrudan yakalayalım diye static olacak 

        public static string Upload(string imageName)
        {
            //png, jpg, jpeg, gif, bmp

            string newImageName = "";

            string uniqueName = Guid.NewGuid().ToString();

            var fileArray = imageName.Split('.');

            var extension = fileArray[fileArray.Length - 1]; //görselin uzantısını temsil eder.

            if(extension == "png" ||  extension == "jpg" || extension == "jpeg" || extension == "gif" || extension == "bmp")
            {
                newImageName = uniqueName + "." + extension;
                return newImageName;
            }
            else
            {
                return "0";
            }

            
        }

    }
}
