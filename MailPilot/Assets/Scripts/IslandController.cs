using UnityEngine;
using System.Collections;

public class IslandController : MonoBehaviour {

	[SerializeField]
	private float speed;

	private Transform _transform;
	private Vector2 _currentPosition;

	private float minx = -3f;
	private float maxx = 3f;

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
		float xpos = Random.Range (minx, maxx);
		float ypos = Random.Range (5.3f, 20f);
		_currentPosition = new Vector2 (xpos, ypos);
		_transform.position = _currentPosition;
	}
}
