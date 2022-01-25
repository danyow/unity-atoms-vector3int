#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;


namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Vector3Int`. Inherits from `AtomEventInstancerEditor&lt;Vector3Int, Vector3IntEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Vector3IntEventInstancer))]
    public sealed class Vector3IntEventInstancerEditor : AtomEventInstancerEditor<Vector3Int, Vector3IntEvent> { }
}
#endif