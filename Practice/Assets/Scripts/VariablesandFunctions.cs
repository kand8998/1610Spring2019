using UnityEngine;

public class VariablesandFunctions : MonoBehaviour 
{

	//Unity Tutorial Variables and Functions

	private int PlayerScore = 5;
	private void Start ()
	{
		PlayerScore = MultiplyByTwo(PlayerScore);
		Debug.Log(PlayerScore);
	}

	protected virtual int MultiplyByTwo(int number)
	{
		var result = number * 5;
		return result;
	}
}
