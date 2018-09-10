using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleObject : MonoBehaviour {

    private Matter matter;
    private MeshRenderer mesh;
    private BoxCollider collider; 


    private void Awake()
    {
        matter = gameObject.GetComponent<Matter>();
        mesh = gameObject.GetComponent<MeshRenderer>();
        collider = gameObject.GetComponent<BoxCollider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        StartCoroutine("DesroyObject");
    }

    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(0.5f);
        mesh.enabled = false;
        collider.enabled = false; 
    }
}
