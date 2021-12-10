using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iut_dbm_lw4
{
    internal partial class Form2 : Form
    {
        public Route Route { get; set; }
        public Form1 form1;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Route Route, Form1 form1)
        {
            this.Route = Route;
            this.form1 = form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxCarrier.DataSource = new BindingSource(Carrier.GetCachedLikeDict(), null);
            comboBoxCarrier.DisplayMember = "Value";
            comboBoxCarrier.ValueMember = "Key";

            comboBoxHotel.DataSource = new BindingSource(Hotel.GetCachedLikeDict(), null);
            comboBoxHotel.DisplayMember = "Value";
            comboBoxHotel.ValueMember = "Key";

            if (Route != null)
            {
                this.Text = String.Format("Route editor for {0} {1} {2}", Route.RepSurname, Route.RepName, Route.RepPhone);
                textBoxRepSurname.Text = Route.RepSurname;
                textBoxRepName.Text = Route.RepName;
                textBoxRepPhone.Text = Route.RepPhone;
                textBoxTitle.Text = Route.Title;
                textBoxCountry.Text = Route.Country;
                textBoxCity.Text = Route.City;
                numericUpDownDuration.Value = Convert.ToInt32(Route.Duration);
                if (Route.Carrier != null)
                {
                    comboBoxCarrier.SelectedIndex = comboBoxCarrier.FindString(Route.Carrier.Title);
                }
                if (Route.Hotel != null)
                {
                    comboBoxHotel.SelectedIndex = comboBoxHotel.FindString(Route.Hotel.Title);
                }
            } else
            {
                this.Text = "Route editor for new route";
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Show();
            form1.UpdateAll();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Route != null)
            {
                Route.RepSurname = textBoxRepSurname.Text;
                Route.RepName = textBoxRepName.Text;
                Route.RepPhone = textBoxRepPhone.Text;
                Route.Title = textBoxTitle.Text;
                Route.Country = textBoxCountry.Text;
                Route.City = textBoxCity.Text;
                Route.Duration = (int)Convert.ToDouble(numericUpDownDuration.Value);
                Route.Carrier = Carrier.GetById<Carrier>(Convert.ToInt32(comboBoxCarrier.SelectedValue));
                Route.Hotel = Hotel.GetById<Hotel>(Convert.ToInt32(comboBoxHotel.SelectedValue));
                Route.Update();
            } else
            {
                Route.Create(textBoxTitle.Text, textBoxCountry.Text, textBoxCity.Text, Hotel.GetById<Hotel>(Convert.ToInt32(comboBoxHotel.SelectedValue)), Carrier.GetById<Carrier>(Convert.ToInt32(comboBoxCarrier.SelectedValue)), textBoxRepSurname.Text, textBoxRepName.Text, textBoxRepPhone.Text, (int)Convert.ToDouble(numericUpDownDuration.Value));
            }
            this.Close();
        }
    }
}
