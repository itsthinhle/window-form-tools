namespace Tools.Constants;

internal class FileExtensionConstants
{
    public static readonly string TXT = ".txt";

    public static readonly string WEBP = ".webp";
    public static readonly string JPG = ".jpg";
    public static readonly string PNG = ".png";

    public static readonly string MP4 = ".mp4";
    public static readonly string MKV = ".mkv";
    public static readonly string TS = ".ts";

    public static readonly List<string> TEXT_FILE_EXTENSIONS =
    [
        TXT
    ];

    public static readonly List<string> IMAGE_FILE_EXTENSIONS =
    [
        WEBP,
        JPG,
        PNG
    ];

    public static readonly List<string> VIDEO_FILE_EXTENSIONS =
    [
        MP4,
        MKV,
        TS
    ];
}
