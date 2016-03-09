﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KulcsFelszedo : MonoBehaviour {

    public int kulcsok = 0;
    public Text kijelzo;
   
	// Use this for initialization
	void Start () {
        KijelzoFrissit();
	}
	
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Kulcs")
        {
			kulcsok++;
			Destroy (other.gameObject);
			KijelzoFrissit ();
        }
    }


    public void KijelzoFrissit()
    {
        kijelzo.text = "Kulcsok: " + kulcsok;
    }
}