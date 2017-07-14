using UnityEngine;
using System.Collections;

public class AnimalMover : MonoBehaviour {

    private float minX;
    private float maxX;

	// Use this for initialization
	void Start () {

        float vertExtent = Camera.main.orthographicSize;
        float horzExtent = vertExtent * Screen.width / Screen.height;

        minX = -horzExtent;
        maxX = horzExtent;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        var v3 = transform.position;
        v3.x = Mathf.Clamp(v3.x + 0.05f, minX, maxX);
        transform.position = v3;
    }
}
