using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MyOwnAndAwesomeCinematicCamera : MonoBehaviour {
  public Animator animator;
  public Transform target;
  public float speedFactor = 0.1f;

  public Vector3 currentPos;

  void OnEnable () {
    currentPos = target.position;
  }

  void FixedUpdate () {
    currentPos = Vector3.Lerp(currentPos, target.position, Time.deltaTime * speedFactor);
    animator.SetFloat("X", target.position.x);
    animator.SetFloat("Z", target.position.z);
  }
}
