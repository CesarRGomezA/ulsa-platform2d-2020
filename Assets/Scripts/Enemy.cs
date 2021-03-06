﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : Character2D
{
    // Start is called before the first frame update
    
        [SerializeField]

        float moveSpeed = 3.0f;
        [SerializeField]
        float delay;

        float timer;

        [SerializeField]
        Vector2 dir;

    void Update()
    {
        transform.Translate(dir * moveSpeed * Time.deltaTime);

        timer += Time.deltaTime;
        if(timer >= delay)
        {
            timer = 0f;
            //dir = dir == Vector2.right ? Vector2.left : Vector2.right ;
            dir.x = dir.x > 0 ? -1 : 1;
            IFlip flip = new NPCFlip();
            spr.flipX = flip.FlipSprite(dir.x, spr);
            //FlipSprite();
        }
    }

     /*public bool FlipSprite()
     {
         get => dir.x > 0 ? false : true;
     }*/

}
