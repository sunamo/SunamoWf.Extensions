namespace SunamoWf.Extensions;

/// <summary>
/// Extension methods for converting System.Drawing.SizeF to System.Windows.Size (WPF interop).
/// </summary>
public static class SystemDrawingSizeFExtension
{
    /// <summary>
    /// Converts a System.Drawing.SizeF to an equivalent System.Windows.Size.
    /// </summary>
    public static System.Windows.Size ToSunamo(this System.Drawing.SizeF size)
    {
        return new System.Windows.Size(size.Width, size.Height);
    }
}
