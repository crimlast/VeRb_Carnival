using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastProjectile : Projectile
{
    public override void Launch()
    {
        base.Launch();
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Target[] targets = hit.collider.GetComponentsInParent<Target>();
            foreach (var target in targets)
            {
                target.RegisterHit();
            }
        }
    }
}