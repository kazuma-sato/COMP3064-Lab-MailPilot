using UnityEngine;
using System.Collections;

public class OceanController : MonoBehaviour {
	[SerializeField]
	private float speed;

	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
		Reset ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		_currentPosition = _transform.position;

		_currentPosition -= new Vector2 (0, speed);
		_transform.position = _currentPosition;

		if (_currentPosition.y <= -5.3) {
			Reset ();
		}
	}

	private void Reset(){
	
		_currentPosition = new Vector2 (0, 5.3f);
		_transform.position = _currentPosition;
	}
}
