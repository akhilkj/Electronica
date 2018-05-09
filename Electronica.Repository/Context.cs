using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;
namespace Electronica.Entity
{
    public class ElectronicaContext : DbContext
        {
            public ElectronicaContext() : base("ElectronicaDB")
            {
            Database.SetInitializer<ElectronicaContext>(new CreateDatabaseIfNotExists<ElectronicaContext>());           
            }
            public virtual DbSet<UserType> UserTypes { get; set; }
            public virtual DbSet<User> Users { get; set; }
            public virtual DbSet<Location> Locations { get; set; }
            public virtual DbSet<Topic> Topics { get; set; }
            public virtual DbSet<Admin> Admins { get; set; }
            public virtual DbSet<Skill> Skills { get; set; }
            public virtual DbSet<SpeakerSkillMap> SpeakerSkillMaps { get; set; }
            public virtual DbSet<Event> Events { get; set; }
            public virtual DbSet<Prerequisite> Prerequisites { get; set; }
            public virtual DbSet<SpeakerEnrollment> SpeakerEnrollments { get; set; }
            public virtual DbSet<ParticipantEnrollment> ParticipantEnrollments { get; set; }


        


        }
    }