using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    protected GameObject target;

    // ENCAPSULATION
    protected virtual Vector3 lookDirection { get; set; }
    public virtual Vector3 LookDirection
    {
        get { return lookDirection; }
        protected set { lookDirection = value; }
    }

    // ENCAPSULATION
    protected virtual string targetName { get; set; }
    public virtual string TargetName
    {
        get { return targetName; }
        protected set { targetName = value; }
    }

    // ENCAPSULATION
    protected virtual float moveSpeed { get; set; }
    public virtual float MoveSpeed
    {
        get { return moveSpeed; }
        protected set { moveSpeed = value; }
    }

    // ABSTRACTION
    protected virtual void Move() {
        transform.Translate(lookDirection * moveSpeed * Time.deltaTime); ;
    }

    // ABSTRACTION
    protected virtual void FindTarget()
    {
        target = GameObject.Find(targetName);
    }
}
