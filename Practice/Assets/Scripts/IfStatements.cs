using UnityEngine;
using UnityEngine.Events;

public class IfStatements : MonoBehaviour {

	//Unity Tutorial
	
	float hotchocolateTemperature = 80.0f;
	private float hotLimitTemperature = 70.0f;
	private float coldLimitTemperature = 40.0f;
	
	public UnityEvent tooHotEvent, tooColdEvent, justRightEvent;

	private void Update () 
	{
		if (!Input.GetKeyDown(KeyCode.Space)) return;
		TemperatureTest();
		hotchocolateTemperature -= Time.deltaTime * 5f;
	}

	private void TemperatureTest()
	{
		if (hotchocolateTemperature > hotLimitTemperature)
		{
			print("Hot Cocoa is too hot.");
			tooHotEvent.Invoke();
		}
		else if (hotchocolateTemperature < coldLimitTemperature)
		{
			print("Hot Cocoa is too cold");
			tooColdEvent.Invoke();
		}
		else
		{
			print("Hot Cocoa is just right");
			justRightEvent.Invoke();
		}
	}
}
