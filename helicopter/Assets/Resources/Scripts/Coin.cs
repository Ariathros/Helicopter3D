using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		
	}

	void OnTriggerEnter(Collider other) {

		// trigger coin pickup function if a helicopter collides with this
		other.transform.parent.GetComponent<HeliController>().PickupCoin(1);
		Destroy(gameObject);
	}
}
