using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flankBlockMovement : MonoBehaviour
{
    Vector3 Vec;
	float speed;
    // Start is called before the first frame update
    void Start()
    {
    	speed = -0.8f;
    }

    // Update is called once per frame
    void Update()
    {
  		Vec = transform.localPosition;
	        if (Vec.y >= 6.4) {
	        	speed = -0.8f;
	        }
	        else if (Vec.y <= 1.07) {
	        	speed = 0.8f;
	        }
	        this.transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
