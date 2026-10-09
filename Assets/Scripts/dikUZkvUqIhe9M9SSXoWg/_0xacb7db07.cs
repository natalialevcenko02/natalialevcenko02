using System;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Turns one screen tap into one world point.
///
/// The template's own InputController cannot be used from generated code - its
/// Instance field and every accessor on it are private - so taps come from a single
/// transparent Image stretched over the play area. It is built as the FIRST child of
/// the HUD host, so every button added afterwards is a later sibling and wins the
/// raycast; only taps that miss the UI reach the board.
/// </summary>
public sealed class _0xacb7db07 : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData _0x280c3880)
    {
        if (this._0x306393cc == null || this._0xf86a10df == null || _0x280c3880 == null)
            return;
        float _0x196c7de0 = Mathf.Abs(this._0x306393cc.transform.position.z);
        Vector3 _0x26c560a1 = new Vector3(_0x280c3880.position.x, _0x280c3880.position.y, _0x196c7de0 <= 0.01f ? 10f : _0x196c7de0);
        Vector3 _0x5282ee57 = this._0x306393cc.ScreenToWorldPoint(_0x26c560a1);
        _0x5282ee57.z = 0f;
        this._0xf86a10df(_0x5282ee57);
    }

    public void _0xb8308d2c(Camera _0x82c96303, Action<Vector3> _0x958ebdc5)
    {
        this._0x306393cc = _0x82c96303;
        this._0xf86a10df = _0x958ebdc5;
    }

    private Camera _0x306393cc;
    private Action<Vector3> _0xf86a10df;
}