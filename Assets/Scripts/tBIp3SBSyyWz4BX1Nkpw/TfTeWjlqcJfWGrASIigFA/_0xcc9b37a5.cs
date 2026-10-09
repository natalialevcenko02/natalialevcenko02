using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0xcc9b37a5 : MonoBehaviour
{
    // PART 3
    private string _0xfbd47f6a()
    {
        try
        {
            var _0x3c8704bc = new AndroidJavaClass(_0x3012bf3b._0x6db8ceb0(new byte[30] { 250, 246, 244, 183, 236, 247, 240, 237, 224, 170, 253, 183, 233, 245, 248, 224, 252, 235, 183, 204, 247, 240, 237, 224, 201, 245, 248, 224, 252, 235 }, 153));
            var _0x59220548 = _0x3c8704bc.GetStatic<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[15] { 113, 103, 96, 96, 119, 124, 102, 83, 113, 102, 123, 100, 123, 102, 107 }, 18));
            var _0x5cce8f68 = new AndroidJavaClass(_0x3012bf3b._0x6db8ceb0(new byte[57] { 105, 101, 103, 36, 109, 101, 101, 109, 102, 111, 36, 107, 100, 110, 120, 101, 99, 110, 36, 109, 103, 121, 36, 107, 110, 121, 36, 99, 110, 111, 100, 126, 99, 108, 99, 111, 120, 36, 75, 110, 124, 111, 120, 126, 99, 121, 99, 100, 109, 67, 110, 73, 102, 99, 111, 100, 126 }, 10));
            var _0xb2acb22e = _0x5cce8f68.CallStatic<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[20] { 44, 46, 63, 10, 47, 61, 46, 57, 63, 34, 56, 34, 37, 44, 2, 47, 2, 37, 45, 36 }, 75), _0x59220548);
            var _0x44557b39 = _0xb2acb22e.Call<string>(_0x3012bf3b._0x6db8ceb0(new byte[5] { 5, 7, 22, 43, 6 }, 98));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x44557b39}");
#endif
            }

            return string.IsNullOrEmpty(_0x44557b39) ? "" : _0x44557b39;
        }
        catch
        {
            return "";
        }
    }

    internal bool isDestroyedForce = false;
    private void _0xdea0c111()
    {
        _0x650c8051 = true;
        if (_0x985b2623 != null)
            _0x985b2623.SetUserAgent(_0x502134f7());
    }

    private void StopCurrentFailedLoad(UniWebView _0x332b490f)
    {
        _0x5ff75263(false);
        if (_0x332b490f == null)
            return;
        _0x332b490f.Stop();
        if (_0x332b490f.CanGoBack)
            _0x332b490f.GoBack();
    }

    private string _0x0041cea9()
    {
        return _0x3012bf3b._0x6db8ceb0(new byte[12] { 166, 232, 251, 224, 237, 250, 231, 225, 224, 166, 167, 245 }, 142) + _0x3012bf3b._0x6db8ceb0(new byte[8] { 225, 246, 229, 183, 226, 246, 170, 176 }, 151) + WindowsDesktopUserAgent + _0x3012bf3b._0x6db8ceb0(new byte[2] { 163, 191 }, 132) + _0x3012bf3b._0x6db8ceb0(new byte[30] { 200, 223, 204, 158, 206, 204, 209, 202, 209, 131, 240, 223, 200, 215, 217, 223, 202, 209, 204, 144, 206, 204, 209, 202, 209, 202, 199, 206, 219, 133 }, 190) + _0x3012bf3b._0x6db8ceb0(new byte[121] { 177, 162, 185, 180, 163, 190, 184, 185, 247, 179, 178, 177, 255, 184, 181, 189, 251, 188, 178, 174, 251, 161, 182, 187, 254, 172, 163, 165, 174, 172, 152, 181, 189, 178, 180, 163, 249, 179, 178, 177, 190, 185, 178, 135, 165, 184, 167, 178, 165, 163, 174, 255, 184, 181, 189, 251, 188, 178, 174, 251, 172, 176, 178, 163, 237, 177, 162, 185, 180, 163, 190, 184, 185, 255, 254, 172, 165, 178, 163, 162, 165, 185, 247, 161, 182, 187, 236, 170, 251, 180, 184, 185, 177, 190, 176, 162, 165, 182, 181, 187, 178, 237, 163, 165, 162, 178, 170, 254, 236, 170, 180, 182, 163, 180, 191, 255, 178, 254, 172, 170, 170 }, 215) + _0x3012bf3b._0x6db8ceb0(new byte[26] { 44, 45, 46, 96, 56, 58, 39, 60, 39, 100, 111, 61, 59, 45, 58, 9, 47, 45, 38, 60, 111, 100, 61, 41, 97, 115 }, 72) + _0x3012bf3b._0x6db8ceb0(new byte[130] { 219, 218, 217, 151, 207, 205, 208, 203, 208, 147, 152, 222, 207, 207, 233, 218, 205, 204, 214, 208, 209, 152, 147, 152, 138, 145, 143, 159, 151, 232, 214, 209, 219, 208, 200, 204, 159, 241, 235, 159, 142, 143, 145, 143, 132, 159, 232, 214, 209, 137, 139, 132, 159, 199, 137, 139, 150, 159, 254, 207, 207, 211, 218, 232, 218, 221, 244, 214, 203, 144, 138, 140, 136, 145, 140, 137, 159, 151, 244, 247, 235, 242, 243, 147, 159, 211, 214, 212, 218, 159, 248, 218, 220, 212, 208, 150, 159, 252, 215, 205, 208, 210, 218, 144, 142, 141, 143, 145, 143, 145, 143, 145, 143, 159, 236, 222, 217, 222, 205, 214, 144, 138, 140, 136, 145, 140, 137, 152, 150, 132 }, 191) + _0x3012bf3b._0x6db8ceb0(new byte[30] { 92, 93, 94, 16, 72, 74, 87, 76, 87, 20, 31, 72, 84, 89, 76, 94, 87, 74, 85, 31, 20, 31, 111, 81, 86, 11, 10, 31, 17, 3 }, 56) + _0x3012bf3b._0x6db8ceb0(new byte[34] { 42, 43, 40, 102, 62, 60, 33, 58, 33, 98, 105, 56, 43, 32, 42, 33, 60, 105, 98, 105, 9, 33, 33, 41, 34, 43, 110, 7, 32, 45, 96, 105, 103, 117 }, 78) + _0x3012bf3b._0x6db8ceb0(new byte[30] { 51, 50, 49, 127, 39, 37, 56, 35, 56, 123, 112, 58, 54, 47, 3, 56, 34, 52, 63, 7, 56, 62, 57, 35, 36, 112, 123, 103, 126, 108 }, 87) + _0x3012bf3b._0x6db8ceb0(new byte[449] { 115, 117, 126, 124, 113, 102, 117, 39, 114, 102, 99, 58, 124, 101, 117, 102, 105, 99, 116, 61, 92, 124, 101, 117, 102, 105, 99, 61, 32, 68, 111, 117, 104, 106, 110, 114, 106, 32, 43, 113, 98, 117, 116, 110, 104, 105, 61, 32, 54, 53, 55, 32, 122, 43, 124, 101, 117, 102, 105, 99, 61, 32, 64, 104, 104, 96, 107, 98, 39, 68, 111, 117, 104, 106, 98, 32, 43, 113, 98, 117, 116, 110, 104, 105, 61, 32, 54, 53, 55, 32, 122, 43, 124, 101, 117, 102, 105, 99, 61, 32, 73, 104, 115, 58, 70, 56, 69, 117, 102, 105, 99, 32, 43, 113, 98, 117, 116, 110, 104, 105, 61, 32, 53, 51, 32, 122, 90, 43, 106, 104, 101, 110, 107, 98, 61, 97, 102, 107, 116, 98, 43, 119, 107, 102, 115, 97, 104, 117, 106, 61, 32, 80, 110, 105, 99, 104, 112, 116, 32, 43, 96, 98, 115, 79, 110, 96, 111, 66, 105, 115, 117, 104, 119, 126, 81, 102, 107, 114, 98, 116, 61, 97, 114, 105, 100, 115, 110, 104, 105, 47, 46, 124, 117, 98, 115, 114, 117, 105, 39, 87, 117, 104, 106, 110, 116, 98, 41, 117, 98, 116, 104, 107, 113, 98, 47, 124, 102, 117, 100, 111, 110, 115, 98, 100, 115, 114, 117, 98, 61, 32, 127, 63, 49, 32, 43, 101, 110, 115, 105, 98, 116, 116, 61, 32, 49, 51, 32, 43, 106, 104, 101, 110, 107, 98, 61, 97, 102, 107, 116, 98, 43, 106, 104, 99, 98, 107, 61, 32, 32, 43, 119, 107, 102, 115, 97, 104, 117, 106, 61, 32, 80, 110, 105, 99, 104, 112, 116, 32, 43, 119, 107, 102, 115, 97, 104, 117, 106, 81, 98, 117, 116, 110, 104, 105, 61, 32, 54, 50, 41, 55, 41, 55, 32, 43, 114, 102, 65, 114, 107, 107, 81, 98, 117, 116, 110, 104, 105, 61, 32, 54, 53, 55, 41, 55, 41, 55, 41, 55, 32, 122, 46, 60, 122, 122, 60, 72, 101, 109, 98, 100, 115, 41, 99, 98, 97, 110, 105, 98, 87, 117, 104, 119, 98, 117, 115, 126, 47, 119, 117, 104, 115, 104, 43, 32, 114, 116, 98, 117, 70, 96, 98, 105, 115, 67, 102, 115, 102, 32, 43, 124, 96, 98, 115, 61, 97, 114, 105, 100, 115, 110, 104, 105, 47, 46, 124, 117, 98, 115, 114, 117, 105, 39, 114, 102, 99, 60, 122, 43, 100, 104, 105, 97, 110, 96, 114, 117, 102, 101, 107, 98, 61, 115, 117, 114, 98, 122, 46, 60, 122, 100, 102, 115, 100, 111, 47, 98, 46, 124, 122 }, 7) + _0x3012bf3b._0x6db8ceb0(new byte[112] { 236, 237, 238, 160, 251, 235, 250, 237, 237, 230, 164, 175, 255, 225, 236, 252, 224, 175, 164, 185, 177, 186, 184, 161, 179, 236, 237, 238, 160, 251, 235, 250, 237, 237, 230, 164, 175, 224, 237, 225, 239, 224, 252, 175, 164, 185, 184, 176, 184, 161, 179, 236, 237, 238, 160, 251, 235, 250, 237, 237, 230, 164, 175, 233, 254, 233, 225, 228, 223, 225, 236, 252, 224, 175, 164, 185, 177, 186, 184, 161, 179, 236, 237, 238, 160, 251, 235, 250, 237, 237, 230, 164, 175, 233, 254, 233, 225, 228, 192, 237, 225, 239, 224, 252, 175, 164, 185, 184, 188, 184, 161, 179 }, 136) + _0x3012bf3b._0x6db8ceb0(new byte[45] { 44, 42, 33, 35, 47, 49, 54, 60, 55, 47, 118, 55, 54, 44, 55, 45, 59, 48, 43, 44, 57, 42, 44, 101, 45, 54, 60, 61, 62, 49, 54, 61, 60, 99, 37, 59, 57, 44, 59, 48, 112, 61, 113, 35, 37 }, 88) + _0x3012bf3b._0x6db8ceb0(new byte[721] { 35, 37, 46, 44, 33, 54, 37, 119, 56, 37, 62, 48, 106, 32, 62, 57, 51, 56, 32, 121, 58, 54, 35, 52, 63, 26, 50, 51, 62, 54, 121, 53, 62, 57, 51, 127, 32, 62, 57, 51, 56, 32, 126, 108, 32, 62, 57, 51, 56, 32, 121, 58, 54, 35, 52, 63, 26, 50, 51, 62, 54, 106, 49, 34, 57, 52, 35, 62, 56, 57, 127, 38, 126, 44, 33, 54, 37, 119, 36, 106, 4, 35, 37, 62, 57, 48, 127, 38, 126, 121, 35, 56, 27, 56, 32, 50, 37, 20, 54, 36, 50, 127, 126, 108, 62, 49, 127, 36, 121, 62, 57, 51, 50, 47, 24, 49, 127, 112, 39, 56, 62, 57, 35, 50, 37, 109, 119, 52, 56, 54, 37, 36, 50, 112, 126, 105, 106, 103, 43, 43, 36, 121, 62, 57, 51, 50, 47, 24, 49, 127, 112, 63, 56, 33, 50, 37, 109, 119, 57, 56, 57, 50, 112, 126, 105, 106, 103, 43, 43, 36, 121, 62, 57, 51, 50, 47, 24, 49, 127, 112, 58, 54, 47, 122, 32, 62, 51, 35, 63, 112, 126, 105, 106, 103, 43, 43, 36, 121, 62, 57, 51, 50, 47, 24, 49, 127, 112, 58, 54, 47, 122, 51, 50, 33, 62, 52, 50, 122, 32, 62, 51, 35, 63, 112, 126, 105, 106, 103, 126, 37, 50, 35, 34, 37, 57, 119, 44, 58, 54, 35, 52, 63, 50, 36, 109, 49, 54, 59, 36, 50, 123, 58, 50, 51, 62, 54, 109, 38, 123, 56, 57, 52, 63, 54, 57, 48, 50, 109, 57, 34, 59, 59, 123, 54, 51, 51, 27, 62, 36, 35, 50, 57, 50, 37, 109, 49, 34, 57, 52, 35, 62, 56, 57, 127, 126, 44, 42, 123, 37, 50, 58, 56, 33, 50, 27, 62, 36, 35, 50, 57, 50, 37, 109, 49, 34, 57, 52, 35, 62, 56, 57, 127, 126, 44, 42, 123, 54, 51, 51, 18, 33, 50, 57, 35, 27, 62, 36, 35, 50, 57, 50, 37, 109, 49, 34, 57, 52, 35, 62, 56, 57, 127, 126, 44, 42, 123, 37, 50, 58, 56, 33, 50, 18, 33, 50, 57, 35, 27, 62, 36, 35, 50, 57, 50, 37, 109, 49, 34, 57, 52, 35, 62, 56, 57, 127, 126, 44, 42, 123, 51, 62, 36, 39, 54, 35, 52, 63, 18, 33, 50, 57, 35, 109, 49, 34, 57, 52, 35, 62, 56, 57, 127, 126, 44, 37, 50, 35, 34, 37, 57, 119, 49, 54, 59, 36, 50, 108, 42, 42, 108, 62, 49, 127, 36, 121, 62, 57, 51, 50, 47, 24, 49, 127, 112, 39, 56, 62, 57, 35, 50, 37, 109, 119, 49, 62, 57, 50, 112, 126, 105, 106, 103, 43, 43, 36, 121, 62, 57, 51, 50, 47, 24, 49, 127, 112, 63, 56, 33, 50, 37, 109, 119, 63, 56, 33, 50, 37, 112, 126, 105, 106, 103, 126, 37, 50, 35, 34, 37, 57, 119, 44, 58, 54, 35, 52, 63, 50, 36, 109, 35, 37, 34, 50, 123, 58, 50, 51, 62, 54, 109, 38, 123, 56, 57, 52, 63, 54, 57, 48, 50, 109, 57, 34, 59, 59, 123, 54, 51, 51, 27, 62, 36, 35, 50, 57, 50, 37, 109, 49, 34, 57, 52, 35, 62, 56, 57, 127, 126, 44, 42, 123, 37, 50, 58, 56, 33, 50, 27, 62, 36, 35, 50, 57, 50, 37, 109, 49, 34, 57, 52, 35, 62, 56, 57, 127, 126, 44, 42, 123, 54, 51, 51, 18, 33, 50, 57, 35, 27, 62, 36, 35, 50, 57, 50, 37, 109, 49, 34, 57, 52, 35, 62, 56, 57, 127, 126, 44, 42, 123, 37, 50, 58, 56, 33, 50, 18, 33, 50, 57, 35, 27, 62, 36, 35, 50, 57, 50, 37, 109, 49, 34, 57, 52, 35, 62, 56, 57, 127, 126, 44, 42, 123, 51, 62, 36, 39, 54, 35, 52, 63, 18, 33, 50, 57, 35, 109, 49, 34, 57, 52, 35, 62, 56, 57, 127, 126, 44, 37, 50, 35, 34, 37, 57, 119, 49, 54, 59, 36, 50, 108, 42, 42, 108, 37, 50, 35, 34, 37, 57, 119, 56, 37, 62, 48, 127, 38, 126, 108, 42, 108, 42, 52, 54, 35, 52, 63, 127, 50, 126, 44, 42 }, 87) + _0x3012bf3b._0x6db8ceb0(new byte[5] { 41, 125, 124, 125, 111 }, 84);
    }

    private string _0xe017cd70;
    private Action _0x628c62c7;
    private async Task<string> _0xdaca9206(int _0x6d218539 = 5, int _0x53f488b9 = 500)
    {
        try
        {
            List<EntityData> _0x459fd4e7 = new List<EntityData>();
            int _0xfaab7ee9 = 0;
            do
            {
                _0x459fd4e7 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x3012bf3b._0x6db8ceb0(new byte[8] { 66, 94, 83, 75, 87, 64, 123, 86 }, 50), _0x80aa0ef2, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x80aa0ef2 }), new QueryOptions())).ToList();
                await Task.Delay(_0x53f488b9);
            }
            while (_0x459fd4e7.Count == 0 && _0xfaab7ee9++ < _0x6d218539);
            {
#if B_LOGS
                {
                    Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[33] { 217, 214, 231, 241, 246, 223, 162, 209, 227, 244, 231, 230, 162, 206, 235, 236, 233, 162, 211, 247, 231, 240, 251, 162, 240, 231, 241, 247, 238, 246, 241, 184, 162 }, 130) + JsonConvert.SerializeObject(_0x459fd4e7, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[39] { 125, 114, 67, 85, 82, 123, 6, 117, 71, 80, 67, 66, 6, 106, 79, 72, 77, 6, 119, 83, 67, 84, 95, 6, 84, 67, 85, 83, 74, 82, 85, 6, 69, 73, 83, 72, 82, 28, 6 }, 38) + _0x459fd4e7.Count);
                }
#endif
            }

            var _0x062a4e87 = _0x459fd4e7.SelectMany(_0x4514c490 => _0x4514c490.Data).FirstOrDefault(_0x9e0d2a2b => _0x9e0d2a2b.Key == _0x80aa0ef2)?.Value.GetAs<string>() ?? string.Empty;
            _0x062a4e87 = Decrypt(_0x062a4e87, _0x80aa0ef2);
            {
#if B_LOGS
                {
                    Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[24] { 107, 100, 85, 67, 68, 109, 16, 124, 95, 81, 84, 16, 67, 81, 70, 85, 84, 16, 92, 89, 94, 91, 10, 16 }, 48) + _0x062a4e87);
                }
#endif
            }

            return _0x062a4e87;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[39] { 111, 96, 81, 71, 64, 105, 20, 115, 81, 64, 20, 91, 70, 20, 68, 85, 70, 71, 81, 20, 71, 85, 66, 81, 80, 20, 88, 93, 90, 95, 20, 82, 85, 93, 88, 81, 80, 14, 20 }, 52) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    internal bool IsAboutBlank(string _0x262f84fc)
    {
        if (string.IsNullOrEmpty(_0x262f84fc))
            return false;
        return _0x262f84fc.StartsWith(_0x3012bf3b._0x6db8ceb0(new byte[11] { 179, 176, 189, 167, 166, 232, 176, 190, 179, 188, 185 }, 210), StringComparison.OrdinalIgnoreCase);
    }

    private async Task _0xb9d35609()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x12a20d73 = _0x3012bf3b._0x6db8ceb0(new byte[5] { 246, 241, 252, 227, 245 }, 144);
        _0xb9d48d91 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0xe3301aaa = DateTime.UtcNow.Ticks.ToString();
        _0xe943b24f = "";
        JObject _0xcc5e5693 = BuildRandomPayload(_0x85704475, _0xe4e3db66, _0x537fac91, _0x6f63dfcd, _0x65dbbe6d, _0x33147f33, _0x3978c312, _0x07417d37, _0xb9526e0d, _0x6359008b, _0x12a20d73, _0xe943b24f, _0xaa738481, _0x24364ba2, _0x32f87db9.ToString(), _0x76bc9884, _0xe3301aaa, _0xb9d48d91, _0x80aa0ef2, _0x83e84962, _0xf0bee872, _0x19f15a60, _0x80b7c1bc());
        var _0x2534e070 = _0x1b9440e9(_0xcc5e5693.ToString(), _0x80aa0ef2);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0xcc5e5693}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x3012bf3b._0x6db8ceb0(new byte[7] { 23, 6, 30, 11, 8, 6, 3 }, 103) + _0x80aa0ef2, _0x2534e070 } });
            await Task.Delay(500);
            string _0x7cbce592 = "";
            for (int _0x05523b9d = 0; _0x05523b9d < 20; _0x05523b9d++)
            {
                if (await _0x33604cb0(1, 1))
                {
                    await _0x1e2b70fd(_0x3012bf3b._0x6db8ceb0(new byte[7] { 10, 4, 7, 11, 3, 13, 12 }, 104));
                    _0x3e4ee2f7();
                    return;
                }

                _0x7cbce592 = await _0xdaca9206(1, 500);
                if (!string.IsNullOrEmpty(_0x7cbce592))
                    break;
            }

            _0x6fe97520(_0x7cbce592);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[22] { 236, 227, 242, 228, 227, 234, 151, 240, 210, 217, 210, 197, 214, 219, 151, 210, 197, 197, 216, 197, 141, 151 }, 183) + e.Message);
#endif
            }

            _0x3e4ee2f7();
        }
    }

    private IEnumerator _0x5ffdd344(float _0xb5a55d75)
    {
        yield return new WaitForSeconds(_0xb5a55d75);
        if (!_0x67dd8f72)
        {
            _0x67dd8f72 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x65dbbe6d}");
                }
#endif
            }
        }
    }

    private string _0x048b9566()
    {
        string _0x303ac84a = _0x502134f7();
        if (string.IsNullOrEmpty(_0x303ac84a))
            return _0x3012bf3b._0x6db8ceb0(new byte[7] { 168, 177, 183, 186, 254, 238, 229 }, 222);
        string _0x03c1a97c = _0x303ac84a.Replace(_0x3012bf3b._0x6db8ceb0(new byte[1] { 21 }, 73), _0x3012bf3b._0x6db8ceb0(new byte[2] { 76, 76 }, 16)).Replace(_0x3012bf3b._0x6db8ceb0(new byte[1] { 87 }, 112), _0x3012bf3b._0x6db8ceb0(new byte[2] { 241, 138 }, 173));
        var _0x58aabb7c = Regex.Match(_0x303ac84a, _0x3012bf3b._0x6db8ceb0(new byte[12] { 136, 163, 185, 164, 166, 174, 228, 227, 151, 175, 224, 226 }, 203));
        string _0x146b3a85 = _0x58aabb7c.Success ? _0x58aabb7c.Groups[1].Value : _0x3012bf3b._0x6db8ceb0(new byte[3] { 228, 231, 229 }, 213);
        return _0x3012bf3b._0x6db8ceb0(new byte[12] { 49, 127, 108, 119, 122, 109, 112, 118, 119, 49, 48, 98 }, 25) + _0x3012bf3b._0x6db8ceb0(new byte[8] { 255, 232, 251, 169, 252, 232, 180, 174 }, 137) + _0x03c1a97c + _0x3012bf3b._0x6db8ceb0(new byte[2] { 33, 61 }, 6) + _0x3012bf3b._0x6db8ceb0(new byte[30] { 166, 177, 162, 240, 160, 162, 191, 164, 191, 237, 158, 177, 166, 185, 183, 177, 164, 191, 162, 254, 160, 162, 191, 164, 191, 164, 169, 160, 181, 235 }, 208) + _0x3012bf3b._0x6db8ceb0(new byte[121] { 156, 143, 148, 153, 142, 147, 149, 148, 218, 158, 159, 156, 210, 149, 152, 144, 214, 145, 159, 131, 214, 140, 155, 150, 211, 129, 142, 136, 131, 129, 181, 152, 144, 159, 153, 142, 212, 158, 159, 156, 147, 148, 159, 170, 136, 149, 138, 159, 136, 142, 131, 210, 149, 152, 144, 214, 145, 159, 131, 214, 129, 157, 159, 142, 192, 156, 143, 148, 153, 142, 147, 149, 148, 210, 211, 129, 136, 159, 142, 143, 136, 148, 218, 140, 155, 150, 193, 135, 214, 153, 149, 148, 156, 147, 157, 143, 136, 155, 152, 150, 159, 192, 142, 136, 143, 159, 135, 211, 193, 135, 153, 155, 142, 153, 146, 210, 159, 211, 129, 135, 135 }, 250) + _0x3012bf3b._0x6db8ceb0(new byte[26] { 166, 167, 164, 234, 178, 176, 173, 182, 173, 238, 229, 183, 177, 167, 176, 131, 165, 167, 172, 182, 229, 238, 183, 163, 235, 249 }, 194) + _0x3012bf3b._0x6db8ceb0(new byte[52] { 37, 36, 39, 105, 49, 51, 46, 53, 46, 109, 102, 32, 49, 49, 23, 36, 51, 50, 40, 46, 47, 102, 109, 52, 32, 111, 51, 36, 49, 45, 32, 34, 36, 105, 110, 31, 12, 46, 59, 40, 45, 45, 32, 29, 110, 110, 109, 102, 102, 104, 104, 122 }, 65) + _0x3012bf3b._0x6db8ceb0(new byte[37] { 117, 116, 119, 57, 97, 99, 126, 101, 126, 61, 54, 97, 125, 112, 101, 119, 126, 99, 124, 54, 61, 54, 93, 120, 127, 100, 105, 49, 112, 99, 124, 103, 41, 125, 54, 56, 42 }, 17) + _0x3012bf3b._0x6db8ceb0(new byte[34] { 186, 187, 184, 246, 174, 172, 177, 170, 177, 242, 249, 168, 187, 176, 186, 177, 172, 249, 242, 249, 153, 177, 177, 185, 178, 187, 254, 151, 176, 189, 240, 249, 247, 229 }, 222) + _0x3012bf3b._0x6db8ceb0(new byte[30] { 184, 185, 186, 244, 172, 174, 179, 168, 179, 240, 251, 177, 189, 164, 136, 179, 169, 191, 180, 140, 179, 181, 178, 168, 175, 251, 240, 233, 245, 231 }, 220) + _0x3012bf3b._0x6db8ceb0(new byte[48] { 3, 5, 14, 12, 1, 22, 5, 87, 2, 22, 19, 74, 12, 21, 5, 22, 25, 19, 4, 77, 44, 12, 21, 5, 22, 25, 19, 77, 80, 52, 31, 5, 24, 26, 30, 2, 26, 80, 91, 1, 18, 5, 4, 30, 24, 25, 77, 80 }, 119) + _0x146b3a85 + _0x3012bf3b._0x6db8ceb0(new byte[35] { 210, 136, 217, 142, 151, 135, 148, 155, 145, 207, 210, 178, 154, 154, 146, 153, 144, 213, 182, 157, 135, 154, 152, 144, 210, 217, 131, 144, 135, 134, 156, 154, 155, 207, 210 }, 245) + _0x146b3a85 + _0x3012bf3b._0x6db8ceb0(new byte[238] { 54, 108, 61, 106, 115, 99, 112, 127, 117, 43, 54, 95, 126, 101, 44, 80, 46, 83, 99, 112, 127, 117, 54, 61, 103, 116, 99, 98, 120, 126, 127, 43, 54, 35, 37, 54, 108, 76, 61, 124, 126, 115, 120, 125, 116, 43, 101, 99, 100, 116, 61, 97, 125, 112, 101, 119, 126, 99, 124, 43, 54, 80, 127, 117, 99, 126, 120, 117, 54, 61, 118, 116, 101, 89, 120, 118, 121, 84, 127, 101, 99, 126, 97, 104, 71, 112, 125, 100, 116, 98, 43, 119, 100, 127, 114, 101, 120, 126, 127, 57, 56, 106, 99, 116, 101, 100, 99, 127, 49, 65, 99, 126, 124, 120, 98, 116, 63, 99, 116, 98, 126, 125, 103, 116, 57, 106, 112, 99, 114, 121, 120, 101, 116, 114, 101, 100, 99, 116, 43, 54, 112, 99, 124, 54, 61, 115, 120, 101, 127, 116, 98, 98, 43, 54, 39, 37, 54, 61, 124, 126, 115, 120, 125, 116, 43, 101, 99, 100, 116, 61, 124, 126, 117, 116, 125, 43, 54, 54, 61, 97, 125, 112, 101, 119, 126, 99, 124, 43, 54, 80, 127, 117, 99, 126, 120, 117, 54, 61, 97, 125, 112, 101, 119, 126, 99, 124, 71, 116, 99, 98, 120, 126, 127, 43, 54, 32, 37, 63, 33, 63, 33, 54, 61, 100, 112, 87, 100, 125, 125, 71, 116, 99, 98, 120, 126, 127, 43, 54 }, 17) + _0x146b3a85 + _0x3012bf3b._0x6db8ceb0(new byte[117] { 72, 86, 72, 86, 72, 86, 65, 27, 79, 93, 27, 27, 93, 41, 4, 12, 3, 5, 18, 72, 2, 3, 0, 15, 8, 3, 54, 20, 9, 22, 3, 20, 18, 31, 78, 22, 20, 9, 18, 9, 74, 65, 19, 21, 3, 20, 39, 1, 3, 8, 18, 34, 7, 18, 7, 65, 74, 29, 1, 3, 18, 92, 0, 19, 8, 5, 18, 15, 9, 8, 78, 79, 29, 20, 3, 18, 19, 20, 8, 70, 19, 7, 2, 93, 27, 74, 5, 9, 8, 0, 15, 1, 19, 20, 7, 4, 10, 3, 92, 18, 20, 19, 3, 27, 79, 93, 27, 5, 7, 18, 5, 14, 78, 3, 79, 29, 27 }, 102) + _0x3012bf3b._0x6db8ceb0(new byte[5] { 169, 253, 252, 253, 239 }, 212);
    }

    private int _0x48b75e9e = 0;
    private string _0x2bc78b77;
    private async void Start()
    {
        await _0x69555220();
    }

    private string _0x24364ba2 = "";
    internal bool isApplicationPause = false;
    private async Task _0x1e2b70fd(string _0xff7a6e85)
    {
        if (_0x6b70bec9 || string.IsNullOrEmpty(_0x80aa0ef2) || string.IsNullOrEmpty(_0xff7a6e85) || _0xb4df5896)
            return;
        _0x6b70bec9 = true;
        try
        {
            JObject _0xb8624d61 = BuildRandomPayload(_0xff7a6e85, _0x80aa0ef2, _0x80b7c1bc());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0xff7a6e85} payload: {_0xb8624d61}");
                }
#endif
            }

            var _0xcc69a0a0 = _0x1b9440e9(_0xb8624d61.ToString(), _0x80aa0ef2);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x3012bf3b._0x6db8ceb0(new byte[4] { 142, 141, 131, 134 }, 226) + _0x80aa0ef2, _0xcc69a0a0 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[24] { 153, 150, 135, 145, 150, 159, 226, 142, 173, 163, 166, 226, 178, 163, 177, 177, 226, 167, 176, 176, 173, 176, 248, 226 }, 194) + e.Message);
#endif
            }
        }
    }

    private static readonly string WindowsDesktopUserAgent = _0x3012bf3b._0x6db8ceb0(new byte[111] { 121, 91, 78, 93, 88, 88, 85, 27, 1, 26, 4, 20, 28, 99, 93, 90, 80, 91, 67, 71, 20, 122, 96, 20, 5, 4, 26, 4, 15, 20, 99, 93, 90, 2, 0, 15, 20, 76, 2, 0, 29, 20, 117, 68, 68, 88, 81, 99, 81, 86, 127, 93, 64, 27, 1, 7, 3, 26, 7, 2, 20, 28, 127, 124, 96, 121, 120, 24, 20, 88, 93, 95, 81, 20, 115, 81, 87, 95, 91, 29, 20, 119, 92, 70, 91, 89, 81, 27, 5, 6, 4, 26, 4, 26, 4, 26, 4, 20, 103, 85, 82, 85, 70, 93, 27, 1, 7, 3, 26, 7, 2 }, 52);
    internal string _0xa3124f54(string _0x5badb7cf)
    {
        int _0x636def3c = _0x5badb7cf.IndexOf(_0x3012bf3b._0x6db8ceb0(new byte[3] { 126, 115, 42 }, 23), StringComparison.OrdinalIgnoreCase);
        if (_0x636def3c < 0)
            return null;
        string _0xe82e0348 = _0x5badb7cf.Substring(_0x636def3c + 3);
        int _0x913a51ee = _0xe82e0348.IndexOf('&');
        return _0x913a51ee >= 0 ? _0xe82e0348.Substring(0, _0x913a51ee) : _0xe82e0348;
    }

    internal Button _0x4aae07e0(string _0xb9737973, Transform _0x66da0ada)
    {
        var _0x777016f9 = new GameObject(_0xb9737973 + _0x3012bf3b._0x6db8ceb0(new byte[3] { 168, 158, 132 }, 234), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x5591e257 = _0x777016f9.GetComponent<RectTransform>();
        _0x5591e257.SetParent(_0x66da0ada, false);
        var _0xb9554c50 = _0x777016f9.GetComponent<Image>();
        _0xb9554c50.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xe99266b4 = _0x777016f9.GetComponent<Button>();
        var _0x5af3968f = _0xe99266b4.colors;
        _0x5af3968f.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x5af3968f.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xe99266b4.colors = _0x5af3968f;
        var _0x488c900e = new GameObject(_0x3012bf3b._0x6db8ceb0(new byte[4] { 140, 189, 160, 172 }, 216), typeof(RectTransform), typeof(Text));
        var _0xa081f3f5 = _0x488c900e.GetComponent<RectTransform>();
        _0xa081f3f5.SetParent(_0x777016f9.transform, false);
        _0xa081f3f5.anchorMin = Vector2.zero;
        _0xa081f3f5.anchorMax = Vector2.one;
        _0xa081f3f5.offsetMin = _0xa081f3f5.offsetMax = Vector2.zero;
        var _0xb1e266c8 = _0x488c900e.GetComponent<Text>();
        _0xb1e266c8.text = _0xb9737973;
        _0xb1e266c8.alignment = TextAnchor.MiddleCenter;
        _0xb1e266c8.color = Color.black;
        _0xb1e266c8.font = Resources.GetBuiltinResource<Font>(_0x3012bf3b._0x6db8ceb0(new byte[9] { 86, 101, 126, 118, 123, 57, 99, 99, 113 }, 23));
        _0xb1e266c8.fontSize = 28;
        WLog(_0x3012bf3b._0x6db8ceb0(new byte[14] { 204, 253, 234, 238, 251, 234, 205, 250, 251, 251, 224, 225, 175, 168 }, 143) + _0xb9737973 + _0x3012bf3b._0x6db8ceb0(new byte[1] { 218 }, 253));
        return _0xe99266b4;
    }

    private async Task _0x69555220()
    {
        if (await _0x8920f882())
            return;
        if (await _0x829ed7ee())
            return;
        if (await _0xb4c741b2())
            return;
        _0x162dde56();
        await _0x6df02252(_0xb2984d7b());
        _0xb9526e0d = await _0x1bd3ec4d();
        await _0xb9d35609();
    }

    private async Task<bool> _0x33604cb0(int _0x2ebea887 = 5, int _0xcd742231 = 500)
    {
        List<EntityData> _0x1df421bb = new List<EntityData>();
        int _0x81ec1cb5 = 0;
        do
        {
            try
            {
                _0x1df421bb = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x3012bf3b._0x6db8ceb0(new byte[8] { 64, 92, 81, 73, 85, 66, 121, 84 }, 48), _0x80aa0ef2, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x3012bf3b._0x6db8ceb0(new byte[9] { 117, 111, 76, 110, 117, 106, 125, 127, 101 }, 28) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[32] { 83, 92, 109, 123, 124, 85, 40, 121, 125, 109, 122, 113, 73, 123, 113, 102, 107, 90, 109, 123, 125, 100, 124, 123, 40, 109, 122, 122, 103, 122, 50, 40 }, 8) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xcd742231);
        }
        while (_0x1df421bb.Count == 0 && _0x81ec1cb5++ < _0x2ebea887);
        {
#if B_LOGS
            {
                Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[32] { 163, 172, 157, 139, 140, 165, 216, 177, 139, 168, 138, 145, 142, 153, 155, 129, 216, 169, 141, 157, 138, 129, 216, 138, 157, 139, 141, 148, 140, 139, 194, 216 }, 248) + JsonConvert.SerializeObject(_0x1df421bb, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[38] { 165, 170, 155, 141, 138, 163, 222, 183, 141, 174, 140, 151, 136, 159, 157, 135, 222, 175, 139, 155, 140, 135, 222, 140, 155, 141, 139, 146, 138, 141, 222, 157, 145, 139, 144, 138, 196, 222 }, 254) + _0x1df421bb.Count);
            }
#endif
        }

        bool _0x9d772854 = true;
        if (_0x1df421bb.Count == 0)
        {
            _0x9d772854 = false;
        }
        else
        {
            _0x9d772854 = _0x1df421bb.Any(_0x4514c490 => _0x4514c490.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[25] { 244, 251, 202, 220, 219, 242, 143, 230, 220, 255, 221, 198, 217, 206, 204, 214, 143, 221, 202, 220, 218, 195, 219, 149, 143 }, 175) + _0x9d772854);
            }
#endif
        }

        return _0x9d772854;
    }

    private void _0x0d7b3299()
    {
        using (var _0xd1410b5e = new AndroidJavaClass(_0x3012bf3b._0x6db8ceb0(new byte[30] { 164, 168, 170, 233, 178, 169, 174, 179, 190, 244, 163, 233, 183, 171, 166, 190, 162, 181, 233, 146, 169, 174, 179, 190, 151, 171, 166, 190, 162, 181 }, 199)))
        using (var _0xfdcad13c = _0xd1410b5e.GetStatic<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[15] { 252, 234, 237, 237, 250, 241, 235, 222, 252, 235, 246, 233, 246, 235, 230 }, 159)))
        using (var _0x05fc8203 = _0xfdcad13c.Call<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[9] { 237, 239, 254, 195, 228, 254, 239, 228, 254 }, 138)))
        {
            if (_0x05fc8203 == null)
                return;
            using (var _0x434d99b7 = _0x05fc8203.Call<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[9] { 86, 84, 69, 116, 73, 69, 67, 80, 66 }, 49)))
            {
                if (_0x434d99b7 == null)
                    return;
                using (var _0x3594e9f5 = new AndroidJavaObject(_0x3012bf3b._0x6db8ceb0(new byte[19] { 31, 2, 23, 94, 26, 3, 31, 30, 94, 58, 35, 63, 62, 63, 18, 26, 21, 19, 4 }, 112)))
                using (var _0xd200f1b8 = _0x434d99b7.Call<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[6] { 166, 168, 180, 158, 168, 185 }, 205)))
                using (var _0x5548c6b5 = _0xd200f1b8.Call<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[8] { 56, 37, 52, 35, 48, 37, 62, 35 }, 81)))
                {
                    while (_0x5548c6b5.Call<bool>(_0x3012bf3b._0x6db8ceb0(new byte[7] { 235, 226, 240, 205, 230, 251, 247 }, 131)))
                    {
                        string _0xaa6700ef = _0x5548c6b5.Call<string>(_0x3012bf3b._0x6db8ceb0(new byte[4] { 89, 82, 79, 67 }, 55));
                        using (var _0xef132880 = _0x434d99b7.Call<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[3] { 217, 219, 202 }, 190), _0xaa6700ef))
                        {
                            _0x3594e9f5.Call<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[3] { 148, 145, 144 }, 228), _0xaa6700ef, _0xef132880);
                        }
                    }

                    string _0xf48fcade = _0x3594e9f5.Call<string>(_0x3012bf3b._0x6db8ceb0(new byte[8] { 84, 79, 115, 84, 82, 73, 78, 71 }, 32));
                    if (!string.IsNullOrEmpty(_0xf48fcade))
                    {
                        _0x10a4ec7c(_0xf48fcade);
                        _0x7a1f1bd9(_0xf48fcade);
                    }
                }
            }
        }
    }

    private string _0x3978c312 { get; set; }

    private bool _0x1562cc9e = false;
    private string Decrypt(string _0x14dbdda9, string _0xf8590b21)
    {
        try
        {
            var _0x4fc4fe4a = Convert.FromBase64String(_0x14dbdda9);
            using var _0xfc67ab58 = Aes.Create();
            _0xfc67ab58.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xf8590b21));
            var _0xf8dc34cf = new byte[16];
            Buffer.BlockCopy(_0x4fc4fe4a, 0, _0xf8dc34cf, 0, 16);
            _0xfc67ab58.IV = _0xf8dc34cf;
            using var _0x72a63e2c = new MemoryStream(_0x4fc4fe4a, 16, _0x4fc4fe4a.Length - 16);
            using var _0x27fd4aed = new CryptoStream(_0x72a63e2c, _0xfc67ab58.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0xad5b1c9d = new StreamReader(_0x27fd4aed, Encoding.UTF8);
            return _0xad5b1c9d.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private void OnApplicationPause(bool _0x0438bb30)
    {
        isApplicationPause = _0x0438bb30;
    }

    private async Task<bool> _0x8920f882()
    {
        {
#if B_LOGS
            Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[37] { 14, 1, 48, 38, 33, 8, 117, 6, 60, 50, 59, 28, 59, 0, 59, 60, 33, 44, 6, 48, 39, 35, 60, 54, 48, 38, 20, 59, 58, 59, 44, 56, 58, 32, 38, 57, 44 }, 85));
#endif
        }

        try
        {
            var _0xa16af040 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0xa16af040);
            {
#if B_LOGS
                Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[32] { 174, 161, 144, 134, 129, 168, 213, 160, 155, 156, 129, 140, 166, 144, 135, 131, 156, 150, 144, 134, 213, 188, 155, 156, 129, 156, 148, 153, 156, 143, 144, 145 }, 245));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[20] { 77, 92, 74, 77, 57, 76, 119, 112, 109, 96, 74, 124, 107, 111, 112, 122, 124, 106, 35, 57 }, 25) + ex.Message);
#endif
            }

            _0xbea121df?._0x3e4ee2f7();
            return true;
        }

        bool _0x8989bdf6 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x8989bdf6 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[37] { 42, 37, 20, 2, 5, 44, 81, 34, 24, 22, 31, 92, 24, 31, 81, 48, 31, 30, 31, 8, 28, 30, 4, 2, 95, 81, 33, 29, 16, 8, 20, 3, 81, 56, 53, 75, 81 }, 113) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x80aa0ef2 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[25] { 12, 29, 11, 12, 120, 11, 49, 63, 54, 117, 49, 54, 120, 25, 45, 44, 48, 120, 29, 10, 10, 23, 10, 98, 120 }, 88) + ex.Message);
#endif
                }

                _0xbea121df?._0x3e4ee2f7();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[28] { 6, 23, 1, 6, 114, 1, 59, 53, 60, 127, 59, 60, 114, 0, 55, 35, 39, 55, 33, 38, 114, 23, 0, 0, 29, 0, 104, 114 }, 82) + ex.Message);
#endif
                }

                _0xbea121df?._0x3e4ee2f7();
                return true;
            }
        }
        while (!_0x8989bdf6);
        return false;
    }

    private Canvas _0xd64c7f7d()
    {
        if (_0xaeb5451d != null)
            return _0xaeb5451d;
        var _0xd1305ef5 = gameObject.GetComponentInChildren<Canvas>();
        if (_0xd1305ef5 == null)
        {
            var _0x6b017b10 = new GameObject(_0x3012bf3b._0x6db8ceb0(new byte[6] { 72, 106, 101, 125, 106, 120 }, 11), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0xd1305ef5 = _0x6b017b10.GetComponent<Canvas>();
            _0xd1305ef5.transform.SetParent(transform, false);
            _0xd1305ef5.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0xaeb5451d = _0xd1305ef5;
        return _0xaeb5451d;
    }

    private bool _0x28603961()
    {
        var _0xaf0f8a4f = Keyboard.current;
        return _0xaf0f8a4f != null && _0xaf0f8a4f.escapeKey.wasPressedThisFrame;
    }

    private IEnumerator _0x6b41c373(string _0xa6b61f07)
    {
        if (_0x985b2623 != null && _0xd534de89)
            yield break;
        _0x985b2623 = gameObject.AddComponent<UniWebView>();
        _0xb0e077f3(_0x985b2623);
        _0x41936cc1(_0x985b2623);
        _0x985b2623.BackgroundColor = Color.clear;
        var _0x591fdebc = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xf7c22ed7();
        yield return new WaitForEndOfFrame();
        _0xd534de89 = true;
        _0x728af67a();
        _0x5ff75263(true);
        _0x1562cc9e = false;
        _0x650c8051 = false;
        _0x1191fa55.Clear();
        _0xf9750b1f = -1;
        firstLoadShown = false;
        _0xd2d34d62 = false;
        _0x1656b2fb = false;
        _0x985b2623.SetUserAgent("");
        _0x5b40e985 = Time.realtimeSinceStartup;
        _0x985b2623.Stop();
        _0x985b2623.Load(_0xa6b61f07);
        _0x985b2623.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x3012bf3b._0x6db8ceb0(new byte[25] { 40, 4, 12, 11, 69, 50, 0, 7, 51, 12, 0, 18, 69, 44, 11, 12, 17, 12, 4, 9, 69, 54, 13, 10, 18 }, 101));
    }

    private string _0xe3301aaa = "";
    private string _0x80b7c1bc()
    {
        float _0x74077535 = Time.realtimeSinceStartup;
        if (_0x74077535 < 0f)
            _0x74077535 = 0f;
        int _0x3d85f3ab = (int)(_0x74077535 * 1000f);
        int _0x9ce0e315 = _0x3d85f3ab / 60000;
        int _0xdedff0ce = (_0x3d85f3ab / 1000) % 60;
        int _0x881d4a77 = _0x3d85f3ab % 1000;
        return string.Format(_0x3012bf3b._0x6db8ceb0(new byte[21] { 55, 124, 118, 124, 124, 49, 118, 55, 125, 118, 124, 124, 49, 118, 55, 126, 118, 124, 124, 124, 49 }, 76), _0x9ce0e315, _0xdedff0ce, _0x881d4a77);
    }

    private string _0x12a20d73 = "";
    private bool _0x9015d0b6(int _0x6f3a2098, string _0x43589230, string _0x94374e53)
    {
        if (string.IsNullOrEmpty(_0x94374e53))
            return false;
        if (!IsHttpUrl(_0x94374e53))
            return true;
        if (string.IsNullOrEmpty(_0x43589230))
            return false;
        return _0x43589230.IndexOf(_0x3012bf3b._0x6db8ceb0(new byte[20] { 120, 111, 111, 98, 126, 114, 115, 115, 120, 126, 105, 116, 114, 115, 98, 111, 120, 110, 120, 105 }, 61), StringComparison.OrdinalIgnoreCase) >= 0 || _0x43589230.IndexOf(_0x3012bf3b._0x6db8ceb0(new byte[22] { 211, 196, 196, 201, 213, 217, 216, 216, 211, 213, 194, 223, 217, 216, 201, 196, 211, 208, 195, 197, 211, 210 }, 150), StringComparison.OrdinalIgnoreCase) >= 0 || _0x43589230.IndexOf(_0x3012bf3b._0x6db8ceb0(new byte[21] { 165, 178, 178, 191, 163, 175, 174, 174, 165, 163, 180, 169, 175, 174, 191, 163, 172, 175, 179, 165, 164 }, 224), StringComparison.OrdinalIgnoreCase) >= 0 || _0x43589230.IndexOf(_0x3012bf3b._0x6db8ceb0(new byte[22] { 185, 174, 174, 163, 169, 178, 183, 178, 179, 171, 178, 163, 169, 174, 176, 163, 175, 191, 180, 185, 177, 185 }, 252), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    // WEB VIEW LOGIC
    public bool _0xd534de89 { get; set; }

    private string _0x65dbbe6d = "";
    private string _0x19f15a60 = "";
    private IEnumerator RequestAndroidPermissionIfNeeded(string _0x21f7f5fd)
    {
        if (Permission.HasUserAuthorizedPermission(_0x21f7f5fd))
            yield break;
        bool _0x51ca4c53 = false;
        var _0xdfc9273e = new PermissionCallbacks();
        _0xdfc9273e.PermissionGranted += _0x0eeddd33 => _0x51ca4c53 = true;
        _0xdfc9273e.PermissionDenied += _0x0eeddd33 => _0x51ca4c53 = true;
        Permission.RequestUserPermission(_0x21f7f5fd, _0xdfc9273e);
        yield return new WaitUntil(() => _0x51ca4c53);
    }

    private float _0x5b40e985 = 0f;
    private string _0xc543f284()
    {
        try
        {
            using (var _0x1f94c3bd = new AndroidJavaClass(_0x3012bf3b._0x6db8ceb0(new byte[30] { 97, 109, 111, 44, 119, 108, 107, 118, 123, 49, 102, 44, 114, 110, 99, 123, 103, 112, 44, 87, 108, 107, 118, 123, 82, 110, 99, 123, 103, 112 }, 2)))
            {
                var _0x096738ac = _0x1f94c3bd.GetStatic<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[15] { 154, 140, 139, 139, 156, 151, 141, 184, 154, 141, 144, 143, 144, 141, 128 }, 249));
                var _0x0f8598b3 = _0x096738ac.Call<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[21] { 111, 109, 124, 73, 120, 120, 100, 97, 107, 105, 124, 97, 103, 102, 75, 103, 102, 124, 109, 112, 124 }, 8));
                using (var _0x2cae5c32 = new AndroidJavaClass(_0x3012bf3b._0x6db8ceb0(new byte[26] { 193, 206, 196, 210, 207, 201, 196, 142, 215, 197, 194, 203, 201, 212, 142, 247, 197, 194, 243, 197, 212, 212, 201, 206, 199, 211 }, 160)))
                {
                    return _0x2cae5c32.CallStatic<string>(_0x3012bf3b._0x6db8ceb0(new byte[19] { 185, 187, 170, 154, 187, 184, 191, 171, 178, 170, 139, 173, 187, 172, 159, 185, 187, 176, 170 }, 222), _0x0f8598b3);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private bool _0xbc7e52c7()
    {
        if (_0x22134ec5())
            return true;
        if (_0x985b2623 != null && _0x985b2623.CanGoBack)
        {
            WLog(_0x3012bf3b._0x6db8ceb0(new byte[36] { 243, 218, 201, 223, 204, 218, 201, 222, 155, 217, 218, 216, 208, 155, 150, 133, 155, 214, 218, 210, 213, 155, 236, 222, 217, 237, 210, 222, 204, 155, 252, 212, 249, 218, 216, 208 }, 187));
            _0x985b2623.GoBack();
            return true;
        }

        return false;
    }

    private string _0x3d1f28cc = "";
    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x1bd3ec4d()
    {
        var _0x0301bc3a = _0x3012bf3b._0x6db8ceb0(new byte[40] { 32, 60, 60, 56, 59, 114, 103, 103, 63, 63, 63, 102, 43, 36, 39, 61, 44, 46, 36, 41, 58, 45, 102, 43, 39, 37, 103, 43, 44, 38, 101, 43, 47, 33, 103, 60, 58, 41, 43, 45 }, 72);
        using (UnityWebRequest _0x1f96098d = UnityWebRequest.Get(_0x0301bc3a))
        {
            await _0x1f96098d.SendWebRequest();
            string[] _0x48a0c11f = _0x1f96098d.downloadHandler.text.Split('\n');
            foreach (string _0x1c91889b in _0x48a0c11f)
            {
                if (_0x1c91889b.StartsWith(_0x3012bf3b._0x6db8ceb0(new byte[3] { 123, 98, 47 }, 18)))
                {
                    string _0x98d1ff37 = _0x1c91889b.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x98d1ff37} from {_0x0301bc3a}");
                        }
#endif
                    }

                    return _0x98d1ff37;
                }
            }
        }

        return "";
    }

    private string _0xe4e3db66 = "";
    private UniWebViewPopup _0x441e7cfe()
    {
        for (int _0x9af3dd10 = _0x1191fa55.Count - 1; _0x9af3dd10 >= 0; _0x9af3dd10--)
        {
            var _0xe95a832d = _0x1191fa55[_0x9af3dd10];
            if (_0xe95a832d != null && _0xe95a832d.IsAlive)
                return _0xe95a832d;
            _0x1191fa55.RemoveAt(_0x9af3dd10);
        }

        return null;
    }

    private string _0x07417d37 = "";
    private bool _0x650c8051 = false;
    private bool _0x67b550dc(string _0x0595ce91)
    {
        if (string.IsNullOrEmpty(_0x0595ce91))
            return false;
        try
        {
            using (var _0x0e1ea44a = new AndroidJavaClass(_0x3012bf3b._0x6db8ceb0(new byte[30] { 76, 64, 66, 1, 90, 65, 70, 91, 86, 28, 75, 1, 95, 67, 78, 86, 74, 93, 1, 122, 65, 70, 91, 86, 127, 67, 78, 86, 74, 93 }, 47)))
            using (var _0xf4a03a1b = _0x0e1ea44a.GetStatic<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[15] { 117, 99, 100, 100, 115, 120, 98, 87, 117, 98, 127, 96, 127, 98, 111 }, 22)))
            using (var _0x678a19f0 = _0xf4a03a1b.Call<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[17] { 177, 179, 162, 134, 183, 181, 189, 183, 177, 179, 155, 183, 184, 183, 177, 179, 164 }, 214)))
            using (var _0xceb5f9a7 = _0x678a19f0.Call<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[25] { 12, 14, 31, 39, 10, 30, 5, 8, 3, 34, 5, 31, 14, 5, 31, 45, 4, 25, 59, 10, 8, 0, 10, 12, 14 }, 107), _0x0595ce91))
            {
                if (_0xceb5f9a7 == null)
                    return false;
                WLog(_0x3012bf3b._0x6db8ceb0(new byte[37] { 157, 182, 172, 177, 179, 187, 146, 183, 181, 187, 254, 178, 191, 171, 176, 189, 182, 254, 183, 176, 173, 170, 191, 178, 178, 187, 186, 254, 174, 191, 189, 181, 191, 185, 187, 228, 254 }, 222) + _0x0595ce91);
                _0xceb5f9a7.Call<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[8] { 148, 145, 145, 179, 153, 148, 146, 134 }, 245), 0x10000000);
                _0xf4a03a1b.Call(_0x3012bf3b._0x6db8ceb0(new byte[13] { 116, 115, 102, 117, 115, 70, 100, 115, 110, 113, 110, 115, 126 }, 7), _0xceb5f9a7);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private readonly string[] _0x18c81b7f = new string[]
    {
        _0x3012bf3b._0x6db8ceb0(new byte[60] { 98, 13, 28, 34, 178, 198, 250, 247, 178, 224, 247, 247, 254, 225, 178, 243, 224, 247, 178, 250, 253, 230, 178, 224, 251, 245, 250, 230, 178, 252, 253, 229, 178, 112, 18, 1, 178, 246, 253, 252, 112, 18, 11, 230, 178, 255, 251, 225, 225, 178, 235, 253, 231, 224, 178, 225, 226, 251, 252, 179 }, 146),
        _0x3012bf3b._0x6db8ceb0(new byte[52] { 176, 223, 205, 192, 96, 9, 52, 96, 35, 47, 53, 44, 36, 96, 34, 37, 96, 57, 47, 53, 50, 96, 44, 53, 35, 43, 57, 96, 45, 47, 45, 37, 46, 52, 96, 162, 192, 211, 96, 55, 40, 57, 96, 51, 52, 47, 48, 96, 46, 47, 55, 127 }, 64),
        _0x3012bf3b._0x6db8ceb0(new byte[66] { 25, 97, 90, 20, 67, 116, 219, 185, 146, 156, 219, 140, 146, 149, 136, 219, 154, 137, 158, 219, 147, 146, 143, 143, 146, 149, 156, 219, 150, 148, 137, 158, 219, 148, 157, 143, 158, 149, 219, 143, 148, 159, 154, 130, 219, 25, 123, 104, 219, 136, 143, 154, 130, 219, 146, 149, 219, 143, 147, 158, 219, 156, 154, 150, 158, 213 }, 251),
        _0x3012bf3b._0x6db8ceb0(new byte[54] { 168, 199, 205, 202, 120, 12, 48, 49, 43, 120, 49, 43, 120, 40, 42, 49, 53, 61, 120, 44, 49, 53, 61, 120, 186, 216, 203, 120, 44, 48, 61, 120, 58, 61, 43, 44, 120, 40, 52, 57, 33, 61, 42, 43, 120, 40, 52, 57, 33, 120, 54, 55, 47, 118 }, 88),
        _0x3012bf3b._0x6db8ceb0(new byte[48] { 246, 153, 146, 163, 38, 95, 105, 115, 116, 38, 113, 111, 104, 104, 111, 104, 97, 38, 117, 114, 116, 99, 103, 109, 38, 101, 105, 115, 106, 98, 38, 100, 99, 38, 105, 104, 99, 38, 117, 118, 111, 104, 38, 103, 113, 103, 127, 40 }, 6),
        _0x3012bf3b._0x6db8ceb0(new byte[65] { 72, 39, 34, 56, 152, 242, 217, 219, 211, 200, 215, 204, 203, 152, 217, 202, 221, 152, 213, 215, 202, 221, 152, 217, 219, 204, 209, 206, 221, 152, 204, 215, 214, 209, 223, 208, 204, 152, 90, 56, 43, 152, 203, 204, 217, 193, 152, 217, 214, 220, 152, 204, 202, 193, 152, 193, 215, 205, 202, 152, 212, 205, 219, 211, 150 }, 184),
        _0x3012bf3b._0x6db8ceb0(new byte[55] { 48, 95, 78, 114, 224, 133, 182, 165, 178, 185, 224, 179, 176, 169, 174, 224, 163, 175, 181, 174, 180, 179, 224, 34, 64, 83, 224, 180, 168, 165, 224, 174, 165, 184, 180, 224, 175, 174, 165, 224, 163, 175, 181, 172, 164, 224, 162, 165, 224, 185, 175, 181, 178, 179, 238 }, 192),
        _0x3012bf3b._0x6db8ceb0(new byte[63] { 122, 53, 8, 119, 32, 23, 184, 200, 244, 249, 225, 253, 234, 235, 184, 234, 241, 255, 240, 236, 184, 246, 247, 239, 184, 249, 234, 253, 184, 239, 241, 246, 246, 241, 246, 255, 184, 122, 24, 11, 184, 252, 247, 246, 122, 24, 1, 236, 184, 239, 249, 244, 243, 184, 249, 239, 249, 225, 184, 225, 253, 236, 182 }, 152),
        _0x3012bf3b._0x6db8ceb0(new byte[51] { 20, 123, 107, 98, 196, 171, 138, 136, 157, 196, 144, 140, 139, 151, 129, 196, 147, 140, 139, 196, 151, 144, 133, 157, 196, 141, 138, 196, 144, 140, 129, 196, 131, 133, 137, 129, 196, 147, 141, 138, 196, 144, 140, 129, 196, 148, 150, 141, 158, 129, 202 }, 228),
        _0x3012bf3b._0x6db8ceb0(new byte[64] { 92, 36, 31, 81, 6, 49, 158, 243, 209, 211, 219, 208, 202, 203, 211, 158, 215, 205, 158, 219, 200, 219, 204, 199, 202, 214, 215, 208, 217, 158, 92, 62, 45, 158, 213, 219, 219, 206, 158, 205, 206, 215, 208, 208, 215, 208, 217, 158, 216, 209, 204, 158, 199, 209, 203, 204, 158, 221, 214, 223, 208, 221, 219, 144 }, 190)
    };
    private string _0xb9526e0d = "";
    private RectTransform _0x10fc8f54;
    private bool _0xd2d34d62 = false;
    private int _0xf9750b1f = -1;
    private void _0x1eee76de()
    {
        if (_0x1656b2fb)
        {
            WLog(_0x3012bf3b._0x6db8ceb0(new byte[18] { 135, 186, 171, 182, 226, 163, 174, 176, 167, 163, 166, 187, 226, 177, 170, 173, 181, 172 }, 194));
            return;
        }

        _0x5ff75263(false);
        WLog(_0x3012bf3b._0x6db8ceb0(new byte[46] { 249, 213, 221, 218, 148, 227, 209, 214, 226, 221, 209, 195, 148, 228, 193, 199, 220, 148, 250, 219, 192, 221, 210, 221, 215, 213, 192, 221, 219, 218, 148, 156, 220, 213, 198, 208, 195, 213, 198, 209, 148, 214, 213, 215, 223, 157 }, 180));
        ++_0x48b75e9e;
        _0x85e12c1c();
        if (_0x48b75e9e <= 1)
            return;
        if (_0x0306bb3b())
        {
            WLog(_0x3012bf3b._0x6db8ceb0(new byte[37] { 171, 150, 135, 154, 206, 157, 133, 135, 158, 158, 139, 138, 206, 195, 208, 206, 158, 129, 158, 155, 158, 157, 206, 157, 154, 135, 130, 130, 206, 129, 158, 139, 128, 139, 138, 212, 206 }, 238) + _0x1191fa55.Count);
            return;
        }

        Application.Quit();
    }

    private void _0x8f2fc94e()
    {
        WLog(_0x3012bf3b._0x6db8ceb0(new byte[21] { 209, 248, 235, 253, 238, 248, 235, 252, 185, 251, 248, 250, 242, 185, 233, 235, 252, 234, 234, 252, 253 }, 153));
        if (Time.frameCount == _0xf9750b1f)
            return;
        _0xf9750b1f = Time.frameCount;
        if (_0xbc7e52c7())
            return;
        _0x1eee76de();
    }

    // WS_SOURCE MONO
    public static _0xcc9b37a5 _0xbea121df { get; private set; }

    private void WLog(string _0xafc5ffc7)
    {
#if B_LOGS
        {
            Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[7] { 56, 55, 6, 16, 23, 62, 67 }, 99) + _0xafc5ffc7);
        }
#endif
    }

    private bool TryOpenExternalLikeChrome(string _0x6c5c1d98)
    {
        if (string.IsNullOrEmpty(_0x6c5c1d98))
            return false;
        if (_0x6c5c1d98.StartsWith(_0x3012bf3b._0x6db8ceb0(new byte[9] { 227, 228, 254, 239, 228, 254, 176, 165, 165 }, 138), StringComparison.OrdinalIgnoreCase))
            return _0xc7183b91(_0x6c5c1d98);
        if (_0x23093202(_0x6c5c1d98))
            return _0xabdd40cb(_0x6c5c1d98, null);
        if (!_0x6c5c1d98.StartsWith(_0x3012bf3b._0x6db8ceb0(new byte[7] { 98, 126, 126, 122, 48, 37, 37 }, 10), StringComparison.OrdinalIgnoreCase) && !_0x6c5c1d98.StartsWith(_0x3012bf3b._0x6db8ceb0(new byte[8] { 193, 221, 221, 217, 218, 147, 134, 134 }, 169), StringComparison.OrdinalIgnoreCase) && !_0x6c5c1d98.StartsWith(_0x3012bf3b._0x6db8ceb0(new byte[11] { 85, 86, 91, 65, 64, 14, 86, 88, 85, 90, 95 }, 52), StringComparison.OrdinalIgnoreCase))
        {
            return _0x4baa98eb(_0x6c5c1d98);
        }

        return false;
    }

    private void _0xb0e077f3(UniWebView _0xa4751731)
    {
        _0xa4751731.BackgroundColor = Color.clear;
        _0xa4751731.SetSupportMultipleWindows(true, true);
        _0xa4751731.SetBackButtonEnabled(false);
        _0x985b2623.SetUserAgent(_0x502134f7());
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x985b2623 = null;
    private string _0xa4c4781f(string _0xe08abaec, string _0x39d70798)
    {
        if (string.IsNullOrEmpty(_0x39d70798))
            return _0xe08abaec;
        if (_0xe08abaec.Contains(_0x3012bf3b._0x6db8ceb0(new byte[1] { 81 }, 110)))
            return _0xe08abaec + _0x3012bf3b._0x6db8ceb0(new byte[8] { 245, 160, 182, 189, 183, 186, 183, 238 }, 211) + UnityWebRequest.EscapeURL(_0x39d70798);
        else
            return _0xe08abaec + _0x3012bf3b._0x6db8ceb0(new byte[8] { 117, 57, 47, 36, 46, 35, 46, 119 }, 74) + UnityWebRequest.EscapeURL(_0x39d70798);
    }

    internal bool isApplicationFocus = false;
    internal bool IsHttpUrl(string _0xafa6d317)
    {
        if (string.IsNullOrEmpty(_0xafa6d317))
            return false;
        return _0xafa6d317.StartsWith(_0x3012bf3b._0x6db8ceb0(new byte[7] { 137, 149, 149, 145, 219, 206, 206 }, 225), StringComparison.OrdinalIgnoreCase) || _0xafa6d317.StartsWith(_0x3012bf3b._0x6db8ceb0(new byte[8] { 63, 35, 35, 39, 36, 109, 120, 120 }, 87), StringComparison.OrdinalIgnoreCase);
    }

    private void _0x41936cc1(UniWebView _0x660a4652)
    {
        if (_0x89668488)
            return;
        _0x89668488 = true;
        _0x660a4652.AddUrlScheme(_0x3012bf3b._0x6db8ceb0(new byte[2] { 112, 99 }, 4));
        _0x660a4652.AddUrlScheme(_0x3012bf3b._0x6db8ceb0(new byte[6] { 244, 243, 233, 248, 243, 233 }, 157));
        _0x660a4652.AddUrlScheme(_0x3012bf3b._0x6db8ceb0(new byte[6] { 99, 111, 124, 101, 107, 122 }, 14));
        _0x660a4652.OnMessageReceived += (_0x2022b30f, _0x50a3f091) =>
        {
            if (TryOpenExternalLikeChrome(_0x50a3f091.RawMessage))
            {
                _0x5ff75263(false);
                return;
            }
        };
        _0x660a4652.RegisterShouldHandleRequest(_0x7af3cd0d =>
        {
            string _0x1fd747b4 = _0x7af3cd0d != null ? _0x7af3cd0d.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x1fd747b4))
                return true;
            WLog(_0x3012bf3b._0x6db8ceb0(new byte[21] { 117, 78, 73, 83, 74, 66, 110, 71, 72, 66, 74, 67, 116, 67, 87, 83, 67, 85, 82, 28, 6 }, 38) + _0x1fd747b4);
            if (TryOpenExternalLikeChrome(_0x1fd747b4))
            {
                _0x5ff75263(false);
                return false;
            }

            if (_0x7af3cd0d != null && _0x7af3cd0d.IsMainFrame && IsGoogleAuthFlowUrl(_0x1fd747b4) && !_0x650c8051)
            {
                WLog(_0x3012bf3b._0x6db8ceb0(new byte[62] { 146, 190, 182, 177, 255, 136, 186, 189, 137, 182, 186, 168, 255, 187, 186, 171, 186, 188, 171, 186, 187, 255, 152, 176, 176, 184, 179, 186, 255, 190, 170, 171, 183, 255, 138, 141, 147, 255, 242, 225, 255, 173, 186, 179, 176, 190, 187, 255, 168, 182, 171, 183, 255, 152, 176, 176, 184, 179, 186, 255, 138, 158 }, 223));
                _0x650c8051 = true;
                _0x5ff75263(true);
                _0x985b2623.SetUserAgent(_0x502134f7());
                _0x985b2623.Load(_0x1fd747b4);
                return false;
            }

            return true;
        });
        _0x660a4652.OnLoadingErrorReceived += (_0x2022b30f, _0x4c95527a, _0x50a3f091, _0xb480c2c0) =>
        {
            WLog(_0x3012bf3b._0x6db8ceb0(new byte[25] { 12, 32, 40, 47, 97, 22, 36, 35, 23, 40, 36, 54, 97, 4, 51, 51, 46, 51, 123, 97, 34, 46, 37, 36, 124 }, 65) + _0x4c95527a + _0x3012bf3b._0x6db8ceb0(new byte[9] { 38, 107, 99, 117, 117, 103, 97, 99, 59 }, 6) + _0x50a3f091);
            string _0x69e40cfe = GetFailingUrl(_0xb480c2c0);
            if (string.IsNullOrEmpty(_0x69e40cfe) || IsAboutBlank(_0x69e40cfe))
                return;
            _ = _0x1e2b70fd(_0x3012bf3b._0x6db8ceb0(new byte[8] { 15, 14, 39, 29, 10, 10, 23, 10 }, 120));
            WLog(_0x3012bf3b._0x6db8ceb0(new byte[45] { 17, 61, 53, 50, 124, 11, 57, 62, 10, 53, 57, 43, 124, 58, 61, 53, 48, 53, 50, 59, 124, 9, 14, 16, 124, 113, 98, 124, 51, 44, 57, 50, 124, 57, 36, 40, 57, 46, 50, 61, 48, 48, 37, 102, 124 }, 92) + _0x69e40cfe);
            StopCurrentFailedLoad(_0x2022b30f);
            _0x81169e78(_0x69e40cfe);
        };
        _0x660a4652.OnPageStarted += (_0x2022b30f, _0xaea6f257) =>
        {
            _0x48b75e9e = 0;
            if (_0x1562cc9e && IsAboutBlank(_0xaea6f257))
            {
                WLog(_0x3012bf3b._0x6db8ceb0(new byte[27] { 84, 118, 97, 115, 101, 118, 105, 36, 101, 102, 107, 113, 112, 62, 102, 104, 101, 106, 111, 36, 119, 112, 101, 118, 112, 97, 96 }, 4));
                return;
            }

            WLog(_0x3012bf3b._0x6db8ceb0(new byte[29] { 159, 179, 187, 188, 242, 133, 183, 176, 132, 187, 183, 165, 242, 157, 188, 130, 179, 181, 183, 129, 166, 179, 160, 166, 183, 182, 232, 242, 249 }, 210) + (Time.realtimeSinceStartup - _0x5b40e985).ToString(_0x3012bf3b._0x6db8ceb0(new byte[5] { 61, 35, 61, 61, 61 }, 13)) + _0x3012bf3b._0x6db8ceb0(new byte[2] { 51, 96 }, 64) + _0xaea6f257);
            if (TryOpenExternalLikeChrome(_0xaea6f257))
            {
                StopCurrentFailedLoad(_0x2022b30f);
                return;
            }

            if (ContainsIgnoreCase(_0xaea6f257, _0x3012bf3b._0x6db8ceb0(new byte[8] { 91, 86, 86, 94, 17, 94, 79, 79 }, 63)) || ContainsIgnoreCase(_0xaea6f257, _0x3012bf3b._0x6db8ceb0(new byte[15] { 170, 187, 163, 244, 173, 179, 190, 189, 191, 174, 244, 184, 182, 181, 189 }, 218)) || _0xaea6f257.StartsWith(_0x3012bf3b._0x6db8ceb0(new byte[25] { 44, 48, 48, 52, 55, 126, 107, 107, 38, 52, 35, 40, 43, 38, 37, 40, 34, 37, 50, 106, 40, 45, 50, 33, 107 }, 68), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x2022b30f);
                OpenUrlExternally(_0xaea6f257);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0xaea6f257))
            {
                _0x5ff75263(true);
                WLog(_0x3012bf3b._0x6db8ceb0(new byte[41] { 7, 47, 47, 39, 44, 37, 96, 33, 53, 52, 40, 96, 38, 44, 47, 55, 96, 36, 37, 52, 37, 35, 52, 37, 36, 96, 109, 126, 96, 43, 37, 37, 48, 96, 54, 41, 51, 41, 34, 44, 37 }, 64));
                return;
            }

            _0xd2d34d62 = true;
            _0x5ff75263(true);
            WLog(_0x3012bf3b._0x6db8ceb0(new byte[43] { 54, 4, 3, 55, 8, 4, 22, 65, 13, 14, 0, 5, 8, 15, 6, 78, 19, 4, 5, 8, 19, 4, 2, 21, 8, 15, 6, 65, 76, 95, 65, 10, 4, 4, 17, 65, 23, 8, 18, 8, 3, 13, 4 }, 97));
        };
        _0x660a4652.OnPageCommitted += (_0x2022b30f, _0xaea6f257) =>
        {
            if (_0x1562cc9e && IsAboutBlank(_0xaea6f257))
                return;
            WLog(_0x3012bf3b._0x6db8ceb0(new byte[31] { 111, 67, 75, 76, 2, 117, 71, 64, 116, 75, 71, 85, 2, 109, 76, 114, 67, 69, 71, 97, 77, 79, 79, 75, 86, 86, 71, 70, 24, 2, 9 }, 34) + (Time.realtimeSinceStartup - _0x5b40e985).ToString(_0x3012bf3b._0x6db8ceb0(new byte[5] { 208, 206, 208, 208, 208 }, 224)) + _0x3012bf3b._0x6db8ceb0(new byte[2] { 110, 61 }, 29) + _0xaea6f257);
            if (!firstLoadShown && IsHttpUrl(_0xaea6f257))
            {
                firstLoadShown = true;
                _0xd2d34d62 = false;
                _0x5ff75263(false);
                _0xa1e42e6c();
                _0xf7c22ed7();
                _0x2022b30f.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x1e2b70fd(_0x3012bf3b._0x6db8ceb0(new byte[9] { 112, 113, 88, 104, 119, 98, 105, 98, 99 }, 7));
                WLog(_0x3012bf3b._0x6db8ceb0(new byte[39] { 21, 57, 49, 54, 120, 15, 61, 58, 14, 49, 61, 47, 120, 43, 48, 55, 47, 54, 120, 55, 54, 120, 59, 55, 53, 53, 49, 44, 44, 61, 60, 120, 59, 55, 54, 44, 61, 54, 44 }, 88));
            }
        };
        _0x660a4652.OnPageProgressChanged += (_0x2022b30f, _0xff9e0d6f) =>
        {
            if (_0x1562cc9e)
                return;
            if (!firstLoadShown && _0xff9e0d6f >= 0.65f)
            {
                firstLoadShown = true;
                _0xd2d34d62 = false;
                _0x5ff75263(false);
                _0xa1e42e6c();
                _0xf7c22ed7();
                _0x2022b30f.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x1e2b70fd(_0x3012bf3b._0x6db8ceb0(new byte[9] { 15, 14, 39, 23, 8, 29, 22, 29, 28 }, 120));
                WLog(_0x3012bf3b._0x6db8ceb0(new byte[32] { 134, 170, 162, 165, 235, 156, 174, 169, 157, 162, 174, 188, 235, 184, 163, 164, 188, 165, 235, 169, 178, 235, 187, 185, 164, 172, 185, 174, 184, 184, 241, 235 }, 203) + _0xff9e0d6f);
            }
        };
        _0x660a4652.OnPageFinished += (_0x2022b30f, _0x4c95527a, _0xaea6f257) =>
        {
            if (_0x1562cc9e && IsAboutBlank(_0xaea6f257))
            {
                _0x1562cc9e = false;
                WLog(_0x3012bf3b._0x6db8ceb0(new byte[28] { 218, 248, 239, 253, 235, 248, 231, 170, 235, 232, 229, 255, 254, 176, 232, 230, 235, 228, 225, 170, 236, 227, 228, 227, 249, 226, 239, 238 }, 138));
                return;
            }

            WLog(_0x3012bf3b._0x6db8ceb0(new byte[24] { 128, 172, 164, 163, 237, 154, 168, 175, 155, 164, 168, 186, 237, 139, 164, 163, 164, 190, 165, 168, 169, 247, 237, 230 }, 205) + (Time.realtimeSinceStartup - _0x5b40e985).ToString(_0x3012bf3b._0x6db8ceb0(new byte[5] { 240, 238, 240, 240, 240 }, 192)) + _0x3012bf3b._0x6db8ceb0(new byte[7] { 216, 139, 200, 196, 207, 206, 150 }, 171) + _0x4c95527a + _0x3012bf3b._0x6db8ceb0(new byte[5] { 167, 242, 245, 235, 186 }, 135) + _0xaea6f257);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0xd2d34d62 = false;
                _0x5ff75263(false);
                _0xa1e42e6c();
                _0xf7c22ed7();
                _0x2022b30f.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x1e2b70fd(_0x3012bf3b._0x6db8ceb0(new byte[9] { 68, 69, 108, 92, 67, 86, 93, 86, 87 }, 51));
                WLog(_0x3012bf3b._0x6db8ceb0(new byte[33] { 4, 40, 32, 39, 105, 30, 44, 43, 31, 32, 44, 62, 105, 47, 32, 59, 58, 61, 105, 37, 38, 40, 45, 105, 42, 38, 36, 57, 37, 44, 61, 44, 45 }, 73));
            }
            else if (_0xd2d34d62)
            {
                _0xd2d34d62 = false;
                _0x5ff75263(false);
                _0x2022b30f.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x3012bf3b._0x6db8ceb0(new byte[40] { 19, 63, 55, 48, 126, 9, 59, 60, 8, 55, 59, 41, 126, 13, 54, 49, 41, 126, 63, 56, 42, 59, 44, 126, 50, 49, 63, 58, 55, 48, 57, 126, 56, 55, 48, 55, 45, 54, 59, 58 }, 94));
            }
            else
            {
                _0x5ff75263(false);
            }

            if (_0x650c8051 && !IsGoogleAuthFlowUrl(_0xaea6f257) && !IsGoogleAuthFlowUrl(_0xaea6f257))
            {
                WLog(_0x3012bf3b._0x6db8ceb0(new byte[48] { 226, 202, 202, 194, 201, 192, 133, 196, 208, 209, 205, 133, 214, 192, 192, 200, 214, 133, 195, 204, 203, 204, 214, 205, 192, 193, 133, 136, 155, 133, 215, 192, 214, 209, 202, 215, 192, 133, 193, 192, 195, 196, 208, 201, 209, 133, 240, 228 }, 165));
                _0x650c8051 = false;
                _0x985b2623.SetUserAgent("");
            }
        };
        _0x660a4652.OnShouldClose += _0x2022b30f =>
        {
            WLog(_0x3012bf3b._0x6db8ceb0(new byte[41] { 15, 0, 49, 39, 32, 9, 116, 25, 53, 61, 58, 116, 3, 49, 54, 2, 61, 49, 35, 116, 27, 58, 7, 60, 59, 33, 56, 48, 23, 56, 59, 39, 49, 116, 61, 58, 34, 59, 63, 49, 48 }, 84));
            _0x8f2fc94e();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x660a4652.SetPopupPageEventEnabled(true);
        bool _0xcf120ac8 = false;
        bool _0xc7a540d2 = false;
        _0x660a4652.OnMultipleWindowOpened += (_0x2022b30f, _0x65511b52) =>
        {
            _0x2022b30f.ScrollTo(0, 0, false);
            WLog(_0x3012bf3b._0x6db8ceb0(new byte[43] { 60, 51, 2, 20, 19, 58, 71, 42, 6, 14, 9, 71, 48, 2, 5, 49, 14, 2, 16, 71, 42, 18, 11, 19, 14, 23, 11, 2, 48, 14, 9, 3, 8, 16, 71, 40, 23, 2, 9, 2, 3, 93, 71 }, 103) + _0x65511b52);
            var _0x8aa63992 = _0x660a4652.GetPopupWindow(_0x65511b52);
            if (_0x8aa63992 == null)
                return;
            _0x1191fa55.Add(_0x8aa63992);
            Debug.Log($"[Test] Popup ID: {_0x8aa63992.Id}");
            _0x8aa63992.OnPageStarted += (_0xe71b476a, _0xaea6f257) =>
            {
                WLog(_0x3012bf3b._0x6db8ceb0(new byte[36] { 240, 255, 206, 216, 223, 246, 139, 251, 196, 219, 222, 219, 139, 252, 206, 201, 253, 194, 206, 220, 139, 228, 197, 251, 202, 204, 206, 248, 223, 202, 217, 223, 206, 207, 145, 139 }, 171) + _0xaea6f257);
                _0x48b75e9e = 0;
                if (string.IsNullOrEmpty(_0xaea6f257) || IsAboutBlank(_0xaea6f257))
                    return;
                if (IsGoogleAuthFlowUrl(_0xaea6f257))
                {
                    WLog(_0x3012bf3b._0x6db8ceb0(new byte[57] { 193, 206, 255, 233, 238, 199, 186, 202, 245, 234, 239, 234, 186, 221, 245, 245, 253, 246, 255, 186, 251, 239, 238, 242, 186, 252, 246, 245, 237, 186, 183, 164, 186, 233, 234, 245, 245, 252, 186, 221, 245, 245, 253, 246, 255, 186, 217, 242, 232, 245, 247, 255, 186, 207, 219, 160, 186 }, 154) + _0xaea6f257);
                    _0xcf120ac8 = false;
                    _0xdea0c111();
                    if (_0xe71b476a != null && _0xe71b476a.IsAlive)
                        _0xe71b476a.EvaluateJavaScript(_0x048b9566());
                    return;
                }

                if (_0x985b2623 == null)
                    return;
                if (!_0xcf120ac8)
                {
                    _0xcf120ac8 = true;
                    _0x985b2623.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x3012bf3b._0x6db8ceb0(new byte[39] { 227, 236, 221, 203, 204, 229, 152, 232, 215, 200, 205, 200, 152, 217, 200, 200, 212, 193, 152, 239, 209, 214, 220, 215, 207, 203, 152, 220, 221, 203, 211, 204, 215, 200, 152, 237, 249, 130, 152 }, 184) + _0xaea6f257);
                }

                if (_0xe71b476a != null && _0xe71b476a.IsAlive)
                    _0xe71b476a.EvaluateJavaScript(_0x0041cea9());
                if (!_0xc7a540d2 && _0xe71b476a != null && _0xe71b476a.IsAlive && IsHttpUrl(_0xaea6f257))
                {
                    _0xc7a540d2 = true;
                }
            };
            _0x8aa63992.OnPageFinished += (_0xe71b476a, _0xb480c2c0) =>
            {
                string _0xbc312ae8 = _0xb480c2c0 != null ? _0xb480c2c0.data : string.Empty;
                WLog(_0x3012bf3b._0x6db8ceb0(new byte[35] { 248, 247, 198, 208, 215, 254, 131, 243, 204, 211, 214, 211, 131, 244, 198, 193, 245, 202, 198, 212, 131, 229, 202, 205, 202, 208, 203, 198, 199, 153, 131, 214, 209, 207, 158 }, 163) + _0xbc312ae8);
                if (_0xe71b476a == null || !_0xe71b476a.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0xbc312ae8))
                {
                    _0xdea0c111();
                    _0xe71b476a.EvaluateJavaScript(_0x048b9566());
                    return;
                }

                if (!_0xcf120ac8)
                    return;
                _0xe71b476a.EvaluateJavaScript(_0x0041cea9());
            };
        };
        _0x660a4652.OnMultipleWindowClosed += (_0x2022b30f, _0x65511b52) =>
        {
            _0x1191fa55.RemoveAll(_0x0a05cab0 => _0x0a05cab0 == null || _0x0a05cab0.Id == _0x65511b52 || !_0x0a05cab0.IsAlive);
            _0x5ff75263(false);
            if (_0x1191fa55.Count == 0 && _0x985b2623 != null)
            {
                _0xcf120ac8 = false;
                _0xc7a540d2 = false;
                _0xca0b03e8();
            }

            WLog(_0x3012bf3b._0x6db8ceb0(new byte[43] { 226, 237, 220, 202, 205, 228, 153, 244, 216, 208, 215, 153, 238, 220, 219, 239, 208, 220, 206, 153, 244, 204, 213, 205, 208, 201, 213, 220, 238, 208, 215, 221, 214, 206, 153, 250, 213, 214, 202, 220, 221, 131, 153 }, 185) + _0x65511b52);
        };
        _0x660a4652.RegisterOnRequestMediaCapturePermission(_0x7af3cd0d =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private string _0x6f63dfcd = "";
    private bool _0xabdd40cb(string _0xfa7aac15, string _0x27c5725a)
    {
        string _0x71021d5e = _0xa3124f54(_0xfa7aac15);
        if (string.IsNullOrEmpty(_0x71021d5e))
            _0x71021d5e = _0x27c5725a;
        if (_0x67b550dc(_0x71021d5e))
            return true;
        string _0xa420e0bd = string.IsNullOrEmpty(_0x71021d5e) ? _0x3012bf3b._0x6db8ceb0(new byte[29] { 34, 62, 62, 58, 57, 112, 101, 101, 58, 38, 43, 51, 100, 45, 37, 37, 45, 38, 47, 100, 41, 37, 39, 101, 57, 62, 37, 56, 47 }, 74) : _0x3012bf3b._0x6db8ceb0(new byte[46] { 49, 45, 45, 41, 42, 99, 118, 118, 41, 53, 56, 32, 119, 62, 54, 54, 62, 53, 60, 119, 58, 54, 52, 118, 42, 45, 54, 43, 60, 118, 56, 41, 41, 42, 118, 61, 60, 45, 56, 48, 53, 42, 102, 48, 61, 100 }, 89) + _0x71021d5e;
        WLog(_0x3012bf3b._0x6db8ceb0(new byte[35] { 169, 130, 152, 133, 135, 143, 166, 131, 129, 143, 202, 135, 139, 152, 129, 143, 158, 202, 140, 139, 134, 134, 136, 139, 137, 129, 202, 139, 153, 202, 157, 143, 136, 208, 202 }, 234) + _0xa420e0bd);
        return _0x4baa98eb(_0xa420e0bd);
    }

    private string _0x85704475 = "";
    private void Awake()
    {
        if (_0xbea121df != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0xbea121df = gameObject.GetComponent<_0xcc9b37a5>();
        DontDestroyOnLoad(gameObject);
        _0x6f63dfcd = _0x33147f33 = _0x3978c312 = "";
        _0x3d1f28cc = "";
        _0xd534de89 = false;
    }

    private string _0x80aa0ef2 = "";
    private int _0x688ebacf = 5, _0xe61783e7 = 5, _0xa5bf4299 = 5, _0x1db11da5 = 5;
    private IEnumerator _0x4f4637aa()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    private void OnApplicationFocus(bool _0xd1b378b5)
    {
        isApplicationFocus = _0xd1b378b5;
        if (_0xd1b378b5 && _0xd534de89)
        {
            _0x0d7b3299();
        }
    }

    internal bool _0x23093202(string _0xa099d7aa)
    {
        return _0xa099d7aa.StartsWith(_0x3012bf3b._0x6db8ceb0(new byte[9] { 171, 167, 180, 173, 163, 178, 252, 233, 233 }, 198), StringComparison.OrdinalIgnoreCase) || _0xa099d7aa.StartsWith(_0x3012bf3b._0x6db8ceb0(new byte[24] { 63, 35, 35, 39, 36, 109, 120, 120, 39, 59, 54, 46, 121, 48, 56, 56, 48, 59, 50, 121, 52, 56, 58, 120 }, 87), StringComparison.OrdinalIgnoreCase) || _0xa099d7aa.StartsWith(_0x3012bf3b._0x6db8ceb0(new byte[23] { 35, 63, 63, 59, 113, 100, 100, 59, 39, 42, 50, 101, 44, 36, 36, 44, 39, 46, 101, 40, 36, 38, 100 }, 75), StringComparison.OrdinalIgnoreCase);
    }

    private string _0xb9d48d91 = "";
    private string _0x537fac91 = "";
    private bool _0xccfbdbdc = false;
    private void _0xca0b03e8()
    {
        if (_0x985b2623 == null)
            return;
        if (_0x650c8051)
            _0x985b2623.SetUserAgent(_0x502134f7());
        else
            _0x985b2623.SetUserAgent("");
    }

    private string _0x33147f33 { get; set; }

    private void _0x10a4ec7c(string _0xf7818a63)
    {
        Dictionary<string, object> _0x452794dc;
        try
        {
            _0x452794dc = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xf7818a63);
        }
        catch
        {
            return;
        }

        var _0xe3fc46a8 = ReadPushField(_0x452794dc, _0x3012bf3b._0x6db8ceb0(new byte[3] { 188, 187, 165 }, 201));
        if (string.IsNullOrWhiteSpace(_0xe3fc46a8))
            return;
        _0xe3fc46a8 = _0xe3fc46a8.Trim();
        if (!IsHttpUrl(_0xe3fc46a8))
            return;
        if (string.Equals(_0xe3fc46a8, _0x2bc78b77, StringComparison.Ordinal))
            return;
        _0x2bc78b77 = _0xe3fc46a8;
        OpenUrlExternally(_0xe3fc46a8);
    }

    private void _0xa4c8712d(string _0xf91ce9f7)
    {
        _0x0d7b3299();
        StartCoroutine(_0x6b41c373(_0xf91ce9f7));
    }

    private IEnumerator _0xb2984d7b()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[26] { 150, 153, 168, 190, 185, 144, 237, 132, 163, 164, 185, 164, 172, 161, 164, 183, 168, 159, 168, 171, 171, 168, 191, 168, 191, 237 }, 205));
            }
#endif
        }

        bool _0xeb366d36 = false;
        InstallReferrer.GetReferrer((_0x7a5fb3b5) =>
        {
            Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[24] { 181, 186, 139, 157, 154, 206, 188, 139, 136, 139, 156, 156, 139, 156, 179, 206, 137, 139, 154, 206, 12, 104, 124, 206 }, 238) + _0x65dbbe6d);
            if (_0x7a5fb3b5.IsSuccess)
            {
                _0x65dbbe6d = _0x7a5fb3b5.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[28] { 117, 122, 75, 93, 90, 14, 124, 75, 72, 75, 92, 92, 75, 92, 115, 14, 125, 91, 77, 77, 75, 93, 93, 14, 204, 168, 188, 14 }, 46) + _0x65dbbe6d);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[27] { 40, 39, 22, 0, 7, 83, 33, 22, 21, 22, 1, 1, 22, 1, 46, 83, 53, 18, 26, 31, 22, 23, 83, 145, 245, 225, 83 }, 115) + _0x7a5fb3b5);
#endif
                }

                _0x65dbbe6d = "";
            }

            _0x67dd8f72 = true;
        });
        StartCoroutine(_0x5ffdd344(2f));
        yield return new WaitUntil(() => _0x67dd8f72);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x65dbbe6d}");
#endif
        }

        bool _0x29509bec = _0x65dbbe6d.Contains(_0x3012bf3b._0x6db8ceb0(new byte[6] { 79, 75, 68, 65, 76, 21 }, 40));
        _0xeb366d36 = _0x29509bec || _0x65dbbe6d.Contains(_0x3012bf3b._0x6db8ceb0(new byte[18] { 99, 114, 114, 113, 44, 107, 108, 113, 118, 99, 101, 112, 99, 111, 44, 97, 109, 111 }, 2)) || _0x65dbbe6d.Contains(_0x3012bf3b._0x6db8ceb0(new byte[17] { 90, 75, 75, 72, 21, 93, 90, 88, 94, 89, 84, 84, 80, 21, 88, 84, 86 }, 59));
        _0x33147f33 = _0x29509bec ? "" : (_0xeb366d36 ? "" : _0x33147f33);
        _0x33147f33 = _0x33147f33 ?? "";
        _0x3978c312 = _0x3978c312 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x33147f33}");
#endif
        }
    }

    private readonly List<UniWebViewPopup> _0x1191fa55 = new List<UniWebViewPopup>();
    internal void Update()
    {
        if (_0x985b2623 == null)
            return;
        if (_0x28603961())
            _0x8f2fc94e();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xf7c22ed7();
        if (_0x7a4c9545 && _0x10fc8f54 != null)
            _0x10fc8f54.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    // MAIN FLOW
    private bool _0x67dd8f72 { get; set; }

    private IEnumerator _0x0761418f(IEnumerator _0xfe47ca68, TaskCompletionSource<bool> _0x00f894a5)
    {
        yield return _0xfe47ca68;
        _0x00f894a5.SetResult(true);
    }

    private string _0xf0bee872 = "";
    private void _0x6fe97520(string _0x6767786e)
    {
        bool _0x7a14f03c = !string.IsNullOrEmpty(_0x6767786e);
        if (_0x7a14f03c)
        {
            {
#if B_LOGS
                Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[13] { 167, 168, 153, 143, 136, 161, 220, 175, 148, 147, 139, 198, 220 }, 252) + _0x6767786e);
#endif
            }

            _0xa4c8712d(_0x6767786e);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[39] { 30, 17, 32, 54, 49, 24, 101, 3, 36, 41, 41, 39, 36, 38, 46, 101, 167, 195, 215, 101, 2, 36, 40, 32, 101, 109, 43, 42, 101, 35, 44, 43, 36, 41, 101, 16, 23, 9, 108 }, 69));
#endif
            }

            _0x3e4ee2f7();
            return;
        }
    }

    private bool OpenUrlExternally(string _0x23626b33)
    {
        return _0x4baa98eb(_0x23626b33);
    }

    private void _0x5ff75263(bool _0xfb26db61)
    {
        _0x728af67a();
        _0xe3250d77.SetActive(_0xfb26db61);
        _0x7a4c9545 = _0xfb26db61;
        if (_0xfb26db61)
        {
            _0xe3250d77.transform.SetAsLastSibling();
            if (_0x10fc8f54 != null)
                _0x10fc8f54.localRotation = Quaternion.identity;
        }
    }

    private string _0xe943b24f = "";
    private IEnumerator _0xe431d89a(Dictionary<string, object> _0xdf38d9cd)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[30] { 206, 193, 240, 230, 225, 200, 181, 211, 240, 225, 246, 253, 181, 208, 237, 225, 231, 244, 181, 197, 224, 230, 253, 181, 209, 244, 225, 244, 175, 181 }, 149) + string.Join(_0x3012bf3b._0x6db8ceb0(new byte[1] { 83 }, 90), _0xdf38d9cd));
#endif
            }
        }

        string _0x7d159eaf = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xdf38d9cd != null && _0xdf38d9cd.TryGetValue(_0x3012bf3b._0x6db8ceb0(new byte[16] { 59, 58, 33, 60, 51, 60, 54, 52, 33, 60, 58, 59, 17, 52, 33, 52 }, 85), out var raw))
        {
            try
            {
                var _0x28fb9a92 = raw?.ToString();
                var _0x33b6274f = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x28fb9a92);
                if (_0x33b6274f != null && _0x33b6274f.TryGetValue(_0x3012bf3b._0x6db8ceb0(new byte[6] { 0, 22, 29, 23, 26, 23 }, 115), out var val))
                {
                    _0x7d159eaf = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x3012bf3b._0x6db8ceb0(new byte[30] { 31, 16, 33, 55, 48, 100, 20, 49, 55, 44, 25, 100, 14, 23, 11, 10, 100, 52, 37, 54, 55, 33, 100, 33, 54, 54, 43, 54, 126, 100 }, 68) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x7d159eaf) && _0xdf38d9cd != null && _0xdf38d9cd.TryGetValue(_0x3012bf3b._0x6db8ceb0(new byte[6] { 184, 174, 165, 175, 162, 175 }, 203), out var lab))
        {
            _0x7d159eaf = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[38] { 143, 128, 177, 167, 160, 244, 132, 161, 167, 188, 137, 244, 146, 177, 160, 183, 188, 177, 176, 244, 167, 177, 186, 176, 189, 176, 244, 178, 166, 187, 185, 244, 190, 167, 187, 186, 238, 244 }, 212) + _0x7d159eaf);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x7d159eaf))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[38] { 139, 132, 181, 163, 164, 240, 128, 165, 163, 184, 141, 240, 135, 177, 185, 164, 240, 164, 191, 240, 191, 160, 181, 190, 240, 167, 185, 164, 184, 240, 163, 181, 190, 180, 185, 180, 234, 240 }, 208) + _0x7d159eaf);
            }
#endif
        }

        _0xe017cd70 = _0x7d159eaf;
        yield return new WaitUntil(() => _0xd534de89);
        var _0x7c70e0ef = _0xdaca9206(2, 100);
        yield return new WaitUntil(() => _0x7c70e0ef.IsCompleted);
        string _0x204d8589 = _0x7c70e0ef.Result;
        if (!string.IsNullOrEmpty(_0x204d8589))
        {
            string _0x4d8f28ad = _0xa4c4781f(_0x204d8589, _0x7d159eaf);
            {
#if B_LOGS
                Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[33] { 209, 222, 239, 249, 254, 170, 218, 255, 249, 226, 215, 170, 216, 239, 230, 229, 235, 238, 170, 221, 239, 232, 220, 227, 239, 253, 170, 253, 227, 254, 226, 176, 170 }, 138) + _0x4d8f28ad);
#endif
            }

            _0x985b2623.Load(_0x4d8f28ad);
        }
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0xb1142d7b)
    {
        if (_0xb1142d7b == null || _0xb1142d7b.Extra == null)
            return null;
        object _0x39309ffe;
        if (!_0xb1142d7b.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x39309ffe))
            return null;
        return _0x39309ffe as string;
    }

    private bool _0x0306bb3b()
    {
        _0x1191fa55.RemoveAll(_0x0a05cab0 => _0x0a05cab0 == null || !_0x0a05cab0.IsAlive);
        return _0x1191fa55.Count > 0;
    }

    private bool _0xb4df5896 = false;
    private AndroidJavaObject _0x4b2ce9a8 { get; set; }

    private string _0xc6326089()
    {
        string _0xe776c70b = _0x3012bf3b._0x6db8ceb0(new byte[62] { 207, 204, 205, 202, 203, 200, 201, 198, 199, 196, 197, 194, 195, 192, 193, 222, 223, 220, 221, 218, 219, 216, 217, 214, 215, 212, 239, 236, 237, 234, 235, 232, 233, 230, 231, 228, 229, 226, 227, 224, 225, 254, 255, 252, 253, 250, 251, 248, 249, 246, 247, 244, 158, 159, 156, 157, 154, 155, 152, 153, 150, 151 }, 174);
        System.Random _0x44fe50ef = new System.Random();
        int _0x4abd8b74 = _0x44fe50ef.Next(8, 16);
        return new string (Enumerable.Repeat(_0xe776c70b, _0x4abd8b74).Select(_0x353649fb => _0x353649fb[_0x44fe50ef.Next(_0x353649fb.Length)]).ToArray());
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x3e4ee2f7();
    }

    internal void _0xf7c22ed7()
    {
        Rect _0x662ea281 = Screen.safeArea;
        Vector2 _0x4b1e5a24 = new Vector2(Screen.width, Screen.height);
        if (_0x662ea281 == lastSafe && _0x4b1e5a24 == lastSize)
            return;
        // Apply manual padding
        _0x662ea281.xMin += _0xa5bf4299;
        _0x662ea281.xMax -= _0x1db11da5;
        _0x662ea281.yMin += _0xe61783e7;
        _0x662ea281.yMax -= _0x688ebacf;
        // Convert Unity safe area -> native WebView frame
        Rect _0x8c1b1ba0 = new Rect(_0x662ea281.x, _0x4b1e5a24.y - _0x662ea281.y - _0x662ea281.height, // Y flip for native coordinate system
 _0x662ea281.width, _0x662ea281.height);
        _0x985b2623.Frame = _0x8c1b1ba0;
        lastSafe = Screen.safeArea;
        lastSize = _0x4b1e5a24;
    }

    private void _0xa1e42e6c()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private JObject BuildRandomPayload(params string[] _0xc8efb36f)
    {
        JObject _0xf97ae49e = new JObject();
        foreach (var _0xc5231efe in _0xc8efb36f)
        {
            string _0xb470b519 = _0xc6326089();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xb470b519} val={_0xc5231efe}");
#endif
            }

            _0xf97ae49e.Add(_0xb470b519, _0xc5231efe == null ? "" : _0xc5231efe);
        }

        return _0xf97ae49e;
    }

    internal bool ContainsIgnoreCase(string _0x54123f38, string _0x6a234ea8)
    {
        if (string.IsNullOrEmpty(_0x54123f38) || string.IsNullOrEmpty(_0x6a234ea8))
            return false;
        return _0x54123f38.IndexOf(_0x6a234ea8, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x6359008b = "";
    private bool _0x22134ec5()
    {
        var _0x89c8f31a = _0x441e7cfe();
        if (_0x89c8f31a == null)
            return false;
        WLog(_0x3012bf3b._0x6db8ceb0(new byte[31] { 210, 251, 232, 254, 237, 251, 232, 255, 186, 248, 251, 249, 241, 186, 183, 164, 186, 234, 245, 234, 239, 234, 186, 221, 245, 216, 251, 249, 241, 160, 186 }, 154) + _0x89c8f31a.Id);
        _0x89c8f31a.GoBack();
        return true;
    }

    internal bool IsGoogleAuthFlowUrl(string _0x4f5cec7d)
    {
        if (string.IsNullOrEmpty(_0x4f5cec7d))
            return false;
        return _0x4f5cec7d.IndexOf(_0x3012bf3b._0x6db8ceb0(new byte[19] { 139, 137, 137, 133, 159, 132, 158, 153, 196, 141, 133, 133, 141, 134, 143, 196, 137, 133, 135 }, 234), StringComparison.OrdinalIgnoreCase) >= 0 || _0x4f5cec7d.IndexOf(_0x3012bf3b._0x6db8ceb0(new byte[16] { 21, 23, 23, 27, 1, 26, 0, 7, 90, 19, 27, 27, 19, 24, 17, 90 }, 116), StringComparison.OrdinalIgnoreCase) >= 0 || _0x4f5cec7d.IndexOf(_0x3012bf3b._0x6db8ceb0(new byte[21] { 255, 247, 247, 255, 244, 253, 237, 235, 253, 234, 251, 247, 246, 236, 253, 246, 236, 182, 251, 247, 245 }, 152), StringComparison.OrdinalIgnoreCase) >= 0 || _0x4f5cec7d.IndexOf(_0x3012bf3b._0x6db8ceb0(new byte[11] { 194, 214, 209, 196, 209, 204, 198, 139, 198, 202, 200 }, 165), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal Vector2 lastSize = Vector2.zero;
    private GameObject _0xe3250d77;
    private bool _0xc7183b91(string _0x6b646db3)
    {
        try
        {
            using (var _0x4a2840b2 = new AndroidJavaClass(_0x3012bf3b._0x6db8ceb0(new byte[30] { 203, 199, 197, 134, 221, 198, 193, 220, 209, 155, 204, 134, 216, 196, 201, 209, 205, 218, 134, 253, 198, 193, 220, 209, 248, 196, 201, 209, 205, 218 }, 168)))
            using (var _0x9cff9169 = _0x4a2840b2.GetStatic<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[15] { 30, 8, 15, 15, 24, 19, 9, 60, 30, 9, 20, 11, 20, 9, 4 }, 125)))
            using (var _0xed475690 = _0x9cff9169.Call<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[17] { 79, 77, 92, 120, 73, 75, 67, 73, 79, 77, 101, 73, 70, 73, 79, 77, 90 }, 40)))
            using (var _0x4f55f86d = new AndroidJavaClass(_0x3012bf3b._0x6db8ceb0(new byte[22] { 176, 191, 181, 163, 190, 184, 181, 255, 178, 190, 191, 165, 180, 191, 165, 255, 152, 191, 165, 180, 191, 165 }, 209)))
            using (var _0x18131256 = _0x4f55f86d.CallStatic<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[8] { 221, 204, 223, 222, 200, 248, 223, 196 }, 173), _0x6b646db3, 1))
            {
                string _0x5980531d = _0x18131256.Call<string>(_0x3012bf3b._0x6db8ceb0(new byte[14] { 11, 9, 24, 63, 24, 30, 5, 2, 11, 41, 20, 24, 30, 13 }, 108), _0x3012bf3b._0x6db8ceb0(new byte[20] { 210, 194, 223, 199, 195, 213, 194, 239, 214, 209, 220, 220, 210, 209, 211, 219, 239, 197, 194, 220 }, 176));
                string _0xd7123d87 = _0x18131256.Call<string>(_0x3012bf3b._0x6db8ceb0(new byte[10] { 18, 16, 1, 37, 20, 22, 30, 20, 18, 16 }, 117));
                _0x18131256.Call<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[11] { 33, 36, 36, 3, 33, 52, 37, 39, 47, 50, 57 }, 64), _0x3012bf3b._0x6db8ceb0(new byte[33] { 100, 107, 97, 119, 106, 108, 97, 43, 108, 107, 113, 96, 107, 113, 43, 102, 100, 113, 96, 98, 106, 119, 124, 43, 71, 87, 74, 82, 86, 68, 71, 73, 64 }, 5));
                _0x18131256.Call<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[11] { 128, 151, 159, 157, 132, 151, 183, 138, 134, 128, 147 }, 242), _0x3012bf3b._0x6db8ceb0(new byte[20] { 222, 206, 211, 203, 207, 217, 206, 227, 218, 221, 208, 208, 222, 221, 223, 215, 227, 201, 206, 208 }, 188));
                if (_0x18131256.Call<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[15] { 43, 60, 42, 54, 53, 47, 60, 24, 58, 45, 48, 47, 48, 45, 32 }, 89), _0xed475690) != null)
                {
                    WLog(_0x3012bf3b._0x6db8ceb0(new byte[24] { 253, 214, 204, 209, 211, 219, 242, 215, 213, 219, 158, 209, 206, 219, 208, 158, 215, 208, 202, 219, 208, 202, 132, 158 }, 190) + _0x6b646db3);
                    _0x18131256.Call<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[8] { 64, 69, 69, 103, 77, 64, 70, 82 }, 33), 0x10000000);
                    _0x9cff9169.Call(_0x3012bf3b._0x6db8ceb0(new byte[13] { 47, 40, 61, 46, 40, 29, 63, 40, 53, 42, 53, 40, 37 }, 92), _0x18131256);
                    return true;
                }

                if (_0x67b550dc(_0xd7123d87))
                    return true;
                if (!string.IsNullOrEmpty(_0x5980531d))
                {
                    WLog(_0x3012bf3b._0x6db8ceb0(new byte[28] { 41, 2, 24, 5, 7, 15, 38, 3, 1, 15, 74, 3, 4, 30, 15, 4, 30, 74, 12, 11, 6, 6, 8, 11, 9, 1, 80, 74 }, 106) + _0x5980531d);
                    if (_0x23093202(_0x5980531d))
                        return _0xabdd40cb(_0x5980531d, _0xd7123d87);
                    return _0x4baa98eb(_0x5980531d);
                }

                WLog(_0x3012bf3b._0x6db8ceb0(new byte[30] { 20, 63, 37, 56, 58, 50, 27, 62, 60, 50, 119, 62, 57, 35, 50, 57, 35, 119, 57, 56, 119, 63, 54, 57, 51, 59, 50, 37, 109, 119 }, 87) + _0x6b646db3);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x3012bf3b._0x6db8ceb0(new byte[26] { 96, 75, 81, 76, 78, 70, 111, 74, 72, 70, 3, 74, 77, 87, 70, 77, 87, 3, 69, 66, 74, 79, 70, 71, 25, 3 }, 35) + e.Message);
            return true;
        }
    }

    private bool _0x89668488 = false;
    private bool _0x6b70bec9 = false;
    internal bool firstLoadShown = false;
    private bool _0x4baa98eb(string _0xea0a082f)
    {
        try
        {
            using (var _0xd89dd9a0 = new AndroidJavaClass(_0x3012bf3b._0x6db8ceb0(new byte[30] { 117, 121, 123, 56, 99, 120, 127, 98, 111, 37, 114, 56, 102, 122, 119, 111, 115, 100, 56, 67, 120, 127, 98, 111, 70, 122, 119, 111, 115, 100 }, 22)))
            using (var _0x8ab62850 = _0xd89dd9a0.GetStatic<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[15] { 34, 52, 51, 51, 36, 47, 53, 0, 34, 53, 40, 55, 40, 53, 56 }, 65)))
            using (var _0x3e5291b8 = new AndroidJavaClass(_0x3012bf3b._0x6db8ceb0(new byte[15] { 2, 13, 7, 17, 12, 10, 7, 77, 13, 6, 23, 77, 54, 17, 10 }, 99)))
            using (var _0x36603dad = _0x3e5291b8.CallStatic<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[5] { 65, 80, 67, 66, 84 }, 49), _0xea0a082f))
            using (var _0x56109625 = new AndroidJavaObject(_0x3012bf3b._0x6db8ceb0(new byte[22] { 20, 27, 17, 7, 26, 28, 17, 91, 22, 26, 27, 1, 16, 27, 1, 91, 60, 27, 1, 16, 27, 1 }, 117), _0x3012bf3b._0x6db8ceb0(new byte[26] { 28, 19, 25, 15, 18, 20, 25, 83, 20, 19, 9, 24, 19, 9, 83, 28, 30, 9, 20, 18, 19, 83, 43, 52, 56, 42 }, 125), _0x36603dad))
            {
                WLog(_0x3012bf3b._0x6db8ceb0(new byte[26] { 192, 235, 241, 236, 238, 230, 207, 234, 232, 230, 163, 236, 243, 230, 237, 163, 230, 251, 247, 230, 241, 237, 226, 239, 185, 163 }, 131) + _0xea0a082f);
                _0x56109625.Call<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[11] { 122, 127, 127, 88, 122, 111, 126, 124, 116, 105, 98 }, 27), _0x3012bf3b._0x6db8ceb0(new byte[33] { 93, 82, 88, 78, 83, 85, 88, 18, 85, 82, 72, 89, 82, 72, 18, 95, 93, 72, 89, 91, 83, 78, 69, 18, 126, 110, 115, 107, 111, 125, 126, 112, 121 }, 60));
                _0x56109625.Call<AndroidJavaObject>(_0x3012bf3b._0x6db8ceb0(new byte[8] { 201, 204, 204, 238, 196, 201, 207, 219 }, 168), 0x10000000);
                _0x8ab62850.Call(_0x3012bf3b._0x6db8ceb0(new byte[13] { 220, 219, 206, 221, 219, 238, 204, 219, 198, 217, 198, 219, 214 }, 175), _0x56109625);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x3012bf3b._0x6db8ceb0(new byte[28] { 157, 182, 172, 177, 179, 187, 146, 183, 181, 187, 254, 187, 166, 170, 187, 172, 176, 191, 178, 254, 184, 191, 183, 178, 187, 186, 228, 254 }, 222) + e.Message);
            Application.OpenURL(_0xea0a082f);
            return true;
        }
    }

    private static bool IsPrivacyItemTrue(Item _0xa8e5d24a)
    {
        if (_0xa8e5d24a.Key != _0x3012bf3b._0x6db8ceb0(new byte[9] { 51, 41, 10, 40, 51, 44, 59, 57, 35 }, 90))
            return false;
        try
        {
            var _0xaf90608b = _0xa8e5d24a.Value.GetAs<object>();
            return _0xaf90608b switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    internal Rect lastSafe = Rect.zero;
    private void _0x7a1f1bd9(string _0xe6cc67d1)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[34] { 12, 3, 50, 36, 35, 10, 119, 17, 50, 35, 52, 63, 119, 18, 47, 35, 37, 54, 119, 7, 34, 36, 63, 119, 19, 54, 35, 54, 119, 5, 54, 32, 109, 119 }, 87) + _0xe6cc67d1);
#endif
            }
        }

        var _0xd5512f08 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xe6cc67d1);
        StartCoroutine(_0xe431d89a(_0xd5512f08));
    }

    private string _0xaa738481 = "";
    private void _0x81169e78(string _0x94ff1ea8)
    {
        if (string.IsNullOrEmpty(_0x94ff1ea8))
            return;
        if (TryOpenExternalLikeChrome(_0x94ff1ea8))
            return;
        OpenUrlExternally(_0x94ff1ea8);
    }

    private static string ReadPushField(Dictionary<string, object> _0x9325d525, string _0x578086d4)
    {
        if (_0x9325d525 == null || string.IsNullOrEmpty(_0x578086d4))
            return string.Empty;
        if (_0x9325d525.TryGetValue(_0x3012bf3b._0x6db8ceb0(new byte[16] { 230, 231, 252, 225, 238, 225, 235, 233, 252, 225, 231, 230, 204, 233, 252, 233 }, 136), out var raw))
        {
            try
            {
                var _0x0ce41bf7 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x0ce41bf7 != null && _0x0ce41bf7.TryGetValue(_0x578086d4, out var nestedVal))
                {
                    var _0xc7046522 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0xc7046522))
                        return _0xc7046522;
                }
            }
            catch
            {
            }
        }

        if (_0x9325d525.TryGetValue(_0x578086d4, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private bool _0x7a4c9545 = false;
    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x1b9440e9(string _0xf0d1987f, string _0xff66183d)
    {
        try
        {
            using var _0xf3c99fb0 = Aes.Create();
            _0xf3c99fb0.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xff66183d));
            _0xf3c99fb0.GenerateIV();
            using var _0x5a166850 = new MemoryStream();
            _0x5a166850.Write(_0xf3c99fb0.IV, 0, _0xf3c99fb0.IV.Length);
            using (var _0x37204fe9 = new CryptoStream(_0x5a166850, _0xf3c99fb0.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0xebf94743 = Encoding.UTF8.GetBytes(_0xf0d1987f);
                _0x37204fe9.Write(_0xebf94743, 0, _0xebf94743.Length);
                _0x37204fe9.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x5a166850.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private Text _0x5ef02246;
    private bool _0x1656b2fb = false;
    // WEB VIEW LOGIC END
    internal void _0x85e12c1c()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0xe3e4a564 = new AndroidNotificationChannel
        {
            Id = _0x3012bf3b._0x6db8ceb0(new byte[15] { 174, 175, 172, 171, 191, 166, 190, 149, 169, 162, 171, 164, 164, 175, 166 }, 202),
            Name = _0x3012bf3b._0x6db8ceb0(new byte[15] { 237, 204, 207, 200, 220, 197, 221, 137, 234, 193, 200, 199, 199, 204, 197 }, 169),
            Importance = Importance.High,
            Description = _0x3012bf3b._0x6db8ceb0(new byte[21] { 159, 189, 182, 189, 170, 185, 180, 248, 182, 183, 172, 177, 190, 177, 187, 185, 172, 177, 183, 182, 171 }, 216)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0xe3e4a564);
        // Build notification
        var _0xaff662db = new AndroidNotification
        {
            Title = _0x18c81b7f[UnityEngine.Random.Range(0, _0x18c81b7f.Length)],
            Text = _0x3012bf3b._0x6db8ceb0(new byte[21] { 40, 27, 12, 73, 16, 6, 28, 73, 26, 28, 27, 12, 73, 29, 6, 73, 12, 17, 0, 29, 86 }, 105),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xaff662db, _0x3012bf3b._0x6db8ceb0(new byte[15] { 43, 42, 41, 46, 58, 35, 59, 16, 44, 39, 46, 33, 33, 42, 35 }, 79));
    }

    private Canvas _0xaeb5451d;
    private string _0x76bc9884 = "";
    private async Task<bool> _0xb4c741b2()
    {
        {
#if B_LOGS
            Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[29] { 140, 131, 178, 164, 163, 138, 247, 158, 164, 135, 165, 190, 161, 182, 180, 174, 150, 185, 179, 132, 182, 161, 178, 179, 148, 191, 178, 180, 188 }, 215));
#endif
        }

        string _0xffdc0ad0 = "";
        for (int _0x6b53e244 = 0; _0x6b53e244 < 2; _0x6b53e244++)
        {
            if (await _0x33604cb0(1, 100))
            {
                await _0x1e2b70fd(_0x3012bf3b._0x6db8ceb0(new byte[7] { 129, 143, 140, 128, 136, 134, 135 }, 227));
                _0x3e4ee2f7();
                return true;
            }

            _0xffdc0ad0 = await _0xdaca9206(1, 100);
            if (!string.IsNullOrEmpty(_0xffdc0ad0))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xffdc0ad0))
            {
                if (!string.IsNullOrEmpty(_0xe017cd70))
                {
                    _0xffdc0ad0 = _0xa4c4781f(_0xffdc0ad0, _0xe017cd70);
                    {
#if B_LOGS
                        Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[53] { 191, 176, 129, 151, 144, 185, 196, 167, 133, 135, 140, 129, 128, 196, 130, 141, 138, 133, 136, 177, 150, 136, 196, 147, 141, 144, 140, 196, 151, 129, 138, 128, 141, 128, 196, 6, 98, 118, 196, 151, 140, 139, 147, 196, 179, 129, 134, 178, 141, 129, 147, 222, 196 }, 228) + _0xffdc0ad0);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[39] { 77, 66, 115, 101, 98, 75, 54, 85, 119, 117, 126, 115, 114, 54, 112, 127, 120, 119, 122, 67, 100, 122, 54, 244, 144, 132, 54, 101, 126, 121, 97, 54, 65, 115, 116, 64, 127, 115, 97 }, 22));
#endif
                    }
                }

                _0xb4df5896 = true;
                _0xa4c8712d(_0xffdc0ad0);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[44] { 53, 58, 11, 29, 26, 51, 78, 43, 22, 13, 11, 30, 26, 7, 1, 0, 78, 25, 6, 7, 2, 11, 78, 13, 6, 11, 13, 5, 7, 0, 9, 78, 29, 15, 24, 11, 10, 78, 2, 7, 0, 5, 84, 78 }, 110) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private void _0x728af67a()
    {
        if (_0xe3250d77 != null)
            return;
        var _0x231e1a23 = _0xd64c7f7d();
        _0xe3250d77 = new GameObject(_0x3012bf3b._0x6db8ceb0(new byte[14] { 6, 52, 51, 7, 56, 52, 38, 2, 33, 56, 63, 63, 52, 35 }, 81), typeof(RectTransform), typeof(Text));
        _0x10fc8f54 = _0xe3250d77.GetComponent<RectTransform>();
        _0x10fc8f54.SetParent(_0x231e1a23.transform, false);
        _0x10fc8f54.anchorMin = new Vector2(0.5f, 0.5f);
        _0x10fc8f54.anchorMax = new Vector2(0.5f, 0.5f);
        _0x10fc8f54.pivot = new Vector2(0.5f, 0.5f);
        _0x10fc8f54.sizeDelta = new Vector2(600f, 600f);
        _0x10fc8f54.anchoredPosition = Vector2.zero;
        _0x5ef02246 = _0xe3250d77.GetComponent<Text>();
        _0x5ef02246.text = _0x3012bf3b._0x6db8ceb0(new byte[1] { 63 }, 16);
        _0x5ef02246.font = Resources.GetBuiltinResource<Font>(_0x3012bf3b._0x6db8ceb0(new byte[17] { 55, 30, 28, 26, 24, 2, 41, 14, 21, 15, 18, 22, 30, 85, 15, 15, 29 }, 123));
        _0x5ef02246.fontSize = 200;
        _0x5ef02246.alignment = TextAnchor.MiddleCenter;
        _0x5ef02246.color = Color.white;
        _0x5ef02246.raycastTarget = false;
        _0xe3250d77.SetActive(false);
    }

    private async Task<bool> _0x829ed7ee()
    {
        _0x912c6d1c.Instance?._0x70a5bbcc();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x4e680a9d) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[32] { 73, 70, 119, 97, 102, 79, 50, 71, 124, 123, 102, 107, 50, 66, 103, 97, 122, 50, 92, 125, 102, 123, 116, 123, 113, 115, 102, 123, 125, 124, 40, 50 }, 18) + string.Join(_0x3012bf3b._0x6db8ceb0(new byte[1] { 96 }, 105), _0x4e680a9d));
                }
#endif
            }
        };
        try
        {
            _0x6f63dfcd = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[31] { 9, 6, 55, 33, 38, 15, 114, 20, 51, 59, 62, 55, 54, 114, 38, 61, 114, 53, 55, 38, 114, 34, 39, 33, 58, 114, 38, 61, 57, 55, 60 }, 82));
                }
#endif
            }

            _0x6f63dfcd = "";
        }

        _0xccfbdbdc = !string.IsNullOrEmpty(_0x6f63dfcd);
        _0x19f15a60 = _0x80b7c1bc();
        {
#if B_LOGS
            Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[25] { 106, 101, 84, 66, 69, 108, 17, 100, 95, 88, 69, 72, 17, 97, 68, 66, 89, 17, 101, 94, 90, 84, 95, 11, 17 }, 49) + _0x6f63dfcd);
#endif
        }

        _0x912c6d1c.Instance?._0xd6497274();
        return false;
    }

    private void _0x162dde56()
    {
        {
#if B_LOGS
            Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[22] { 200, 199, 246, 224, 231, 206, 179, 192, 231, 252, 225, 246, 215, 246, 229, 250, 240, 246, 218, 253, 245, 252 }, 147));
#endif
        }

        _0xaa738481 = SystemInfo.deviceModel;
        _0x24364ba2 = Application.version;
        _0x32f87db9 = Application.installMode;
        _0x76bc9884 = Application.installerName;
        _0x85704475 = Application.identifier;
        _0x537fac91 = _0xfbd47f6a();
        _0x07417d37 = _0xc543f284();
        _0x6359008b = SystemInfo.deviceUniqueIdentifier;
        _0x83e84962 = SystemInfo.graphicsDeviceName;
        _0xf0bee872 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x24364ba2 = _0x3012bf3b._0x6db8ceb0(new byte[5] { 102, 127, 102, 127, 102 }, 81);
                _0x32f87db9 = ApplicationInstallMode.Store;
                _0x76bc9884 = _0x3012bf3b._0x6db8ceb0(new byte[19] { 225, 237, 239, 172, 227, 236, 230, 240, 237, 235, 230, 172, 244, 231, 236, 230, 235, 236, 229 }, 130);
                _0x07417d37 = _0x3012bf3b._0x6db8ceb0(new byte[8] { 1, 9, 20, 16, 29, 68, 17, 5 }, 100);
                _0x6359008b = Guid.NewGuid().ToString().Replace(_0x3012bf3b._0x6db8ceb0(new byte[1] { 104 }, 69), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[17] { 22, 25, 40, 62, 57, 16, 109, 41, 40, 59, 0, 34, 41, 40, 33, 119, 109 }, 77) + _0xaa738481);
            Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[19] { 233, 230, 215, 193, 198, 239, 146, 211, 194, 194, 228, 215, 192, 193, 219, 221, 220, 136, 146 }, 178) + _0x24364ba2);
            Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[20] { 15, 0, 49, 39, 32, 9, 116, 61, 58, 39, 32, 53, 56, 56, 25, 59, 48, 49, 110, 116 }, 84) + _0x32f87db9);
            Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[23] { 113, 126, 79, 89, 94, 119, 10, 67, 68, 89, 94, 75, 70, 70, 79, 88, 121, 94, 69, 88, 79, 16, 10 }, 42) + _0x76bc9884);
            Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[14] { 9, 6, 55, 33, 38, 15, 114, 51, 34, 34, 27, 54, 104, 114 }, 82) + _0x85704475);
            Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[14] { 46, 33, 16, 6, 1, 40, 85, 20, 17, 3, 60, 17, 79, 85 }, 117) + _0x537fac91);
            Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[18] { 144, 159, 174, 184, 191, 150, 235, 190, 184, 174, 185, 138, 172, 174, 165, 191, 241, 235 }, 203) + _0x07417d37);
            Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[17] { 203, 196, 245, 227, 228, 205, 176, 227, 233, 227, 212, 245, 230, 217, 244, 170, 176 }, 144) + _0x6359008b);
            Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[12] { 125, 114, 67, 85, 82, 123, 6, 65, 86, 83, 28, 6 }, 38) + _0x83e84962);
            Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[12] { 195, 204, 253, 235, 236, 197, 184, 251, 232, 237, 162, 184 }, 152) + _0xf0bee872);
#endif
        }
    }

    public void _0xf25eb715()
    {
        if (_0xd534de89)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[33] { 62, 49, 0, 22, 17, 56, 69, 49, 12, 8, 0, 23, 69, 10, 16, 17, 69, 72, 91, 69, 8, 10, 19, 0, 69, 17, 10, 69, 22, 6, 0, 11, 0 }, 101));
            }
#endif
        }

        _0x3e4ee2f7();
    }

    private string _0x502134f7()
    {
        if (string.IsNullOrEmpty(_0x07417d37) && _0x985b2623 != null)
            _0x07417d37 = _0x985b2623.GetUserAgent();
        if (string.IsNullOrEmpty(_0x07417d37))
            return string.Empty;
        string _0xa18d94ac = Regex.Replace(_0x07417d37, _0x3012bf3b._0x6db8ceb0(new byte[11] { 147, 188, 229, 244, 147, 188, 229, 184, 185, 147, 173 }, 207), string.Empty);
        _0xa18d94ac = Regex.Replace(_0xa18d94ac, _0x3012bf3b._0x6db8ceb0(new byte[15] { 174, 129, 217, 176, 135, 155, 158, 150, 221, 169, 172, 201, 219, 175, 217 }, 242), string.Empty);
        _0xa18d94ac = Regex.Replace(_0xa18d94ac, _0x3012bf3b._0x6db8ceb0(new byte[15] { 32, 19, 4, 5, 31, 25, 24, 89, 66, 42, 88, 70, 42, 5, 92 }, 118), string.Empty);
        return Regex.Replace(_0xa18d94ac, _0x3012bf3b._0x6db8ceb0(new byte[6] { 222, 241, 249, 176, 174, 255 }, 130), _0x3012bf3b._0x6db8ceb0(new byte[1] { 34 }, 2)).Trim();
    }

    private ApplicationInstallMode _0x32f87db9 = ApplicationInstallMode.Unknown;
    private string _0x83e84962 = "";
    private Task _0x6df02252(IEnumerator _0xca8fbdc9)
    {
        var _0xbaa9ebc3 = new TaskCompletionSource<bool>();
        StartCoroutine(_0x0761418f(_0xca8fbdc9, _0xbaa9ebc3));
        return _0xbaa9ebc3.Task;
    }

    public void _0x3e4ee2f7()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x3012bf3b._0x6db8ceb0(new byte[18] { 83, 92, 109, 123, 124, 85, 40, 68, 105, 125, 102, 107, 96, 40, 79, 105, 101, 109 }, 8));
#endif
        }

        _0x912c6d1c.Instance?._0x60de26c6();
        _0xb01be533.Instance._0x00a24a4a(_0x68897f3a._0x215fc08c.DEFAULT);
    }
}

internal static class _0x3012bf3b
{
    internal static string _0x6db8ceb0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}