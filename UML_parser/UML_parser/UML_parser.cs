using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace UML_parser
{
    public partial class UML_parser : Form
    {
        Graphics g;
        Rectangle rectClass;
        List<Rectangle> listOfRectangles;
        bool flag1, flag2;

        public UML_parser()
        {
            InitializeComponent();
            g = pnlCenter.CreateGraphics();
            listOfRectangles = new List<Rectangle>();
        }

        private void PnlCenter_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbClass.Checked)
            {
                if (txtClassName.Text != "")
                {
                    rectClass = new Rectangle(e.X, e.Y, 100, 100);
                    PaintClass(rectClass);
                }
                else
                {
                    MessageBox.Show("Morate uneti naziv klase kako bi ste je nacrtali.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(rdbSelectTool.Checked)
            {
                if(listOfRectangles.Count == 0)
                {
                    MessageBox.Show("Trenutno nema klasa za selekciju.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach(Rectangle rect in listOfRectangles)
                {
                    if(rect.Contains(e.X, e.Y))
                    {
                        g.DrawRectangle(Pens.Blue, new Rectangle(rect.X, rect.Y, 100, 100));
                        flag1 = true;
                        flag2 = true;
                        break;
                    }
                }
                if(!flag2)
                {
                    MessageBox.Show("Treba da selektujete klasu.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                flag2 = false;
            }
            else
            {
                MessageBox.Show("Odaberite jednu od dve ponuđene opcije [Class/Select tool].", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PaintClass(Rectangle rect)
        {
            listOfRectangles.Add(rect);
            g.DrawRectangle(Pens.Gray, rectClass);
            g.FillRectangle(Brushes.LightGray, rectClass);
            g.DrawString(txtClassName.Text, this.Font, Brushes.Black, rectClass.X + 30, rectClass.Y + 10);   
        }

        private void CbxShowClassDetails_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Rectangle rect in listOfRectangles)
            {

            }

            if ((cbxShowClassDetails.Checked == true && rdbSelectTool.Checked == true || rdbSelectTool.Checked == true && cbxShowClassDetails.Checked) && flag1)
            {
                pnlRight.Visible = true;
                flag1 = false;
            }
            else
                pnlRight.Visible = false;
        }

        private void BtnAddProperty_Click(object sender, EventArgs e)
        {
            if (txtDataType.Text != "" && txtClassName.Text != "" && cbxPropertieAccessor.SelectedItem != null)
            {
                listClassState.Items.Add(FormatPropertie(txtDataType.Text, txtPropertieName.Text, cbxPropertieAccessor.SelectedItem));
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja kako bi dodali novi properti za ovu klasu.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAddMethod_Click(object sender, EventArgs e)
        {
            if (txtMethod.Text != "" && cbxMethodAccessor.SelectedItem != null)
            {
                listClassBehaviour.Items.Add(FormatMethod(txtMethod.Text, cbxMethodAccessor.SelectedItem));
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja kako bi dodali novu metodu za ovu klasu.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClearScreen_Click(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
        }

        private string FormatPropertie(string type, string className, object accessor)
        {
            if (accessor.ToString() == "public")
            {
                return "+ " + className + ": " + type;
            }
            else if (accessor.ToString() == "protected")
            {
                return "# " + className + ": " + type; ;
            }
            else
            {
                return "- " + className + ": " + type;
            }
        }

        private string FormatMethod(string method, object accessor)
        {
            if (accessor.ToString() == "public")
            {
                return "+ " + method + "() ";
            }
            else if (accessor.ToString() == "protected")
            {
                return "# " + method + "() ";
            }
            else
            {
                return "- " + method + "() ";
            }
        }
    }
}
