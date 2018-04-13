using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Models;

namespace UML_parser
{
    public partial class Parser : Form
    {
        List <Class> listOfClasses;
        bool flag, flag1;
        Graphics g;

        public Parser()
        {
            InitializeComponent();
            g = pnlCenter.CreateGraphics();
            listOfClasses = new List <Class> ();
        }

        private void PnlCenter_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbClass.Checked)
            {
                if (txtClassName.Text != "")
                {
                    foreach (Class cl in listOfClasses)
                    {
                        if (cl.Rect.Contains(e.X, e.Y) || cl.Rect.Contains(e.X - cl.Rect.Width / 2, e.Y - cl.Rect.Height / 2) || cl.Rect.Contains(e.X + cl.Rect.Width, e.Y + cl.Rect.Height) || cl.Rect.Contains(e.X + cl.Rect.Width, e.Y - cl.Rect.Height) || cl.Rect.Contains(e.X - cl.Rect.Width, e.Y + cl.Rect.Height))
                        {
                            flag = true;
                            break;
                        }
                    }

                    foreach (Class cl in listOfClasses)
                    {
                        if(cl.Name == txtClassName.Text)
                        {
                            flag1 = true;
                            break;
                        }
                    }

                    if (!flag)
                    {
                        if (!flag1)
                        {
                            Class rectClass = new Class(new Rectangle(e.X - 60, e.Y - 60, 120, 120), txtClassName.Text);
                            rectClass.Draw(g);
                            listOfClasses.Add(rectClass);
                            txtClassName.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Dve klase ne mogu imati isti naziv.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ne možete crtati klase jedne preko drugih.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    flag = false;
                    flag1 = false;
                }
                else
                {
                    MessageBox.Show("Morate uneti naziv klase kako bi ste je nacrtali.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(rdbSelectTool.Checked)
            {
                if(listOfClasses.Count == 0)
                {
                    MessageBox.Show("Trenutno nema klasa za selekciju.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                g.Clear(pnlCenter.BackColor);

                foreach (Class cl in listOfClasses)
                {
                    if (!(cl.Rect.Contains(e.X, e.Y)))
                    {
                        cl.BorderColor = Pens.Black;
                        cl.Selected = false;
                    }
                    else if(cl.Rect.Contains(e.X, e.Y))
                    {
                        cl.BorderColor = Pens.Blue;
                        cl.Selected = true;
                    }

                    cl.Draw(g);
                }
            }
            else
            {
                MessageBox.Show("Odaberite jednu od dve ponuđene opcije [Class/Select tool].", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAddProperty_Click(object sender, EventArgs e)
        {
            if (txtDataType.Text != "" && txtPropertieName.Text != "" && cbxPropertieAccessor.SelectedItem != null)
            {
                foreach (Class cl in listOfClasses)
                {
                    if (cl.Selected)
                    {
                        cl.ListOfProperties.Add(new Propertie(cbxPropertieAccessor.SelectedItem.ToString(), txtPropertieName.Text, txtDataType.Text));
                        listClassState.Items.Add(FormatPropertie(txtDataType.Text, txtPropertieName.Text, cbxPropertieAccessor.SelectedItem.ToString()));
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
                foreach (Class cl in listOfClasses)
                {
                    if (cl.Selected)
                    {
                        cl.ListOfMethods.Add(new Method(cbxMethodAccessor.ToString(), txtMethod.Text));
                        listClassBehaviour.Items.Add(FormatMethod(txtMethod.Text, cbxMethodAccessor.SelectedItem.ToString()));
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
            listOfClasses.Clear();
        }

        public string FormatPropertie(string type, string propertieName, string accessor)
        {
            if (accessor == "public")
            {
                return "+" + propertieName + ": " + type;
            }
            else if (accessor == "protected")
            {
                return "#" + propertieName + ": " + type;
            }
            else
            {
                return "-" + propertieName + ": " + type;
            }
        }

        private void CbShowClassDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSelectTool.Checked && cbShowClassDetails.Checked)
            {
                foreach (Class cl in listOfClasses)
                {
                    if (cl.Selected)
                    {
                        ClassName.Text = cl.Name;
                        pnlRight.Visible = true;

                        if (cl.ListOfMethods.Count != 0)
                        {
                            foreach (Method m in cl.ListOfMethods)
                            {
                                listClassBehaviour.Items.Add(FormatMethod(m.Name, m.Accessor));
                            }
                        }

                        if (cl.ListOfProperties.Count != 0)
                        {
                            foreach (Propertie p in cl.ListOfProperties)
                            {
                                listClassState.Items.Add(FormatPropertie(p.Type, p.Name, p.Accessor));
                            }
                        }

                        return;
                    }
                }

                MessageBox.Show("Morate selektovati neku od klasa kako bi videli njene detalje.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (!cbShowClassDetails.Checked)
            {
                listClassBehaviour.Clear();
                listClassState.Clear();
                txtPropertieName.Text = "";
                txtMethod.Text = "";
                txtDataType.Text = "";
                pnlRight.Visible = false;
            }
        }

        public string FormatMethod(string methodName, string accessor)
        {
            if (accessor == "public")
            {
                return "+" + methodName + "()";
            }
            else if (accessor == "protected")
            {
                return "#" + methodName + "()";
            }
            else
            {
                return "-" + methodName + "()";
            }
        }
    }
}