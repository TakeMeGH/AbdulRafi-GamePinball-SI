using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    [SerializeField] float multiplier;
    [SerializeField] Color[] colors;
    [SerializeField] float poin = 10;
    AudioManager audioManager;
    ScoreManager scoreManager;

    VFXManager VFXManager;
    Renderer bumperRenderer;
    Animator animator;

    int currentColor;
    private void Start() {
        animator = GetComponent<Animator>();
        bumperRenderer = GetComponent<Renderer>();
        bumperRenderer.material.color = colors[currentColor];
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        VFXManager = GameObject.FindGameObjectWithTag("VFXManager").GetComponent<VFXManager>();
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Ball"){

            Rigidbody ballRB = other.gameObject.GetComponent<Rigidbody>();
            ballRB.velocity *= multiplier;

            animator.SetTrigger("GetHit");

            currentColor = (currentColor + 1) % colors.Length;
            bumperRenderer.material.color = colors[currentColor];
            audioManager.PlaySFX(other.transform.position);
            VFXManager.PlayVFX(other.transform.position);
            scoreManager.AddScore(poin);
        }
    }
}
