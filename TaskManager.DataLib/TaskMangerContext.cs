using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity;
using TaskManager.Entities; 
namespace TaskManager.DataLib
{
    public class TaskMangerContext:DbContext
    {
        public TaskMangerContext() : base("name=TaskmanagerConn")
        {
        }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Task>().
              HasOptional(e => e.TaskParent).
              WithMany().
              HasForeignKey(m => m.TaskParentId);

        }
    }
}
