using UnityEngine;
using System.Collections;

public class Player{
	private const string key = highScore;

	private int _points = 0;
	private int _health = 100;
	private int _highScore = 0;
	public HUDController hud;

	private static Player _instance = null;
	public static Player Instance{
		get{ 
			if (_instance == null) _instance = new Player();
			return _instance;
		}

	}

	private Player(){
		if (PlayerPrefs.HasKey (key)) {
			_highScore = PlayerPrefs.GetInt (key);
		}
	}

	public int points { 
		get{ return _points;}
		set{ 
			_points = value;
			hud.UpdatePoints();
		}
	}
	public int health{
		get{ return _health;}
		set{ 
			_health = value;
			hud.UpdateHealth();
			if(_health <= 0) hud.GameOver();
		}
	}
	public int highScore{
		get{ return _highScore; }
		set {
			if (value > _highScore) {
				_highScore = value;
				PlayerPrefs.SetInt(key, value);
		}
	}

}
