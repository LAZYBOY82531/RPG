using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HittableAdaptor : MonoBehaviour, IHittable
{
    public UnityEvent OnInteract;


    public void TakeHit(int damage)
    {
        OnInteract.Invoke();
    }
}
