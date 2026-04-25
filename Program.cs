using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Fortnite Settings Optimizer ===");
        Console.WriteLine();

        HardwareDetector detector = new HardwareDetector();
        detector.DetectHardware();

        SettingsGenerator generator = new SettingsGenerator(detector);
        var settings = generator.GenerateOptimalSettings();

        Console.WriteLine("\n=== Recommended Settings ===");
        foreach (var setting in settings)
        {
            Console.WriteLine($"{setting.Key}: {setting.Value}");
        }
    }
}