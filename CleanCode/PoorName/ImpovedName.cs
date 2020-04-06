using System.Drawing

namespace CleanCode
{
  public class Example
  {
    public Bitmap GenerateImage(string path);
    {   
        var bitmap = new Bitmap(path);
        var graphics = Graphics.FromImage(bitmap);
        
        graphics.DrawString("a", SystemFonts.DefaultFont, SystemBrushes.Decktop, new PointF(0, 0));
        graphics.DrawString("b", SystemFonts.DefaultFont, SystemBrushes.Decktop, new PointF(0, 20));
        graphics.DrawString("c", SystemFonts.DefaultFont, SystemBrushes.Decktop, new PointF(0, 30));
        
        return bitmap;
    }
  }
}
