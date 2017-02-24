using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS300;
using CIS300.Queues;

namespace Lab6
{
    public partial class UserInterface : Form
    {
        private IQueue<double> _queue = new QueueFromStacks<double>();

        public UserInterface()
        {
            InitializeComponent();
        }

        private void uxBuy_Click(object sender, EventArgs e)
        {
            int num = 0;
            double cost = 0;
            try
            {
                num = Convert.ToInt32(uxShares.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Number of shares must be a whole number");
                return;
            }
            try
            {
                cost = Convert.ToDouble(uxCost.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Cost must be a number");
                return;
            }

            if (num < 0 || cost < 0)
            {
                MessageBox.Show("Number of shares and cost must both be nonnegative");
                return;
            }

            for (int i = 0; i < num; i++)
            {
                _queue.Enqueue(cost);
            }
        }

        private void uxSell_Click(object sender, EventArgs e)
        {
            int num = 0;
            double cost = 0;
            try
            {
                num = Convert.ToInt32(uxShares.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Number of shares must be a whole number");
                return;
            }
            try
            {
                cost = Convert.ToDouble(uxCost.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Cost must be a number");
                return;
            }

            if (num < 0 || cost < 0)
            {
                MessageBox.Show("Number of shares and cost must both be nonnegative");
                return;
            }

            if (_queue.Count < num)
            {
                MessageBox.Show("Not enough shares to sell");
                return;
            }

            double curNet = Convert.ToDouble(uxNet.Text);
            for (int i = 0; i < num; i++)
            {
                double oldCost = _queue.Dequeue();

                curNet += (cost - oldCost);
            }

            uxNet.Text = curNet.ToString();
         }

        private void UserInterface_Load(object sender, EventArgs e)
        {

        }

        public void QueueChanged(object sender, EventArgs e)
        {
            if(uxTwoStacksButton.Checked)
            {
                _queue = new QueueFromStacks<double>();
            }
            if (uxArrayButton.Checked)
            {
                _queue = new ArrayQueue<double>();
            }
            if (uxLinkedButton.Checked)
            {
                _queue = new LinkedQueue<double>();
            }

            uxShares.Text = "";
            uxCost.Text = "";
            uxNet.Text = "0";

            MessageBox.Show("The queue is changing type... Program resetting.");
        }
    }
}
