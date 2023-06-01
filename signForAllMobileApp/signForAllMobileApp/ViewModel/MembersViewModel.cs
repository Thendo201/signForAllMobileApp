using signForAllMobileApp.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace signForAllMobileApp.ViewModel
{
    class MembersViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Member> Members;

        public ObservableCollection<Member> members
        {
            get { return Members; }
            set
            {
                Members = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("members"));
            }
        }
        public MembersViewModel()
        {
            members = new ObservableCollection<Member>();
            addMember();

        }

        private void addMember()
        {
            members.Add(new Member
            {
                id = 0,
                name = "Thendo Ndhlovu",
                email = "someone@gmail.com",
                picture = "https://media.licdn.com/dms/image/C5603AQEw191SJVkqIw/profile-displayphoto-shrink_800_800/0/1662050721619?e=1688601600&v=beta&t=92C3RTlJHF33F9PrFX_Yhjyd0xNdBw3OvJlGPZoZayg",
                link = "https://i.pinimg.com/564x/bf/7a/86/bf7a865e3cb94ea25fc48c2f7b186944.jpg"
            });
            members.Add(new Member
            {
                id = 0,
                name = "Ruby Steegmans",
                email = "someone@gmail.com",
                picture = "https://media.licdn.com/dms/image/D4E03AQFi53BdTWjFPw/profile-displayphoto-shrink_800_800/0/1671270379177?e=1688601600&v=beta&t=CFVdpO9iDgxfxwn9owjL8LftPJsHcfUOSBYwQViPfik",
                link = "https://www.linkedin.com/in/ruby-steegmans"
            });
            members.Add(new Member
            {
                id = 0,
                name = "Alharthy,Ahmed A.S.A.",

                picture = "https://media.licdn.com/dms/image/C4D03AQGm4RSuNeHkaQ/profile-displayphoto-shrink_800_800/0/1633626701736?e=1688601600&v=beta&t=HA_KtlhfrtosX-7jRqQSWXty-4SlfvcjVk4CXuV9j10",
                link = "https://www.linkedin.com/in/ahmed-alharthy/"
            });
            members.Add(new Member
            {
                id = 0,
                name = "William Houy",
                email = "someone@gmail.com",
                picture = "https://media.licdn.com/dms/image/D4D03AQGfnZRDhkgs8w/profile-displayphoto-shrink_200_200/0/1684579173923?e=1691020800&v=beta&t=lwiTUZmsMDKXt1ZTwkBh92kjbvjgjhpl-1coMSgYihA",
                link = "https://www.linkedin.com/in/william-houy-b15975277/"
            });
            members.Add(new Member
            {
                id = 0,
                name = "Kagiso Kgobane",
                email = "someone@gmail.com",
                picture = "https://assets.stickpng.com/images/585e4bf3cb11b227491c339a.png",
                link = "https://i.pinimg.com/564x/bf/7a/86/bf7a865e3cb94ea25fc48c2f7b186944.jpg"
            });
        }
    }
}
