using UnityEngine;

class ObjectRenderer : MonoBehaviour
{
    private MeshRenderer[] meshRenderers;

    private void Awake()
    {

        meshRenderers = GetComponentsInChildren<MeshRenderer>();
    }

    public void Show()
    {
        SetVisibility(true);
    }

    public void Hide()
    {
        SetVisibility(false);
    }

    private void SetVisibility(bool isVisible)
    {
        foreach (MeshRenderer meshRenderer in meshRenderers)
        {
            meshRenderer.enabled = isVisible;
        };
    }
}