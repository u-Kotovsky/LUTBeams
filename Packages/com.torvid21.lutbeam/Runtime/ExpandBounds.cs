#if UDONSHARP
using UdonSharp;
#endif
using UnityEngine;

namespace LUTBeam
{
    #if UDONSHARP
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class ExpandBounds : UdonSharpBehaviour
    #else
    public class ExpandBounds : MonoBehaviour
    #endif
    {
        public float expandSize = 10.0f;

        void Start()
        {
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.ResetBounds();
            meshRenderer.bounds = new Bounds(meshRenderer.bounds.center, Vector3.one * expandSize);
        }
    }
}