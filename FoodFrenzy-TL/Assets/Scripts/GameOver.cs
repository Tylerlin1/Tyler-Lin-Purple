using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject screenParent;
    public GameObject scoreParent;
    public Text loseText;
    public Text scoreText;
    public Image[] stars;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        screenParent.SetActive(false);

        for(int i = 0; i < stars.Length; i++)
        {
            stars[i].enabled = false;
        }

        animator = GetComponent<Animator>();
    }

    public void ShowLose(int score)
    {
        screenParent.SetActive(true);
        screenParent.SetActive(false);
        loseText.enabled = true;
        scoreText.text = score.ToString();
        scoreText.enabled = true;

        if (animator)
        {
            animator.Play("GameOverDisplay");
        }
    }

    public void ShowWin(int score, int starCount)
    {
        Debug.Log(score);
        screenParent.SetActive(true);
        scoreParent.SetActive(true);
        loseText.enabled = false;
        scoreText.text = score.ToString();
        scoreText.enabled = true;

        if (animator)
        {
            animator.Play("GameOverDisplay");
        }

        StartCoroutine(ShowWinCoroutine(starCount));
    }

    private IEnumerator ShowWinCoroutine(int starCount)
    {
        yield return new WaitForSeconds(0.5f);

        if(starCount < stars.Length)
        {
            for (int i = 0; i <= starCount; i++)
            {
                stars[i].enabled = true;

                if(i > 0)
                {
                    stars[i - 1].enabled = false;
                }

                yield return new WaitForSeconds(0.5f);
            }
        }

        scoreText.enabled = true;
    }

    public void OnReplayClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnDoneClicked()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
