using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject AIControl;
    
    void Start()
    {
        CarControl.GetComponent<CarController> ().enabled = true;
        AIControl.GetComponent<CarController> ().enabled = true;
    }
}
