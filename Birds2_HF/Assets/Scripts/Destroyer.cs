using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{


    public float lifetime; // az ellenfél az életciklusa után törlődik

    void Start()
    {

        Destroy(gameObject, lifetime);


    }

}