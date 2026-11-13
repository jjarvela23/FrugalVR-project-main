using System;
using UnityEngine;

public class Interaction : Interactive
{
    private Renderer objectRenderer;

    void Start()
    {
    }
    public new void Interact()
    {
        transform.localScale = new Vector3(2f, 2f, 2f);
    }

    public void ChangeColor()
    {
        float random1 = UnityEngine.Random.Range(0f, 1f);
        float random2 = UnityEngine.Random.Range(0f, 1f);
        float random3 = UnityEngine.Random.Range(0f, 1f);

        Color newColor = new Color(random1, random2, random3, 1f);

        objectRenderer.material.SetColor("_Color", newColor);
        print("jotain");
    }
}
