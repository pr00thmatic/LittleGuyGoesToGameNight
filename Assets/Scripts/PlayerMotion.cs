using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMotion : MonoBehaviour {
  public float speed = 4;
  public Transform motionTarget;

  void FixedUpdate () {
    Vector3 deltaPosition =
      Input.GetAxis("Horizontal") * PointOfView.Current.Right(transform) +
      Input.GetAxis("Vertical") * PointOfView.Current.Forward(transform);

    motionTarget.transform.position += deltaPosition * speed * Time.deltaTime;
  }
}
