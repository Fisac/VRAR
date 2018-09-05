using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statement : MonoBehaviour {

    [SerializeField]
    private Manipulatable manipulatable, wantedCondition, target, wantedTurnOut;

    public Conditions destroyCondition, movingCondition, airborneCondition;

    private void Update()
    {
        TryConditions();
    }

    public void TryConditions()
    {
        if(destroyCondition != Conditions.Ignore)
        {
            if (!TryDestroyed())
            {
                return;
            }
        }

        if(movingCondition != Conditions.Ignore)
        {
            if (!TryMoving())
            {
                return;
            }
        }

        if(movingCondition != Conditions.Ignore)
        {
            if (!TryAirborne())
            {
                return;
            }
        }

        Debug.Log("ALL CONDITIONS ARE MET");
    }

    public bool TryDestroyed()
    {
        if(manipulatable.destroyed == wantedCondition.destroyed)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool TryMoving()
    {
        if (manipulatable.moving == wantedCondition.moving)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool TryAirborne()
    {
        if (manipulatable.airborne == wantedCondition.airborne)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
