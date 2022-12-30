using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
	private const float ROTATION_X_LIMIT = 90f;

	[SerializeField]
	private Camera _camera;

	private PlayerInput _playerInput;

	private float _mouseXMove;
	private float _mouseYMove;

	private float _xRotation;
	private float _yRotation;

	private float _xSpeed;
	private float _ySpeed;

	private void Awake()
	{
		_playerInput = GetComponent<PlayerInput>();

		_xRotation = 0f;
		_yRotation = 0f;

		_xSpeed = 1f;
		_ySpeed = 1f;
	}

	private void Update()
	{
		Rotate();
	}

	private void Rotate()
	{
		_mouseXMove = _playerInput.mouseXMove * _xSpeed;
		_mouseYMove = _playerInput.mouseYMove * _ySpeed;

		_yRotation += _mouseXMove;
		_xRotation -= _mouseYMove;
		_xRotation = Mathf.Clamp(_xRotation, -ROTATION_X_LIMIT, ROTATION_X_LIMIT);

		transform.eulerAngles = new Vector3(0f, _yRotation, 0f);
		_camera.transform.eulerAngles = new Vector3(_xRotation, transform.eulerAngles.y, 0f);
	}
}
