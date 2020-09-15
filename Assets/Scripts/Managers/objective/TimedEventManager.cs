using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimedEventManager : GameTypeManager
{
    //instantiates
    public GameObject timeWidget;
    public GameObject splitUIPrefab;

    //static vars
    [SerializeField]
    public float timeGoalSeconds;
    public float passengerCountGoal;
    public static float defaultBestTimeSeconds = 600f; //always 15 mins

    //dynamic vars
    public bool runActive;
    public float currentTimeSeconds;
    private int splitCount;

    public List<LapTime> allAttempts = new List<LapTime>();

    public LapTime currentAttempt;
    public LapTime lastAttempt;
    public LapTime bestAttempt;

    //UI
    private Text timeToBeatTxt;
    private Text currentTimeTxt;
    private Text bestAttemptTxt;
    private Text lastAttemptTxt;

    private List<SplitUI> splitUIs = new List<SplitUI>();




    protected override void initializeGameManager()
    {
        base.initializeGameManager();
        GameObject widget = Instantiate(timeWidget, GameObject.FindObjectOfType<Canvas>().transform);
        timeToBeatTxt = widget.transform.Find("TimeToBeat").gameObject.GetComponent<Text>();
        currentTimeTxt = widget.transform.Find("CurrentTime").gameObject.GetComponent<Text>();
        bestAttemptTxt = widget.transform.Find("BestAttempt").gameObject.GetComponent<Text>();
        lastAttemptTxt = widget.transform.Find("LastAttempt").gameObject.GetComponent<Text>();

       

        timeToBeatTxt.text = TimeUtility.convertFloatToTimeString(timeGoalSeconds);
        currentTimeTxt.text = "-";
        bestAttemptTxt.text = "-";
        lastAttemptTxt.text = "-";

        SplitTrigger[] splits = FindObjectsOfType<SplitTrigger>();
        //print("splits: " + splits.Length);
        splitCount = splits.Length;
        //Debug.Log("split count: " + splitCount);
        for (int i = 0; i < splitCount; i++)
        {
            GameObject splitUI = Instantiate(splitUIPrefab, widget.transform);

            RectTransform rectTransform = splitUI.GetComponent<RectTransform>();
            rectTransform.position += new Vector3(0, (i *-25), 0);
            splitUIs.Add(splitUI.GetComponent<SplitUI>());
            splitUI.transform.Find("SplitNumber").GetComponent<Text>().text = i.ToString();
        }


        disableUnusedSplits();
        clearCurrentSplits();
    }
    private void disableUnusedSplits()
    {
       for (int i = 0; i < splitUIs.Count; i++)
        {
            if (i > splitCount)
                splitUIs[i].gameObject.SetActive(false);
        }
    }
    protected override void Update()
    {
        base.Update();
        if (runActive)
        {
            currentTimeSeconds += Time.deltaTime;
            currentTimeTxt.text = TimeUtility.convertFloatToTimeString(currentTimeSeconds);
        }
    }

    public void startAttempt()
    {
        clearCurrentSplits();
        runActive = true;
        currentTimeSeconds = 0;
        currentAttempt = new LapTime();
        currentAttempt.splitIndex = 0;
    }

    public void endAttempt(int passengerCount)
    {
        if (runActive == true)
        {
            runActive = false;
            //verify they hit all the checkpoints
            submitCurrentTime(passengerCount);
        }
    }

    public void submitCurrentTime(int passengerCount)
    {
        currentAttempt.time = currentTimeSeconds;
        bool isValidTime = TimeUtility.validateTime(currentAttempt, splitCount);
        if (isValidTime)
        {
            lastAttempt = currentAttempt;
            lastAttemptTxt.text = TimeUtility.convertFloatToTimeString(lastAttempt.time);
            allAttempts.Add(lastAttempt);
            if (lastAttempt.time < timeGoalSeconds && passengerCount >= passengerCountGoal)
            {
                transmitGameMessage("WINNER!", "Press F to pay respects.", 3);
            }
            else
                transmitGameMessage("LOSER!", 3);

            if (bestAttempt == null)
                updateBestAttempt(lastAttempt);

            updateBestAttempt(TimeUtility.compareTimesForBest(allAttempts, bestAttempt));
        }
        else
        {
            transmitGameMessage("INVALID TIME!", 3);
        }
        return;
    }

    private void updateBestAttempt(LapTime newBestAttempt)
    {
        bestAttempt = newBestAttempt;
        bestAttemptTxt.text = TimeUtility.convertFloatToTimeString(bestAttempt.time);
        updateBestSplits(bestAttempt);
    }

    //new lap
    public void cycleAttempt(int passengerCount)
    {
        endAttempt(passengerCount);
        startAttempt();
    }


    public void checkpoint(int index, int passengerCount)
    {
        //valid 
        if (currentAttempt.splitIndex == (index - 1))
        {
            currentAttempt.splitIndex += 1;
        }
        Split currentSplit = new Split();
        currentSplit.index = index;
        currentSplit.time = currentTimeSeconds;
        currentSplit.passengerCount = passengerCount;

        currentAttempt.splits.Add(currentSplit);
        updateCurrentSplit(currentSplit);

        //update splits UI
    }
    private void updateCurrentSplit(Split currentSplit)
    {
        SplitUI currentSplitUI = splitUIs[currentSplit.index - 1];
        currentSplitUI.currentSplit.text = TimeUtility.convertFloatToTimeString(currentSplit.time);
        currentSplitUI.passengerCount.text = currentSplit.passengerCount.ToString();
        if (bestAttempt != null)
        {
            if (bestAttempt.splits[currentSplit.index - 1].time < bestAttempt.splits[currentSplit.index - 1].time)
                currentSplitUI.currentSplit.color = Color.red;
            else
                currentSplitUI.currentSplit.color = Color.green;
        }



    }

    private void updateBestSplits(LapTime lap)
    {
        
        for(int i = 0; i < lap.splits.Count; i++)
        {
            splitUIs[i].bestSplit.text = TimeUtility.convertFloatToTimeString(lap.splits[i].time);
        }
    }

    private void clearCurrentSplits()
    {
        foreach (SplitUI splitUI in splitUIs)
        {
            splitUI.currentSplit.text = "-";
            splitUI.currentSplit.color = Color.white;
        }
    }
}
