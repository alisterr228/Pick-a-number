using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class saveData : MonoBehaviour
{
    private int recordScore;

    public int PubRecordScore
    {
        get
        {
            return recordScore;
        }
        set
        {
            if (value >= 0)
                recordScore = value;
        }
    }

    private void Start()
    {
        Load();
    }

    private void Load()
    {
        string key = "saveGame";

        if (PlayerPrefs.HasKey(key))
        {
            recordScore = PlayerPrefs.GetInt(key);
        }
    }

    public void PubSave()
    {
        Save();
    }

    private void Save()
    {
        string key = "saveGame";

        PlayerPrefs.SetInt(key, recordScore);
        PlayerPrefs.Save();
    }

}

