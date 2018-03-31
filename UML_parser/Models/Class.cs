using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Models
{
    public class Class
    {
        public Rectangle Rect { get; set; }
        public string Name { get; set; }
        public List<Method> ListOfMethods { get; set; }
        public List<Propertie> ListOfProperties { get; set; }
        public bool Selektovana { get; set; }
        public Pen BorderColor { get; set; }

        public Class(Rectangle rect, string name)
        {
            Rect = rect;
            Name = name;
            ListOfMethods = new List<Method>();
            ListOfProperties = new List<Propertie>();
            BorderColor = Pens.Black;
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(BorderColor , this.Rect);
            g.FillRectangle(Brushes.LightSkyBlue, new Rectangle(this.Rect.X + 2, this.Rect.Y + 2, 118, 118));
            g.DrawString(this.Name, new Font(FontFamily.GenericSerif, 10, FontStyle.Bold), Brushes.CornflowerBlue, this.Rect.X + 15, this.Rect.Y + 8);
        }
    }
}