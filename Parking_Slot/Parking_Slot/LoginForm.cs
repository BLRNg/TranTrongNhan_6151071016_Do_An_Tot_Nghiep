using Parking_Slot.Repo;
using Parking_Slot.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Slot
{
    public partial class LoginForm : Form
    {
        public user User { get; private set; }

        private UserRepository userRepository;
        public LoginForm()
        {
            InitializeComponent();

            userRepository = new UserRepository();
        }

      
        private void sign_in_bt_Click(object sender, EventArgs e)
        {
            string username = user_name_tb.Text;
            string password = pw_tb.Text;


            if (userRepository.AuthenticateUser(username, password))
            {
                User = userRepository.GetUserByUsername(username);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                // User not found or incorrect credentials
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void user_name_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the Enter key
                pw_tb.Focus(); // Move focus to the next text box
            }
        }

        private void pw_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the Enter key
                sign_in_bt.PerformClick(); // Simulate button click
            }
        }
    }
}
