using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SingleFire : Weapon
{ 
    [SerializeField] private Projectile bullet;
    protected override void StartShooting(XRBaseInteractor interactor)
    {
        base.StartShooting(interactor);
        Shoot();
    }
    protected override void StopShooting(XRBaseInteractor interactor)
    {
        base.StopShooting(interactor);
    }
    protected override void Shoot()
    {
        base.Shoot();
        Projectile projectileInstantiate = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
        projectileInstantiate.Init(this);
        projectileInstantiate.Launch();
    }


}
