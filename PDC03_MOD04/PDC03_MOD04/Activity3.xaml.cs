using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace PDC03_MOD04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity3 : ContentPage
    {
        ObservableCollection<Member> members = new ObservableCollection<Member>();

        public ObservableCollection<Member> Members { get { return members; } }
        public Activity3()
        {
            InitializeComponent();

            MemberView.ItemsSource = members;

            members.Add(new Member { DisplayName = "Yeji", Position = "Leader, Main Dancer, Lead Vocalist, Rapper", Image = "Yeji.jpeg" });
            members.Add(new Member { DisplayName = "Ryujin", Position = "Main Rapper, Centre, Lead Dancer, Sub-Vocalist", Image = "Ryujin.jpeg" });
            members.Add(new Member { DisplayName = "Yuna", Position = "Lead Rapper, Vocalist, Visual, Maknae", Image = "Yuna.jpeg" });
            members.Add(new Member { DisplayName = "Lia", Position = "Main Vocalist", Image = "Lia.jpeg" });
            members.Add(new Member { DisplayName = "Chaeryeong", Position = "Main Dancer, Vocalist, Rapper", Image = "Chaeryeong.jpeg" });
        }
    }
}