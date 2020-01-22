﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platform2DUtils.GameplaySystem;

public class Player : Character2D
{
    void Start()
    {
        
    }
    
    void Update()
   {
       GameplaySystem.TMovementDelta(transform, moveSpeed);
   }

    void LateUpdate()
    {
        spr.flipX = FlipSprite;
        anim.SetFloat("moveX", Mathf.Abs(GameplaySystem.Axis.x));
    }


}