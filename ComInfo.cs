﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 共通情報のロジック
/// </summary>
public class ComInfo
{
    /// <summary>
    /// Pixelの列挙
    /// </summary>
    public enum Pixel
    {
        B = 0,
        G,
        R,
        A,
        MAX,
    };

    /// <summary>
    /// 画像処理のタイプの列挙
    /// </summary>
    public enum ImgProcType
    {
        EdgeDetection = 0,
        GrayScale,
        Binarization,
        GrayScale2Diff,
        ColorReversal,
        MAX,
    }

    /// <summary>
    /// 画像のタイプの列挙
    /// </summary>
    public enum ImgDataType
    {
        Jpg = 0,
        Png,
        MAX,
    }

    /// <summary>
    /// 画像の状態の列挙
    /// </summary>
    public enum PictureType
    {
        Original = 0,
        After,
        MAX,
    }

    public const short RGB_MAX = 256;

    public const string MENU_SETTING_IMAGE_PROCESSING = "Image Processing";
    public const string MENU_FILE_END = "End(&X)";
    public const string MENU_SAVE_CSV = "Save Csv...";
    public const string BTN_OK = "btnOk";
    public const string BTN_CANCEL = "btnCancel";
    public const string IMG_NAME_EDGE_DETECTION = "EdgeDetection";
    public const string IMG_NAME_GRAY_SCALE = "GrayScale";
    public const string IMG_NAME_BINARIZATION = "Binarization";
    public const string IMG_NAME_GRAY_SCALE_2DIFF = "GrayScale 2Diff";
    public const string IMG_NAME_COLOR_REVERSAL = "ColorReversal";
}