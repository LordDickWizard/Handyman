using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneInteraction : MonoBehaviour
{
    public Transform interactionObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = interactionObject.position;
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            Debug.Log(collisionInfo.collider.name);

        }
    }
}
