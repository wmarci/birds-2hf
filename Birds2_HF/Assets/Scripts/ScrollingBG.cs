using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBG : MonoBehaviour {

    [SerializeField]
    float scrollSpeed;
    Vector2 startPos;


	void Start () {

        startPos = transform.position;


	}
	
	
	void Update () {

        float newPos = Mathf.Repeat(Time.time * scrollSpeed, 49.152f);
        transform.position = startPos + Vector2.right * newPos;


	}
}
