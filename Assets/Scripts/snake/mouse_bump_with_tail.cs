using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_bump_with_tail : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void OnTriggerEnter(Collider other)
    {

        if (other.name == "Snake Head(Clone)")
        {
           
            creat_object.did_mouse_collide_with_tail_ = true;
            Destroy(this.gameObject);
            Debug.Log("Destroy");
        }

        

    }
    // Update is called once per frame
    void Update () {
		
	}
}
