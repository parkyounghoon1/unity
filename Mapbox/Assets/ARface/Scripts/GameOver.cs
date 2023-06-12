using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    private bool timer = false;
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject GO;

    [SerializeField] GameObject gameOverText;
    [SerializeField] GameObject gameStartButton;
    [SerializeField] float maxTime = 5f;
    float timeLeft;
    Image timerBar;
    public static bool gameStarted;

    void Start()
    {
        gameStarted = false;

        A.SetActive(false);
        B.SetActive(false);
        C.SetActive(false);
        GO.SetActive(false);
        gameOverText.SetActive(false);
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    public void StartGame()
    {
        gameStartButton.SetActive(false);
        Countdown(); 
    }

    void Countdown()
    {
        StartCoroutine(CountdownCoroutine());
    }

    IEnumerator CountdownCoroutine()
    {
        yield return new WaitForSeconds(1.0f);
        C.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        C.SetActive(false);
        B.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        B.SetActive(false);
        A.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        A.SetActive(false);
        GO.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        GO.SetActive(false);
        gameStarted = true;

        timer = true;

       yield return new WaitForSeconds(5f);
        
        GameOverSequence();
    }

    void Update()
    {
        if (timer == true)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                timerBar.fillAmount = timeLeft / maxTime;
            }
        }
    }

    void GameOverSequence()
    {
        gameOverText.SetActive(true);
        gameStarted = false;
    }
}
