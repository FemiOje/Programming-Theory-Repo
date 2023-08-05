using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AttachVehicleToDropdown : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public GameObject[] vehicleList;
    public GameObject selectedVehicle;

    // Start is called before the first frame update
    void Start()
    {
        dropdown.onValueChanged.AddListener(SelectVehicle);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SelectVehicle(int optionIndex)
    {
        // Check if the option index is valid
        if (optionIndex >= 0 && optionIndex < vehicleList.Length)
        {
            // Get the name of the selected vehicle
            string selectedVehicleName = dropdown.options[optionIndex].text;

            // Save the selected vehicle name to a PlayerPrefs to pass it to the next scene
            PlayerPrefs.SetString("SelectedVehicleName", selectedVehicleName);


            // Get the selected GameObject
            //selectedVehicle = vehicleList[optionIndex];

            // Attach the selected GameObject to this GameObject (script's GameObject)
            //selectedVehicle.transform.SetParent(this.transform, false);
        }
    }
}
