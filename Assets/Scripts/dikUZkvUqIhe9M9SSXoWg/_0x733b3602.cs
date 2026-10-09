using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// Draws every beam one tile per crossed cell, from a pool so a redraw after each
/// swap costs no allocation. Redrawing immediately after every swap is the whole
/// hook of the game: one stone moves and half the screen re-routes.
///
/// Tile orientation, derived once:
///  - the straight art runs LEFT to RIGHT, so a run heading `d` is the art turned d*90.
///  - the elbow art enters LEFT and leaves TOP, i.e. the pair (in=Right, out=Up).
///    Turning it by k gives (k, k+1), which covers every LEFT turn directly. A RIGHT
///    turn (out == in-1) is the same picture read backwards, so it is drawn as the
///    left turn (in+1, in+2) - one extra quarter turn, no flip and no second sprite.
/// </summary>
public sealed class _0x733b3602 : MonoBehaviour
{
    private void _0x8672e259(List<SpriteRenderer> _0x3a1e06ac, float _0x50b5af71)
    {
        for (int _0xf92ea693 = 0; _0xf92ea693 < _0x3a1e06ac.Count; _0xf92ea693++)
        {
            SpriteRenderer _0x4992434e = _0x3a1e06ac[_0xf92ea693];
            if (_0x4992434e == null || !_0x4992434e.gameObject.activeSelf)
                continue;
            DOTween.Kill(_0x4992434e);
            _0x4992434e.DOFade(0f, _0x50b5af71);
        }
    }

    private SpriteRenderer _0xb720622c()
    {
        return this._0x67c907bf(this._0x16e00478, this._turnPrefab, ref this._0xf8c17773);
    }

    [SerializeField]
    private GameObject _straightPrefab;
    private const float TileShare = 1.0f;
    private int _0x3521233a;
    private static int SpinFor(int _0x3a8a0983, int _0x3adc0282)
    {
        if (_0x3a8a0983 == _0x3adc0282)
            return _0x3a8a0983;
        return _0x3adc0282 == ((_0x3a8a0983 + 1) & 3) ? _0x3a8a0983 : ((_0x3a8a0983 + 1) & 3);
    }

    private readonly List<SpriteRenderer> _0x16e00478 = new List<SpriteRenderer>(24);
    private int _0xf8c17773;
    private SpriteRenderer _0x8fee9187()
    {
        return this._0x67c907bf(this._0xeea39a94, this._straightPrefab, ref this._0x3521233a);
    }

    [SerializeField]
    private Transform _beamRoot;
    private void _0x3a7f8281(List<SpriteRenderer> _0xb31f055e, int _0xf2a1ccfd)
    {
        for (int _0x5489d1cf = _0xf2a1ccfd; _0x5489d1cf < _0xb31f055e.Count; _0x5489d1cf++)
            if (_0xb31f055e[_0x5489d1cf] != null)
                _0xb31f055e[_0x5489d1cf].gameObject.SetActive(false);
    }

    private SpriteRenderer _0x67c907bf(List<SpriteRenderer> _0xa84a16eb, GameObject _0xb13df0eb, ref int _0xcb92027a)
    {
        if (_0xcb92027a < _0xa84a16eb.Count)
        {
            SpriteRenderer _0x2c02f8cb = _0xa84a16eb[_0xcb92027a];
            _0xcb92027a++;
            return _0x2c02f8cb;
        }

        if (_0xb13df0eb == null)
            return null;
        GameObject _0xd7eb68fd = Instantiate(_0xb13df0eb, this._beamRoot);
        SpriteRenderer _0x41df8e6f = _0xd7eb68fd.GetComponent<SpriteRenderer>();
        _0xa84a16eb.Add(_0x41df8e6f);
        _0xcb92027a++;
        return _0x41df8e6f;
    }

    private const float BeamAlpha = 0.92f;
    private readonly List<SpriteRenderer> _0xeea39a94 = new List<SpriteRenderer>(48);
    [SerializeField]
    private _0x9390206a _board;
    [SerializeField]
    private GameObject _turnPrefab;
    public void _0x220de5e1(_0xdfdf0b34 _0xb93d96d0, _0xfa8fa6c6 _0xf086bd9f, bool _0xff81b7c7)
    {
        if (this._board == null || this._beamRoot == null)
            return;
        this._0x3521233a = 0;
        this._0xf8c17773 = 0;
        float _0x365796c2 = this._board._0xfa16ca94 * TileShare;
        for (int _0xe2c54a4b = 0; _0xe2c54a4b < _0xb93d96d0._0xf9ecab52; _0xe2c54a4b++)
        {
            Color _0xde6c841e = _0x61e0b808.BeamColours[_0xe2c54a4b % _0x61e0b808.BeamColours.Length];
            _0xf086bd9f._0x859c0a79(_0xb93d96d0, _0xe2c54a4b);
            IList<_0xfa8fa6c6.Segment> _0x2a98650d = _0xf086bd9f._0x51799421;
            for (int _0x765ca112 = 0; _0x765ca112 < _0x2a98650d.Count; _0x765ca112++)
            {
                _0xfa8fa6c6.Segment _0xef23bd4f = _0x2a98650d[_0x765ca112];
                bool _0x46e8a989 = _0xef23bd4f.DirIn == _0xef23bd4f.DirOut;
                SpriteRenderer _0xf1d87d52 = _0x46e8a989 ? this._0x8fee9187() : this._0xb720622c();
                if (_0xf1d87d52 == null)
                    continue;
                Transform _0xb878d1b7 = _0xf1d87d52.transform;
                _0xb878d1b7.position = this._board._0xd13a84c2(_0xef23bd4f.X, _0xef23bd4f.Y);
                _0xb878d1b7.localRotation = Quaternion.Euler(0f, 0f, SpinFor(_0xef23bd4f.DirIn, _0xef23bd4f.DirOut) * 90f);
                _0xb878d1b7.localScale = Vector3.one;
                _0xf1d87d52.size = new Vector2(_0x365796c2, _0x365796c2);
                _0xf1d87d52.gameObject.SetActive(true);
                DOTween.Kill(_0xf1d87d52);
                if (_0xff81b7c7)
                {
                    _0xf1d87d52.color = _0x61e0b808.WithAlpha(_0xde6c841e, 0f);
                    _0xf1d87d52.DOFade(BeamAlpha, 0.14f);
                }
                else
                {
                    _0xf1d87d52.color = _0x61e0b808.WithAlpha(_0xde6c841e, BeamAlpha);
                }
            }
        }

        this._0x3a7f8281(this._0xeea39a94, this._0x3521233a);
        this._0x3a7f8281(this._0x16e00478, this._0xf8c17773);
    }

    /// <summary>Beams die out when the run is lost.</summary>
    public void _0x6d92b7cd(float _0x03e922d8)
    {
        this._0x8672e259(this._0xeea39a94, _0x03e922d8);
        this._0x8672e259(this._0x16e00478, _0x03e922d8);
    }
}