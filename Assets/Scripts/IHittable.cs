using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public interface IHittable
{
    public void TakeHit(int damage);
}
