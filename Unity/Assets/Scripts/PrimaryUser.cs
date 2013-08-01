using UnityEngine;
using System.Collections;

public class PrimaryUser : MonoBehaviour 
{
	ZigHandSessionDetector _detector;
	
	void Awake()
	{
		//Global.Zig.listeners.Add (gameObject);
		_detector = gameObject.GetComponent<ZigHandSessionDetector>();
	}
	
	void Start() 
	{
		_raptor = GameObject.Find ("HelloRaptor");
		_raptor.SetActive(false);
	}
	
	void Update()
	{
	}
	
	float _waveTime, _waveDisplayTime = 3;
	GameObject _raptor;
	
	public void HandWaved(ZigTrackedUser user)
	{
		_waveTime = Time.time;
		_raptor.SetActive (true);
	}
	
	void OnGUI()
	{
		var delta = Time.time - _waveTime;
		if (delta > _waveDisplayTime)
		{
			_raptor.SetActive(false);
			return;
		}
		GUI.Label(new Rect(Screen.width/2, Screen.height/2, 200, 100), "Rawwr! Om nom nom nom!");
	}
	
	void Zig_UserFound(ZigTrackedUser user)
	{
	}
	
	void Zig_UserLost(ZigTrackedUser user)
	{
	}
	
	void Zig_Update(ZigInput input)
	{
	}
}
