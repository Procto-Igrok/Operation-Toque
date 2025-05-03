using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevDErr : MonoBehaviour
{
    public SpriteRenderer shade;
    public float vf = 0f;

    void Update()
    {
        if (vf == 0f && shade.color.a > 0f)
        {
            var op = shade.color;
            op.a -= 0.05f;
            shade.color = op;
        }
        if (vf == 1)
        {
            var op = shade.color;
            op.a += 0.05f;
            shade.color = op;
        }
    }
}
