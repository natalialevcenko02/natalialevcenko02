using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses the splash: a dark wash over the stage art, three slowly turning
/// spotlight rays and the abstract faceted mark. No game name appears here or
/// anywhere else on screen - the brand is the mark, the palette and nothing else.
///
/// The splash body ships with its children switched off in the template, so they are
/// woken before the mark is slid in behind them; the loading bar therefore stays on
/// top of the art it loads over.
/// </summary>
public sealed class _0xff0ce341 : MonoBehaviour
{
    private static void BreatheMark(RectTransform _0x092a81d4)
    {
        if (_0x092a81d4 == null)
            return;
        _0x092a81d4.DOScale(1.02f, 1.6f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    public void _0x9df44b3b()
    {
        if (this._0xd520bf89 || _0x912c6d1c.Instance == null || _0x912c6d1c.Instance.Content == null)
            return;
        Transform _0x4afc1457 = _0x912c6d1c.Instance.Content.transform;
        // Wake whatever the template put in the body (the loading bar ships off).
        for (int _0x68bd0b83 = 0; _0x68bd0b83 < _0x4afc1457.childCount; _0x68bd0b83++)
            _0x4afc1457.GetChild(_0x68bd0b83).gameObject.SetActive(true);
        // Splash loading bar (rule G): the template ships the fill white and the track
        // (Image on "Fill Area") at alpha 0.004, so a woken bar is still invisible.
        // Fill = accent, track = solid dark palette colour.
        Slider _0xda06bc09 = _0x4afc1457.GetComponentInChildren<Slider>(true);
        if (_0xda06bc09 != null && _0xda06bc09.fillRect != null)
        {
            Image _0x39985fb4 = _0xda06bc09.fillRect.GetComponent<Image>();
            if (_0x39985fb4 != null)
                _0x39985fb4.color = _0x61e0b808.Gold;
            Transform _0x862c15a4 = _0xda06bc09.fillRect.parent;
            Image _0x320f1fa7 = _0x862c15a4 != null ? _0x862c15a4.GetComponent<Image>() : null;
            if (_0x320f1fa7 != null)
                _0x320f1fa7.color = _0x61e0b808.VioletDeep;
        }

        RectTransform _0x05044792 = _0x0816affa.Sheet(_0x4afc1457, _0xd232be16._0xce575b02(new byte[11] { 150, 181, 169, 164, 182, 173, 150, 177, 164, 162, 160 }, 197));
        _0x05044792.SetAsFirstSibling();
        RectTransform _0x302257c0 = _0x0816affa.Sheet(_0x05044792, _0xd232be16._0xce575b02(new byte[10] { 103, 68, 88, 85, 71, 92, 99, 85, 71, 92 }, 52));
        _0x0816affa.Picture(_0x302257c0, _0x61e0b808.WithAlpha(_0x61e0b808.InkDeep, 0.88f), null, false, 1f);
        RectTransform _0x600336c2 = _0x0816affa.Node(_0x05044792, _0xd232be16._0xce575b02(new byte[10] { 60, 31, 3, 14, 28, 7, 61, 14, 22, 28 }, 111), new Vector2(0.5f, 0.56f), new Vector2(980f, 980f));
        for (int _0x96c35b1d = 0; _0x96c35b1d < 3; _0x96c35b1d++)
        {
            RectTransform _0x8b1991aa = _0x0816affa.Node(_0x600336c2, _0xd232be16._0xce575b02(new byte[9] { 210, 241, 237, 224, 242, 233, 211, 224, 248 }, 129) + _0x96c35b1d.ToString(), new Vector2(0.5f, 0.5f), new Vector2(940f, 150f));
            _0x8b1991aa.localRotation = Quaternion.Euler(0f, 0f, 60f * _0x96c35b1d);
            _0x0816affa.Picture(_0x8b1991aa, _0x61e0b808.WithAlpha(_0x61e0b808.BeamColours[_0x96c35b1d], 0.22f), this._raySprite, false, 1f);
        }

        _0x600336c2.DOLocalRotate(new Vector3(0f, 0f, 360f), 24f, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
        RectTransform _0x792bc296 = _0x0816affa.Node(_0x05044792, _0xd232be16._0xce575b02(new byte[10] { 190, 157, 129, 140, 158, 133, 160, 140, 159, 134 }, 237), new Vector2(0.5f, 0.56f), new Vector2(520f, 520f));
        _0x0816affa.Picture(_0x792bc296, _0x61e0b808.Cream, this._gemMark, false, 1f);
        _0x792bc296.localScale = Vector3.one * 0.86f;
        _0x792bc296.DOScale(1f, 0.42f).SetEase(Ease.OutBack).OnComplete(() => BreatheMark(_0x792bc296));
        _0x0816affa.Caption(_0x05044792, _0xd232be16._0xce575b02(new byte[10] { 75, 104, 116, 121, 107, 112, 80, 113, 118, 108 }, 24), new Vector2(0.5f, 0.345f), new Vector2(620f, 70f), _0xd232be16._0xce575b02(new byte[7] { 72, 75, 69, 64, 77, 74, 67 }, 4), 34f, _0x61e0b808.WithAlpha(_0x61e0b808.Cream, 0.85f), this._font);
        this._0xd520bf89 = true;
    }

    private bool _0xd520bf89;
    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite _gemMark;
    [SerializeField]
    private Sprite _raySprite;
}

internal static class _0xd232be16
{
    internal static string _0xce575b02(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}