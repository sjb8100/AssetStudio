﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetStudio
{
    public sealed class MonoBehaviour : Behaviour
    {
        public PPtr m_Script;
        public string m_Name;

        public MonoBehaviour(AssetPreloadData preloadData) : base(preloadData)
        {
            m_Script = sourceFile.ReadPPtr();
            m_Name = reader.ReadAlignedString();
        }
    }
}
