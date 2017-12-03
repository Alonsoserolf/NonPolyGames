using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObject : MonoBehaviour {

	public float pushPower = 3.0F;
	Vector3 pos;
	GameObject floor;
	GameObject destinationPoint;

	void Update() {
		pos = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), Mathf.Round(transform.position.z));
        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * pushPower);
	}

    void OnCollisionEnter(Collision c) {
    	Vector3 dir = c.contacts[0].point - transform.position;

    	dir = -dir.normalized;

    	GetComponent<Rigidbody>().AddForce(dir * pushPower);
    }


}
