using UnityEngine;
using System.Collections;

public class RaptorAgent : MonoBehaviour
{
	private Animator _anim;
	private float _speed; // this is used to drive anim

	private Vector3 _velocity; // this is used to move model
	private Vector3 _velSmooth;
	private float _smoothTime;

	private void Awake()
	{
		_anim = GetComponent<Animator>();


	}

	public float Accel = 1;//0.05f;

	void Update()
	{
		ParseInput();

		Move();
	}

	void OnGUI()
	{
		GUI.Label(new Rect(10, 10, 400, 100), "LeftControl: Speed");
		GUI.Label(new Rect(10, 30, 400, 100), "SpaceBar: Overlay 'Look Left and Right' animation");
		GUI.Label(new Rect(10, 50, 400, 100), "Speed: " + _speed);

	}

	private void ParseInput()
	{
		var fwd = Input.GetKey(KeyCode.LeftControl);

		if (fwd)
			_speed += Time.deltaTime*Accel;
		else
			_speed -= Time.deltaTime*Accel;

		_speed = Mathf.Clamp01(_speed);

		_anim.SetFloat("Speed", _speed);

		var left = Input.GetKey(KeyCode.LeftShift);
		_anim.SetBool("LookLeft", left);

		var right = Input.GetKey(KeyCode.RightShift);
		_anim.SetBool("LookRight", right);

		var sniff = Input.GetKey(KeyCode.Space);
		_anim.SetBool("Sniff", sniff);

		//_anim.SetBool("Dead", Input.GetKey(KeyCode.D));
	}

	private Transform _target;

	private void Move()
	{
	}
}
