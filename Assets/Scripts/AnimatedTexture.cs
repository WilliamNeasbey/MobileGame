using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedTexture : MonoBehaviour
{
    public float speed = 0.5f;
    public float tiling = 1f;

    void Update()
    {
        // Get the material from the renderer component
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        Material material = renderer.material;

        // Calculate the texture offset based on time and speed
        Vector2 textureOffset = new Vector2(Time.time * speed, 0f);

        // Set the tiling and offset of the main texture
        material.mainTextureScale = new Vector2(tiling, tiling);
        material.mainTextureOffset = textureOffset;
    }
}
