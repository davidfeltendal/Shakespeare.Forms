using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Shakespeare.Forms.Views
{
    public partial class Banner : UserControl
    {
        public Banner()
        {
            InitializeComponent();
        }

        [DefaultValue("Title")]
        [Browsable(true)]
        public string Title
        {
            get { return this.title.Text; }
            set { this.title.Text = value; }
        }

        [DefaultValue("Description")]
        [Browsable(true)]
        public string Description
        {
            get { return this.description.Text; }
            set { this.description.Text = value; }
        }

        [Browsable(true)]
        public Image Image
        {
            get { return this.pictureBox.Image; }
            set
            {
                this.pictureBox.Image = value;
                PictureBoxSizeMode tmp = this.pictureBox.SizeMode;
                this.pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                this.pictureBox.SizeMode = tmp;
            }
        }

        [DefaultValue(PictureBoxSizeMode.Normal)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public PictureBoxSizeMode SizeMode
        {
            get { return this.pictureBox.SizeMode; }
            set { this.pictureBox.SizeMode = value; }
        }
    }
}