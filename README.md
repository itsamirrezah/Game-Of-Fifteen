# Game Of Fifteen
An old work for university class which demonstrates a 15-puzzle game

![Game-Of-Fifteen](/assets/Game-Of-Fifteen.gif)

## Using
* Windows Form Application (sorry about that :D)
* MVP Architecture Pattern


## How to solve the 15 puzzle
This video will help: https://www.youtube.com/watch?v=EtXE08bOVZM

I should warn you when you complete the game this is the only thing you're gonna get:

```c#
public void PuzzleCompleted()
{
        MessageBox.Show("YOU WON");
}
```
so play at your own risk.


## Implementation
For implementation you need to know these three:
* How to divide an image into n pieces
* How to shuffle the puzzle
* Determine if the player won the game or not


### Divide an image into n pieces

```c#
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
        new Rectangle( (i%puzzle_width) * puzzle_width_size, (i/puzzle_width) * puzzle_width_size, puzzle_width_size, puzzle_width_size),GraphicsUnit.Pixel);
        graphics.Dispose();
    }
    return imgs;
}
```

### Shuffle the puzzle

```c#
public void ShufflePuzzleValues()
{
    List<int> numberlist = new List<int>();
    for (int i=0; i<puzzle_map.Length; i++)
        numberlist.Add(i);

    Random random = new Random();
    for (int i=0; i<puzzle_width; i++)
    {
        for (int j=0; j<puzzle_width; j++)
        {
            int randIndex = random.Next(0, numberlist.Count);
            puzzle_map[i, j] = numberlist[randIndex];
            //find empty spot index
            if (puzzle_map[i, j] == puzzle_map.Length - 1)
            empty_index = i * puzzle_width + j;
            numberlist.RemoveAt(randIndex);
            }
    }
}
```
### Check if the player won or not
  
```c#
public bool isPuzzleComplete()
{
    for (int i=0; i< puzzle_width; i++)
    {
        for (int j=0; j<puzzle_width; j++)
        {
            int index = i * puzzle_width + j;
            if (puzzle_map[i, j] != index)
                return false;
        }
    }
    return true;
}
```
