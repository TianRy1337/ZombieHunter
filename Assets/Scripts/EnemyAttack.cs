using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 40f;

    private void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }
    public void OnDamageTaken()
    {
        Debug.Log(name+" I Know I take damage");
        
    }
    public void AttackHitEvent()
    {
        if(target == null)return;
        target.TakeDamage(damage);
        target.GetComponent<DisPlayDamage>().ShowDamageImpact();
    }
}
