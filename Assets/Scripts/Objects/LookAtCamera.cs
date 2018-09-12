using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour {

    public Camera vrCamera;

    GameObject canvasHolder;
    float canvasHolderScale;
    float firstHypotenuse;
    float secondHypotenuse;
    float sizeOfCanvasHolder;

	// Use this for initialization
	void Start () {
        canvasHolder = GetComponent<GameObject>();

        canvasHolderScale = canvasHolder.transform.localScale.z * 1.2f;

        sizeOfCanvasHolder = CanvasHolderSizeCalculation(canvasHolderScale);

        if (FindObjectOfType<Camera>().tag=="MainCamera")
        {
            vrCamera = GetComponent<Camera>();	
        }
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(vrCamera.transform.position);
    }

    float CanvasHolderSizeCalculation(float canvasHolderScale)
    {
        firstHypotenuse = Mathf.Sqrt(Mathf.Pow(canvasHolderScale / 2, 2) + Mathf.Pow(canvasHolderScale / 2, 2));

        secondHypotenuse = Mathf.Sqrt(Mathf.Pow(firstHypotenuse, 2) + Mathf.Pow(canvasHolderScale / 2, 2));

        return secondHypotenuse;
    }
}
