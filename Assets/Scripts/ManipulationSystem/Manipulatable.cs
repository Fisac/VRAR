using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manipulatable : MonoBehaviour {

    [HideInInspector]
    public Statement statement;
    private Rigidbody rigidBody;

    public bool destroyed, moving, airborne;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        CheckMovement();
    }

    private void CheckMovement()
    {
        if (rigidBody == null)
            return;

        if (rigidBody.velocity.magnitude > 0)
            moving = true;
        else
            moving = false;

        UpdateValues();
    }

    public void UpdateValues()
    {
        if(statement != null)
            StatementsManager.Instance.CheckStatement(statement);
    }

    private void OnCollisionStay(Collision collision)
    {
        airborne = false;
        UpdateValues();
    }

    private void OnCollisionExit(Collision collision)
    {
        airborne = true;
        UpdateValues();
    }
}