using TMPro;
using UnityEngine;
using static _0x68897f3a;

public class _0xe1ded7fc : MonoBehaviour
{
    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x0016648e;
            if (this.gameObject.TryGetComponent(out _0x0016648e))
                this.MoneyCountText = _0x0016648e;
        }

        this._0x574764d2();
    }

    public void _0x574764d2()
    {
        this.MoneyCountText.text = _0xe9080e3c._0x12295ddc.ToString();
    }
}