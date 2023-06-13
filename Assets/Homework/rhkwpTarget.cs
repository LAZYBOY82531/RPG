using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rhkwpTarget : MonoBehaviour, IHittable
{
    public void TakeHit(int damage)
    {
        Destroy(gameObject);
    }
}
