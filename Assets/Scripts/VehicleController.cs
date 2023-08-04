using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VehicleController : MonoBehaviour
{
    public List<AxleInfo> axleInfos; // the information about each individual axle
    private float maxMotorTorque = 4000.0f; // maximum torque the motor can apply to wheel
    private float maxSteeringAngle = 70.0f; // maximum steer angle the wheel can have

    public void FixedUpdate()
    {
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");

        foreach (AxleInfo axleInfo in axleInfos)
        {
            if (axleInfo.steering)
            {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            if (axleInfo.motor)
            {
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;

                //axleInfo.leftWheel.brakeTorque = motor;
                //axleInfo.rightWheel.brakeTorque = motor;
            }
        }
    }
}

[System.Serializable]
public class AxleInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor; // is this wheel attached to motor?
    public bool steering; // does this wheel apply steer angle?
}


