using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Newt : Amphibian
{

	public float EatingSpeed = 0.5f;
	public bool CanEat = true;
	public IntData Distance; 
	
	void Start () 
	{
		GetComponent<SpriteRenderer>().color = SkinColor;
	}
	
	void Update () 
	{
		transform.Translate(-1,0,0);

}
}
