using UnityEngine;
using System.Collections;

/// <summary>
/// Flag that indicates the left or right player.
/// </summary>
public enum ePlayer
{
	Left,
	Right
}


public class Player : MonoBehaviour {
	
	
	public float speed = 15f;
	
	public ePlayer player;
	
	
	void FixedUpdate () 
	{
		// input speed of keyboard from -1 to 1
		float inputSpeed = 0f;
		if (player == ePlayer.Left)
		{
			inputSpeed = Input.GetAxisRaw("PlayerLeft");
		}
		else if (player == ePlayer.Right)
		{
			inputSpeed = Input.GetAxisRaw("PlayerRight");
		}

        // moves player along the z axis

        var pos = transform.position;
        pos.z = Mathf.Clamp(transform.position.z, -4.5f, 4.5f);
        transform.position = pos;
        transform.position += new Vector3(0f, 0f, inputSpeed * speed * Time.deltaTime);

        if (Input.GetKeyDown("r"))
        {
          Application.LoadLevel("Tennis");
        }
    }
}
