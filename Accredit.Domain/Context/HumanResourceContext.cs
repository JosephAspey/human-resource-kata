using System;
using System.Collections.Generic;
using System.Linq;
using Accredit.Domain.ModelBuilders;
using Accredit.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Accredit.Domain.Context
{
    public class HumanResourceContext : DbContext
    {
        public HumanResourceContext(DbContextOptions<HumanResourceContext> options)
            : base(options)
        { }

        public DbSet<HumanResource> HumanResources { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //get and configure each entity
            GetModelBuilders().ForEach(b => b.Construct(modelBuilder));

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;
        }

        private static List<IContextModelBuilder> GetModelBuilders()
        {
            var builders = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => typeof(IContextModelBuilder).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

            return CreateModelBuilders(builders);
        }

        private static List<IContextModelBuilder> CreateModelBuilders(IEnumerable<Type> builders)
        {
            return builders.Select(type => (IContextModelBuilder)Activator.CreateInstance(type)).ToList();
        }
    }
}