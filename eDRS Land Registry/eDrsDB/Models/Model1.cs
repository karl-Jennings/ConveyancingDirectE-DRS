using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace eDrsDB.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=AppDbContext")
        {
        }

        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<ApplicationForm> ApplicationForms { get; set; }
        public virtual DbSet<DocumentReference> DocumentReferences { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<LrCredential> LrCredentials { get; set; }
        public virtual DbSet<Outstanding> Outstandings { get; set; }
        public virtual DbSet<Party> Parties { get; set; }
        public virtual DbSet<RegistrationType> RegistrationTypes { get; set; }
        public virtual DbSet<Representation> Representations { get; set; }
        public virtual DbSet<RequestLog> RequestLogs { get; set; }
        public virtual DbSet<SupportingDocument> SupportingDocuments { get; set; }
        public virtual DbSet<TitleNumber> TitleNumbers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; }
        public virtual DbSet<Hash> Hashes { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobParameter> JobParameters { get; set; }
        public virtual DbSet<JobQueue> JobQueues { get; set; }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<Schema> Schemata { get; set; }
        public virtual DbSet<Server> Servers { get; set; }
        public virtual DbSet<Set> Sets { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Counter> Counters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
