using System.IO;
using System;
using Avalonia.Media.Imaging;
using Avalonia.Controls;

namespace Logic;

public class ImageHandler()
{
    private static string projectRoot = Directory.GetParent( AppDomain.CurrentDomain.BaseDirectory ).Parent.Parent.Parent.FullName;
    private static string imageFolderPath = Path.Combine( projectRoot, "Content" );

    public static Image GetImageControl(string imageName)
    {
        string imageFilePath = Path.Combine( imageFolderPath, imageName, ".png" );
        return new Image ()
        {
            Source = new Bitmap ( imageFilePath )//,
            //Height,
            //Width
        };
    }

    /*
    public static Image GetImageControl ( int imageId )
    {
        // string path = await Data.GetImagePath(id)
        string imageFilePath = Path.Combine( imageFolderPath, imagePath );
        return new Image ()
        {
            Source = new Bitmap ( imageFilePath )
        };
    }
    */

}