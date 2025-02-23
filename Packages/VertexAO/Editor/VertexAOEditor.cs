// Licensed under the MIT License.

using UnityEditor;
using UnityEngine;

/// <summary>
/// Custom inspector that exposes additional user controls for the AmbientOcclsion component
/// </summary>
[CustomEditor(typeof(VertexAO), CanEditMultipleObjects]
public class AmbientOcclusionInspector : UnityEditor.Editor
{
    /// <summary>
    /// Renders a custom inspector
    /// </summary>
    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("Gather samples"))
        {
            var component = target as VertexAO;
            component.GatherSamples();
        }
        DrawDefaultInspector();
    }
}
