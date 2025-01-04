using UnityEngine;

class ColorChanger
{
    private Color targetColor;


    public ColorChanger(Color color)
    {
        targetColor = color;
    }

    public void ChangeColor(MeshRenderer renderer)
    {
        if (renderer != null)
        {
            renderer.material.color = targetColor;
        }
        else
        {
            Debug.LogWarning("MeshRenderer is null");
        }
    }
}
