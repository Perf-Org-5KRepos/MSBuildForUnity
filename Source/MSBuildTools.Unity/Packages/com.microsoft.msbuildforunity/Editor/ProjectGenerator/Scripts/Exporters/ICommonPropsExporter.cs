﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

#if UNITY_EDITOR
using System.IO;

namespace Microsoft.Build.Unity.ProjectGeneration.Exporters
{
    /// <summary>
    /// Exporter for the MSBuild common props file.
    /// </summary>
    public interface ICommonPropsExporter
    {
        /// <summary>
        /// Gets or sets the Unity major version.
        /// </summary>
        string UnityMajorVersion { get; set; }

        /// <summary>
        /// Gets or sets the Unity minir version.
        /// </summary>
        string UnityMinorVersion { get; set; }

        /// <summary>
        /// Gets or sets the current unity platform selected in the editor.
        /// </summary>
        string CurrentUnityPlatform { get; set; }

        /// <summary>
        /// Gets or sets the currently configured target framework.
        /// </summary>
        string CurrentTargetFramework { get; set; }

        /// <summary>
        /// Gets or sets the current Unity project assets directory.
        /// </summary>
        DirectoryInfo UnityProjectAssetsDirectory { get; set; }

        /// <summary>
        /// Gets or sets the MSBuild generated output directory.
        /// </summary>
        DirectoryInfo GeneratedProjectOutputPath { get; set; }

        /// <summary>
        /// Writes out the data.
        /// </summary>
        void Write();
    }
}
#endif