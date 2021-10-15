using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReloadSettings: MonoBehaviour
{
    public List<Sprite> mainPhone = new List<Sprite>();
    public GameObject mainPanel;
    public Button reloadGame;

    private int nextPhone;

    private void Start()
    {
        reloadGame.onClick.AddListener(ReloadGame);

        nextPhone = Random.Range(0, 3);
        mainPanel.GetComponent<Image>().sprite = mainPhone[nextPhone];
    }

    private void ReloadGame()
    {
        SceneManager.LoadScene(0);
    }
}
