using UnityEngine;
using System.Collections;
using System;
using System.IO;

/*
Olyan labirintus "generáló", amely valójában egy fájlból tölti be, nem pedig véletlenszerűen hozza létre a labirintust.
*/
public class BlockMazeLoader : MonoBehaviour, BlockMazeGenerator
{
	public string Terkep;

	public BlockMaze generate ()
	{
		string[] lines = File.ReadAllLines (Terkep);
		int sorok = lines.Length;
		int sorhossz = 0;
		foreach (string line in lines) {
			if (line.Length > sorhossz)
				sorhossz = line.Length;
		}
		BlockMaze maze = new BlockMaze (sorok, sorhossz);
		for (int x = 0; x < sorok; x++) {
			for (int y = 0; y < lines [x].Length; y++) {
				maze [x, y] = new Block(lines [x] [y]);
			}            
		} 
		return maze;
	}
}