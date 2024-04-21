using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;




namespace BookInventoryApp.CustomControls
{
    /// <summary>
    /// Represents a custom button control with rounded corners.
    /// </summary>
    public class RoundedButton : Button
    {
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        //Properties 
        /// <summary>
        /// Custom properties that can be changed within the properties tab of the form
        /// </summary>
        [Category("Rounded Button Properties")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();

            }
        }

        [Category("Rounded Button Properties")]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                if (value <= this.Height)
                    borderRadius = value;

                else borderRadius = this.Height; 
                this.Invalidate();

            }
        }

        [Category("Rounded Button Properties")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();

            }
        }

        [Category("Rounded Button Properties")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category ("Rounded Button Properties")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        // Constructor
        /// <summary>
        /// Initializes a new instance of the RoundedButton class with default settings.
        /// </summary>
        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }



        //Methods
        /// <summary>
        /// Creates a rounded rectangle path for the button's surface.
        /// </summary>
        /// <param name="rect">Rectangle defining the bounds of the path.</param>
        /// <param name="radius">Radius of the rounded corners.</param>
        /// <returns>A GraphicsPath representing the rounded rectangle.</returns>
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width-radius, rect.Height-radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        /// <summary>
        /// Overrides the OnPaint method to draw the button with rounded edges and custom border.
        /// </summary>
        /// <param name="pevent">PaintEventArgs containing event data.</param>
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(0, 0, this.Width, this.Height);

            if ( borderRadius > 2 )
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder =  GetFigurePath(rectBorder, borderRadius - 1F))
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    // Button Surface
                    this.Region = new Region(pathSurface);
                    // Draw Surface border
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    // Button Border
                    if (borderSize >= 1)
                        //Draw Control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
            else
            {
                this.Region = new Region(rectSurface);

                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen( borderColor, borderSize))
                    {
                        penBorder.Alignment= PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0 , 0 , this.Width-1, this.Height-1);
                    }
                }
            }

        }

        /// <summary>
        /// Event handler that responds to the creation of the button's handle by setting up a parent background color change listener.
        /// </summary>
        /// <param name="e">EventArgs containing event data.</param>
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

        }

        /// <summary>
        /// Invalidates the control when the container's background color changes.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">EventArgs containing event data.</param>
        private void Container_BackColorChanged(object? sender, EventArgs e)
        {
            if(this.DesignMode)
                this.Invalidate();
        }

        /// <summary>
        /// Ensures the border radius does not exceed the button height upon resizing.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">EventArgs containing event data.</param>
        private void Button_Resize(object? sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                BorderRadius = this.Height;
        }
    }
}
