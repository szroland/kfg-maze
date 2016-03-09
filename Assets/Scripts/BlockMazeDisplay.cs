using UnityEngine;
using System.Collections;

public class BlockMazeDisplay : MonoBehaviour
{
	public GameObject Kulcs;
	public GameObject Ajto;
	public GameObject Padlo;
	public GameObject Fal;

	//public float ValosX = 24;
	//public float ValosZ = 24;

	private BlockMazeGenerator generator;
	private BlockMaze maze;

	void Start ()
	{
		generator = GetComponent<BlockMazeGenerator> ();
		maze = generator.generate ();

		GameObject plane = GameObject.Find ("Plane");
		//plane.transform.localScale = new Vector3 (maze.MeretX/10f, 1f, maze.MeretY/10f);
		//plane.transform.position = new Vector3 ((maze.MeretX-1) / 2f, -0.1f, (maze.MeretY) / 2f);
		for (int x = 0; x < maze.MeretX; x++) {
			for (int y = 0; y < maze.MeretY; y++) {
				var d = maze [x, y];
				var pos = new Vector3 (x, 0, y);
				switch (d) {
				case Block.fal:
					Letrehoz (pos, Fal);
					break;
				case Block.ajto:
					Letrehoz (pos, Ajto);
					break;
				case Block.kulcs:					
					Letrehoz (pos, Kulcs);					
					break;
				}
				Letrehoz (pos, Padlo);
			}
		}
	}

	//Létrehozza a megadott prefab másolatát a pos által definiált relatív pozícióban
	void Letrehoz (Vector3 pos, GameObject epitoElem)
	{
		var t = (Instantiate (epitoElem, transform.position + pos + epitoElem.transform.position, Quaternion.identity) as GameObject);
		t.transform.parent = transform;
	}
}
