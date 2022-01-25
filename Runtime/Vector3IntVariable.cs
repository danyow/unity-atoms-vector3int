using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `Vector3Int`. Inherits from `EquatableAtomVariable&lt;Vector3Int, Vector3IntPair, Vector3IntEvent, Vector3IntPairEvent, Vector3IntVector3IntFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Vector3Int", fileName = "Vector3IntVariable")]
    public sealed class Vector3IntVariable : EquatableAtomVariable<Vector3Int, Vector3IntPair, Vector3IntEvent,
        Vector3IntPairEvent, Vector3IntVector3IntFunction>
    {
        /// <summary>
        /// Multiply variable by value.
        /// </summary>
        /// <param name="value">Value to multiple by.</param>
        public void MultiplyBy(int value) => Value *= value;

        /// <summary>
        /// Multiply variable by Variable value.
        /// </summary>
        /// <param name="variable">Variable with value to multiple by.</param>
        public void MultiplyBy(AtomBaseVariable<int> variable) => MultiplyBy(variable.Value);

        /// <summary>
        /// Divide Variable by value.
        /// </summary>
        /// <param name="value">Value to divide by.</param>
        public void DivideBy(int value) => Value /= value;

        /// <summary>
        /// Divide Variable by Variable value.
        /// </summary>
        /// <param name="variable">Variable value to divide by.</param>
        public void DivideBy(AtomBaseVariable<int> variable) => DivideBy(variable.Value);
    }
}