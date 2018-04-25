using System.Collections.Generic;
using System.Drawing;

namespace Models
{
    public class Class
    {
        public Rectangle Rect { get; set; }
        public string Name { get; set; }
        public List <Method> ListOfMethods { get; set; }
        public List <Propertie> ListOfProperties { get; set; }
        public bool Selected { get; set; }

        public Class(Rectangle rect, string name)
        {
            Rect = rect;
            Name = name;
            ListOfMethods = new List <Method>();
            ListOfProperties = new List <Propertie>();
            Selected = false;
        }

        public void Draw(Graphics g)
        {
            if (Selected)
            {
                g.DrawRectangle(Pens.Blue, Rect);
            }
            else
            {
                g.DrawRectangle(Pens.Black, Rect);
            }

            g.FillRectangle(Brushes.LightSkyBlue, new Rectangle(Rect.X + 2, Rect.Y + 2, 118, 118));
            g.DrawString(Name, new Font(FontFamily.GenericSerif, 10, FontStyle.Bold), Brushes.CornflowerBlue, Rect.X + 15, Rect.Y + 8);
        }
    }
}