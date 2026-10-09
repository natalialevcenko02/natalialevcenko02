using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x300a70fc : MonoBehaviour
{
    private TMP_Text _0xbb077fc5;
    private float _0x5d0f73e0;
    private float _0x2545f9ff = 0.6f;
    private float _0x4926879e = 4;
    private void Update()
    {
        int _0xc7a8db45 = 1;
        if (this._0x7a2d1ea9.Count > 0)
        {
            string _0xc81206be = this._0xbb077fc5.text;
            foreach (string _0x2e7d6abb in this._0x7a2d1ea9)
                while (_0xc81206be.Contains(_0x2e7d6abb))
                    _0xc81206be = _0xc81206be.Replace(_0x2e7d6abb, "");
            _0xc7a8db45 = _0xc81206be.Length;
        }
        else
        {
            _0xc7a8db45 = this._0xbb077fc5.text.Length;
        }

        float _0xb56b44e2 = Mathf.Clamp(this._0x5d0f73e0 + this._0x2545f9ff * _0xc7a8db45, this._0xabcc29fb, this._0x4926879e);
        if (!Mathf.Approximately(this._0x24830d02.aspectRatio, _0xb56b44e2))
            this._0x24830d02.aspectRatio = _0xb56b44e2;
    }

    private float _0xabcc29fb = 1.5f;
    private List<string> _0x7a2d1ea9 = new();
    private AspectRatioFitter _0x24830d02;
}