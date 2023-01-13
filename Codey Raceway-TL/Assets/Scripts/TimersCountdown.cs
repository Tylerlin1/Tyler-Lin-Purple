using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;

    public CodeyMove speedVariable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();

        if(totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            GameObject.FindGameObjectWithTag("Player").GetComponent<CodeyMove>().Speed = 0;
        }

        if(totalCountdownTime <= 0)
        {
            startCountdown.text = ("");
            totalLapTime -= Time.deltaTime;
            lapTime.text = Mathf.Round(totalLapTime).ToString();
            GameObject.FindGameObjectWithTag("Player").GetComponent<CodeyMove>().Speed = 300;
        }

        if(totalLapTime < 0)
        {
            print("Time is up!");
        }
    }
}
