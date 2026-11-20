using System;
using UnityEngine;

public class FoodSizeHandler : SizeHandler
{
   private void OnDestroy()
   {
        Debug.Log(gameObject.name + " DESTROYED");

        SpawnManager.Instance.CleanFoodArray(this);
   }
}
