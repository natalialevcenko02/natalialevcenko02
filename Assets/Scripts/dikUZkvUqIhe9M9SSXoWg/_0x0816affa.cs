using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// Runtime UGUI construction kit. Every screen of this game is built into the
/// template's own panel bodies, so nothing here ever looks an object up by name -
/// callers hold the RectTransforms they made.
///
/// Draw order is positional: each helper adds the background plate FIRST and the
/// label LAST, so a label is always a later sibling than the plate behind it
/// (CLAUDE-unity.md C.13).
/// </summary>
public static class _0x0816affa
{
    /// <summary>An icon-only button (gear, pause, back, close).</summary>
    public static Button IconButton(Transform _0x4b21bdae, string _0x655b7980, Vector2 _0xcbcdce71, Vector2 _0xf99d2dfc, Sprite _0x7a47158d, Color _0xd4163696, UnityAction onTap)
    {
        RectTransform _0xdbbcd541 = Node(_0x4b21bdae, _0x655b7980, _0xcbcdce71, _0xf99d2dfc);
        Image _0x03d7db80 = _0xdbbcd541.gameObject.AddComponent<Image>();
        _0x03d7db80.color = new Color(1f, 1f, 1f, 0.004f); // invisible, still raycasts
        _0x03d7db80.raycastTarget = true;
        RectTransform _0xe8916a72 = Node(_0xdbbcd541, _0x655b7980 + _0x19a716a8._0x5ddcd037(new byte[5] { 131, 168, 189, 180, 172 }, 196), new Vector2(0.5f, 0.5f), _0xf99d2dfc * 0.72f);
        Image _0xacc1fa6c = Picture(_0xe8916a72, _0xd4163696, _0x7a47158d, false, 1f);
        _0xacc1fa6c.raycastTarget = false;
        Button _0x6c203693 = _0xdbbcd541.gameObject.AddComponent<Button>();
        _0x6c203693.targetGraphic = _0x03d7db80;
        _0x6c203693.transition = Selectable.Transition.None;
        Transform _0x990a2b2b = _0xe8916a72;
        _0x6c203693.onClick.AddListener(() => Punch(_0x990a2b2b));
        if (onTap != null)
            _0x6c203693.onClick.AddListener(() => onTap());
        return _0x6c203693;
    }

    /// <summary>
    /// A tappable button: plate, rim, then the caption on top. The press tint plus the
    /// punch on release are the visible acknowledgement rule C.7 asks for.
    /// </summary>
    public static Button ActionButton(Transform _0x85a1633d, string _0x1e875103, Vector2 _0x974ebc0d, Vector2 _0x05dde76d, Color _0x885e4033, Color _0x80599365, Color _0x3c361e75, string _0xd6bafdb4, float _0x04875e83, Sprite _0xdaf411f6, float _0x924bea75, TMP_FontAsset _0xaa88d2d3, UnityAction onTap)
    {
        RectTransform _0xea117ed7 = Node(_0x85a1633d, _0x1e875103, _0x974ebc0d, _0x05dde76d);
        Image _0x0db64900 = Picture(_0xea117ed7, _0x885e4033, _0xdaf411f6, _0xdaf411f6 != null, _0x924bea75);
        _0x0db64900.raycastTarget = true;
        if (_0x80599365.a > 0f)
        {
            RectTransform _0x6e75fad5 = Sheet(_0xea117ed7, _0x1e875103 + _0x19a716a8._0x5ddcd037(new byte[3] { 70, 125, 121 }, 20));
            Picture(_0x6e75fad5, _0x80599365, _0xdaf411f6, _0xdaf411f6 != null, _0x924bea75 * 1.6f);
        }

        if (!string.IsNullOrEmpty(_0xd6bafdb4))
            Caption(_0xea117ed7, _0x1e875103 + _0x19a716a8._0x5ddcd037(new byte[4] { 89, 104, 117, 121 }, 13), new Vector2(0.5f, 0.5f), new Vector2(_0x05dde76d.x - 48f, _0x05dde76d.y * 0.62f), _0xd6bafdb4, _0x04875e83, _0x3c361e75, _0xaa88d2d3);
        Button _0x56ff9aca = _0xea117ed7.gameObject.AddComponent<Button>();
        _0x56ff9aca.targetGraphic = _0x0db64900;
        _0x56ff9aca.transition = Selectable.Transition.ColorTint;
        ColorBlock _0x3f7e2f87 = _0x56ff9aca.colors;
        _0x3f7e2f87.normalColor = Color.white;
        _0x3f7e2f87.highlightedColor = Color.white;
        _0x3f7e2f87.pressedColor = new Color(0.72f, 0.72f, 0.78f, 1f);
        _0x3f7e2f87.selectedColor = Color.white;
        _0x3f7e2f87.disabledColor = new Color(0.45f, 0.45f, 0.5f, 0.6f);
        _0x3f7e2f87.fadeDuration = 0.08f;
        _0x56ff9aca.colors = _0x3f7e2f87;
        Transform _0x5a1a029f = _0xea117ed7;
        _0x56ff9aca.onClick.AddListener(() => Punch(_0x5a1a029f));
        if (onTap != null)
            _0x56ff9aca.onClick.AddListener(() => onTap());
        return _0x56ff9aca;
    }

    public static float Lerp(float _0x4861d55e, float _0x1768a05b, float _0x4a8ae8f7)
    {
        return _0x4861d55e + (_0x1768a05b - _0x4861d55e) * Mathf.Clamp01(_0x4a8ae8f7);
    }

    /// <summary>A full-parent shade that also closes the sheet it dims.</summary>
    public static Button Shade(Transform _0xc1a1465e, string _0xe3bc3ebf, Color _0x6bbb2271, UnityAction onTap)
    {
        RectTransform _0x4af89d2a = Sheet(_0xc1a1465e, _0xe3bc3ebf);
        Image _0x1dca4796 = _0x4af89d2a.gameObject.AddComponent<Image>();
        _0x1dca4796.color = _0x6bbb2271;
        _0x1dca4796.raycastTarget = true;
        Button _0x7be1a023 = _0x4af89d2a.gameObject.AddComponent<Button>();
        _0x7be1a023.targetGraphic = _0x1dca4796;
        _0x7be1a023.transition = Selectable.Transition.None;
        if (onTap != null)
            _0x7be1a023.onClick.AddListener(() => onTap());
        return _0x7be1a023;
    }

    public static void Punch(Transform _0x433ed831)
    {
        if (_0x433ed831 == null)
            return;
        DOTween.Kill(_0x433ed831);
        _0x433ed831.localScale = Vector3.one;
        _0x433ed831.DOPunchScale(new Vector3(-0.06f, -0.06f, 0f), 0.18f, 1, 0.4f).SetEase(Ease.OutQuad);
    }

    /// <summary>One label. Word wrap is OFF - pass an explicit \n for every line break.</summary>
    public static TextMeshProUGUI Caption(Transform _0xbf029e9e, string _0xded8c6e3, Vector2 _0xadfa159b, Vector2 _0x4fdef997, string _0xe83fc2cf, float _0xd8c75603, Color _0xc7e0d81f, TMP_FontAsset _0x0f74858f)
    {
        RectTransform _0xe14ec801 = Node(_0xbf029e9e, _0xded8c6e3, _0xadfa159b, _0x4fdef997);
        TextMeshProUGUI _0xca533b08 = _0xe14ec801.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0x0f74858f != null)
            _0xca533b08.font = _0x0f74858f;
        _0xca533b08.text = _0xe83fc2cf;
        _0x0c4200aa.Dress(_0xca533b08, _0xd8c75603, _0xc7e0d81f);
        return _0xca533b08;
    }

    /// <summary>A point-anchored box, sized in canvas reference pixels (1242x2688).</summary>
    public static RectTransform Node(Transform _0xfafa8bab, string _0xf72e05ff, Vector2 _0x82c0cb46, Vector2 _0x3bdbe01e)
    {
        GameObject _0xf330e90a = new GameObject(_0xf72e05ff, typeof(RectTransform));
        RectTransform _0x22dd2075 = _0xf330e90a.GetComponent<RectTransform>();
        _0x22dd2075.SetParent(_0xfafa8bab, false);
        _0x22dd2075.anchorMin = _0x82c0cb46;
        _0x22dd2075.anchorMax = _0x82c0cb46;
        _0x22dd2075.pivot = new Vector2(0.5f, 0.5f);
        _0x22dd2075.sizeDelta = _0x3bdbe01e;
        _0x22dd2075.anchoredPosition = Vector2.zero;
        _0x22dd2075.localScale = Vector3.one;
        _0x22dd2075.localRotation = Quaternion.identity;
        return _0x22dd2075;
    }

    /// <summary>Blanks every label under a container - template filler must never reach a screen.</summary>
    public static void BlankLabels(Transform _0x71def456)
    {
        if (_0x71def456 == null)
            return;
        TMP_Text[] _0x83537311 = _0x71def456.GetComponentsInChildren<TMP_Text>(true);
        for (int _0x9472eaff = 0; _0x9472eaff < _0x83537311.Length; _0x9472eaff++)
            if (_0x83537311[_0x9472eaff] != null)
                _0x83537311[_0x9472eaff].text = string.Empty;
    }

    /// <summary>Switches off every direct child of a container without touching the container.</summary>
    public static void ClearChildren(Transform _0x55120083)
    {
        if (_0x55120083 == null)
            return;
        for (int _0x55895fd7 = _0x55120083.childCount - 1; _0x55895fd7 >= 0; _0x55895fd7--)
        {
            Transform _0x63638a7a = _0x55120083.GetChild(_0x55895fd7);
            if (_0x63638a7a != null)
                _0x63638a7a.gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// Adds an Image. A sprite with a 9-slice border is drawn Sliced so the corner
    /// radius survives any box size; a plain sprite stays Simple.
    /// </summary>
    public static Image Picture(RectTransform _0xd22a2890, Color _0x6fb423e2, Sprite _0x408c2a44, bool _0xb90cae2a, float _0xde2e0701)
    {
        Image _0x00a57002 = _0xd22a2890.gameObject.AddComponent<Image>();
        _0x00a57002.sprite = _0x408c2a44;
        _0x00a57002.color = _0x6fb423e2;
        _0x00a57002.raycastTarget = false;
        if (_0x408c2a44 != null && _0xb90cae2a)
        {
            _0x00a57002.type = Image.Type.Sliced;
            _0x00a57002.pixelsPerUnitMultiplier = _0xde2e0701;
        }
        else
        {
            _0x00a57002.type = Image.Type.Simple;
            _0x00a57002.preserveAspect = _0x408c2a44 != null;
        }

        return _0x00a57002;
    }

    /// <summary>A box stretched over its whole parent.</summary>
    public static RectTransform Sheet(Transform _0x2c82e87d, string _0xf3066978)
    {
        GameObject _0x0f76b8b8 = new GameObject(_0xf3066978, typeof(RectTransform));
        RectTransform _0xbb836fde = _0x0f76b8b8.GetComponent<RectTransform>();
        _0xbb836fde.SetParent(_0x2c82e87d, false);
        _0xbb836fde.anchorMin = Vector2.zero;
        _0xbb836fde.anchorMax = Vector2.one;
        _0xbb836fde.pivot = new Vector2(0.5f, 0.5f);
        _0xbb836fde.offsetMin = Vector2.zero;
        _0xbb836fde.offsetMax = Vector2.zero;
        _0xbb836fde.localScale = Vector3.one;
        return _0xbb836fde;
    }

    /// <summary>Fades a CanvasGroup in; used for the menu entry cascade.</summary>
    public static void FadeIn(RectTransform _0x3c138ef2, float _0x2a4ef66a)
    {
        if (_0x3c138ef2 == null)
            return;
        CanvasGroup _0x1492328d = _0x3c138ef2.gameObject.AddComponent<CanvasGroup>();
        _0x1492328d.alpha = 0f;
        Vector2 _0x25d04d52 = _0x3c138ef2.anchoredPosition;
        _0x3c138ef2.anchoredPosition = _0x25d04d52 + new Vector2(0f, -40f);
        DOTween.To(() => _0x1492328d.alpha, (float _0x90f7f453) => _0x1492328d.alpha = _0x90f7f453, 1f, 0.22f).SetDelay(_0x2a4ef66a);
        _0x3c138ef2.DOAnchorPos(_0x25d04d52, 0.26f).SetDelay(_0x2a4ef66a).SetEase(Ease.OutCubic);
    }

    /// <summary>A themed plate: fill, then a rim of its own so the edge reads on any background.</summary>
    public static Image Plate(Transform _0x8f800b5e, string _0x88922702, Vector2 _0x7bffaac7, Vector2 _0x916b9864, Color _0x37e4db3e, Color _0x2ff27882, Sprite _0x9286aa18, float _0xeb09d3e9)
    {
        RectTransform _0xbf8436e5 = Node(_0x8f800b5e, _0x88922702, _0x7bffaac7, _0x916b9864);
        Image _0x1c7543ab = Picture(_0xbf8436e5, _0x37e4db3e, _0x9286aa18, _0x9286aa18 != null, _0xeb09d3e9);
        if (_0x2ff27882.a > 0f)
        {
            RectTransform _0x3db1a943 = Sheet(_0xbf8436e5, _0x88922702 + _0x19a716a8._0x5ddcd037(new byte[3] { 26, 33, 37 }, 72));
            Image _0xff1e5498 = Picture(_0x3db1a943, _0x2ff27882, _0x9286aa18, _0x9286aa18 != null, _0xeb09d3e9);
            _0xff1e5498.raycastTarget = false;
        }

        return _0x1c7543ab;
    }

    /// <summary>
    /// Switches off every direct child except one. Used where the template put a live
    /// control inside a body we otherwise own - the menu's Play button is a template
    /// prefab instance and must survive the sweep.
    /// </summary>
    public static void ClearChildrenExcept(Transform _0xdcae887d, Transform _0xdb24fd3b)
    {
        if (_0xdcae887d == null)
            return;
        for (int _0x6f77482c = _0xdcae887d.childCount - 1; _0x6f77482c >= 0; _0x6f77482c--)
        {
            Transform _0x114b2b34 = _0xdcae887d.GetChild(_0x6f77482c);
            if (_0x114b2b34 == null || _0x114b2b34 == _0xdb24fd3b)
                continue;
            if (_0xdb24fd3b != null && _0xdb24fd3b.IsChildOf(_0x114b2b34))
                continue;
            _0x114b2b34.gameObject.SetActive(false);
        }
    }
}

internal static class _0x19a716a8
{
    internal static string _0x5ddcd037(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}