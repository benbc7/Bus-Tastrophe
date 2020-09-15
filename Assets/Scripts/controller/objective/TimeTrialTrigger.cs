using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TriggerType
{
    START,
    SPLIT,
    FINISH
}

public class TimeTrialTrigger : MonoBehaviour
{
    public TriggerType triggerType;
    public int index;
    private TimedEventManager timeTrialManager;

    void Start()
    {
        timeTrialManager = FindObjectOfType<TimedEventManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        print("trigger hit: " + other.tag);
        if (other.tag == "Player")
        {
            int passengerCount = other.gameObject.GetComponentInParent<BusPassengerTracker>().passengerCount;
            switch (triggerType)
            {
                case TriggerType.START:
                    GameTypeManager.instance.resetObjective();
                    timeTrialManager.startAttempt();
                    break;
                case TriggerType.SPLIT:
                    timeTrialManager.checkpoint(index, passengerCount);
                    break;
                case TriggerType.FINISH:
                    timeTrialManager.endAttempt(passengerCount);
                    break;
                default:
                    Debug.Log("No triggerType");
                    break;
            }
        }
    }
}
