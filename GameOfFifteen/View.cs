using System.Drawing;

namespace GameOfFifteen
{
    interface View
    {
        void MoveSelectedPictureBox(int newlocation, int selectedPieceIndex);
        void PuzzleCompleted();
        Image GetCurrentImage();
        void CreatePictureBox(int value, int puzzle_width, Image image);
        void SetEmptyPictureBox(int empty_index);
        void AddUserScore();
        void ClearPuzzlePanel();
        void SetInitialValues(int puzzle_width);
    }
}
