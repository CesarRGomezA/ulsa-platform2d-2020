﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platform2DUtils.GameplaySystem;
using Platform2DUtils.MemorySystem;

public class Player : Character2D
{
    [SerializeField]
    float maxVel;

    void Start()
    {
        //Gamemanager.instance.gameData.Player = this;
        //Gamemanager.instance.Save();
        transform.position = Gamemanager.instance.gameData.PlayerPos;
    }

    public Player()
    {
        
    }

    void FixedUpdate() 
    {
         if(GameplaySystem.JumpBtn)
        {
                if(Grounding)
            {
                Gamemanager.instance.gameData.PlayerPos = transform.position;
                //Debug.Log(Gamemanager.instance.gameData.Player);
                //Gamemanager.instance.Save();
                GameData gd = Gamemanager.instance.gameData;
                MemorySystem.SaveData(gd, gd.GameName);

                anim.SetTrigger("jump");
                GameplaySystem.Jump(rb2D, jumpForce);
            }
        }
        anim.SetBool("grownding", Grounding);

        //GameplaySystem.MovementAddForce(rb2D, moveSpeed, maxVel, Grounding);
        GameplaySystem.MovementVelocity(rb2D, moveSpeed, maxVel);
        
    }

    
    void Update()
   {
       //GameplaySystem.TMovementDelta(transform, moveSpeed);
       
   }


    void LateUpdate()
    {
        //spr.flipX = FlipSprite;
        IFlip flip = new PlayerFlip();
        spr.flipX = flip.FlipSprite(GameplaySystem.Axis.x, spr);
        anim.SetFloat("moveX", Mathf.Abs(GameplaySystem.Axis.x));        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("collectable"))
        {
            Collectable collectable = other.GetComponent<Collectable>();
           Gamemanager.instance.Score.AddPoints(collectable.Points);
           // score.AddPoints(collectable.Points);
            Destroy(other.gameObject);
        }
    }
}
