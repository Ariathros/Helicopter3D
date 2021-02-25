using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gems : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {

        // trigger coin pickup function if a helicopter collides with this
        other.transform.parent.GetComponent<HeliController>().PickupCoin(5);
        Destroy(gameObject);
    }

}
