using UnityEngine;
using System.Collections;


public class ScoreUI : MonoBehaviour {
	
	public int scorePlayerRight;
	
	public int scorePlayerLeft;
	
	public GUIStyle style;

	
	public int winningScore;

    void Start()
    {
        winningScore = PlayerPrefs.GetInt("MaxScore", 15);
    }

    void OnGUI()
	{
		float x = Screen.width/2f;
		float y = 30f;
		float width = 300f;
		float height = 20f;
		string text = scorePlayerLeft + " - " + scorePlayerRight;
		
		
		GUI.Label(new Rect(x-(width/2f), y, width, height), text, style);

		
		if (scorePlayerLeft >= winningScore || scorePlayerRight >= winningScore)
		{
			
			GameObject ball = GameObject.Find("Ball");
			if (ball != null)
			{
				ball.SetActive(false);
			}

			
			string winMessage = "Player Down won";
			if (scorePlayerRight >= winningScore)
			{
				winMessage = "Player Up won";
			}

			
			y = Screen.height/2f;
			GUI.Label(new Rect(x-(width/2f), y+(height/2f), width, height), winMessage, style);
		}

	}
}
