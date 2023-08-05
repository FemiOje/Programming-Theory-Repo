using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VehicleInstantiator : MonoBehaviour
{
    public GameObject[] vehicles;

    private void Start()
    {
        // Get the selected vehicle name from PlayerPrefs
        string selectedVehicleName = PlayerPrefs.GetString("SelectedVehicleName");

        // Find the corresponding GameObject from the array based on the selected name
        GameObject selectedVehiclePrefab = null;
        foreach (GameObject vehicle in vehicles)
        {
            if (vehicle.name == selectedVehicleName)
            {
                selectedVehiclePrefab = vehicle;
                break;
            }
        }

        // Instantiate the selected vehicle
        if (selectedVehiclePrefab != null)
        {
            Instantiate(selectedVehiclePrefab, transform.position, transform.rotation);
        }
        else
        {
            Debug.LogError("Selected vehicle not found!");
        }
    }
}
