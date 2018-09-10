using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public class EventManager : MonoBehaviour {


    [SerializeField]
    public GameObject test; 
    // Use this for initialization
    public void DestroyBlock()
    {
        //propertyTriggered[0].Invoke();
        StartCoroutine("Destruction"); 
    }

    IEnumerator Destruction()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(test); 
    }
}
