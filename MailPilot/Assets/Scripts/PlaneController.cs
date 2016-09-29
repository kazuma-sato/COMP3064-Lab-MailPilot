using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {

	[SerializeField]
	private float speed;

	private Transform _transform;
	private Vector2 _currentPosition;
	private float _playerInput;

	// Use this for initialization
	void Start () {
	
		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		_playerInput = Input.GetAxis ("Horizontal");
		_currentPosition = _transform.position;
		//move right
		if (_playerInput > 0) {
			_currentPosition += new Vector2 (speed, 0);
		}
		//move left
		if (_playerInput < 0) {
			_currentPosition -= new Vector2 (speed, 0);
		}
		//fix bounds
		checkBounds ();
		_transform.position = _currentPosition;
	}


	private void checkBounds(){
	
		if (_currentPosition.x < -2.9f) {
			_currentPosition.x = -2.9f;
		}
		if (_currentPosition.x > 2.9f) {
			_currentPosition.x = 2.9f;
		}
	}

}
