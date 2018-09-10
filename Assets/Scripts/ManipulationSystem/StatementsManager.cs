using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatementsManager : MonoBehaviour {

    public Statement[] statements;

    private void Update()
    {
        //CheckStatements();
    }

    public void CheckStatement(Statement statement)
    {
        foreach (var item in statements)
        {
            if(item.TryStatement())
                Debug.Log("YEE");
        }
    }
}
