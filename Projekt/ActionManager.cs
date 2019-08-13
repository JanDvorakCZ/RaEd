/*
 * Author - Jan Dvořák 
 * Email - jdvorula@gmail.com
 */
using RoP_RaEd.Tools;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RoP_RaEd
{

    class ActionManager
    {
        //Image opened for editing 
        public Image ImageEdit;
        public Image ImageStepback;
        //Color manager
        public ColorManager ColorManager;
        //Key handler
        public KeyHandler KeyHandler;
        //Mouse action listener
        public MouseListener MouseListener;
        //Indicates if opened file is saved
        public bool IsImageSaved;
        //String containing path and file name
        public string FileName;
        //Enum that contains selected tool
        public Tool ActiveTool { get; set; }
        //point tool percantage width height 
        public int ToolSurface;
        //Indicates if mouse cursor is inbetween image borders
        public bool IsMouseInimage = false;

        public Point ScrollOffset { get; set; }
        // 
        public Point MouseCoordsInImage { get; set; }
        public Point LastMouseoCoordsInImage { get; set; }
        public bool StepEnable;

        //Constructor
        public ActionManager()
        {
            //Inicializetion of ColorManager
            ColorManager = new ColorManager();
            //Default inicialization when no image is opened
            IsImageSaved = true;
            //Creates new instance of Key handler 
            KeyHandler = new KeyHandler();
            //New Mouse Listener inicialization
            MouseListener = new MouseListener(0, 0);
            //Sets activeTool to Arrow 
            ActiveTool = new Arrow();
            ToolSurface = 10;
            StepEnable = false;
        }

        //Saves image
        public void Save()
        {
            //if FileName contains no path then SaveAs is called
            if (FileName != "" && File.Exists(FileName))
            {
                //Saves image
                ImageEdit.Save(FileName);
                //Sets indicator that image is saved
                IsImageSaved = true;
            }
            else
            {
                SaveAs();
            }
        }

        //Saves image to a new path
        public void SaveAs()
        {
            //Creates new Save File Dialog
            SaveFileDialog sfd = new SaveFileDialog();
            //Sets default filename 
            sfd.FileName = "newImage";
            //Sets filter for only image formats
            sfd.Filter = "JPG file | *.jpg; | PNG file | *.png; | BMP file | *.bmp; | TIFF file | *.tiff";
            //Enables add of extensions when selected
            sfd.AddExtension = true;
            //Gets dialog result from open file dialog and stores it
            DialogResult result = sfd.ShowDialog();
            //Checks if dialog result is OK
            if (result == DialogResult.OK)
            {
                //Saves the image to selected path 
                ImageEdit.Save(sfd.FileName);
                //Stores image filename 
                FileName = sfd.FileName;
            }
            //Sets indicator that tells, the image is saved 
            IsImageSaved = true;
        }

        //Method for opening images from file
        public bool OpenFile()
        {
            //Checks if any image is opened 
            if (ImageEdit != null && !IsImageSaved)
            {
                //Creates dialog result container
                DialogResult wannaSave;
                //User is asked if the opened image should be saved and result is stored
                wannaSave = MessageBox.Show("Would you like to save your progress?", "Open file", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (wannaSave == DialogResult.Yes)
                {
                    //Checks is FileName is not empty
                    if (FileName != "")
                    {
                        //Saves image
                        Save();
                    }
                    else
                    {
                        //Saves image to user selected path
                        SaveAs();
                    }
                }

            }
            //Creates new instance of file dialog
            OpenFileDialog fileDialog = new OpenFileDialog();
            //Sets file dialog title
            fileDialog.Title = "Please select an image file.";
            //File dialog filter is set for image formats
            fileDialog.Filter = "image files (*.jpg, *.png, *.bmp, *.jpeg, *.tiff)|*.jpg; *.png; *.bmp; *.jpeg; *tiff|All files (*.*)|*.*";
            //Dialog result from open file dialog is stored
            DialogResult result = fileDialog.ShowDialog();
            //Checks if resul is open file dialog is OK
            if (result == DialogResult.OK)
            {
                //Checks if seledcted file format is image format
                if (fileDialog.FileName.EndsWith(".jpg") || fileDialog.FileName.EndsWith(".png") || fileDialog.FileName.EndsWith(".jpeg") || fileDialog.FileName.EndsWith(".bmp") || fileDialog.FileName.EndsWith(".tiff"))
                {
                    //Opens a file stream with only read file acces and 
                    FileStream fs = new FileStream(fileDialog.FileName, FileMode.Open, FileAccess.Read);
                    //Sets indicator of save state
                    IsImageSaved = true;
                    StepEnable = true;
                    //Stores file name
                    FileName = fileDialog.FileName;
                    //image is acquired from filestream
                    ImageEdit = Image.FromStream(fs);
                    //Files stream is closed
                    fs.Close();
                    //Resets view offset
                    ResetView();
                    //Returns true to indicate that image has been opened 
                    return true;
                }
                else
                {
                    //Informs user, that selected files extension is not 
                    MessageBox.Show("Wrong file type selected.", "Wrong file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Return false to indicate that no image has been opened
            return false;
        }

        //Method for creating a new image
        public void CreateNewImage(int width, int height)
        {
            //New image is created  
            ImageEdit = new Bitmap(height, width, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            //Using graphics from new image image is filled with white color
            using (Graphics g = Graphics.FromImage(ImageEdit))
            {
                g.Clear(Color.White);
                g.Dispose();
            }
            ResetView();
            StepEnable = true;
            //indicator is image saved is set to false
            IsImageSaved = false;
        }

        public void ResetView()
        {
            ScrollOffset = new Point(0, 0);
        }


        /* Image scaling - move to image scaler
        public Image ScaleImage(Image input, double zoom)
        {
            var image = new Bitmap((int)(input.Width * zoom), (int)(input.Height * zoom));
            using (Graphics g = Graphics.FromImage(image))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(input, new Rectangle(Point.Empty, image.Size));
            }

            return image;
        }
        */

        public void RecalculateRelativeMouseCoords()
        {
            LastMouseoCoordsInImage = MouseCoordsInImage;
            MouseCoordsInImage = new Point(MouseListener.X - ScrollOffset.X, MouseListener.Y - ScrollOffset.Y);
        }

        //Flips image by specified rotation
        public void RotateImage(RotateFlipType flipType)
        {
            ImageEdit.RotateFlip(flipType);
            //indicator is image saved is set to false
            IsImageSaved = false;
        }

        //Sets specified key state
        public void KeyStateChange(Keys key, bool value)
        {
            KeyHandler.changeState(key, value);
        }

        //Active tool is selected to pencil
        public void SelectPencil()
        {
            ActiveTool = new Pencil();
        }

        //Active tool is selected to brush
        public void SelectBrush()
        {
            ActiveTool = new Tools.Brush();
        }

        //Active tool is selected to eraser
        public void SelectEraser()
        {
            ActiveTool = new Eraser();
        }

        //Active tool is selected to arrow
        public void SelectArrow()
        {
            ActiveTool = new Arrow();
        }
        //Active tool is changed to color picker
        public void SelectColorPicker()
        {
            ActiveTool = new ColorPicker();
        }
        //Active tool is changed to fill tool
        public void SelectFill()
        {
            ActiveTool = new Fill();
        }
        //Mouse button released
        public void OnMouseUp()
        {
            StepEnable = true;
            RecalculateRelativeMouseCoords();
            if (!(ActiveTool is Arrow))
            {
                IsImageSaved = false;
                ActiveTool.OnMouseUp(this);
            }
        }
        //Mouse button is pressed
        public void OnMouseDown()
        {
            if (StepEnable)
            {
                ImageStepback = ImageEdit;
                StepEnable = false;
            }
            RecalculateRelativeMouseCoords();
            if (!(ActiveTool is Arrow))
            {
                IsImageSaved = false;
                ActiveTool.OnMouseDown(this);
            }

        }
        //Mouse is moved with pressed button
        public void OnMouseMove()
        {
            RecalculateRelativeMouseCoords();
            if (!(ActiveTool is Arrow))
            {
                if (MouseListener.leftMouseDown)
                {
                    IsImageSaved = false;
                    ActiveTool.OnMouseMove(this);
                }
            }
        }
        //Sets tool percantage
        public void SetToolSurface(int space)
        {
            ToolSurface = space;
        }
        public void ClearImage()
        {
            IsImageSaved = false;
            using (Graphics g = Graphics.FromImage(ImageEdit))
            {
                g.FillRectangle(new SolidBrush(Color.White), 0, 0, ImageEdit.Width, ImageEdit.Height);
                g.Flush();
            }
        }
        //not included
        public void StepBack()
        {
            Image container = ImageEdit;
            ImageEdit = ImageStepback;
            ImageStepback = container;
        }
        public void StepForward()
        {
            ImageEdit = ImageStepback;
            ImageStepback = ImageEdit;
        }
    }
}
