using UnityEngine;
using System.Collections;

public class Player{
	private int _points = 0;
	private int _health = 100;

	public HUDController hud;

	private static Player _instance = null;
	public static Player Instance{
		get{ 
			if (_instance == null) _instance = new Player();
			return _instance;
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
		}
	}

}
