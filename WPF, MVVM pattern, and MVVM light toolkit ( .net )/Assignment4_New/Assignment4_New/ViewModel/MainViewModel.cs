using GalaSoft.MvvmLight;
using Assignment4_New.View;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Assignment4_New.Model;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Messaging;
using System.Windows.Controls;
using System;

namespace Assignment4_New.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        // command for displaying new window.
        public ICommand ShowCommand { get; private set; }

        // command to exit the entire application.
        public RelayCommand<Window> CloseCommand { get; private set; }

        // command to save the data
        public ICommand SaveCommand { get; private set; }

        // command used when there is any change in selected member data.
        public ICommand SelectedMemberChangedCommand { get; private set; }

        // command used when member data is updated.
        public ICommand SelectedMemberUpdateCommand { get; private set; }

        // command used for deleting the member.
        public ICommand SelectedMemberDeleteCommand { get; private set; }
        
        // command use dto cancel the current window. 
        public ICommand cancelCommand { get; private set; }

        // window object.
        Window display;

        // used to add new members.
        private ObservableCollection<Member> membersList;
        public ObservableCollection<Member> MembersList
        {
            get => membersList;
            set
            {
                membersList = value;
                 RaisePropertyChanged(() => MembersList);
            }
        }

        // used to select member which need change.
        private Member selectedMember;

        //this property is bounded in the MainView using SelectedItem ="{Binding SelectedMember}" of the listbox
        public Member SelectedMember
        {
            get
            {
                if (selectedMember == null)
                    selectedMember = new Member();
                return selectedMember;
            }
            set
            {
                selectedMember = value;
                RaisePropertyChanged(() => MembersList);
            }
        }

        string fname = "";
        string lname = "";
        string email = "";

        // constructor.
        public MainViewModel()
        {
            this.ShowCommand = new RelayCommand(addMember);
            this.CloseCommand = new RelayCommand<Window>(closeWindow);
            this.SaveCommand = new RelayCommand(SaveMember);
            this.SelectedMemberChangedCommand = new RelayCommand(edit);
            this.SelectedMemberUpdateCommand = new RelayCommand(update);
            this.SelectedMemberDeleteCommand = new RelayCommand(delete);
            this.cancelCommand = new RelayCommand(cancel);
            MembersList = MemberShipData.GetMemberships();
        }

        // method to display window after clicking on ADD button.
        private void addMember()
        {
            display = new AddView();
            display.Show();        
        }

        // method to close the current application.
        private void closeWindow(Window obj)
        {
            Application.Current.MainWindow.Close();
        }

        // method to save the new member.
        private void SaveMember()
        {
            if (!Validator.IsValid(selectedMember.FirstName) || !Validator.IsValid(selectedMember.LastName) 
                || !Validator.IsValidEmail(selectedMember.Email))
                return ;

            else
            {
                MembersList.Add(selectedMember);
                MemberShipData.SaveMemberships(MembersList); //Write to members.txt
                Messenger.Default.Send(new NotificationMessage(selectedMember.GetDisplayText + " is now a new member."));
                display.Close();
                selectedMember = null;
            }
                   
        }

        // method to display details window of selected member .
        private void edit()
        {
            if (SelectedMember != null)
            {
                display = new Editview();
                display.Show();
            }
        }

        // method to update the changes made in memebrs information.
        private void update()
        {
            MemberShipData.SaveMemberships(MembersList); //Write to members.txt
           membersList = MemberShipData.GetMemberships();
           RaisePropertyChanged(() => MembersList);
            display.Close();
        }

        // method to delete the members from the list.
        public void delete()
        {
            MembersList.Remove(SelectedMember);
            MemberShipData.SaveMemberships(MembersList); //Write to members.txt
            membersList = MemberShipData.GetMemberships();
            RaisePropertyChanged(() => MembersList);
            display.Close();
                selectedMember = null;
        }

        // method to cancel the current window.
        public void cancel()
        {
            display.Close();
            selectedMember = null;
        }
    }
}