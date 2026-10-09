using UnityEngine;

/// <summary>
/// Theme constants for the whole game. Colours are the ticket palette; the sorting
/// band is the -19..-1 corridor that keeps every world sprite above the background
/// canvas (-30) and under the pop canvases (10).
/// </summary>
public static class _0x61e0b808
{
    public static readonly Color Ink = new Color(0.090f, 0.071f, 0.122f, 1f);
    public static readonly Color VioletDeep = new Color(0.227f, 0.122f, 0.361f, 1f);
    public const int SlotOrder = -14;
    public static readonly Color Gold = new Color(0.937f, 0.757f, 0.298f, 1f);
    public static readonly Color Teal = new Color(0.208f, 0.722f, 0.663f, 1f);
    public const float RefHeight = 2688f;
    public static readonly Color GoldDeep = new Color(0.784f, 0.573f, 0.180f, 1f);
    public const int BeamOrder = -12;
    public const int SparkOrder = -2;
    public const int SelectOrder = -9;
    public const int EmitterOrder = -6;
    public static readonly Color Violet = new Color(0.459f, 0.247f, 0.686f, 1f);
    // ── readable text floor (CLAUDE-unity.md C.12) ─────────────────────────
    public const float MinFontSize = 24f;
    public static readonly Color Rose = new Color(0.847f, 0.231f, 0.412f, 1f);
    public const int BeamTurnOrder = -11;
    public const int FacetOrder = -5;
    public static readonly Color InkDeep = new Color(0.051f, 0.039f, 0.075f, 1f);
    // ── canvas reference resolution (CanvasScaler, match width) ─────────────
    public const float RefWidth = 1242f;
    public const int FacetGlowOrder = -4;
    public static readonly Color RoseLight = new Color(0.941f, 0.541f, 0.659f, 1f);
    public static readonly Color Cream = new Color(0.961f, 0.914f, 0.851f, 1f);
    public static readonly Color TealDeep = new Color(0.122f, 0.494f, 0.455f, 1f);
    public const int BlockerOrder = -10;
    /// <summary>Beam colours, indexed by beam id. Rose never carries text.</summary>
    public static readonly Color[] BeamColours =
    {
        Rose,
        Gold,
        Teal
    };
    public const int StoneOrder = -8;
    public static Color WithAlpha(Color _0x899af441, float _0xb88892f0)
    {
        return new Color(_0x899af441.r, _0x899af441.g, _0x899af441.b, _0xb88892f0);
    }

    // ── sorting band ────────────────────────────────────────────────────────
    // Background canvas is -30, pops are +10. Everything the board draws must sit
    // strictly inside -19..-1 or verify-unity-layout fails the run.
    public const int BackdropOrder = -19;
    public const int FrameOrder = -16;
}