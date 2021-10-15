using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumsLogic : MonoBehaviour
{
    public List<Text> NumsTxt = new List<Text>();
    public Slider _timeCount;
    public GameObject timeOutPanel;
    private saveData sd;

    public Text globalNum;
    public Text scoreTxt;
    public Text recordScoreTxt;

    private int score;
    private int[] numsLength = new int[25] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
    private int i;
    private int _i;
    private int lastRecordScore;
    private float time = 10.0f;
    private float timer = 0.5f;

    System.Random rand = new System.Random();

    public int[] PubNumsLength
    {
        get
        {
            return numsLength;
        }
    }

    void Start()
    {
        MixNums();

        sd = gameObject.GetComponent<saveData>();
    }

    private void Update()
    {
        time -= timer * Time.deltaTime;

        if (time <= 0)
        {
            time = 0;
            timeOutPanel.SetActive(true);
            lastRecordScore = sd.PubRecordScore;
        }

        if(score > sd.PubRecordScore && time <= 0)
        {
            sd.PubRecordScore = score;
            sd.PubSave();
        }

        if (buttonDown.PubCount == numsLength[i] && time > 0)
        {
            i = rand.Next(0, numsLength.Length-1);

            score++;
            scoreTxt.text = score + "";
            time = 10.0f;
            timer += 0.1f;

            MixNums();
        }

        if (i == numsLength.Length)
            i = numsLength.Length - 1;

        globalNum.text = numsLength[i] + "";
        recordScoreTxt.text = sd.PubRecordScore + "";
        _timeCount.value = time;
    }


    private void MixNums()
    {
        for (int i = NumsTxt.Count - 1; i >= 0; i--)
        {
            int j = rand.Next(i + 1);

            int temp = numsLength[j];
            numsLength[j] = numsLength[i];
            numsLength[i] = temp;

            NumsTxt[i].text = numsLength[i] + "";
        }
    }
}
