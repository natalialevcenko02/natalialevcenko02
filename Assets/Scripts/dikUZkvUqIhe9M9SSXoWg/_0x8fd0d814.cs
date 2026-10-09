using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x8fd0d814 : MonoBehaviour
{
    private static float Ratio(Color _0x876e9656, Color _0x7cf594e1)
    {
        float _0x3539039d = Luminance(_0x876e9656);
        float _0xb244cb3e = Luminance(_0x7cf594e1);
        return (Mathf.Max(_0x3539039d, _0xb244cb3e) + 0.05f) / (Mathf.Min(_0x3539039d, _0xb244cb3e) + 0.05f);
    }

    private const float MinOutlineWidth = 0.01f;
    private static _0x8fd0d814 _0xcdecc0ed;
    private const float MinRatio = 4.5f;
    private static void Fix(TMP_Text _0x30861ada)
    {
        if (_0x30861ada == null || !_0x30861ada.isActiveAndEnabled)
            return;
        Material _0xaf2ee4a2 = _0x30861ada.fontSharedMaterial;
        if (_0xaf2ee4a2 == null || !_0xaf2ee4a2.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xaf2ee4a2.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xaf2ee4a2.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0xf574b5c5 = _0x30861ada.color;
        if (_0xf574b5c5.a <= 0f)
            return;
        Color _0x6a9ad774 = _0xaf2ee4a2.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0xf574b5c5, _0x6a9ad774) >= MinRatio)
            return;
        Color _0x4713f715 = Luminance(_0x6a9ad774) < 0.5f ? Color.white : Color.black;
        Color _0x94afc2e8;
        if (Ratio(_0x4713f715, _0x6a9ad774) < TargetRatio)
        {
            _0x94afc2e8 = _0x4713f715;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0xeb4374a8 = 0f;
            float _0xde90ae6c = 1f;
            for (int _0x2820c1e1 = 0; _0x2820c1e1 < 20; _0x2820c1e1++)
            {
                float _0xdb40473d = (_0xeb4374a8 + _0xde90ae6c) * 0.5f;
                if (Ratio(Color.Lerp(_0xf574b5c5, _0x4713f715, _0xdb40473d), _0x6a9ad774) >= TargetRatio)
                    _0xde90ae6c = _0xdb40473d;
                else
                    _0xeb4374a8 = _0xdb40473d;
            }

            _0x94afc2e8 = Color.Lerp(_0xf574b5c5, _0x4713f715, _0xde90ae6c);
        }

        _0x94afc2e8.a = _0xf574b5c5.a;
        _0x30861ada.color = _0x94afc2e8;
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x1201f77b(Object _0xf99aad48)
    {
        TMP_Text _0x5d5a4550 = _0xf99aad48 as TMP_Text;
        if (_0x5d5a4550 != null)
            this._0x5196a93f.Add(_0x5d5a4550);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x68cf5d18;
    private void LateUpdate()
    {
        if (this._0x5196a93f.Count == 0)
            return;
        this._0xf3046955.Clear();
        this._0xf3046955.AddRange(this._0x5196a93f);
        this._0x5196a93f.Clear();
        for (int _0x2d39d4dc = 0; _0x2d39d4dc < this._0xf3046955.Count; _0x2d39d4dc++)
            Fix(this._0xf3046955[_0x2d39d4dc]);
    }

    private const float TargetRatio = 7f;
    private void OnEnable()
    {
        if (this._0x68cf5d18 == null)
            this._0x68cf5d18 = _0x69329657 => this._0x1201f77b(_0x69329657);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x68cf5d18);
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x7b6eee7a)
    {
        return 0.2126f * Linear(_0x7b6eee7a.r) + 0.7152f * Linear(_0x7b6eee7a.g) + 0.0722f * Linear(_0x7b6eee7a.b);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0xcdecc0ed != null)
            return;
        GameObject _0x8718ec4b = new GameObject(_0xe80c9195._0xd1d70817(new byte[16] { 211, 234, 247, 196, 232, 233, 243, 245, 230, 244, 243, 192, 242, 230, 245, 227 }, 135));
        _0x8718ec4b.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x8718ec4b);
        _0xcdecc0ed = _0x8718ec4b.AddComponent<_0x8fd0d814>();
    }

    private readonly List<TMP_Text> _0xf3046955 = new List<TMP_Text>();
    private void OnDisable()
    {
        if (this._0x68cf5d18 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x68cf5d18);
    }

    private static float Linear(float _0x62dc8a46)
    {
        _0x62dc8a46 = Mathf.Clamp01(_0x62dc8a46);
        return _0x62dc8a46 <= 0.03928f ? _0x62dc8a46 / 12.92f : Mathf.Pow((_0x62dc8a46 + 0.055f) / 1.055f, 2.4f);
    }

    private readonly HashSet<TMP_Text> _0x5196a93f = new HashSet<TMP_Text>();
}

internal static class _0xe80c9195
{
    internal static string _0xd1d70817(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}