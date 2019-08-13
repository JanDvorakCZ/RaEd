/*
 * Author - Jan Dvořák 
 * Email - jdvorula@gmail.com
 */
using RoP_RaEd.Tools;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace RoP_RaEd
{
    public partial class MainForm : Form
    {

        //Declaration of ActionManager
        private ActionManager actionManager;

        //Constructor
        public MainForm()
        {
            Init();
        }

        //First inicialization of different components of the MainForm
        private void Init()
        {
            InitializeComponent();
            //ActionManager inicialization
            actionManager = new ActionManager();
            //Update of Color components
            UpdateColor();
            //Update of Tool components
            UpdateTool();
            //Disable of saving, editing and scrolling if image is not inicialized
            if (actionManager.ImageEdit == null)
            {
                DisableSteps();
                DisableSaving();
                DisableEditing();
                //DisableScrolling();
            }

            actionManager.ColorManager.color.PropertyChanged += Color_PropertyChanged;
            pnlCanvas.Paint += pnlCanvas_Paint;
            //enables doubleBuffering for canvas
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            pnlCanvas, new object[] { true });
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (actionManager.ImageEdit == null)
            {
                return;
            }

            var graphics = e.Graphics;
            graphics.DrawImageUnscaledAndClipped(actionManager.ImageEdit, new Rectangle(actionManager.ScrollOffset, actionManager.ImageEdit.Size));
        }
        // occures when color is changed
        private void Color_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            AlphaTrackBar.Value = actionManager.ColorManager.color.A;
            RTrackBar.Value = actionManager.ColorManager.color.R;
            GTrackBar.Value = actionManager.ColorManager.color.G;
            BTrackBar.Value = actionManager.ColorManager.color.B;

            ColorCanvas.Image = actionManager.ColorManager.ColorFill;
            //Updates color labels 
            UpdateColorLabels();
        }

        //Exit methode of Application
        private void Exit(object sender, FormClosingEventArgs e)
        {
            //If active image is not saved, save opportunity is displayed
            if (!actionManager.IsImageSaved)
            {
                //Ask user if active image should be saved before aplication is closed
                DialogResult result = MessageBox.Show("Do you want to save your progress before leaving?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //Saves active image
                    actionManager.Save();
                }
                else if (result == DialogResult.Cancel)
                {
                    //If dialog result is cancel exit is cancelled
                    e.Cancel = true;
                }
            }
        }

        // Calls the Exit methode while the MainForm is closing
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit(sender, e);
        }

        // updates tools
        private void UpdateTool()
        {
            //Updates tool surface label
            ToolWidthLabel.Text = "" + ToolTrackBar.Value + "px";
            //Sets tool width / height percantage
            actionManager.SetToolSurface(ToolTrackBar.Value);
        }

        // Updates color
        private void UpdateColor()
        {
            //Creates new Instance of color in ColorManager
            actionManager.ColorManager.SetColor((byte)AlphaTrackBar.Value, (byte)RTrackBar.Value, (byte)GTrackBar.Value, (byte)BTrackBar.Value);
            //Sets image of ColorCanvas to ColorFill from ColorManager
            ColorCanvas.Image = actionManager.ColorManager.ColorFill;
            //Updates color labels 
            UpdateColorLabels();
        }

        //Updates color labels
        private void UpdateColorLabels()
        {
            LabelRed.Text = "R:" + RTrackBar.Value;
            LabelGreen.Text = "G:" + GTrackBar.Value;
            LabelBlue.Text = "B:" + BTrackBar.Value;
            LabelAlpha.Text = "A:" + AlphaTrackBar.Value;
            ColorHTML.Text = "Color: " + ColorTranslator.ToHtml(actionManager.ColorManager.color.ToDefaultColor());
        }

        //Tool strip File - Open File
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if image is opened properly, editing, saving and scrolling is enabled
            if (actionManager.OpenFile())
            {
                EnableSaving();
                EnableEditing();
                //Image is render to MainCanvas
                pnlCanvas.Invalidate();
            }

        }

        //Tool strip File - Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes MainForm
            MainForm.ActiveForm.Close();
        }

        //Updates Color components when value is changed
        private void RTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        //Tool strip Image - Rotate Left  - Rotates active image 90° to the left
        private void rotateLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionManager.RotateImage(RotateFlipType.Rotate270FlipNone);
            //Renders changes
            pnlCanvas.Invalidate();
        }

        //Tool strip Image - Rotate Right  - Rotates active image 90° to the right
        private void rotateRight90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionManager.RotateImage(RotateFlipType.Rotate90FlipNone);
            //Renders changes
            pnlCanvas.Invalidate();
        }

        //Tool strip Image - Horizontal Mirror  - Flips active image horizontally
        private void horizontalMirrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionManager.RotateImage(RotateFlipType.RotateNoneFlipX);

            //Renders changes
            pnlCanvas.Invalidate();
        }

        //Tool strip Image - Vertical Mirror  - Flips active image vertically
        private void verticalMirrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionManager.RotateImage(RotateFlipType.RotateNoneFlipY);
            pnlCanvas.Invalidate();
        }
        private void AdjustPictureBox()
        {
        }

        //Tool strip Image - Rotate 180  - Rotates active image 180° 
        private void rotate180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionManager.RotateImage(RotateFlipType.Rotate180FlipNone);

            //Renders changes
            pnlCanvas.Invalidate();
        }

        //Tool strip File - Save - Saves active image 
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionManager.Save();
            DisableSteps();
        }

        //Tool strip File - Save - Saves active image with a new path
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionManager.SaveAs();
            DisableSteps();
        }

        //Occures when key is released
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {

            actionManager.KeyStateChange(e.KeyCode, false);
        }

        //Occures when key is pressed
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            actionManager.KeyStateChange(e.KeyCode, true);
            if (e.Shift && e.Control && e.KeyCode == Keys.S)
            {
                actionManager.SaveAs();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                actionManager.Save();
            }
        }

        //Disables saving option
        public void DisableSaving()
        {
            foreach (Control c in this.Controls)
            {
                if (c.AccessibleName == "SaveControls")
                {
                    c.Enabled = false;
                }
            }

            foreach (ToolStripMenuItem items in this.MenuStrip.Items)
            {
                foreach (ToolStripItem i in items.DropDownItems)
                {
                    if (i.AccessibleName == "SaveControls")
                    {
                        i.Enabled = false;
                    }
                }
            }
        }

        //Enables saving option
        public void EnableSaving()
        {
            foreach (Control c in this.Controls)
            {
                if (c.AccessibleName == "SaveControls")
                {
                    c.Enabled = true;
                }
            }
            foreach (ToolStripMenuItem items in this.MenuStrip.Items)
            {
                foreach (ToolStripItem i in items.DropDownItems)
                {
                    if (i.AccessibleName == "SaveControls")
                    {
                        i.Enabled = true;
                    }
                }
            }
        }

        //Tool strip File - New File
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creates form for new file specifications
            CreateNewFileForm newFileForm = new CreateNewFileForm();
            //Disables MainForm 
            this.Enabled = false;
            //Gets dialog result from newFileForm
            DialogResult result = newFileForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Creates new image from collected data
                actionManager.CreateNewImage(int.Parse(newFileForm.TBHeight.Text), int.Parse(newFileForm.TBWidth.Text));
                //Renders new image onto MainCanvas
                pnlCanvas.Invalidate();
                //Enables saving, editing and scrolling
                EnableEditing();
                EnableSaving();
                EnableScrolling();
            }
            //Enables MainForm
            this.Enabled = true;
        }

        //Disables all components for editing
        private void DisableEditing()
        {
            foreach (Control c in this.Controls)
            {
                if (c.AccessibleName == "EditControls")
                {
                    c.Enabled = false;
                }
            }
            foreach (ToolStripMenuItem items in this.MenuStrip.Items)
            {
                foreach (ToolStripItem i in items.DropDownItems)
                {
                    if (i.AccessibleName == "EditControls")
                    {
                        i.Enabled = false;
                    }
                }
            }
        }

        //Enables all components for editing
        private void EnableEditing()
        {
            foreach (Control c in this.Controls)
            {
                if (c.AccessibleName == "EditControls")
                {
                    c.Enabled = true;
                }
            }

            foreach (ToolStripMenuItem items in this.MenuStrip.Items)
            {
                foreach (ToolStripItem i in items.DropDownItems)
                {
                    if (i.AccessibleName == "EditControls")
                    {
                        i.Enabled = true;
                    }
                }
            }
        }

        //Enables all components for scrolling
        private void EnableScrolling()
        {
            foreach (Control c in this.Controls)
            {
                if (c.AccessibleName == "ScrollControls")
                {
                    c.Enabled = true;
                }
            }
        }
        //Disables all components for scrolling
        private void DisableScrolling()
        {
            foreach (Control c in this.Controls)
            {
                if (c.AccessibleName == "ScrollControls")
                {
                    c.Enabled = false;
                }
            }
        }

        //Enables all components for editing
        private void MainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            actionManager.MouseListener.MouseMoved(e.X, e.Y);
            if (actionManager.ImageEdit != null)
            {
                actionManager.OnMouseMove();
                if (!( actionManager.ActiveTool is Arrow) || !(actionManager.ActiveTool is Arrow))
                {

                }
            }

            pnlCanvas.Refresh();
        }

        //Occures when mouse button is pressed
        private void MainCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                actionManager.MouseListener.RightMouseDown(true);
            }
            else
            {
                actionManager.MouseListener.LeftMouseDown(true);
            }
            if (actionManager.ImageEdit != null)
            {
                actionManager.OnMouseDown();
            }
            pnlCanvas.Refresh();
        }

        //Occures when mouse button is released
        private void MainCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            //checks which mouse button is released
            if (e.Button == MouseButtons.Right)
            {
                actionManager.MouseListener.RightMouseDown(false);
            }
            else
            {
                actionManager.MouseListener.LeftMouseDown(false);
            }
            if (actionManager.ImageEdit != null)
            {
                actionManager.OnMouseUp();
            }
            pnlCanvas.Refresh();
        }

        //Occures when button Pencil is pressed
        private void ButtonPencil_Click(object sender, EventArgs e)
        {
            actionManager.SelectPencil();
        }

        //Tool strip Edit - Pencil
        private void pencilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionManager.SelectPencil();
        }

        //Occures when button Brush is pressed
        private void ButtonBrush_Click(object sender, EventArgs e)
        {
            actionManager.SelectBrush();
        }

        //Occures when button Erser is pressed
        private void ButtonEraser_Click(object sender, EventArgs e)
        {
            actionManager.SelectEraser();
        }

        //Updates tool components when value of trackbar is changed
        private void ToolWidthTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateTool();
        }

        //Updates tool components when value of trackbar is changed
        private void ToolHeightTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateTool();
        }

        //Tool strip Edit - Eraser 
        private void rubberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionManager.SelectEraser();
        }

        //Tool strip Edit - Brush  
        private void brushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionManager.SelectBrush();
        }
        //Ocures when arrow button is clicked
        private void ButtonArrow_Click(object sender, EventArgs e)
        {
            actionManager.SelectArrow();
        }

        //Tool strip Edit - Arrow 
        private void arrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionManager.SelectArrow();
        }

        //Ocures when color picker tool is pressed
        private void ButtonColorPicker_Click(object sender, EventArgs e)
        {
            actionManager.SelectColorPicker();
        }

        //Ocures when main forms size is changed
        private void MainForm_Resize(object sender, EventArgs e)
        {
            pnlCanvas.Invalidate();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(SystemColors.ActiveBorder);
            e.Graphics.PageUnit = GraphicsUnit.Display;

            if (actionManager.ImageEdit != null)
                e.Graphics.DrawImageUnscaled(actionManager.ImageEdit, 0, 0);
        }

        private void btnMoveTool_Click(object sender, EventArgs e)
        {
            actionManager.ActiveTool = new Move();
        }

        private void stepBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionManager.StepBack();
        }

        private void stepForwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionManager.StepForward();
        }
        //not included
        private void DisableSteps()
        {
            foreach (ToolStripMenuItem items in this.MenuStrip.Items)
            {
                foreach (ToolStripItem i in items.DropDownItems)
                {
                    if (i.AccessibleName == "StepControlBack" || i.AccessibleName == "StepControlForward")
                    {
                        i.Enabled = false;
                    }
                }
            }
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionManager.SelectFill();
        }

        private void btnFilltool_Click(object sender, EventArgs e)
        {
            actionManager.SelectFill();
        }

        private void clearCanvasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionManager.ClearImage();
        }

        private void centerCanvasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionManager.ScrollOffset = new Point(0, 0);
        }
    }
}
