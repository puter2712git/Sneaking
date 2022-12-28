using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
	/* Detect WASD input */
	public float horizontalMove { private set; get; }
	public float verticalMove { private set; get; }

	private void Update()
	{
		/* Get inputs of move */
		horizontalMove = Input.GetAxis("Horizontal");
		verticalMove = Input.GetAxis("Vertical");
	}
}
