using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Project2_UniInt
{
    public partial class fMain : Form
    {
        Structure Structure1, Structure2;

        public fMain()
        {
            InitializeComponent();
        }
        //
        // Định nghĩa các Lớp
        //
        //
        [XmlRoot(ElementName = "state")]
        public class State
        {
            [XmlElement(ElementName = "x")]
            public string X { get; set; }
            [XmlElement(ElementName = "y")]
            public string Y { get; set; }
            [XmlElement(ElementName = "initial")]
            public string Initial { get; set; }
            [XmlAttribute(AttributeName = "id")]
            public string Id { get; set; }
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
            [XmlElement(ElementName = "final")]
            public string Final { get; set; }
        }

        [XmlRoot(ElementName = "transition")]
        public class Transition
        {
            [XmlElement(ElementName = "from")]
            public string From { get; set; }
            [XmlElement(ElementName = "to")]
            public string To { get; set; }
            [XmlElement(ElementName = "read")]
            public string Read { get; set; }
        }

        [XmlRoot(ElementName = "automaton")]
        public class Automaton
        {
            [XmlElement(ElementName = "state")]
            public List<State> ListState { get; set; }
            [XmlElement(ElementName = "transition")]
            public List<Transition> ListTransition { get; set; }
        }

        [XmlRoot(ElementName = "structure")]
        public class Structure
        {
            [XmlElement(ElementName = "type")]
            public string Type { get; set; }
            [XmlElement(ElementName = "automaton")]
            public Automaton Automaton { get; set; }
        }
        //
        // HÀM Chuyển nội dung tệp XML thành các Lớp
        //
        Structure ConvertXMLtoClass(string LinkXML)
        {
            Structure struc = new Structure();
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Structure));
                using (TextReader reader = new StringReader(File.ReadAllText(LinkXML)))
                {
                    struc = (Structure)serializer.Deserialize(reader);
                }
                return struc;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //
        // Lấy các thông tin của tệp Jff
        //
        Structure GetInfoFileJff(string link, TextBox txbLink, TextBox txbPreview)
        {
            Structure Struc = new Structure();
            txbPreview.Text = null;

            if (File.Exists(link))
            {
                FileInfo fi = new FileInfo(link);
                if (fi.Exists && fi.Extension == ".jff")
                {
                    Struc = ConvertXMLtoClass(link); //Chuyển nội dung tệp XML thành Lớp Structure
                    if (Struc != null)
                    {
                        string content = null;
                        FileStream fs = new FileStream(link, FileMode.Open, FileAccess.Read);
                        StreamReader sr = new StreamReader(fs);
                        content = sr.ReadToEnd();
                        sr.Close();
                        fs.Close();

                        txbLink.Text = link;
                        txbPreview.Text = content;

                        return Struc;
                    }
                    else return null;
                }
                else return null;
            }
            else return null;
        }
        private void btnBrowser1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JFLAP files (*.jff)|*.jff";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Structure1 = GetInfoFileJff(ofd.FileName, txbLink1, txbPreview1);
            }
        }
        private void btnBrowser2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JFLAP files (*.jff)|*.jff";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Structure2 = GetInfoFileJff(ofd.FileName, txbLink2, txbPreview2);
            }
        }
        private void txbLink1_TextChanged(object sender, EventArgs e)
        {
            Structure1 = GetInfoFileJff(txbLink1.Text, txbLink1, txbPreview1);
        }
        private void txbLink2_TextChanged(object sender, EventArgs e)
        {
            Structure2 = GetInfoFileJff(txbLink2.Text, txbLink2, txbPreview2);
        }
        //
        // HÀM GỘP
        //
        public class CoupleState
        {
            public State State1 { get; set; }
            public State State2 { get; set; }
            public string Id { get; set; }
        }
        Structure NewStructure(Structure Str1, Structure Str2, int flag) // flag = 0 = "UNI" ; flag = 1 = "INT";
        {
            if (Str1 != null || Str2 != null)
            {
                Structure Struc = new Structure();
                Struc.Type = "fa";
                Struc.Automaton = new Automaton();

                int id = 0;
                List<CoupleState> ListCpState = new List<CoupleState>();

                foreach (State st1 in Str1.Automaton.ListState)
                {
                    foreach (State st2 in Str2.Automaton.ListState)
                    {
                        CoupleState cp = new CoupleState();
                        cp.State1 = st1;
                        cp.State2 = st2;
                        cp.Id = id.ToString();
                        id++;

                        ListCpState.Add(cp);
                    }
                }

                List<Transition> ListTran = new List<Transition>();

                foreach (CoupleState cpt in ListCpState)
                {
                    foreach (Transition tran1 in Str1.Automaton.ListTransition)
                    {
                        foreach (Transition tran2 in Str2.Automaton.ListTransition)
                        {
                            if (tran1.From == cpt.State1.Id && tran2.From == cpt.State2.Id && tran1.Read == tran2.Read)
                            {
                                Transition tran = new Transition();

                                tran.Read = tran1.Read;
                                tran.From = cpt.Id;

                                string To = null;

                                foreach (CoupleState cpt2 in ListCpState)
                                {
                                    if (tran1.To == cpt2.State1.Id
                                     && tran2.To == cpt2.State2.Id)
                                    {
                                        To = cpt2.Id;
                                        break;
                                    }
                                }

                                tran.To = To;
                                ListTran.Add(tran);
                            }
                        }
                    }
                }
                List<State> ListSt = new List<State>();
                int X = 20;
                int Y = 20;
                foreach (CoupleState cpt in ListCpState)
                {
                    State st = new State();
                    st.Id = cpt.Id;
                    st.Name = cpt.State1.Name + "," + cpt.State2.Name;

                    X += 100;
                    Y += 50;

                    st.X = X.ToString();
                    st.Y = (Y % 100).ToString();

                    if (cpt.State1.Initial != null &&
                        cpt.State2.Initial != null)
                    {
                        st.Initial = "";
                    }

                    if (flag == 0)
                    {
                        if (cpt.State1.Final != null ||
                          cpt.State2.Final != null)
                        {
                            st.Final = "";
                        }
                    }

                    if (flag == 1)
                    {
                        if (cpt.State1.Final != null &&
                          cpt.State2.Final != null)
                        {
                            st.Final = "";
                        }
                    }

                    ListSt.Add(st);
                }

                Struc.Automaton.ListState = ListSt;
                Struc.Automaton.ListTransition = ListTran;

                return Struc;
            }
            else return null;
        }
        //
        // Serialize thành định dạng XML
        //
        void SerializeToXML(object Obj, string Link)
        {
            FileStream fs = new FileStream(Link, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(Structure));
            sr.Serialize(fs, Obj);
            fs.Close();
        }
        //
        // SaveFile
        //
        void SaveFile(Structure Struc)
        {  
            if (Struc != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "JFLAP files (*.jff)|*.jff";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    {
                        SerializeToXML(Struc, sfd.FileName);
                        string content = null;
                        FileStream fs = new FileStream(sfd.FileName, FileMode.Open, FileAccess.Read);
                        StreamReader sr = new StreamReader(fs);
                        content = sr.ReadToEnd();
                        sr.Close();
                        fs.Close();

                        txbResult.Text = content;
                    }
                }
            }
            else MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //
        // Click UNION
        //
        private void btnUnion_Click(object sender, EventArgs e)
        {
            Structure Struc = NewStructure(Structure1, Structure2, 0); // flag = 0 = "UNION" 
            SaveFile(Struc);
        }
        //
        // Click INTERSECTION
        //
        private void btnInt_Click(object sender, EventArgs e)
        {
            Structure Struc = NewStructure(Structure1, Structure2, 1); // flag = 1 = "INTERSECTION";
            SaveFile(Struc);
        }
        //
        //
        //
        private void btnClear_Click(object sender, EventArgs e)
        {
            txbResult.Text = null;
        }
    }
}
