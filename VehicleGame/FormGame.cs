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
        }
    }
}
