﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tile_Collision : MonoBehaviour
{
    public Rigidbody2D player, cam;
    public Animator planim;
    public GameObject over;
    public tile_Collision()
    {

    }
    public tile_Collision(Rigidbody2D player, Rigidbody2D cam)
        {
        this.player = player;
        this.cam = cam;
        }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      Debug.Log("collision!");
        singularity();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //TODO
        Debug.Log("you lose");
        singularity();
     
    }
    private void singularity()
    {
        player.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        cam.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        planim.enabled = false;
        over.SetActive(true);
    }
}

