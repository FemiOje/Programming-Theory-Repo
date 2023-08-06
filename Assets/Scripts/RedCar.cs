using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCar : VehicleController //INHERITANCE
{
    float maxBrakeTorque = 10000000.0f;
    private void Update()
    {
        maxMotorTorque = 80000.0f;
        maxSteeringAngle = 80.0f;
    }

    protected override void HandleMovement() //POLYMORPHISM(METHOD OVERRIDING)
    { // ALL VEHICLES INHERIT THE HANDLEMOVEMENT METHOD


        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");
        float brake = maxBrakeTorque * Input.GetAxis("Brake"); //POLYMORPHISM

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

                axleInfo.leftWheel.brakeTorque = brake;
                axleInfo.rightWheel.brakeTorque = brake;
            }
        }
    }
}
