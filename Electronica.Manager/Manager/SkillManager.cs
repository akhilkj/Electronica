using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Repository;
using Electronica.Entity;


namespace Electronica.Manager
{
 public   class SkillManager
    {
     public   List<Skill> SelectSkillsForEvent()
        {
            SkillDAL skillRepositary = new SkillDAL();
            List<Electronica.Entity.Skill> skillListEntity = new List<Electronica.Entity.Skill>();
            List<Skill> skillList = new List<Skill>();
            Skill skill = new Skill();
            skillListEntity = skillRepositary.SelectSkillForEvent();
            foreach (var item in skillListEntity)
            {
                skill = new Skill();
                skill.SkillID = item.SkillID;
                skill.SkillName = item.SkillName;
                skillList.Add(skill);
            }
            return skillList;
        }
    }
}
