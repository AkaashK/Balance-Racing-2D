using System.Collections;
using UnityEngine;

public class carcontroller : MonoBehaviour {

    public float speed = 1500;
    public float rotationspeed = 15f;

    public WheelJoint2D backwheel;
    public WheelJoint2D frontwheel;

    public Rigidbody2D rb;
    public float movement = 0f;
    public float rotation = 0f;
    void Update()
    {
        movement = Input.GetAxisRaw("Vertical") * speed;
        rotation = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void FixedUpdate()
    {
        if(movement == 0)
        {
            backwheel.useMotor = false;
            frontwheel.useMotor = false;
        }
        else
        {
            backwheel.useMotor = true;
            frontwheel.useMotor = true;

            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };
            backwheel.motor = motor;
            frontwheel.motor = motor;
        }

        rb.AddTorque(-rotation * rotationspeed * Time.fixedDeltaTime);

    }

}
