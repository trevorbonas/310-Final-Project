using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridgePlatformMovement : MonoBehaviour
{
    Vector3 Vec;
	float speed;
    // Start is called before the first frame update
    void Start()
    {
    	speed = -0.3f;
    }

    // Update is called once per frame
    void Update()
    {
  		Vec = transform.localPosition;
	        if (Vec.y >= 0.378) {
	        	speed = -0.3f;
	        }
	        else if (Vec.y <= -0.6) {
	        	speed = 0.3f;
	        }
	        this.transform.Translate(0, speed * Time.deltaTime, 0);
    }
}