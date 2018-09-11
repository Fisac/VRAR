using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour {

    private InteractableObject interactable;
    private Matter currentMatter;

    private Renderer rend; 

    private void Awake()
    {
        interactable = gameObject.GetComponent<InteractableObject>();
        rend = gameObject.GetComponent<Renderer>();
        currentMatter = interactable.matter;
        rend.material = currentMatter.matterMaterial; 
       
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        ApplyNewMaterial();
		
	}

    public void ApplyNewMaterial()
    {
        if(rend.material != currentMatter.matterMaterial)
        {
            rend.material = currentMatter.matterMaterial; 
        }
    }
}
