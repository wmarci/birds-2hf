using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timerText; // UI beimportálásával a Text tipus elerheto
    public float startTime;



	void Start () {

        startTime = Time.time;


	}
	
	
	void Update () {

        float t = Time.time - startTime; // késleltetéssel az óra inditása

        
        string seconds = (t % 60).ToString("f2"); // két tizedesre

        timerText.text = "Time: " + seconds + "s";

	}
}
