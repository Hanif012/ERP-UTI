using System;

// This file is auto-generated. Do not modify or move this file.

namespace SuperUnityBuild.Generated
{
    public enum ReleaseType
    {
        None,
        Beta,
    }

    public enum Platform
    {
        None,
        Android,
        iOS,
    }

    public enum ScriptingBackend
    {
        None,
        IL2CPP,
    }

    public enum Architecture
    {
        None,
        Android,
        iOS,
    }

    public enum Distribution
    {
        None,
    }

    public static class BuildConstants
    {
        public static readonly DateTime buildDate = new DateTime(638510350935796580);
        public const string version = "1.0.0.1";
        public const ReleaseType releaseType = ReleaseType.Beta;
        public const Platform platform = Platform.iOS;
        public const ScriptingBackend scriptingBackend = ScriptingBackend.IL2CPP;
        public const Architecture architecture = Architecture.iOS;
        public const Distribution distribution = Distribution.None;
    }
}

