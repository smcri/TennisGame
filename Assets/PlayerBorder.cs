using UnityEngine;
using System.Collections;


public class PlayerBorder : MonoBehaviour {
	
	
	public ePlayer player;
	
	public ScoreUI score;
	
	
	void OnCollisionEnter(Collision col)
	{
		
		Ball ball = col.gameObject.GetComponent<Ball>();
		if (ball != null)
		{
			
			ball.transform.position = new Vector3(0f, 1f, 0f);
			
			
			if (player == ePlayer.Right) score.scorePlayerLeft++;
			else if (player == ePlayer.Left) score.scorePlayerRight++;
		}
	}
}
