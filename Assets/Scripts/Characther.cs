﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characther : MonoBehaviour
{

    SpriteRenderer Sprite;
    Animator Anim;
    // Use this for initialization
    void Start()
    {
        Sprite = GetComponentInChildren<SpriteRenderer>();
        Anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Touch touch;
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            Anim.SetBool("Hit", true);
            if (touch.position.x < Screen.width / 2)
            {
                gameObject.transform.position = new Vector3((float)-1.31, (float)-2.597116, (float)-1);
                Sprite.flipX = false;
            }
            else if (touch.position.x > Screen.width / 2)
            {
                gameObject.transform.position = new Vector3((float)1.31, (float)-2.597116, (float)-1);
                Sprite.flipX = true;
            }
            Anim.SetBool("Hit", false);
        }
    }
}
