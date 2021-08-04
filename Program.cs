using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

/*HOW TO APPLY Windows.Forms
  Expand the project in Solution Tree, Right-Click on References, Add Reference, Select System.Windows.Forms on Framework tab.
  You need to add reference to some non-default assemblies sometimes.
  From comments: for people looking for VS 2019+: Now adding project references is Right-Click on Dependencies in Solution Explorer. 
 */
using System.Windows.Forms;

namespace PicBoxes
{
    class Program
    {

        //static void Main(string[] args)
        //{
        //    Console.Read();
        //}
         public partial class Form1 : Form
        {

            Random rand = new Random();
            List<PictureBox> items = new List<PictureBox>();
            public Form1()
            {
                InitializeComponent();
            }

            //private void InitializeComponent()
            //{
            //    throw new NotImplementedException();
            //}

            private void PictureBox()
            {
                //pic properties
                PictureBox newPic = new PictureBox();
                newPic.Height = 50;
                newPic.Width = 50;
                newPic.BackColor = Color.Maroon;
                //Determine a random number (width/height pic stays in location)
                int x = rand.Next(10, this.ClientSize.Width - newPic.Width);
                int y = rand.Next(10, this.ClientSize.Height - newPic.Height);
                newPic.Location = new Point(x, y);

                newPic.Click += NewPic_Click;
                //pic to appear
                items.Add(newPic);
                this.Controls.Add(newPic);
            }
            //pic removal
            private void NewPic_Click(object sender, EventArgs e)
            {
                PictureBox temPicture = sender as PictureBox;

                items.Remove(temPicture);

                this.Controls.Remove(temPicture);

                ItemCount.Text = "Items: " + items.Count();
            }
            //Calculate items within list
            private void TimerEvent(object sender, EventArgs e)
            {
                PictureBox();

                ItemCount.Text = "Items: " + items.Count();
            }
            
        }
    }

    //class lblItemCount
    //{
    //    public static string Text { get; internal set; }
    //}
    
}
