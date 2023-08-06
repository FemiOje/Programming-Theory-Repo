using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : VehicleController //INHERITANCE
{
    private void Update()
    {
        maxMotorTorque = 5000.0f;
        maxSteeringAngle = 60.0f;
    }
}
