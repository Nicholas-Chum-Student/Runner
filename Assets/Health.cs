using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 3;

    public void Damage(int dmg)
    {
        health -= dmg;
        GameFeel.AddCameraShake(0.1f);

        if (health <= 0)
        {
            GameManager.instance.Restart();
        }
    }

    public static void TryDamage(GameObject target, int dmg)
    {
        Health targetHealth = target.GetComponent<Health>();

        if (targetHealth) 
        {
            targetHealth.Damage(dmg);
        }
    }
}
