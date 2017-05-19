using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timerCS : MonoBehaviour {

  private float timeLeft;
  private float roundedtime;

  private string displayTime;

  private bool win;

  public GameObject timer;
  public GameObject gameOverParent;
  Text Timer;
	public Text gameOverText;


	void Start() {
    Timer = GetComponent<Text>();
    timeLeft = 120f;
    roundedtime = 0.0f;
	}
	
	void Update() {
    if(roundedtime < 0) {
      roundedtime = 0;
    }

    if (timeLeft <= 0) {
      		gameOverParent.SetActive(true);
			Main.m.paused = true;
			gameOverText.text = Main.m.score.ToString();
    }

    // PlayerPrefs.SetFloat("Score", score);
	}

  void FixedUpdate() {
    timeLeft -= Time.deltaTime;
    roundedtime = (float)System.Math.Round(timeLeft, 0);
    if (roundedtime <= 0) {
      roundedtime = 0;
    }
    displayTime = FloatToTime((float)roundedtime, "#0:00");
    Timer.text = displayTime;
  }

  public string FloatToTime (float toConvert, string format){
    switch (format){
      // case "00.0":
      //   return string.Format("{0:00}:{1:0}", 
      //     Mathf.Floor(toConvert) % 60,//seconds
      //     Mathf.Floor((toConvert*10) % 10));//miliseconds
      // break;
      // case "#0.0":
      //   return string.Format("{0:#0}:{1:0}", 
      //     Mathf.Floor(toConvert) % 60,//seconds
      //     Mathf.Floor((toConvert*10) % 10));//miliseconds
      // break;
      // case "00.00":
      //   return string.Format("{0:00}:{1:00}", 
      //     Mathf.Floor(toConvert) % 60,//seconds
      //     Mathf.Floor((toConvert*100) % 100));//miliseconds
      // break;
      case "#0:00":
        return string.Format("{0:#0}:{1:00}",
          Mathf.Floor(toConvert / 60),//minutes
          Mathf.Floor(toConvert) % 60);//seconds
      break;
    }
    return "error";
  }
}
