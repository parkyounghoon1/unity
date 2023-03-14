using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nagagi : MonoBehaviour
{
    public void NagagiBtnClicked()
    {
        GameManager.Instance.CurrentPlayer.Point += 10;
        LoadingSceneController.LoadScene(m_Contents.SCENE_WORLD);
    }

}
