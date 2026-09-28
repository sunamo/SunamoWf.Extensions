namespace SunamoWf.Extensions;

/// <summary>
/// Extension methods for converting System.Drawing.Color to the platform-independent SunamoColor type.
/// </summary>
public static class SystemDrawingColorExtensions
{
    /// <summary>
    /// Converts a System.Drawing.Color to a SunamoColor with the same ARGB components.
    /// </summary>
    public static SunamoColor ToSunamoColor(this System.Drawing.Color color)
    {
        SunamoColor sunamoColor = new SunamoColor(color.A, color.R, color.G, color.B);
        return sunamoColor;
    }
}
