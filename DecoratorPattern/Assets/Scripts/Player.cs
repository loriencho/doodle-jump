using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IPoweredupPlayer
{
    public void Apply(){
        return; // base player has no powerup
    }
}
