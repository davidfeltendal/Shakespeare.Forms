using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Shakespeare.Forms.Views
{
    [DefaultProperty("Text")]
    public partial class IconLabel : UserControl
    {
        public IconLabel()
        {
            InitializeComponent();
        }

        [Browsable(true)]        
        public Size IconSize
        {
            get { return this.icon.Size; }
            set { this.icon.Size = value; }
        }

        [Browsable(true)]
        public Image Icon
        {
            get { return this.icon.Image; }
            set { this.icon.Image = value; }
        }

        [Browsable(true)]
        [DefaultValue(ContentAlignment.TopLeft)]        
        public ContentAlignment TextAlign
        {
            get { return this.label.TextAlign; }
            set { this.label.TextAlign = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get { return this.label.Text ?? base.Text; }
            set { this.label.Text = base.Text = value; }
        }
    }
}