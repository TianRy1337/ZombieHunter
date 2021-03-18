using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
   [SerializeField] int ammoAmout = 10;
   public int GetCurrentAmmo()
   {
       return ammoAmout;
   }
   public void ReduceCurrentAmmo()
   {
       ammoAmout --;
   }
}
