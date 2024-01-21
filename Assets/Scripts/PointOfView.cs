using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;

public class PointOfView : MonoBehaviour {
  public static PointOfView Current { get; set; }

  public CinemachineVirtualCamera cam;

  public bool IsLive {
    get => cam.Priority == 20;
    set {

      if (value) {
        if (Current) Current.IsLive = false;
        Current = this;
      } else if (Current == this) {
        Current = null;
      }

      cam.Priority = value ? 20 : 10;
    }
  }

  public Vector3 Right (Transform target) =>
    Vector3.Cross(Vector3.up, Forward(target)).normalized;

  public Vector3 Forward (Transform target) =>
    Vector3.Scale(new Vector3(1,0,1), target.position - Camera.main.transform.position).normalized;

  void OnEnable () {
    if (IsLive)
      Current = this;
  }
}
