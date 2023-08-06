using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : VehicleController //INHERITANCE
{
    private void Update()
    {
        maxMotorTorque = 5000.0f;
        maxSteeringAngle = 80.0f;
    }
}
