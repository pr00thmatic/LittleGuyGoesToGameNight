using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class SerializableTransform {
  public Vector3 position;
  public Vector3 localScale;
  public Quaternion rotation;

  public static SerializableTransform Lerp (SerializableTransform a, SerializableTransform b, float value) {
    SerializableTransform lerped = new SerializableTransform();
    lerped.position = Vector3.Lerp(a.position, b.position, value);
    lerped.localScale = Vector3.Lerp(a.localScale, b.localScale, value);
    lerped.rotation = Quaternion.Lerp(a.rotation, b.rotation, value);

    return lerped;
  }
}
