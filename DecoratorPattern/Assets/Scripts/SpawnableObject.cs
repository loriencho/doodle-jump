using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpawnableObject
{
    Vector3 PickPosition();

    void Spawn();

    bool CheckOutOfBounds();
}
