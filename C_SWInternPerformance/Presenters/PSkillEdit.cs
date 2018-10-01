using C_SWInternPerformance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Presenters
{
    class PSkillEdit
    {
        private ISkillEdit vSkillEdit;
        public PSkillEdit(ISkillEdit view) => this.vSkillEdit = view;

        // Add new skill.
        public void AddSkill()
        {
            SkillEdit skill = new SkillEdit
            {
                SkillEditID = vSkillEdit.SkillEditID,
                SkillName = vSkillEdit.SkillName,
                SkillType = vSkillEdit.SkillType,
                DelEdit = vSkillEdit.DelEdit,
                RemarkEdit = vSkillEdit.RemarkEdit
            };
            skill.AddSkill();
        }

        // Update skill.
        public void SaveSkill()
        {
            SkillEdit skill = new SkillEdit
            {
                SkillEditID = vSkillEdit.SkillEditID,
                SkillName = vSkillEdit.SkillName,
                SkillType = vSkillEdit.SkillType,
                DelEdit = vSkillEdit.DelEdit,
                RemarkEdit = vSkillEdit.RemarkEdit
            };
            skill.SaveSkill();
        }
    }
}
