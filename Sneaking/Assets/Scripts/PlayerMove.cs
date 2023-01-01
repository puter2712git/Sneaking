using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	private PlayerInput _playerInput;

	[SerializeField]
	private float moveSpeed;
	private float _horizontalMove;
	private float _verticalMove;

	private Vector3 _moveDir;

	private void Awake()
	{
		_playerInput = GetComponent<PlayerInput>();
	}

	private void FixedUpdate()
	{
		Move();
	}

	private void Move()
	{
		_horizontalMove = _playerInput.horizontalMove;
		_verticalMove = _playerInput.verticalMove;

		_moveDir = new Vector3(_horizontalMove, 0f, _verticalMove).normalized;
		transform.Translate(_moveDir * moveSpeed * Time.deltaTime);
	}
}
