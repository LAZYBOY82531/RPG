using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttacker : MonoBehaviour
{
    [SerializeField] bool debug;
    [SerializeField] float range;
    [SerializeField] int damage;
    [SerializeField, Range(0, 360)] float angle;
    private Animator anim;
    private float cosResult;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        cosResult = Mathf.Cos(angle * 0.5f * Mathf.Deg2Rad);
    }

    public void Attack()
    {
        anim.SetTrigger("Attack");
    }

    private void OnAttack(InputValue value)
    {
        Attack();
    }
    
    public void AttackTiming()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, range);
        foreach (Collider collider in colliders)
        {
            Vector3 dirTarget = (collider.transform.position - transform.position).normalized;
            if (Vector3.Dot(transform.forward, dirTarget) < cosResult)
                continue;

            IHittable hittable = collider.GetComponent<IHittable>();
            hittable?.TakeHit(damage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (!debug)
        {
            return;
        }
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);

        Vector3 rightDir = AngleToDir(transform.eulerAngles.y + angle * 0.5f);
        Vector3 leftDir = AngleToDir(transform.eulerAngles.y - angle * 0.5f);
        UnityEngine.Debug.DrawRay(transform.position, rightDir * range, Color.yellow);
        UnityEngine.Debug.DrawRay(transform.position, leftDir * range, Color.yellow);
    }

    private Vector3 AngleToDir(float angle)
    {
        float radian = angle * Mathf.Deg2Rad;
        return new Vector3(Mathf.Sin(radian), 0, Mathf.Cos(radian));
    }
}
