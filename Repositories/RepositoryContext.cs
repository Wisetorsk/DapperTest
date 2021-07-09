using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Repositories
{
    /// <summary>
    /// Questionable implementation of flexible repo pattern...
    /// </summary>
    public class RepositoryContext : DbContext
    {
        public RepositoryContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public Dictionary<Guid, DbSet<Object>> Sets { get; set; }
    }
}
