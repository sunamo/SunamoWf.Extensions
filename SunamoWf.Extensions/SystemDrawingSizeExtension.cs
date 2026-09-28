namespace SunamoWf.Extensions;

/// <summary>
/// Extension methods for converting System.Drawing.Size to System.Windows.Size (WPF interop).
/// </summary>
public static class SystemDrawingSizeExtension
{
    /// <summary>
    /// Converts a System.Drawing.Size to an equivalent System.Windows.Size.
    /// </summary>
    public static System.Windows.Size ToSunamo(this System.Drawing.Size size)
    {
        return new System.Windows.Size(size.Width, size.Height);
    }
}
