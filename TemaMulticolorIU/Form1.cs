using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaMulticolorIU
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;

        //Constructor
       
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.Colorlist.Count);
            while (tempIndex == index)
            {
                random.Next(ThemeColor.Colorlist.Count);
            }
            tempIndex = index;
            string color = ThemeColor.Colorlist[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonReporting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonNotification_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
