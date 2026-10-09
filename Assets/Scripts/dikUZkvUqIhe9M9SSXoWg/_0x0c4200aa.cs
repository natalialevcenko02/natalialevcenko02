using TMPro;
using UnityEngine;

/// <summary>
/// Outline + wrapping discipline for every label this game creates at runtime.
/// The scene font material carries the themed outline, but a label built with
/// AddComponent gets a fresh instance of it, so the keyword has to be re-enabled
/// per label (CLAUDE-unity.md C.10).
/// </summary>
public static class _0x0c4200aa
{
    /// <summary>
    /// Word wrap OFF, autosize ON, outline on. Line breaks are the caller's job:
    /// pass an explicit \n, never let the engine pick the break.
    /// </summary>
    public static void Dress(TMP_Text _0x01805704, float _0x9a1945d6, Color _0xa2e7fd49)
    {
        if (_0x01805704 == null)
            return;
        _0x01805704.color = _0xa2e7fd49;
        _0x01805704.textWrappingMode = TextWrappingModes.NoWrap;
        _0x01805704.overflowMode = TextOverflowModes.Overflow;
        _0x01805704.enableAutoSizing = true;
        _0x01805704.fontSizeMin = _0x61e0b808.MinFontSize;
        _0x01805704.fontSizeMax = Mathf.Max(_0x61e0b808.MinFontSize, _0x9a1945d6);
        _0x01805704.fontSize = Mathf.Max(_0x61e0b808.MinFontSize, _0x9a1945d6);
        _0x01805704.alignment = TextAlignmentOptions.Center;
        _0x01805704.raycastTarget = false;
        ApplyOutline(_0x01805704);
    }

    /// <summary>
    /// Turns the SDF outline on for one label. A TMP_Text that has not run Awake yet
    /// (built into an inactive hierarchy) has no font asset and reading fontMaterial
    /// throws, which would unwind the whole caller - so bail out instead.
    /// </summary>
    public static void ApplyOutline(TMP_Text _0x6e838c38)
    {
        if (_0x6e838c38 == null || _0x6e838c38.font == null)
            return;
        Material _0x3c0098ed = _0x6e838c38.fontMaterial;
        if (_0x3c0098ed == null)
            return;
        _0x3c0098ed.EnableKeyword(OutlineKeyword);
        _0x3c0098ed.SetColor(_0xba597e6f, _0x61e0b808.Ink);
        _0x3c0098ed.SetFloat(_0x33e220cd, 0.24f);
        _0x3c0098ed.SetFloat(_0xf0daae0d, 0.20f);
    }

    private static readonly int _0xba597e6f = Shader.PropertyToID(_0x9504a5a0._0x2a4111ac(new byte[13] { 112, 96, 90, 91, 67, 70, 65, 74, 108, 64, 67, 64, 93 }, 47));
    private static readonly string OutlineKeyword = _0x9504a5a0._0x2a4111ac(new byte[10] { 206, 212, 213, 205, 200, 207, 196, 222, 206, 207 }, 129);
    private static readonly int _0x33e220cd = Shader.PropertyToID(_0x9504a5a0._0x2a4111ac(new byte[13] { 131, 147, 169, 168, 176, 181, 178, 185, 139, 181, 184, 168, 180 }, 220));
    private static readonly int _0xf0daae0d = Shader.PropertyToID(_0x9504a5a0._0x2a4111ac(new byte[11] { 192, 217, 254, 252, 250, 219, 246, 243, 254, 235, 250 }, 159));
}

internal static class _0x9504a5a0
{
    internal static string _0x2a4111ac(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}