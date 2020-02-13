using System.Drawing;


namespace GameOfFifteen
{
    static class Utils
    {
        public const int puzzle_width_pixel = 400;

        public static Image[] ImageDivider(Image img, int puzzle_width)
        {
            int puzzle_size = puzzle_width * puzzle_width;
            Image[] imgs = new Image[puzzle_size];
            img = ResizeImage(img, new Size(puzzle_width_pixel, puzzle_width_pixel)); //send to resize function

            int puzzle_width_size = puzzle_width_pixel/puzzle_width; // define Size of each Puzzle Pieces
            
            for (int i=0; i<puzzle_size; i++)
            {
                imgs[i] = new Bitmap(puzzle_width_size, puzzle_width_size);
                var graphics = Graphics.FromImage(imgs[i]);
                graphics.DrawImage(
                    img, new Rectangle(0, 0, puzzle_width_size, puzzle_width_size),
                    new Rectangle( (i%puzzle_width) * puzzle_width_size, (i/puzzle_width) * puzzle_width_size, puzzle_width_size, puzzle_width_size),
                    GraphicsUnit.Pixel
                );
                graphics.Dispose();
            }
            return imgs;
        }

        public static Image ResizeImage(Image imgToResize, Size size) //resize picture
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
    }
}
