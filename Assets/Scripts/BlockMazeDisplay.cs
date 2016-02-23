using UnityEngine;
using System.Collections;

public class BlockMazeDisplay : MonoBehaviour {

    public GameObject Padlo;
    public GameObject Fal;

    public float MeretX = 1;
    public float MeretZ = 1;

    private BlockMazeGenerator generator;
    private BlockMaze maze;

	void Start () {

        generator = GetComponent<BlockMazeGenerator>();
        maze = generator.generate();

	}

    //Létrehozza a megadott prefab másolatát a pos által definiált relatív pozícióban
    void Letrehoz(Vector3 pos, GameObject epitoElem)
    {
        GameObject instance = (GameObject)Instantiate(epitoElem, transform.position + pos + epitoElem.transform.position, Quaternion.identity);
        instance.transform.parent = transform;
    }


}
