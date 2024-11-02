using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ARPlacementPrefabSwitcherButtons : MonoBehaviour
{
    public GameObject[] prefabs;
    public ARPlacementInteractable arPlacementInteractable;

    public void SetPlacementPrefab(int prefabIndex)
    {
        if (arPlacementInteractable != null && prefabIndex >= 0 && prefabIndex < prefabs.Length)
        {
            arPlacementInteractable.placementPrefab = prefabs[prefabIndex];
        }
    }
}
