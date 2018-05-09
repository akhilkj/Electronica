using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;

namespace Electronica.Repository
{
  public  class SkillDAL
    {
        ElectronicaContext context;
        public SkillDAL()
        {
            context = new ElectronicaContext();
        }
        public void InsertSkill(Skill skill)
        {
            context.Skills.Add(skill);
            context.SaveChanges();
        }
        
        public List<Skill> SelectSkillForEvent()
        {
            List < Skill > SkillList= new List<Skill>();
            SkillList = (from skill in context.Skills select skill).ToList<Skill>();
            return SkillList;
        }
    }
}
