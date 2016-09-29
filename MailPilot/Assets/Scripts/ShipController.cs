using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {

	[SerializeField]
	private Vector2 speed = Vector2.zero;

	private Transform _transform;
	private Vector2 _currentPosition;

	//direction: positive when moving right, negative when moving left
	private int direction = 1;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
		Reset ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		_currentPosition = _transform.position;
		Vector2 currSpeed = new Vector2 (speed.x * direction, speed.y);
		_currentPosition -= currSpeed;
		_transform.position = _currentPosition;

		if (_currentPosition.y <= -5.3) {
			Reset ();
		}
	}

	public void Reset(){
		direction = -direction;
		_transform.localScale = new Vector2 (direction, 1);
		_currentPosition = new Vector2 (direction*5f, 5f);
		_transform.position = _currentPosition;
	}
}
