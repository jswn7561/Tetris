using System.ComponentModel;

namespace Tetris
{
    public partial class SuperButton : UserControl
    {
        public Image PressedBackgroundImage { get; set; }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => label.Text;
            set => label.Text = value;
        }

        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                label.ForeColor = value;
            }
        }

        private Image originalBackgroundImage;

        public SuperButton()
        {
            MouseDown += OnMouseDown;
            MouseUp += OnMouseUp;
            SizeChanged += OnSizeChanged;
            InitializeComponent();
            ControlUtils.SetControlEnabled(label, false);
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
            label.Size = Size;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (BackgroundImage != null && PressedBackgroundImage != null)
            {
                originalBackgroundImage = BackgroundImage;
                BackgroundImage = PressedBackgroundImage;
            }

            var color = label.ForeColor;
            label.ForeColor = Color.FromArgb(color.A, (int)(color.R * 0.78f), (int)(color.G * 0.78f),
                (int)(color.B * 0.78f));
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (BackgroundImage != null && PressedBackgroundImage != null)
            {
                BackgroundImage = originalBackgroundImage;
            }

            label.ForeColor = base.ForeColor;
            AudioManager.Instance.PlayButtonClick();
        }
    }
}
