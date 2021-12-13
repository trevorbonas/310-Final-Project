using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class largeBlockMovement : MonoBehaviour
{
	Vector3 Vec;
	float speed;
    // Start is called before the first frame update
    void Start()
    {
    	speed = 1.8f;
    }

    // Update is called once per frame
    void Update()
    {
        Vec = transform.localPosition;
        if (Vec.x >= 30.0) {
        	speed = -1.8f;
        }
        else if (Vec.x <= 12.0) {
        	speed = 1.8f;
        }
        this.transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
