﻿using RepoDb.Attributes;

namespace RepoDb.Enumerations
{
    public enum Order : short
    {
        [Text("ASC")] Ascending = 1,
        [Text("DESC")] Descending = 2
    }
}