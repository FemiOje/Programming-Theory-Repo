using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCar : VehicleController //INHERITANCE
{
    private void Update()
    {
        maxMotorTorque = 7000.0f;
        maxSteeringAngle = 80.0f;
    }
}
