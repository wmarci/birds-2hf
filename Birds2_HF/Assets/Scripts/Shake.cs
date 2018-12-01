using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour {

    public Animator camAnim; // main camera animáció

    public void CamShake() {

        camAnim.SetTrigger("shake"); // shake animáció lejátszása

    }
	
}
