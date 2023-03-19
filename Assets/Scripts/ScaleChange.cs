using UnityEngine;

public class ScaleChange : MonoBehaviour
{
    public Vector3 scaleChange;

    void Update()
    {
        transform.localScale += scaleChange;
    }
}