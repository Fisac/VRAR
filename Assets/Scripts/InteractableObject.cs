using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour {

    public Matter matter;

    public List<Matter> matters;

    Collider objectCollider;
    Rigidbody objectRigidbody;

    public float mass;
    public float maximumLiftWeight;

    void Start()
    {
        objectCollider = GetComponent<BoxCollider>();
        objectRigidbody = GetComponent<Rigidbody>();

        Debug.Log("Name: " + matter.name);
        Debug.Log("Mass: " + matter.mass);
        Debug.Log("Friction multiplier: " + matter.frictionMultiplier);
        Debug.Log("Is physical: " + matter.isPhysical);
        Debug.Log("Is destructable: " + matter.isDestructable);
        Debug.Log("Is physical: " + matter.isPhysical);

        if (matter.mass > maximumLiftWeight)
        {
            objectRigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        }
        if (!matter.isPhysical)
        {
            objectCollider.enabled = !objectCollider.enabled;
            objectRigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        }
    }

    void Update()
    {
        //if (messageRecieved)
        //{
        // update object with properties from scriptableObjects

        //matter = matters[];
        //}
    }
}
