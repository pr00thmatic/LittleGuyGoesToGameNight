using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraSwitchingTriggerPairMember : MonoBehaviour {
  [field: SerializeField] public PointOfView TargetCamera { get; private set; }

  void OnTriggerEnter (Collider c) {
    if (c.GetComponentInParent<PlayerTag>()) {
      TargetCamera.IsLive = true;
    }
  }
}
