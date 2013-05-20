using System;
using System.Collections.Generic;
using System.IO;
using TetristPuzzle.Logic;
using TetristPuzzle.Models;

namespace TetristPuzzle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            args = new string[2];
            args[0] = @"C:\Source\CC\input.txt";
            args[1] = "42";

            var importer = new InputImporter();
            Input input = importer.Import(args[0]);
            input.StartIndex = int.Parse(args[1]);

            Grid bestSolution = null;
            for (int i = 0; i < 10000; i++)
            {
                var puzzle = new TetrisPuzzle();
                Grid solution = puzzle.Solve(input);
                if (bestSolution == null || solution.NumEmpty < bestSolution.NumEmpty)
                {
                    bestSolution = solution;
                }
            }

            var serializer = new GridSerializer();
            string output = serializer.Execute(bestSolution);

            Console.WriteLine(output);
            File.WriteAllText("output.txt", output);
            Console.ReadKey();
        }
    }
}