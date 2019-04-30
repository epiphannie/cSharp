using System;

namespace Collections
{
    class Program
    {
static void Main(string[] args)
        {
            //Jagged Array
            Cell[][] sheet = new Cell[100][];
            for (int rowIndex = 0; rowIndex < sheet.Length; rowIndex++)
            {
                sheet[rowIndex] = new Cell[10];
                //create a row of 10 cells
                for (int colIndex = 0; colIndex < sheet[rowIndex].Length; colIndex++)
                {
                    sheet[rowIndex][colIndex] = new Cell();
                }
            }

            foreach(Cell[] row in sheet)
            {
                foreach(Cell cell in row)
                {
                    Console.Write(cell);
                }
                Console.WriteLine();
            }

            //Every row has the exact same number of cells, a true multi-dimensional array
            Cell[,] sheet2D = new Cell[100, 10];
            
            for(int rowIndex = 0; rowIndex < sheet2D.GetLength(0); rowIndex++)
                //Get length of first dimension
            {
                for(int colIndex = 0; colIndex < sheet2D.GetLength(1); colIndex++)
                    //Get length of second dimenstion
                {
                    sheet2D[rowIndex, colIndex] = new Cell();
                }
            }

            //adding stuff to an array
            int[]ages = { 24, 31, 56 };
            int[] agesCopy = new int[4];
            ages.CopyTo(agesCopy, 1);
            agesCopy[0] = 16;
            ages = agesCopy; // this won't work as prior references won't be updated

            //fast for retrieving and setting, slow for removing and adding
        }
    }
}
