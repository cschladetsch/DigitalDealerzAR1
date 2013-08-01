using UnityEngine;
using System.Collections;

public class Global : MonoBehaviour 
{
	public static Zig Zig;
	
	void Awake() 
	{
		Zig = FindObjectOfType(typeof(Zig)) as Zig;
		if (Zig == null)
			throw new System.Exception("Skeleton tracker not found");
	}

	void Update() 
	{
	}
}
