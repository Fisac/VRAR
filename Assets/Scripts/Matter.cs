using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Matter", menuName ="Matter")]
public class Matter : ScriptableObject {

    public new string name;

    public int weight;

    public int frictionMultiplier;

    public bool destructable;

    public bool isPhysical;

    public Material matterMaterial;
}
