using System;
using UnityEngine;

public class Droper : MonoBehaviour
{
    [SerializeField] float ChangeTime = 5f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();
        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;

    }
    void Update()
    {
        if (Time.time > ChangeTime)
        {
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;



        }

    }



}
