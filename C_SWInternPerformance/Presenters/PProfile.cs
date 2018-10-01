using C_SWInternPerformance.Data;
using C_SWInternPerformance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Presenters
{
    class PProfile:BasePresenter
    {
        private IProfile vProfile;
        public PProfile(IProfile view) => this.vProfile = view;

        // Get ONE profile.
        public ProfileData GetProfile(int ID)
        {
            Profile profile = new Profile();
            return profile.GetProfile(ID);
        }

        // Update the current profile.
        public int Save()
        {
            Profile profile = new Profile
            {
                ID = vProfile.ID,
                Email = vProfile.Email,
                Password = vProfile.Password,
                Remark = vProfile.Remark,
                Del = vProfile.Del
            };
            if (profile.EmailCheck() == 1)
            {
                profile.SaveProfile();
                return 1;
            }
            else return 0;
        }
    }
}
