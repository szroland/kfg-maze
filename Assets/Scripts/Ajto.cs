using UnityEngine;
using System.Collections;

public class Ajto : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		var k = other.GetComponent<KulcsFelszedo> ();
		if (k != null){
			if (k.kulcsok > 0) {
				k.kulcsok--;
				Destroy (this.gameObject);
			}
		}
	}
}
