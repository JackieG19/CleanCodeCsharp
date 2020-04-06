using System.Drawing

namespace CleanCode
{
  public class Example
  {
    public Bitmap Method1(string n);
    {
        var b = new Bitmap(n);
        var g = Graphics.FromImage(b);
        
        g.DrawString("a", SystemFonts.DefaultFont, SystemBrushes.Decktop, new PointF(0, 0));
        g.DrawString("b", SystemFonts.DefaultFont, SystemBrushes.Decktop, new PointF(0, 20));
        g.DrawString("c", SystemFonts.DefaultFont, SystemBrushes.Decktop, new PointF(0, 30));
        
        return b;
    }
  }
}
