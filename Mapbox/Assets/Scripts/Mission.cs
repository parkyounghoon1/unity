using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mission : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private GameObject menu;

    private void Start()
    {
        menu.SetActive(false);
    }

    private void OnMouseDown()
    {
        menu.SetActive(!menu.activeSelf);
        //LoadingSceneController.LoadScene(m_Contents.SCENE_CAPTURE);
        canvas.sortingOrder = 1;
    }
}
