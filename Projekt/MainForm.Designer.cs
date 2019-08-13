using System.Windows.Forms;

namespace RoP_RaEd
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pencilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rubberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateRight90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalMirrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalMirrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearCanvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerCanvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RTrackBar = new System.Windows.Forms.TrackBar();
            this.GTrackBar = new System.Windows.Forms.TrackBar();
            this.BTrackBar = new System.Windows.Forms.TrackBar();
            this.LabelRed = new System.Windows.Forms.Label();
            this.LabelGreen = new System.Windows.Forms.Label();
            this.LabelBlue = new System.Windows.Forms.Label();
            this.ColorCanvas = new System.Windows.Forms.PictureBox();
            this.AlphaTrackBar = new System.Windows.Forms.TrackBar();
            this.LabelAlpha = new System.Windows.Forms.Label();
            this.ColorHTML = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonPencil = new System.Windows.Forms.Button();
            this.ButtonBrush = new System.Windows.Forms.Button();
            this.ButtonEraser = new System.Windows.Forms.Button();
            this.ToolTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.ToolWidthLabel = new System.Windows.Forms.Label();
            this.ButtonArrow = new System.Windows.Forms.Button();
            this.ButtonColorPicker = new System.Windows.Forms.Button();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.btnMoveTool = new System.Windows.Forms.Button();
            this.btnFilltool = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip.Size = new System.Drawing.Size(1235, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AccessibleName = "";
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.newFileToolStripMenuItem.Text = "New File";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.AccessibleName = "SaveControls";
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.AccessibleName = "SaveControls";
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.AccessibleName = "EditControls";
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pencilToolStripMenuItem,
            this.rubberToolStripMenuItem,
            this.brushToolStripMenuItem,
            this.arrowToolStripMenuItem,
            this.colorPickerToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.fillToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // pencilToolStripMenuItem
            // 
            this.pencilToolStripMenuItem.AccessibleName = "EditControls";
            this.pencilToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.pencilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pencilToolStripMenuItem.Image")));
            this.pencilToolStripMenuItem.Name = "pencilToolStripMenuItem";
            this.pencilToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pencilToolStripMenuItem.Text = "Pencil";
            this.pencilToolStripMenuItem.Click += new System.EventHandler(this.pencilToolStripMenuItem_Click);
            // 
            // rubberToolStripMenuItem
            // 
            this.rubberToolStripMenuItem.AccessibleName = "EditControls";
            this.rubberToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rubberToolStripMenuItem.Image")));
            this.rubberToolStripMenuItem.Name = "rubberToolStripMenuItem";
            this.rubberToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.rubberToolStripMenuItem.Text = "Eraser";
            this.rubberToolStripMenuItem.Click += new System.EventHandler(this.rubberToolStripMenuItem_Click);
            // 
            // brushToolStripMenuItem
            // 
            this.brushToolStripMenuItem.AccessibleName = "EditControls";
            this.brushToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("brushToolStripMenuItem.Image")));
            this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.brushToolStripMenuItem.Text = "Brush";
            this.brushToolStripMenuItem.Click += new System.EventHandler(this.brushToolStripMenuItem_Click);
            // 
            // arrowToolStripMenuItem
            // 
            this.arrowToolStripMenuItem.AccessibleName = "EditControls";
            this.arrowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("arrowToolStripMenuItem.Image")));
            this.arrowToolStripMenuItem.Name = "arrowToolStripMenuItem";
            this.arrowToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.arrowToolStripMenuItem.Text = "Arrow";
            this.arrowToolStripMenuItem.Click += new System.EventHandler(this.arrowToolStripMenuItem_Click);
            // 
            // colorPickerToolStripMenuItem
            // 
            this.colorPickerToolStripMenuItem.AccessibleName = "EditControls";
            this.colorPickerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerToolStripMenuItem.Image")));
            this.colorPickerToolStripMenuItem.Name = "colorPickerToolStripMenuItem";
            this.colorPickerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.colorPickerToolStripMenuItem.Text = "Color picker";
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.AccessibleName = "EditControls";
            this.moveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moveToolStripMenuItem.Image")));
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.moveToolStripMenuItem.Text = "Move ";
            this.moveToolStripMenuItem.Click += new System.EventHandler(this.btnMoveTool_Click);
            // 
            // fillToolStripMenuItem
            // 
            this.fillToolStripMenuItem.AccessibleName = "EditControls";
            this.fillToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fillToolStripMenuItem.Image")));
            this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            this.fillToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.fillToolStripMenuItem.Text = "Fill";
            this.fillToolStripMenuItem.Click += new System.EventHandler(this.fillToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.AccessibleName = "EditControls";
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateToolStripMenuItem,
            this.rotateRight90ToolStripMenuItem,
            this.rotate180ToolStripMenuItem,
            this.verticalMirrorToolStripMenuItem,
            this.horizontalMirrorToolStripMenuItem,
            this.toolStripSeparator2,
            this.clearCanvasToolStripMenuItem,
            this.centerCanvasToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.AccessibleName = "EditControls";
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotateToolStripMenuItem.Text = "Rotate left °90";
            this.rotateToolStripMenuItem.Click += new System.EventHandler(this.rotateLeftToolStripMenuItem_Click);
            // 
            // rotateRight90ToolStripMenuItem
            // 
            this.rotateRight90ToolStripMenuItem.AccessibleName = "EditControls";
            this.rotateRight90ToolStripMenuItem.Name = "rotateRight90ToolStripMenuItem";
            this.rotateRight90ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotateRight90ToolStripMenuItem.Text = "Rotate right °90";
            this.rotateRight90ToolStripMenuItem.Click += new System.EventHandler(this.rotateRight90ToolStripMenuItem_Click);
            // 
            // rotate180ToolStripMenuItem
            // 
            this.rotate180ToolStripMenuItem.AccessibleName = "EditControls";
            this.rotate180ToolStripMenuItem.Name = "rotate180ToolStripMenuItem";
            this.rotate180ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotate180ToolStripMenuItem.Text = "Rotate °180";
            this.rotate180ToolStripMenuItem.Click += new System.EventHandler(this.rotate180ToolStripMenuItem_Click);
            // 
            // verticalMirrorToolStripMenuItem
            // 
            this.verticalMirrorToolStripMenuItem.AccessibleName = "EditControls";
            this.verticalMirrorToolStripMenuItem.Name = "verticalMirrorToolStripMenuItem";
            this.verticalMirrorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verticalMirrorToolStripMenuItem.Text = "Vertical mirror";
            this.verticalMirrorToolStripMenuItem.Click += new System.EventHandler(this.horizontalMirrorToolStripMenuItem_Click);
            // 
            // horizontalMirrorToolStripMenuItem
            // 
            this.horizontalMirrorToolStripMenuItem.AccessibleName = "EditControls";
            this.horizontalMirrorToolStripMenuItem.Name = "horizontalMirrorToolStripMenuItem";
            this.horizontalMirrorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horizontalMirrorToolStripMenuItem.Text = "Horizontal mirror";
            this.horizontalMirrorToolStripMenuItem.Click += new System.EventHandler(this.verticalMirrorToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // clearCanvasToolStripMenuItem
            // 
            this.clearCanvasToolStripMenuItem.AccessibleName = "EditControls";
            this.clearCanvasToolStripMenuItem.Name = "clearCanvasToolStripMenuItem";
            this.clearCanvasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearCanvasToolStripMenuItem.Text = "Clear canvas";
            this.clearCanvasToolStripMenuItem.Click += new System.EventHandler(this.clearCanvasToolStripMenuItem_Click);
            // 
            // centerCanvasToolStripMenuItem
            // 
            this.centerCanvasToolStripMenuItem.AccessibleName = "EditControls";
            this.centerCanvasToolStripMenuItem.Name = "centerCanvasToolStripMenuItem";
            this.centerCanvasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.centerCanvasToolStripMenuItem.Text = "Center canvas";
            this.centerCanvasToolStripMenuItem.Click += new System.EventHandler(this.centerCanvasToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RTrackBar
            // 
            this.RTrackBar.AccessibleName = "EditControls";
            this.RTrackBar.Location = new System.Drawing.Point(51, 66);
            this.RTrackBar.Maximum = 255;
            this.RTrackBar.Name = "RTrackBar";
            this.RTrackBar.Size = new System.Drawing.Size(120, 45);
            this.RTrackBar.TabIndex = 3;
            this.RTrackBar.Scroll += new System.EventHandler(this.RTrackBar_Scroll);
            // 
            // GTrackBar
            // 
            this.GTrackBar.AccessibleName = "EditControls";
            this.GTrackBar.Location = new System.Drawing.Point(51, 92);
            this.GTrackBar.Maximum = 255;
            this.GTrackBar.Name = "GTrackBar";
            this.GTrackBar.Size = new System.Drawing.Size(120, 45);
            this.GTrackBar.TabIndex = 4;
            this.GTrackBar.Scroll += new System.EventHandler(this.RTrackBar_Scroll);
            // 
            // BTrackBar
            // 
            this.BTrackBar.AccessibleName = "EditControls";
            this.BTrackBar.Location = new System.Drawing.Point(51, 118);
            this.BTrackBar.Maximum = 255;
            this.BTrackBar.Name = "BTrackBar";
            this.BTrackBar.Size = new System.Drawing.Size(120, 45);
            this.BTrackBar.TabIndex = 5;
            this.BTrackBar.Scroll += new System.EventHandler(this.RTrackBar_Scroll);
            // 
            // LabelRed
            // 
            this.LabelRed.AutoSize = true;
            this.LabelRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelRed.Location = new System.Drawing.Point(6, 66);
            this.LabelRed.Name = "LabelRed";
            this.LabelRed.Size = new System.Drawing.Size(27, 20);
            this.LabelRed.TabIndex = 7;
            this.LabelRed.Text = "R:";
            // 
            // LabelGreen
            // 
            this.LabelGreen.AutoSize = true;
            this.LabelGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelGreen.Location = new System.Drawing.Point(6, 91);
            this.LabelGreen.Name = "LabelGreen";
            this.LabelGreen.Size = new System.Drawing.Size(28, 20);
            this.LabelGreen.TabIndex = 8;
            this.LabelGreen.Text = "G:";
            // 
            // LabelBlue
            // 
            this.LabelBlue.AutoSize = true;
            this.LabelBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelBlue.Location = new System.Drawing.Point(8, 117);
            this.LabelBlue.Name = "LabelBlue";
            this.LabelBlue.Size = new System.Drawing.Size(26, 20);
            this.LabelBlue.TabIndex = 9;
            this.LabelBlue.Text = "B:";
            // 
            // ColorCanvas
            // 
            this.ColorCanvas.AccessibleName = "EditControls";
            this.ColorCanvas.BackColor = System.Drawing.Color.Transparent;
            this.ColorCanvas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ColorCanvas.BackgroundImage")));
            this.ColorCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorCanvas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ColorCanvas.Location = new System.Drawing.Point(40, 194);
            this.ColorCanvas.Name = "ColorCanvas";
            this.ColorCanvas.Size = new System.Drawing.Size(100, 100);
            this.ColorCanvas.TabIndex = 11;
            this.ColorCanvas.TabStop = false;
            // 
            // AlphaTrackBar
            // 
            this.AlphaTrackBar.AccessibleName = "EditControls";
            this.AlphaTrackBar.Location = new System.Drawing.Point(51, 143);
            this.AlphaTrackBar.Maximum = 255;
            this.AlphaTrackBar.Name = "AlphaTrackBar";
            this.AlphaTrackBar.Size = new System.Drawing.Size(120, 45);
            this.AlphaTrackBar.TabIndex = 5;
            this.AlphaTrackBar.Value = 255;
            this.AlphaTrackBar.Scroll += new System.EventHandler(this.RTrackBar_Scroll);
            // 
            // LabelAlpha
            // 
            this.LabelAlpha.AutoSize = true;
            this.LabelAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelAlpha.Location = new System.Drawing.Point(8, 143);
            this.LabelAlpha.Name = "LabelAlpha";
            this.LabelAlpha.Size = new System.Drawing.Size(26, 20);
            this.LabelAlpha.TabIndex = 13;
            this.LabelAlpha.Text = "A:";
            // 
            // ColorHTML
            // 
            this.ColorHTML.AutoSize = true;
            this.ColorHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ColorHTML.Location = new System.Drawing.Point(5, 27);
            this.ColorHTML.Name = "ColorHTML";
            this.ColorHTML.Size = new System.Drawing.Size(82, 25);
            this.ColorHTML.TabIndex = 14;
            this.ColorHTML.Text = "Color :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(5, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tools";
            // 
            // ButtonPencil
            // 
            this.ButtonPencil.AccessibleName = "EditControls";
            this.ButtonPencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonPencil.BackgroundImage")));
            this.ButtonPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonPencil.Location = new System.Drawing.Point(12, 404);
            this.ButtonPencil.Name = "ButtonPencil";
            this.ButtonPencil.Size = new System.Drawing.Size(47, 45);
            this.ButtonPencil.TabIndex = 20;
            this.ButtonPencil.UseVisualStyleBackColor = true;
            this.ButtonPencil.Click += new System.EventHandler(this.ButtonPencil_Click);
            // 
            // ButtonBrush
            // 
            this.ButtonBrush.AccessibleName = "EditControls";
            this.ButtonBrush.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonBrush.BackgroundImage")));
            this.ButtonBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonBrush.Location = new System.Drawing.Point(63, 353);
            this.ButtonBrush.Name = "ButtonBrush";
            this.ButtonBrush.Size = new System.Drawing.Size(47, 45);
            this.ButtonBrush.TabIndex = 21;
            this.ButtonBrush.UseVisualStyleBackColor = true;
            this.ButtonBrush.Click += new System.EventHandler(this.ButtonBrush_Click);
            // 
            // ButtonEraser
            // 
            this.ButtonEraser.AccessibleName = "EditControls";
            this.ButtonEraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEraser.BackgroundImage")));
            this.ButtonEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEraser.Location = new System.Drawing.Point(116, 353);
            this.ButtonEraser.Name = "ButtonEraser";
            this.ButtonEraser.Size = new System.Drawing.Size(47, 45);
            this.ButtonEraser.TabIndex = 22;
            this.ButtonEraser.UseVisualStyleBackColor = true;
            this.ButtonEraser.Click += new System.EventHandler(this.ButtonEraser_Click);
            // 
            // ToolTrackBar
            // 
            this.ToolTrackBar.AccessibleName = "EditControls";
            this.ToolTrackBar.Location = new System.Drawing.Point(12, 532);
            this.ToolTrackBar.Maximum = 100;
            this.ToolTrackBar.Minimum = 1;
            this.ToolTrackBar.Name = "ToolTrackBar";
            this.ToolTrackBar.Size = new System.Drawing.Size(100, 45);
            this.ToolTrackBar.TabIndex = 23;
            this.ToolTrackBar.Value = 10;
            this.ToolTrackBar.Scroll += new System.EventHandler(this.ToolWidthTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tool:";
            // 
            // ToolWidthLabel
            // 
            this.ToolWidthLabel.AutoSize = true;
            this.ToolWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ToolWidthLabel.Location = new System.Drawing.Point(112, 547);
            this.ToolWidthLabel.Name = "ToolWidthLabel";
            this.ToolWidthLabel.Size = new System.Drawing.Size(0, 20);
            this.ToolWidthLabel.TabIndex = 27;
            // 
            // ButtonArrow
            // 
            this.ButtonArrow.AccessibleName = "EditControls";
            this.ButtonArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonArrow.BackgroundImage")));
            this.ButtonArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonArrow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonArrow.Location = new System.Drawing.Point(10, 353);
            this.ButtonArrow.Name = "ButtonArrow";
            this.ButtonArrow.Size = new System.Drawing.Size(47, 45);
            this.ButtonArrow.TabIndex = 29;
            this.ButtonArrow.UseVisualStyleBackColor = true;
            this.ButtonArrow.Click += new System.EventHandler(this.ButtonArrow_Click);
            // 
            // ButtonColorPicker
            // 
            this.ButtonColorPicker.AccessibleName = "EditControls";
            this.ButtonColorPicker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonColorPicker.BackgroundImage")));
            this.ButtonColorPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonColorPicker.Location = new System.Drawing.Point(63, 404);
            this.ButtonColorPicker.Name = "ButtonColorPicker";
            this.ButtonColorPicker.Size = new System.Drawing.Size(47, 45);
            this.ButtonColorPicker.TabIndex = 32;
            this.ButtonColorPicker.UseVisualStyleBackColor = true;
            this.ButtonColorPicker.Click += new System.EventHandler(this.ButtonColorPicker_Click);
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCanvas.AutoScroll = true;
            this.pnlCanvas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanvas.Location = new System.Drawing.Point(177, 37);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1058, 722);
            this.pnlCanvas.TabIndex = 33;
            this.pnlCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainCanvas_MouseDown);
            this.pnlCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainCanvas_MouseMove);
            this.pnlCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainCanvas_MouseUp);
            // 
            // btnMoveTool
            // 
            this.btnMoveTool.AccessibleName = "EditControls";
            this.btnMoveTool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoveTool.BackgroundImage")));
            this.btnMoveTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveTool.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMoveTool.Location = new System.Drawing.Point(116, 404);
            this.btnMoveTool.Name = "btnMoveTool";
            this.btnMoveTool.Size = new System.Drawing.Size(47, 45);
            this.btnMoveTool.TabIndex = 34;
            this.btnMoveTool.UseVisualStyleBackColor = true;
            this.btnMoveTool.Click += new System.EventHandler(this.btnMoveTool_Click);
            // 
            // btnFilltool
            // 
            this.btnFilltool.AccessibleName = "EditControls";
            this.btnFilltool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilltool.BackgroundImage")));
            this.btnFilltool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilltool.Location = new System.Drawing.Point(12, 455);
            this.btnFilltool.Name = "btnFilltool";
            this.btnFilltool.Size = new System.Drawing.Size(47, 45);
            this.btnFilltool.TabIndex = 35;
            this.btnFilltool.UseVisualStyleBackColor = true;
            this.btnFilltool.Click += new System.EventHandler(this.btnFilltool_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1235, 759);
            this.Controls.Add(this.btnFilltool);
            this.Controls.Add(this.btnMoveTool);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.ButtonColorPicker);
            this.Controls.Add(this.ButtonArrow);
            this.Controls.Add(this.ToolWidthLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ToolTrackBar);
            this.Controls.Add(this.ButtonEraser);
            this.Controls.Add(this.ButtonBrush);
            this.Controls.Add(this.ButtonPencil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ColorHTML);
            this.Controls.Add(this.LabelAlpha);
            this.Controls.Add(this.AlphaTrackBar);
            this.Controls.Add(this.ColorCanvas);
            this.Controls.Add(this.LabelBlue);
            this.Controls.Add(this.LabelGreen);
            this.Controls.Add(this.LabelRed);
            this.Controls.Add(this.BTrackBar);
            this.Controls.Add(this.GTrackBar);
            this.Controls.Add(this.RTrackBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "RaEd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar RTrackBar;
        private System.Windows.Forms.TrackBar GTrackBar;
        private System.Windows.Forms.TrackBar BTrackBar;
        private System.Windows.Forms.Label LabelRed;
        private System.Windows.Forms.Label LabelGreen;
        private System.Windows.Forms.Label LabelBlue;
        private System.Windows.Forms.PictureBox ColorCanvas;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateRight90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalMirrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalMirrorToolStripMenuItem;
        private System.Windows.Forms.TrackBar AlphaTrackBar;
        private System.Windows.Forms.Label LabelAlpha;
        private System.Windows.Forms.ToolStripMenuItem pencilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rubberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brushToolStripMenuItem;
        private System.Windows.Forms.Label ColorHTML;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonPencil;
        private System.Windows.Forms.Button ButtonBrush;
        private System.Windows.Forms.Button ButtonEraser;
        private System.Windows.Forms.TrackBar ToolTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ToolWidthLabel;
        private System.Windows.Forms.Button ButtonArrow;
        private System.Windows.Forms.ToolStripMenuItem arrowToolStripMenuItem;
        private System.Windows.Forms.Button ButtonColorPicker;
        private System.Windows.Forms.ToolStripMenuItem colorPickerToolStripMenuItem;
        private Panel pnlCanvas;
        private Button btnMoveTool;
        private ToolStripMenuItem moveToolStripMenuItem;
        private ToolStripMenuItem fillToolStripMenuItem;
        private Button btnFilltool;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem clearCanvasToolStripMenuItem;
        private ToolStripMenuItem centerCanvasToolStripMenuItem;
    }
}

