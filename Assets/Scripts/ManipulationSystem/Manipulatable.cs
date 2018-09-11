using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manipulatable : MonoBehaviour {

    [HideInInspector]
    public Statement statement;

    public bool destroyed, moving, airborne;

    public void UpdateValues()
    {
        if(statement != null)
            StatementsManager.Instance.CheckStatement(statement);
    }
}
