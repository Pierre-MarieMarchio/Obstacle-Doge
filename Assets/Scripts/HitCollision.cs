using UnityEditor;
using UnityEngine;

public class HitCollision : MonoBehaviour
{
    private ColorChanger colorChanger;
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        colorChanger = new ColorChanger(Color.red);
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter()
    {
        HitOnWall();
    }

    private void HitOnWall()
    {
        Debug.Log("Ouchhh! Watch out!");
        ChangeColorIfValid();
    }

    private void ChangeColorIfValid()
    {
        if (meshRenderer != null)
        {
            colorChanger.ChangeColor(meshRenderer);

        }
        else
        {
            Debug.LogWarning("MeshRenderer not found on this object.");
        }
    }
}
