using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    [SerializeField] float multiplier;
    [SerializeField] Color[] colors;
    Renderer bumperRenderer;
    Animator animator;

    int currentColor;
    private void Start() {
        animator = GetComponent<Animator>();
        bumperRenderer = GetComponent<Renderer>();
        bumperRenderer.material.color = colors[currentColor];
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Ball"){

            Rigidbody ballRB = other.gameObject.GetComponent<Rigidbody>();
            ballRB.velocity *= multiplier;

            animator.SetTrigger("GetHit");

            currentColor = (currentColor + 1) % colors.Length;
            bumperRenderer.material.color = colors[currentColor];
        }
    }
}
