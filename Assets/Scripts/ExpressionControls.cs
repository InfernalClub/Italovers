using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpressionControls : MonoBehaviour
{
    [SerializeField] public Animator anim;

    public void SetExpressionDefault()
    {
        anim.SetTrigger("Default");
    }


    public void SetExpressionHappy()
    {
        anim.SetTrigger("JOY");
    }

    public void SetExpressionAngry()
    {
        anim.SetTrigger("Angry");
    }


    public void SetExpressionSUS()
    {
        anim.SetTrigger("Sus");
    }

    public void SetExpressionSad()
    {
        anim.SetTrigger("Sad");
    }

    public void SetCurrentStatus()
    {
        anim.SetTrigger("Idle");
    }

    public void SetCurrentStatusDance()
    {
        anim.SetTrigger("Dance");
    }

    public void SetCurrentStatusFortnite()
    {
        anim.SetTrigger("Fortnite");
    }

    public void SetCurrentStatusHand()
    {
        anim.SetTrigger("Hand");
    }

    public void SetCurrentStatusloop()
    {
        anim.SetTrigger("Simpleloop");
    }

    public void SetExpressionAstonish()
    {
        anim.SetTrigger("Astonish");
    }

}
