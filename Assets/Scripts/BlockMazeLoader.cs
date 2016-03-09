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
    public char KulcsKarakter = 'K';
   
    public BlockMaze generate()
    {
        string[] lines = File.ReadAllLines(Terkep);
        int sorok = lines.Length;
        int sorhossz = Leghosszabb(lines);

        bool[,] fal = new bool[sorok, sorhossz];
        bool[,] kulcs = new bool[sorok, sorhossz];
        for (int x=0; x<sorok; x++)
        {
            for (int y=0; y<lines[x].Length; y++)
            {
                fal[x, y] = FalKarakter == lines[x][y];
                kulcs[x, y] = KulcsKarakter == lines[x][y];
            }
            
        }
        return new BlockMaze(fal, kulcs);        
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
