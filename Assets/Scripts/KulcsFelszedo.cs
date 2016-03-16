﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KulcsFelszedo : MonoBehaviour {

    private int kulcsok = 0;
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
            KijelzoFrissit();
            Destroy(other.gameObject);
        }
    }


    public void KijelzoFrissit()
    {
        kijelzo.text = "Kulcsok: " + kulcsok;
    }
}
