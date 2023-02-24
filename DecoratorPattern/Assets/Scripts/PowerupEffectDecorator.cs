using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerupEffectDecorator
{
    private IPoweredupPlayer _player;   
  
    public PowerupEffectDecorator(IPoweredupPlayer player)   
    {   
        this._player = player;   
    }      

   public virtual void Apply(GameObject target)   
   {   
        _player.Apply();   
   }   
    
}
