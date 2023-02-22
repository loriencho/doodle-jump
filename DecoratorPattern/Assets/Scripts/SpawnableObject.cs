using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpawnableObject
{
    Vector3 PickPosition(float minimumHeight);

    void Spawn(float minimumHeight);
    
    void Despawn();

    bool CheckOutOfBounds();
}
