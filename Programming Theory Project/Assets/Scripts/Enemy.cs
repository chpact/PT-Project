using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Enemy : Entity
{
    // POLYMORPHISM
    protected override string targetName { get; set; } = "Player";
    protected override float moveSpeed { get; set; } = 5.0f;

    private void Start()
    {
        FindTarget();
    }

    // ABSTRACTION
    private void Update()
    {
        lookDirection = (target.transform.position - transform.position).normalized;
        Move();
    }
}