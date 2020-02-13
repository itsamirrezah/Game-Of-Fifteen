using System;
using System.Collections.Generic;

namespace GameOfFifteen
{
    class Puzzle
    {
        public int[,] puzzle_map { get; }
        private int empty_index;
        public int puzzle_width { get; }

        public int _emptyIndex
        {
            get { return empty_index; }
        }


        public Puzzle(int puzzle_width)
        {
            this.puzzle_width = puzzle_width;
            puzzle_map = new int[puzzle_width, puzzle_width];
            ShufflePuzzleValues();
            //createPuzzleMapValues();
        }

        public int MovePiece(int selected_index)
        {
            int[] selectedPieceInd = Convert1Dto2Dindex(selected_index);
            int[] emptyPieceInd = Convert1Dto2Dindex(empty_index);

            if (IsMovingPossible(selectedPieceInd, emptyPieceInd))
            {
                //save previus empty index for returning later.
                //then change the current empty index with new value
                int last_empty_index = empty_index;
                empty_index = selected_index;

                //swap values in puzzle_map
                int temp = puzzle_map[selectedPieceInd[0], selectedPieceInd[1]];
                puzzle_map[selectedPieceInd[0], selectedPieceInd[1]] = puzzle_map[emptyPieceInd[0], emptyPieceInd[1]];
                puzzle_map[emptyPieceInd[0], emptyPieceInd[1]] = temp;
                
                return last_empty_index;
            }

            throw new NotImplementedException();
        }

        public bool IsCompleted()
        {
            for (int i=0; i< puzzle_width; i++)
            {
                for (int j=0; j<puzzle_width; j++)
                {
                    int index = i * puzzle_width + j;
                    //if (i == puzzle_width - 1 && j == puzzle_width-1)
                    //    return true;
                    if (puzzle_map[i, j] != index)
                        return false;
                }
            }
            return true;
        }

        private bool IsMovingPossible(int[] currentPiece, int[] emptyPiece)
        {
            // if 'row' of the two spot is equal and the difference between the 'column' of them is 1
            // and if the 'column' of the two spot is equal and the difference between the 'row' of them is 1
            // THEN MOVING IS POSSIBLE
            if ( (currentPiece[0] == emptyPiece[0] && Math.Abs(currentPiece[1] - emptyPiece[1]) == 1)
                || (currentPiece[1] == emptyPiece[1] && Math.Abs(currentPiece[0] - emptyPiece[0]) == 1) )
                return true;
            return false;
        }

        private int[] Convert1Dto2Dindex(int index)
        {
            int i = index / puzzle_width;
            int j = index % puzzle_width;

            return new int[] { i, j };
        }

        public void ShufflePuzzleValues()
        {
            List<int> numberlist = new List<int>();

            for (int i=0; i<puzzle_map.Length; i++)
            {
                numberlist.Add(i);
            }

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

        //For Test
        private void createPuzzleMapValues()
        {
            for (int i = 0; i < puzzle_width; i++)
            {
                for (int j = 0; j < puzzle_width; j++)
                {
                    puzzle_map[i, j] = i * puzzle_width + j;
                }
            }
            //puzzle_map[puzzle_width - 1, puzzle_width - 1] = -1;
            empty_index = (puzzle_width * puzzle_width) - 1;
        }
    }
}
