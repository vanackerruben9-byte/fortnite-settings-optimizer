using System;
using System.Collections.Generic;

class SettingsPresets
{
    public static Dictionary<string, Dictionary<string, string>> GetPresets()
    {
        var presets = new Dictionary<string, Dictionary<string, string>>();

        // Low-end preset (GTX 1650, Ryzen 3300X)
        presets["Low-End"] = new Dictionary<string, string>
        {
            { "Resolution", "1920x1080" },
            { "Frame Rate Target", "120 FPS" },
            { "Graphics Quality", "Medium" },
            { "Shadows", "Low" },
            { "Textures", "High" },
            { "Effects", "Low" },
            { "DLSS", "Performance" },
            { "Ray Tracing", "Off" }
        };

        // Medium preset
        presets["Medium"] = new Dictionary<string, string>
        {
            { "Resolution", "2560x1440" },
            { "Frame Rate Target", "144 FPS" },
            { "Graphics Quality", "High" },
            { "Shadows", "Medium" },
            { "Textures", "Ultra" },
            { "Effects", "Medium" },
            { "DLSS", "Quality" },
            { "Ray Tracing", "Off" }
        };

        // High-end preset
        presets["High-End"] = new Dictionary<string, string>
        {
            { "Resolution", "3840x2160" },
            { "Frame Rate Target", "240 FPS" },
            { "Graphics Quality", "Ultra" },
            { "Shadows", "High" },
            { "Textures", "Ultra" },
            { "Effects", "Ultra" },
            { "DLSS", "Off" },
            { "Ray Tracing", "On" }
        };

        return presets;
    }
}