using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class PowerUpSwitch : ScriptableObject
{
		public UnityEvent ShieldEvent, RaccoonEvent, DisguiseEvent;
    	public enum PowerUp
    	{
    		Shield,
    		Raccoon,
    		Disguise
    	}
    	public PowerUp CurrentPowerUp;
    	
    	public void ChangePowerUp(PowerUp newPowerUp)
    	{
    		CurrentPowerUp = newPowerUp;
    	}

        public void Update()
        {
	        switch (CurrentPowerUp)
	        {
		        case PowerUp.Shield:
			        ShieldEvent.Invoke();
			        break;
		        case PowerUp.Raccoon:
			        RaccoonEvent.Invoke();
			        break;
		        case PowerUp.Disguise:
			        DisguiseEvent.Invoke();
			        break;
		        default:
			        throw new ArgumentOutOfRangeException();
	        }
        }


}
