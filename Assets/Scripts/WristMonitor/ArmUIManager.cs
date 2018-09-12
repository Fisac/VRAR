using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmUIManager : MonoBehaviour {

    public Canvas armUICanvas;
    public GameObject controller, hand;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="MainCamera")
        {
            armUICanvas.gameObject.SetActive(true);
            //controller.SetActive(false);
            //hand.SetActive(false);
            Debug.Log("MainCamera in trigger.");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            armUICanvas.gameObject.SetActive(false);
            controller.SetActive(true);
            hand.SetActive(true);
            Debug.Log("MainCamera not in trigger.");
        }
    }
}
