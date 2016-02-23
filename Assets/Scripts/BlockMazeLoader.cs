using UnityEngine;
using System.Collections;
using System;
using System.IO;

/*
Olyan labirintus "generáló", amely valójában egy fájlból tölti be, nem pedig véletlenszerűen hozza létre a labirintust.
*/
public class BlockMazeLoader : MonoBehaviour, BlockMazeGenerator {

    public string Terkep;
    public char FalKarakter = '#';
   
    public BlockMaze generate()
    {
        string[] lines = File.ReadAllLines(Terkep);
        int sorok = lines.Length;
        int sorhossz = Leghosszabb(lines);

        bool[,] maze = new bool[sorok,sorhossz];
        for (int x=0; x<sorok; x++)
        {
            for (int y=0; y<lines[x].Length; y++)
            {
                maze[x, y] = FalKarakter == lines[x][y];
            }
            
        }
        return new BlockMaze(maze);        
    }

    private int Leghosszabb(string[] lines)
    {
        int max = 0;
        foreach (string line in lines)
        {
            if (line.Length > max)
                max = line.Length;
        }
        return max;
    }


}
