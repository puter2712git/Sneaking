using UnityEngine;

public class PlayerInput : MonoBehaviour
{
	/* Detect WASD input */
	public float horizontalMove { private set; get; }
	public float verticalMove { private set; get; }

	/* Detect mouse move input */
	public float mouseXMove { private set; get; }
	public float mouseYMove { private set; get; }

	private void Update()
	{
		/* Get inputs of move */
		horizontalMove = Input.GetAxisRaw("Horizontal");
		verticalMove = Input.GetAxisRaw("Vertical");

		/* Get inputs of rotate */
		mouseXMove = Input.GetAxisRaw("Mouse X");
		mouseYMove = Input.GetAxisRaw("Mouse Y");
	}
}
