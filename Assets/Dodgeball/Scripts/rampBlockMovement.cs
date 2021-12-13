using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rampBlockMovement : MonoBehaviour
{
    Vector3 Vec;
	float speed;
    // Start is called before the first frame update
    void Start()
    {
    	speed = -1.8f;
    }

    // Update is called once per frame
    void Update()
    {
  		Vec = transform.localPosition;
	        if (Vec.y >= 7.44) {
	        	speed = -1.8f;
	        }
	        else if (Vec.y <= 3.05) {
	        	speed = 1.8f;
	        }
	        this.transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
