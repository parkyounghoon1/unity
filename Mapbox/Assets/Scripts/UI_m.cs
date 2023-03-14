using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_m : MonoBehaviour
{
    [SerializeField] Text pointText;
    [SerializeField] private GameObject menu;

    void Update()
    {
        updatePoint();
    }

    public void updatePoint()
    {
        pointText.text = GameManager.Instance.CurrentPlayer.Point.ToString();
    }

    public void btn_click()
    {
        LoadingSceneController.LoadScene(m_Contents.SCENE_CAPTURE);
    }

    public void exitMenu()
    {
        menu.SetActive(false);
    }
}
