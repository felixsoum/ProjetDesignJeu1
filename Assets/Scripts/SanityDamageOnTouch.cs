using MoreMountains.CorgiEngine;
using MoreMountains.Feedbacks;
using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanityDamageOnTouch : DamageOnTouch
{
    public int SanityDamageCaused = 10;

    protected override void OnCollideWithDamageable(Health health)
    {
        SanityHealth sanityHealth = health as SanityHealth;
        if (sanityHealth != null)
        {
            sanityHealth.Damage(SanityDamageCaused);
        }

        base.OnCollideWithDamageable(health);
    }
}
