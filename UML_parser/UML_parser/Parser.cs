using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Models;

namespace UML_parser
{
    public partial class Parser : Form
    {
        public List<Class> ListOfClasses { get; set; }
        public List<Relationship> ListOfRelationships { get; set; }
        public Graphics G { get; set; }
        Relationship relation;
        Class rectClass;

        public Parser()
        {
            InitializeComponent();
            ListOfClasses = new List <Class>();
            ListOfRelationships = new List<Relationship>();
            G = pnlCenter.CreateGraphics();
        }

        public void PnlCenter_MouseClick(object sender, MouseEventArgs klik)
        {
            if (rdbClass.Checked)
            {
                if (txtClassName.Text != "")
                {
                    if (txtClassName.Text.Length >= 18)
                    {
                        MessageBox.Show("Uneli ste predugačak naziv klase, naziv može biti do 18 karaktera, pokušajte ponovo.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    foreach (Class cl in ListOfClasses)
                    {
                        if (cl.Rect.Contains(klik.X, klik.Y) || cl.Rect.Contains(klik.X - cl.Rect.Width / 2, klik.Y - cl.Rect.Height / 2) || cl.Rect.Contains(klik.X + cl.Rect.Width, klik.Y + cl.Rect.Height) || cl.Rect.Contains(klik.X + cl.Rect.Width, klik.Y - cl.Rect.Height) || cl.Rect.Contains(klik.X - cl.Rect.Width, klik.Y + cl.Rect.Height))
                        {
                            MessageBox.Show("Ne možete crtati klase jedne preko drugih.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (cl.Name == txtClassName.Text)
                        {
                            MessageBox.Show("Dve klase ne mogu imati isti naziv.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    rectClass = new Class(new Rectangle(klik.X - 60, klik.Y - 60, 120, 120), txtClassName.Text);

                    if (rectClass.Rect.X < pnlLeft.Width / 2 || rectClass.Rect.Y < pnlCenter.Location.Y)
                    {
                        MessageBox.Show("Klasa izlazi izvan granica panela.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    rectClass.Draw(G);
                    ListOfClasses.Add(rectClass);
                    txtClassName.Text = "";
                }
                else if (rdbNone.Checked)
                {
                    MessageBox.Show("Morate uneti naziv klase kako bi ste je nacrtali.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rdbSelectTool.Checked)
            {
                if (ListOfClasses.Count == 0)
                {
                    MessageBox.Show("Trenutno nema klasa za selekciju.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                G.Clear(pnlCenter.BackColor);

                foreach (Class cl in ListOfClasses)
                {
                    if (rdbAggregation.Checked)
                    {
                        if (cl.Selected)
                        {
                            foreach (Class cl1 in ListOfClasses)
                            {
                                if (cl1.Rect.Contains(klik.X, klik.Y))
                                {
                                    relation = new Relationship(cl, cl1, "aggregation");
                                    ListOfRelationships.Add(relation);
                                    relation.Draw(G);
                                }
                            }
                        }
                    }
                    else if (rdbAssociation.Checked)
                    {
                        if (cl.Selected)
                        {
                            foreach (Class cl1 in ListOfClasses)
                            {
                                if (cl1.Rect.Contains(klik.X, klik.Y))
                                {
                                    relation = new Relationship(cl, cl1, "association");
                                    ListOfRelationships.Add(relation);
                                    relation.Draw(G);
                                }
                            }
                        }
                    }
                    else if (rdbComposition.Checked)
                    {
                        if (cl.Selected)
                        {
                            foreach (Class cl1 in ListOfClasses)
                            {
                                if (cl1.Rect.Contains(klik.X, klik.Y))
                                {
                                    relation = new Relationship(cl, cl1, "composition");
                                    ListOfRelationships.Add(relation);
                                    relation.Draw(G);
                                }
                            }
                        }
                    }
                    else if (rdbGeneralization.Checked)
                    {
                        if (cl.Selected)
                        {
                            foreach (Class cl1 in ListOfClasses)
                            {
                                if (cl1.Rect.Contains(klik.X, klik.Y))
                                {
                                    relation = new Relationship(cl, cl1, "generalization");
                                    ListOfRelationships.Add(relation);
                                    relation.Draw(G);
                                }
                            }
                        }
                    }
                    else if (rdbRealization.Checked)
                    {
                        if (cl.Selected)
                        {
                            foreach (Class cl1 in ListOfClasses)
                            {
                                if (cl1.Rect.Contains(klik.X, klik.Y))
                                {
                                    relation = new Relationship(cl, cl1, "realization");
                                    ListOfRelationships.Add(relation);
                                    relation.Draw(G);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (cl.Rect.Contains(klik.X, klik.Y))
                        {
                            cl.Selected = true;

                            foreach (Relationship relation in ListOfRelationships)
                            {
                                if (relation.Selected)
                                {
                                    cl.Selected = false;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            cl.Selected = false;
                        }
                    }

                    cl.Draw(G);
                }

                foreach (Relationship relation in ListOfRelationships)
                {
                    if (Udaljenost(relation.LeftClass.Rect.X, relation.LeftClass.Rect.Y, klik.X, klik.Y) + Udaljenost(relation.RightClass.Rect.X, relation.RightClass.Rect.Y, klik.X, klik.Y) - Udaljenost(relation.RightClass.Rect.X, relation.RightClass.Rect.Y, relation.LeftClass.Rect.X, relation.LeftClass.Rect.Y) <= 1)
                    {
                        relation.Selected = true;

                        foreach (Class cl in ListOfClasses)
                        {
                            if (cl.Selected)
                            {
                                relation.Selected = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        relation.Selected = false;
                    }

                    relation.Draw(G);
                }
            }
            else
            {
                MessageBox.Show("Odaberite jednu od dve ponuđene opcije [Class/Select tool].", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public double Udaljenost(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        private void BtnAddProperty_Click(object sender, EventArgs e)
        {
            if (txtDataType.Text != "" && txtPropertieName.Text != "" && cbxPropertieAccessor.SelectedItem != null)
            {
                foreach (Class cl in ListOfClasses)
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
                foreach (Class cl in ListOfClasses)
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

        public void BtnClearScreen_Click(object sender, EventArgs e)
        {
            G.Clear(BackColor);
            ListOfClasses.Clear();
            ListOfRelationships.Clear();
        }

        public void CbShowObjectDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowObjectDetails.Checked)
            {
                foreach (Class cl in ListOfClasses)
                {
                    if (cl.Selected)
                    {
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

                        ClassName.Text = cl.Name;
                        pnlRelationshipDetails.Visible = false;
                        pnlClassDetails.Visible = true;
                        return;
                    }
                }

                foreach (Relationship relation in ListOfRelationships)
                {
                    if (relation.Selected)
                    {
                        if (relation.Name != "")
                        {
                            txtRelationshipName.Text = relation.Name;
                        }
                        if (relation.LeftMultiplicity != "")
                        {
                            cbxLeftMultiplicity.SelectedItem = relation.LeftMultiplicity;
                        }
                        if (relation.RightMultiplicity != "")
                        {
                            cbxRightMultiplicity.SelectedItem = relation.RightMultiplicity;
                        }

                        pnlClassDetails.Visible = false;
                        pnlRelationshipDetails.Visible = true;
                        return;
                    }
                }

                MessageBox.Show("Morate selektovati neki objekat kako bi videli njegove detalje.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (pnlClassDetails.Visible)
                {
                    listClassBehaviour.Clear();
                    listClassState.Clear();
                    txtPropertieName.Text = "";
                    txtMethod.Text = "";
                    txtDataType.Text = "";
                    pnlClassDetails.Visible = false;
                }
                else if (pnlRelationshipDetails.Visible)
                { 
                    if (txtRelationshipName.Text != "" || cbxLeftMultiplicity.SelectedItem != null || cbxRightMultiplicity.SelectedItem != null)
                    {
                        if (txtRelationshipName.Text == "" || cbxLeftMultiplicity.SelectedItem == null || cbxRightMultiplicity.SelectedItem == null)
                        {
                            MessageBox.Show("Morate uneti sva polja za datu vezu.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cbShowObjectDetails.Checked = true;
                            return;
                        }

                        foreach (Relationship relation in ListOfRelationships)
                        {
                            if (relation.Selected)
                            {
                                relation.Name = txtRelationshipName.Text;

                                if (relation.Type == "aggregation")
                                {
                                    if (cbxLeftMultiplicity.SelectedItem.ToString() != "0..1" && cbxRightMultiplicity.SelectedItem.ToString() != "0..1")
                                    {
                                        MessageBox.Show("Kod agregacije jedan od kardinaliteta mora biti 0..1, probajte ponovo da unesete vrednosti.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        cbShowObjectDetails.Checked = true;
                                        cbxLeftMultiplicity.SelectedItem = null;
                                        cbxRightMultiplicity.SelectedItem = null;
                                        return;
                                    }
                                }

                                if (relation.Type == "composition")
                                {
                                    if (cbxLeftMultiplicity.SelectedItem.ToString() != "1" && cbxRightMultiplicity.SelectedItem.ToString() != "1")
                                    {
                                        MessageBox.Show("Kod kompozicije jedan od kardinaliteta mora biti 1, probajte ponovo da unesete vrednosti.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        cbShowObjectDetails.Checked = true;
                                        cbxLeftMultiplicity.SelectedItem = null;
                                        cbxRightMultiplicity.SelectedItem = null;
                                        return;
                                    }
                                }

                                relation.LeftMultiplicity = cbxLeftMultiplicity.SelectedItem.ToString();
                                relation.RightMultiplicity = cbxRightMultiplicity.SelectedItem.ToString();
                            }
                        }

                        txtRelationshipName.Text = "";
                        cbxLeftMultiplicity.SelectedItem = null;
                        cbxRightMultiplicity.SelectedItem = null;
                    }

                    pnlRelationshipDetails.Visible = false;
                }
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
    }
}