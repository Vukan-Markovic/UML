using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Models;

namespace UML_parser
{
    public partial class UML_parser : Form
    {
        List <Class> listOfRectangles;
        bool flag;
        Graphics g;

        public UML_parser()
        {
            InitializeComponent();
            g = pnlCenter.CreateGraphics();
            listOfRectangles = new List<Class>();
        }

        private void PnlCenter_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbClass.Checked)
            {
                if (txtClassName.Text != "")
                {

                    foreach (Class rect in listOfRectangles)
                    {
                        if (rect.Rect.Contains(e.X, e.Y) || rect.Rect.Contains(e.X - rect.Rect.Width / 2, e.Y - rect.Rect.Height / 2) || rect.Rect.Contains(e.X + rect.Rect.Width, e.Y + rect.Rect.Height) || rect.Rect.Contains(e.X + rect.Rect.Width, e.Y - rect.Rect.Height) || rect.Rect.Contains(e.X - rect.Rect.Width, e.Y + rect.Rect.Height))
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (!flag)
                    {
                        Class rectClass = new Class(new Rectangle(e.X - 50, e.Y - 50, 120, 120), txtClassName.Text);
                        rectClass.Draw(g);
                        rectClass.Name = txtClassName.Text;
                        txtClassName.Text = "";
                        listOfRectangles.Add(rectClass);
                    }
                    else
                    {
                        MessageBox.Show("Ne možete crtati klase jedne preko drugih.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    flag = false;
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

                g.Clear(pnlCenter.BackColor);

                foreach (Class cl in listOfRectangles)
                {
                    if (!(cl.Rect.Contains(e.X, e.Y)))
                    {
                        cl.BorderColor = Pens.Black;
                        cl.Selektovana = false;
                        cl.Draw(g);
                    }
                }

                foreach (Class rect in listOfRectangles)
                {
                    if (rect.Rect.Contains(e.X, e.Y))
                    {
                        
                        rect.BorderColor = Pens.Blue;
                        rect.Draw(g);
                        rect.Selektovana = true;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Odaberite jednu od dve ponuđene opcije [Class/Select tool].", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CbxShowClassDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (((cbxShowClassDetails.Checked && rdbSelectTool.Checked) || (rdbSelectTool.Checked && cbxShowClassDetails.Checked)))
            {
                foreach (Class rect in listOfRectangles)
                {
                    if (rect.Selektovana)
                    {
                        ClassName.Text = rect.Name;
                        pnlRight.Visible = true;

                        if (rect.ListOfMethods.Count != 0)
                        {
                            foreach (Method m in rect.ListOfMethods)
                            {
                                listClassBehaviour.Items.Add(FormatMethod(m.Name, m.Accessor));
                            }
                        }

                        if (rect.ListOfProperties.Count != 0)
                        {
                            foreach (Propertie p in rect.ListOfProperties)
                            {
                                listClassState.Items.Add(FormatPropertie(p.Type, p.Name, p.Accessor));
                            }
                        }

                        return;
                    }
                }

                MessageBox.Show("Morate selektovati neku od klasa kako bi videli njene detalje.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
     
            else if(!cbxShowClassDetails.Checked)
            {
                listClassBehaviour.Clear();
                listClassState.Clear();
                txtPropertieName.Text = "";
                txtMethod.Text = "";
                txtDataType.Text = "";
                pnlRight.Visible = false;
            }
        }

        private void BtnAddProperty_Click(object sender, EventArgs e)
        {
            if (txtDataType.Text != "" && txtPropertieName.Text != "" && cbxPropertieAccessor.SelectedItem != null)
            {
                foreach (Class rect in listOfRectangles)
                {
                    if (rect.Selektovana)
                    {
                        rect.ListOfProperties.Add(new Propertie(cbxPropertieAccessor.SelectedItem.ToString(), txtPropertieName.Text, txtDataType.Text));
                        listClassState.Items.Add(FormatPropertie(txtDataType.Text, txtPropertieName.Text, cbxPropertieAccessor.SelectedItem));
                        break;
                    }
                }
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
                foreach (Class rect in listOfRectangles)
                {
                    if (rect.Selektovana)
                    {
                        rect.ListOfMethods.Add(new Method(cbxMethodAccessor.ToString(), txtMethod.Text));
                        listClassBehaviour.Items.Add(FormatMethod(txtMethod.Text, cbxMethodAccessor.SelectedItem));
                        break;
                    }
                }
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
                return "+" + className + ": " + type;
            }
            else if (accessor.ToString() == "protected")
            {
                return "#" + className + ": " + type;
            }
            else
            {
                return "-" + className + ": " + type;
            }
        }

        private string FormatMethod(string method, object accessor)
        {
            if (accessor.ToString() == "public")
            {
                return "+" + method + "()";
            }
            else if (accessor.ToString() == "protected")
            {
                return "#" + method + "()";
            }
            else
            {
                return "-" + method + "()";
            }
        }
    }
}