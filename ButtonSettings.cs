using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonSettings: MonoBehaviour
{
    public List<Button> buttonNum = new List<Button>();
    public List<Sprite> mainPhone = new List<Sprite>();
    public GameObject mainPanel;
    public Button reloadGame;

    private int count;
    private int[] numsLength = new int[25];
    private int nextPhone;

    public int[] pubNumsLength {

        get
        {
            return numsLength;
        }
        set
        {
            if(value.Length > numsLength.Length)
                numsLength = value;
        }
    }

    public int pubCount {

        get
        {
            return count;
        }
    }

    private void Start()
    {
        buttonNum[0].onClick.AddListener(Button1);
        buttonNum[1].onClick.AddListener(Button2);
        buttonNum[2].onClick.AddListener(Button3);
        buttonNum[3].onClick.AddListener(Button4);
        buttonNum[4].onClick.AddListener(Button5);
        buttonNum[5].onClick.AddListener(Button6);
        buttonNum[6].onClick.AddListener(Button7);
        buttonNum[7].onClick.AddListener(Button8);
        buttonNum[8].onClick.AddListener(Button9);
        buttonNum[9].onClick.AddListener(Button10);
        buttonNum[10].onClick.AddListener(Button11);
        buttonNum[11].onClick.AddListener(Button12);
        buttonNum[12].onClick.AddListener(Button13);
        buttonNum[13].onClick.AddListener(Button14);
        buttonNum[14].onClick.AddListener(Button15);
        buttonNum[15].onClick.AddListener(Button16);
        buttonNum[16].onClick.AddListener(Button17);
        buttonNum[17].onClick.AddListener(Button18);
        buttonNum[18].onClick.AddListener(Button19);
        buttonNum[19].onClick.AddListener(Button20);
        buttonNum[20].onClick.AddListener(Button21);
        buttonNum[21].onClick.AddListener(Button22);
        buttonNum[22].onClick.AddListener(Button23);
        buttonNum[23].onClick.AddListener(Button24);
        buttonNum[24].onClick.AddListener(Button25);

        reloadGame.onClick.AddListener(ReloadGame);

        nextPhone = Random.Range(0, 3);
        mainPanel.GetComponent<Image>().sprite = mainPhone[nextPhone];
    }

    private void ReloadGame()
    {
        SceneManager.LoadScene(0);
    }

    private void Button1()
    {
        count = numsLength[0];
    }

    private void Button2()
    {
        count = numsLength[1];
    }

    private void Button3()
    {
        count = numsLength[2];
    }

    private void Button4()
    {
        count = numsLength[3];
    }

    private void Button5()
    {
        count = numsLength[4];
    }

    private void Button6()
    {
        count = numsLength[5];
    }

    private void Button7()
    {
        count = numsLength[6];
    }

    private void Button8()
    {
        count = numsLength[7];
    }

    private void Button9()
    {
        count = numsLength[8];
    }

    private void Button10()
    {
        count = numsLength[9];
    }

    private void Button11()
    {
        count = numsLength[10];
    }

    private void Button12()
    {
        count = numsLength[11];
    }

    private void Button13()
    {
        count = numsLength[12];
    }

    private void Button14()
    {
        count = numsLength[13];
    }

    private void Button15()
    {
        count = numsLength[14];
    }

    private void Button16()
    {
        count = numsLength[15];
    }

    private void Button17()
    {
        count = numsLength[16];
    }

    private void Button18()
    {
        count = numsLength[17];
    }

    private void Button19()
    {
        count = numsLength[18];
    }

    private void Button20()
    {
        count = numsLength[19];
    }

    private void Button21()
    {
        count = numsLength[20];
    }

    private void Button22()
    {
        count = numsLength[21];
    }

    private void Button23()
    {
        count = numsLength[22];
    }

    private void Button24()
    {
        count = numsLength[23];
    }

    private void Button25()
    {
        count = numsLength[24];
    }
}
