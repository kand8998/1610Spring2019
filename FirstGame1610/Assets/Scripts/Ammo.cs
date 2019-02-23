using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : PowerUpBase
{
    private void OnMouseDown(float SubtractValue)
    {
        Value -= SubtractValue;
    }

}
