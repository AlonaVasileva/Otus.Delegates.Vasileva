﻿using System;

namespace Otus.Delegates.Vasileva
{
    public class FileArgs : EventArgs
    {
        public string FileName { get; set; }
        public bool Cancel { get; set; } // для отмены поиска
    }
}
