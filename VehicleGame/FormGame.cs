using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleGame
{
    public partial class FormGame : Form
    {
        private Helicopter helicopter;
        private Ambulance ambulance;
        private Motorcycle motorcycle;
        private Random random;

        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;

            const int MotorcycleSpeed = 10;
            const int AmbulanceSpeed = 15;
            const int HelicopterSpeed = 30;
            const int HelicopterMaxHigh = 30;

            int x = pictureBoxMotorcycle.Location.X;
            int y = pictureBoxMotorcycle.Location.Y;
            int distanceW = formSizeW - pictureBoxMotorcycle.Size.Width;
            motorcycle = new Motorcycle(x, y, MotorcycleSpeed, distanceW, pictureBoxMotorcycle);

            x = pictureBoxAmbulance.Location.X;
            y = pictureBoxAmbulance.Location.Y;
            distanceW = formSizeW - pictureBoxAmbulance.Size.Width;
            motorcycle = new Motorcycle(x, y, MotorcycleSpeed, distanceW, pictureBoxAmbulance);

            x = pictureBoxHelicopter.Location.X;
            y = pictureBoxHelicopter.Location.Y;
            distanceW = formSizeW - pictureBoxHelicopter.Size.Width;
            motorcycle = new Motorcycle(x, y, MotorcycleSpeed, distanceW, pictureBoxHelicopter);

            random = new Random();

            labelNotice.Text = "";
        }
    }
}
