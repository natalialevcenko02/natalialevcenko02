using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xc3bbf243 : MonoBehaviour
{
    private void _0xfb955176()
    {
        if (this._0xfc27b897.canvasRenderer.GetColor() != this._0x02a01217.canvasRenderer.GetColor())
            this._0x02a01217.canvasRenderer.SetColor(this._0xfc27b897.canvasRenderer.GetColor());
    }

    private void Update()
    {
        this._0xfb955176();
    }

    private TMP_Text _0x02a01217;
    private Image _0xfc27b897;
}