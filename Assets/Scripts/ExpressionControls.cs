using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpressionControls : MonoBehaviour
{
    [SerializeField] private Animator anim;
    
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


}
