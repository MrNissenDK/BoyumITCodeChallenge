using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using BoyumITCodeChallenge.models;

namespace BoyumITCodeChallenge
{
    public partial class boyumChallenge : Form
    {
        public boyumChallenge()
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("da-DK");
            InitializeComponent();
        }

        private void fileInputBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Select XML file",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "XML",
                Filter = "XML files (*.XML)|*.XML",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileInputField.Text = openFileDialog1.FileName;
            }
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(fileInputField.Text);
            try
            {
                if (fileInfo.Exists)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(WebOrder));
                    using (FileStream fileStream = new FileStream(fileInputField.Text, FileMode.Open))
                    {
                        WebOrder result = (WebOrder)serializer.Deserialize(fileStream);

                        idOutput.Text = result.Id.ToString();
                        customerOutput.Text = result.Customer;
                        dateOutputLable.Text = result.Date.ToString("dd. MMMM. yyyy");
                        priceAverageOutput.Text = result.priceAverage.ToString("##,#.000");
                        totalOutput.Text = result.totalPrice.ToString("##,#.000");

                    }
                }
                else
                {
                    MessageBox.Show("File does not exist");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(
                    $"Something went wrong! \n" +
                    $"{ex.Message}"
                );
            }
        }

        private void fileInputField_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(fileInputField.Text)) {
                FileInfo fileInfo = new FileInfo(fileInputField.Text);
                if (fileInfo.Exists)
                {
                    processBtn.Enabled = true;
                }
                else
                {
                    processBtn.Enabled = false;
                }
            }
            else
            {
                processBtn.Enabled = false;
            }
        }
    }
}
