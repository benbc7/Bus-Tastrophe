using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusPassengerTracker : MonoBehaviour
{
    private VehicleController vehicleController;

    public int passengerCount;

    [SerializeField]
    List<Collider> passengerList = new List<Collider>();

    private void Start()
    {
        vehicleController = GetComponent<VehicleController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!passengerList.Contains(other) && other.tag == "Passenger")
        {
            passengerList.Add(other.GetComponent<Collider>());
            passengerCount = passengerList.Count;
            vehicleController.updatePassengerCount(passengerCount);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (passengerList.Contains(other) && other.tag == "Passenger")
        {
            passengerList.Remove(other.GetComponent<Collider>());
            passengerCount = passengerList.Count;
            vehicleController.updatePassengerCount(passengerCount);
        }
    }
}
