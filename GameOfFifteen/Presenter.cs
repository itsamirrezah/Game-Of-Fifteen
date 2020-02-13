using System;
using System.Drawing;

namespace GameOfFifteen
{
    class Presenter
    {
        View view;
        Puzzle puzzle;

        public Presenter(View view)
        {
            this.view = view;
        }

        public void NewGame(int puzzle_width = 4)
        {
            view.ClearPuzzlePanel();
            puzzle = new Puzzle(puzzle_width);
            view.SetInitialValues(puzzle_width);
            MapPuzzleInView();
        }

        private void MapPuzzleInView()
        {
            Image[] imgs = Utils.ImageDivider(view.GetCurrentImage(), puzzle.puzzle_width);
            for (int i = 0; i < puzzle.puzzle_width; i++)
            {
                for (int j = 0; j < puzzle.puzzle_width; j++)
                {
                    int index = i * puzzle.puzzle_width + j;
                    int value = puzzle.puzzle_map[i, j];
                    view.CreatePictureBox(index, puzzle.puzzle_width,imgs[value]);
                }
            }
            view.SetEmptyPictureBox(puzzle._emptyIndex);
        }

        internal void OnPuzzlePieceSelected(int selected_index)
        {
            try
            {
                int newlocation = puzzle.MovePiece(selected_index);
                MovePiece(newlocation, selected_index);
                if (puzzle.IsCompleted())
                    view.PuzzleCompleted();
            } catch(NotImplementedException e)
            {
            }
        }

        private void MovePiece(int newlocation, int selected_index)
        {
            view.MoveSelectedPictureBox(newlocation, selected_index);
            view.AddUserScore();
        }

        internal void onImageChanged(int puzzle_size)
        {
            NewGame(puzzle_size);
        }

        internal void PuzzleSizeChanged(int puzzle_width)
        {
            if (puzzle.puzzle_width != puzzle_width) { 
                NewGame(puzzle_width);
            }
        }

        internal void OnRefreshPuzzle(int puzzle_size)
        {
            NewGame(puzzle_size);
        }
    }
}
