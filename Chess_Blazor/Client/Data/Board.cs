using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chess_Blazor.Client.Data
{
    public class Board
    {
        public int Size { get; set; }
        public Cell[,] theGrid { get; set; }
        public Board (int size)
        {
            Size = size;

            theGrid = new Cell[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }

            }
        }

        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {
            //Nettoie le cache des déplacements précédents
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j].LegalNextMove = false;
                    theGrid[i, j].IsOccupied = false;
                }
            }

            //Vérifie les déplacements possibles
            switch (chessPiece)
            {
                case "Pions":
                    break;

                case "Tour":
                    break;

                case "Cavalier":
                    theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;

                    break;

                case "Fou":
                    break;

                case "Reine":
                    break;

                case "Roi":
                    break;

                default:
                    break;
            }
        }
    }
}
