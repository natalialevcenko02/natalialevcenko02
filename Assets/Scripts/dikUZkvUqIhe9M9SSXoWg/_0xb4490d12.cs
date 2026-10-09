using DG.Tweening;
using UnityEngine;

/// <summary>
/// The menu hero: the faceted mark bobbing between three slowly counter-rotating
/// beam arcs. Decoration only - it is built first and sits behind every control, so
/// nothing it does can cover a caption (rule C.13).
/// </summary>
public sealed class _0xb4490d12 : MonoBehaviour
{
    [SerializeField]
    private Sprite _gemMark;
    public RectTransform _0x0bae8c59(Transform _0xe7d6dabc, Vector2 _0x7e66a6b5, float _0xb2bf94a7)
    {
        RectTransform _0xfc66938b = _0x0816affa.Node(_0xe7d6dabc, _0xc253375d._0x7ad69eda(new byte[12] { 18, 58, 49, 42, 24, 58, 50, 12, 43, 62, 56, 58 }, 95), _0x7e66a6b5, new Vector2(_0xb2bf94a7, _0xb2bf94a7));
        for (int _0x1d789f1b = 0; _0x1d789f1b < 3; _0x1d789f1b++)
        {
            RectTransform _0x32be2424 = _0x0816affa.Node(_0xfc66938b, _0xc253375d._0x7ad69eda(new byte[6] { 151, 181, 189, 145, 162, 179 }, 208) + _0x1d789f1b.ToString(), new Vector2(0.5f, 0.5f), new Vector2(_0xb2bf94a7 * (0.98f - _0x1d789f1b * 0.14f), _0xb2bf94a7 * 0.16f));
            _0x32be2424.localRotation = Quaternion.Euler(0f, 0f, 34f + 56f * _0x1d789f1b);
            _0x0816affa.Picture(_0x32be2424, _0x61e0b808.WithAlpha(_0x61e0b808.BeamColours[_0x1d789f1b], 0.35f), this._arcSprite, false, 1f);
            float _0x9dc0b0a3 = (_0x1d789f1b % 2 == 0) ? 360f : -360f;
            _0x32be2424.DOLocalRotate(new Vector3(0f, 0f, _0x9dc0b0a3), 18f + 5f * _0x1d789f1b, RotateMode.LocalAxisAdd).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
        }

        RectTransform _0x611ceded = _0x0816affa.Node(_0xfc66938b, _0xc253375d._0x7ad69eda(new byte[7] { 98, 74, 65, 90, 104, 74, 66 }, 47), new Vector2(0.5f, 0.5f), new Vector2(_0xb2bf94a7 * 0.82f, _0xb2bf94a7 * 0.82f));
        _0x0816affa.Picture(_0x611ceded, _0x61e0b808.Cream, this._gemMark, false, 1f);
        _0x611ceded.DOAnchorPosY(14f, 2.4f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
        return _0xfc66938b;
    }

    [SerializeField]
    private Sprite _arcSprite;
}

internal static class _0xc253375d
{
    internal static string _0x7ad69eda(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}