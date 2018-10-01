using C_SWInternPerformance.Data;
using C_SWInternPerformance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Presenters
{
    class PSkillManage:BasePresenter
    {
        private ISkillManage vSkillManage;
        public PSkillManage(ISkillManage view) => this.vSkillManage = view;

        // Get a list of skills.
        public BindingList<SkillData> SkillList()
        {
            SkillManage skill = new SkillManage();
            return skill.SkillList();
        }

        // Get a list of specifit user skills.
        public BindingList<SkillData> GetUserSkill(int ID)
        {
            SkillManage skill = new SkillManage();
            return skill.GetUserSkill(ID);
        }

        // Assign new skill to user.
        public void SkillAssign(int ID)
        {
            SkillManage skill = new SkillManage
            {
                SkillListID = vSkillManage.SkillListID,
                startDate = vSkillManage.StartDate,
                Del = vSkillManage.Del,
                Remark = vSkillManage.Remark
            };
            skill.SkillAssign(ID);
        }

        // Update assigned skill of the user.
        public void SaveSkillAssign(int ID)
        {
            SkillManage skill = new SkillManage
            {
                SkillListID = vSkillManage.SkillListID,
                startDate = vSkillManage.StartDate,
                Del = vSkillManage.Del,
                Remark = vSkillManage.Remark
            };
            skill.SaveSkillAssign(ID);
        }
    }
}
