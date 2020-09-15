using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitTrigger : MonoBehaviour
{
    public int splitIndex;
    private TimedEventManager timeTrialManager;

    void Start()
    {
        timeTrialManager = FindObjectOfType<TimedEventManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            int passengerCount = other.gameObject.GetComponentInParent<BusPassengerTracker>().passengerCount;
            timeTrialManager.checkpoint(splitIndex, passengerCount);
        }
    }
}
