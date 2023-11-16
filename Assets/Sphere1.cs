using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Sphere1 : MonoBehaviour
{

    private Rigidbody myRigidBody;

    public float speedX = -30;
    public float speedY = 10;
    public float speedZ = -30;





    // Start is called before the first frame update
    void Start()
    {

        myRigidBody = this.gameObject.GetComponent<Rigidbody>();

        UnityEngine.Vector3 force = new UnityEngine.Vector3(speedX, speedY, speedZ);

        myRigidBody.AddForce(force);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
