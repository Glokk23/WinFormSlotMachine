using System;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        private int balance = 100; // Starting balance

        public Form1()
        {
            InitializeComponent();
            UpdateBalanceLabel();
        }

        private void UpdateBalanceLabel()
        {
            balanceLabel.Text = $"Balance: ${balance}";
        }

        private void SpinButton_Click(object sender, EventArgs e)
        {
            const int spinCost = 10; // Cost to spin
            if (balance >= spinCost)
            {
                // Decrease balance by spin cost
                balance -= spinCost;

                // Update balance display
                UpdateBalanceLabel();

                // Generate random numbers for each slot
                Random rand = new Random();
                int slot1 = rand.Next(1, 4);
                int slot2 = rand.Next(1, 4);
                int slot3 = rand.Next(1, 4);

                // Display slot results
                slotPictureBox1.Image = GetSlotImage(slot1);
                slotPictureBox2.Image = GetSlotImage(slot2);
                slotPictureBox3.Image = GetSlotImage(slot3);

                // Check for win
                if (slot1 == slot2 && slot2 == slot3)
                {
                    // Increase balance for a win
                    balance += 75; // You can change the win amount
                    UpdateBalanceLabel();
                    MessageBox.Show("You win $75!");
                }
                else
                {
                    MessageBox.Show("Try again!");
                }
            }
            else
            {
                MessageBox.Show("Insufficient balance to spin.");
            }
        }

        private Image GetSlotImage(int slotValue)
        {
            Console.WriteLine($"Slot value: {slotValue}"); // Debug statement
            string imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

            switch (slotValue)
            {
                case 1:
                    return LoadImageFromFolder(imagesFolder, "apple.png");
                case 2:
                    return LoadImageFromFolder(imagesFolder, "banana.png");
                case 3:
                    return LoadImageFromFolder(imagesFolder, "pear.png");
                default:
                    return null; // Return null for unknown slot values
            }
        }

        private Image LoadImageFromFolder(string folderPath, string imageName)
        {
            string imagePath = Path.Combine(folderPath, imageName);

            if (File.Exists(imagePath))
            {
                try
                {
                    Image loadedImage = Image.FromFile(imagePath);
                    Console.WriteLine($"Image loaded: {imageName}"); // Debug statement
                    return loadedImage;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading image: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine($"Image not found: {imageName}");
            }

            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
