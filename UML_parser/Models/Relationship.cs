using System.Drawing;

namespace Models
{
    public class Relationship
    {
        public string Name { get; set; }
        public string LeftMultiplicity { get; set; }
        public string RightMultiplicity { get; set; }
        public string Type { get; set; }
        public bool Selected { get; set; }
        public Class LeftClass { get; set; }
        public Class RightClass { get; set; }

        public Relationship(Class leftClass, Class rightClass, string type)
        {
            LeftClass = leftClass;
            RightClass = rightClass;
            Type = type;
            Selected = false;
        }

        public void Draw(Graphics g)
        {
            if (Selected)
            {
                g.DrawLine(Pens.Blue, LeftClass.Rect.X, LeftClass.Rect.Y, RightClass.Rect.X, RightClass.Rect.Y);
            }
            else
            {
                g.DrawLine(Pens.Black, LeftClass.Rect.X, LeftClass.Rect.Y, RightClass.Rect.X, RightClass.Rect.Y);
            }

            g.DrawString(Type, new Font(FontFamily.GenericSerif, 10, FontStyle.Bold), Brushes.Black, LeftClass.Rect.X + LeftClass.Rect.Width / 4, LeftClass.Rect.Y + LeftClass.Rect.Height / 2);

            if (LeftMultiplicity != "" && RightMultiplicity != "")
            {
                g.DrawString(LeftMultiplicity, new Font(FontFamily.GenericSerif, 10, FontStyle.Bold), Brushes.Black, LeftClass.Rect.X, LeftClass.Rect.Y);
                g.DrawString(RightMultiplicity, new Font(FontFamily.GenericSerif, 10, FontStyle.Bold), Brushes.Black, RightClass.Rect.X, RightClass.Rect.Y);
            }
        }

    }
}