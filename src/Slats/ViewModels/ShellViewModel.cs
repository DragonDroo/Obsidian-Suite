using System;
using System.Windows.Input;

using Slats.Contracts.Services;
using Slats.Core.Contracts.Services;
using Slats.Helpers;

namespace Slats.ViewModels
{
    public class ShellViewModel : Observable
    {
        private readonly IRightPaneService _rightPaneService;
        private readonly INavigationService _navigationService;
        private readonly IIdentityService _identityService;

        //TODO Implement Identity Service and 
        //private readonly IIdentityService _identityService;
        private bool _isLoggedIn;
        private bool _isAuthorized;

        private ICommand _loadedCommand;
        private ICommand _unloadedCommand;

        // Menu Definition
        private ICommand _menuViewsMasterDetailCommand;
        public ICommand MenuViewsMasterDetailCommand => _menuViewsMasterDetailCommand ?? (_menuViewsMasterDetailCommand = new RelayCommand(OnMenuViewsMasterDetail));
        private void OnMenuViewsMasterDetail() => _navigationService.NavigateTo(typeof(MasterDetailViewModel).FullName, null, true);

        // Menu Definition
        private ICommand _menuViewsContentGridCommand;

        // Menu Definition
        private ICommand _menuViewsDataGridCommand;
        public ICommand MenuViewsDataGridCommand => _menuViewsDataGridCommand ?? (_menuViewsDataGridCommand = new RelayCommand(OnMenuViewsDataGrid));
        private void OnMenuViewsDataGrid() => _navigationService.NavigateTo(typeof(DataGridViewModel).FullName, null, true);

        // Menu Definition
        private ICommand _menuCprAssignmentMakerCommand;
        public ICommand CprAssignmentMakerCommand => _menuCprAssignmentMakerCommand ?? (_menuCprAssignmentMakerCommand = new RelayCommand(OnCprAssignmentMaker));
        private void OnCprAssignmentMaker() => _navigationService.NavigateTo(typeof(CprAssignmentMakerVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuCprBuilderCommand;
        public ICommand CprBuilderCommand => _menuCprBuilderCommand ?? (_menuCprBuilderCommand = new RelayCommand(OnCprBuilder));
        private void OnCprBuilder() => _navigationService.NavigateTo(typeof(CprBuilderVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuCprFormCommand;
        public ICommand CprFormCommand => _menuCprFormCommand ?? (_menuCprFormCommand = new RelayCommand(OnCprForm));
        private void OnCprForm() => _navigationService.NavigateTo(typeof(CprBuilderVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuCprReviewAdminCommand;
        public ICommand CprReviewAdminCommand => _menuCprReviewAdminCommand ?? (_menuCprReviewAdminCommand = new RelayCommand(OnCprReviewAdmin));
        private void OnCprReviewAdmin() => _navigationService.NavigateTo(typeof(CprReviewAdminVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuCprReviewStaffCommand;
        public ICommand CprReviewStaffCommand => _menuCprReviewStaffCommand ?? (_menuCprReviewStaffCommand = new RelayCommand(OnCprReviewStaff));
        private void OnCprReviewStaff() => _navigationService.NavigateTo(typeof(CprReviewStaffVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuCprReviewSupervisorCommand;
        public ICommand CprReviewSupervisorCommand => _menuCprReviewSupervisorCommand ?? (_menuCprReviewSupervisorCommand = new RelayCommand(OnCprReviewSupervisor));
        private void OnCprReviewSupervisor() => _navigationService.NavigateTo(typeof(CprReviewSupervisorVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuCprSummaryCommand;
        public ICommand CprSummaryCommand => _menuCprSummaryCommand ?? (_menuCprSummaryCommand = new RelayCommand(OnCprSummary));
        private void OnCprSummary() => _navigationService.NavigateTo(typeof(CprSummaryVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuCprPoolsCommand;
        public ICommand CprPoolsCommand => _menuCprPoolsCommand ?? (_menuCprPoolsCommand = new RelayCommand(OnCprPools));
        private void OnCprPools() => _navigationService.NavigateTo(typeof(CprPoolsVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuDataManagerCommand;
        public ICommand DataManagerCommand => _menuDataManagerCommand ?? (_menuDataManagerCommand = new RelayCommand(OnDataManager));
        private void OnDataManager() => _navigationService.NavigateTo(typeof(DataManagerVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuFeeBasisStaffCommand;
        public ICommand FeeBasisStaffCommand => _menuFeeBasisStaffCommand ?? (_menuFeeBasisStaffCommand = new RelayCommand(OnFeeBasisStaff));
        private void OnFeeBasisStaff() => _navigationService.NavigateTo(typeof(FeeBasisStaffVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuFeeBasisAdminCommand;
        public ICommand FeeBasisAdminCommand => _menuFeeBasisAdminCommand ?? (_menuFeeBasisAdminCommand = new RelayCommand(OnFeeBasisAdmin));
        private void OnFeeBasisAdmin() => _navigationService.NavigateTo(typeof(FeeBasisAdminVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuFeeBasisSupervCommand;
        public ICommand FeeBasisSupervCommand => _menuFeeBasisSupervCommand ?? (_menuFeeBasisSupervCommand = new RelayCommand(OnFeeBasisSuperv));
        private void OnFeeBasisSuperv() => _navigationService.NavigateTo(typeof(FeeBasisSupervVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuFileManagerCommand;
        public ICommand MenuViewsFileManagerCommand => _menuFileManagerCommand ?? (_menuFileManagerCommand = new RelayCommand(OnFileManager));
        private void OnFileManager() => _navigationService.NavigateTo(typeof(FileManagerVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuFlipNotesCommand;
        public ICommand MenuFlipNotesCommand => _menuFlipNotesCommand ?? (_menuFlipNotesCommand = new RelayCommand(OnFlipNotes));
        private void OnFlipNotes() => _navigationService.NavigateTo(typeof(FlipNotesVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuFormFillCommand;
        public ICommand FormFillCommand => _menuFormFillCommand ?? (_menuFormFillCommand = new RelayCommand(OnFormFill));
        private void OnFormFill() => _navigationService.NavigateTo(typeof(FormFillVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuFormManagerCommand;
        public ICommand FormManagerCommand => _menuFormManagerCommand ?? (_menuFormManagerCommand = new RelayCommand(OnFormManager));
        private void OnFormManager() => _navigationService.NavigateTo(typeof(FormManagerVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuLeavePollCommand;
        public ICommand LeavePollCommand => _menuLeavePollCommand ?? (_menuLeavePollCommand = new RelayCommand(OnLeavePoll));
        private void OnLeavePoll() => _navigationService.NavigateTo(typeof(LeavePollVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuMainViewCommand;
        public ICommand MainViewCommand => _menuMainViewCommand ?? (_menuMainViewCommand = new RelayCommand(OnMainView));
        private void OnMainView() => _navigationService.NavigateTo(typeof(MainViewModel).FullName, null, true);

        // Menu Definition
        private ICommand _menuMeetingAttendAdminCommand;
        public ICommand MeetingAttendAdminCommand => _menuMeetingAttendAdminCommand ?? (_menuMeetingAttendAdminCommand = new RelayCommand(OnMeetingAttendAdmin));
        private void OnMeetingAttendAdmin() => _navigationService.NavigateTo(typeof(MeetingAttendAdminVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuMeetingAttendanceCommand;
        public ICommand MeetingAttendanceCommand => _menuMeetingAttendanceCommand ?? (_menuMeetingAttendanceCommand = new RelayCommand(OnMeetingAttendance));
        private void OnMeetingAttendance() => _navigationService.NavigateTo(typeof(MeetingAttendanceVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuMeetingAttendStaffCommand;
        public ICommand MeetingAttendStaffCommand => _menuMeetingAttendStaffCommand ?? (_menuMeetingAttendStaffCommand = new RelayCommand(OnMeetingAttendStaff));
        private void OnMeetingAttendStaff() => _navigationService.NavigateTo(typeof(MeetingAttendStaffVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuMeetingAttendSupervisorCommand;
        public ICommand MeetingAttendSupervisorCommand => _menuMeetingAttendSupervisorCommand ?? (_menuMeetingAttendSupervisorCommand = new RelayCommand(OnMeetingAttendSupervisor));
        private void OnMeetingAttendSupervisor() => _navigationService.NavigateTo(typeof(MeetingAttendSupervisorVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuNewEditPersonCommand;
        public ICommand MenuNewEditPersonCommand => _menuNewEditPersonCommand ?? (_menuNewEditPersonCommand = new RelayCommand(OnNewEditPerson));
        private void OnNewEditPerson() => _navigationService.NavigateTo(typeof(NewEditPersonVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuNotifyEmailTemplateCommand;
        public ICommand NotifyEmailTemplateCommand => _menuNotifyEmailTemplateCommand ?? (_menuNotifyEmailTemplateCommand = new RelayCommand(OnNotifyEmailTemplate));
        private void OnNotifyEmailTemplate() => _navigationService.NavigateTo(typeof(NotifyEmailTemplatesVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuOrgChartCommand;
        public ICommand MenuViewsOrgChartCommand => _menuOrgChartCommand ?? (_menuOrgChartCommand = new RelayCommand(OnMenuOrgChartDetail));
        private void OnMenuOrgChartDetail() => _navigationService.NavigateTo(typeof(OrgChartVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuPositionsCommand;
        public ICommand MenuPositionsCommand => _menuPositionsCommand ?? (_menuPositionsCommand = new RelayCommand(OnPositions));
        private void OnPositions() => _navigationService.NavigateTo(typeof(PositionsVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuPrivilegesCommand;
        public ICommand PrivilegesCommand => _menuPrivilegesCommand ?? (_menuPrivilegesCommand = new RelayCommand(OnPrivileges));
        private void OnPrivileges() => _navigationService.NavigateTo(typeof(PrivilegesVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuProductivityAdminCommand;
        public ICommand ProductivityAdminCommand => _menuProductivityAdminCommand ?? (_menuProductivityAdminCommand = new RelayCommand(OnProductivityAdmin));
        private void OnProductivityAdmin() => _navigationService.NavigateTo(typeof(ProductivityAdminVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuProductivityCptCommand;
        public ICommand ProductivityCptCommand => _menuProductivityCptCommand ?? (_menuProductivityCptCommand = new RelayCommand(OnProductivityCpt));
        private void OnProductivityCpt() => _navigationService.NavigateTo(typeof(ProductivityCptVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuProductivityDxCommand;
        public ICommand ProductivityDxCommand => _menuProductivityDxCommand ?? (_menuProductivityDxCommand = new RelayCommand(OnProductivityDx));
        private void OnProductivityDx() => _navigationService.NavigateTo(typeof(ProductivityDxVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuProductivityCommand;
        public ICommand ProductivityCommand => _menuProductivityCommand ?? (_menuProductivityCommand = new RelayCommand(OnProductivity));
        private void OnProductivity() => _navigationService.NavigateTo(typeof(ProductivityVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuProgramInfoCommand;
        public ICommand ProgramInfoCommand => _menuProgramInfoCommand ?? (_menuProgramInfoCommand = new RelayCommand(OnProgramInfo));
        private void OnProgramInfo() => _navigationService.NavigateTo(typeof(ProgramInfoVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuReportDesignerCommand;
        public ICommand ReportDesignerCommand => _menuReportDesignerCommand ?? (_menuReportDesignerCommand = new RelayCommand(OnReportDesigner));
        private void OnReportDesigner() => _navigationService.NavigateTo(typeof(ReportDesignerVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuReportPageCommand;
        public ICommand ReportPageCommand => _menuReportPageCommand ?? (_menuReportPageCommand = new RelayCommand(OnReportPage));
        private void OnReportPage() => _navigationService.NavigateTo(typeof(ReportPageVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuReportViewerCommand;
        public ICommand ReportViewerCommand => _menuReportViewerCommand ?? (_menuReportViewerCommand = new RelayCommand(OnReportViewer));
        private void OnReportViewer() => _navigationService.NavigateTo(typeof(ReportViewerVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuScheduleDayCommand;
        public ICommand ScheduleDayCommand => _menuScheduleDayCommand ?? (_menuScheduleDayCommand = new RelayCommand(OnScheduleDay));
        private void OnScheduleDay() => _navigationService.NavigateTo(typeof(ScheduleDayVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuSchedulePpCommand;
        public ICommand SchedulePpCommand => _menuSchedulePpCommand ?? (_menuSchedulePpCommand = new RelayCommand(OnSchedulePp));
        private void OnSchedulePp() => _navigationService.NavigateTo(typeof(SchedulePpVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuScheduleStaffCommand;
        public ICommand ScheduleStaffCommand => _menuScheduleStaffCommand ?? (_menuScheduleStaffCommand = new RelayCommand(OnScheduleStaff));
        private void OnScheduleStaff() => _navigationService.NavigateTo(typeof(ScheduleStaffVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuScheduleWeekCommand;
        public ICommand ScheduleWeekCommand => _menuScheduleWeekCommand ?? (_menuScheduleWeekCommand = new RelayCommand(OnScheduleWeek));
        private void OnScheduleWeek() => _navigationService.NavigateTo(typeof(ScheduleWeekVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuStaffDetailCommand;
        public ICommand StaffDetailCommand => _menuStaffDetailCommand ?? (_menuStaffDetailCommand = new RelayCommand(OnStaffDetail));
        private void OnStaffDetail() => _navigationService.NavigateTo(typeof(StaffDetailVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuStaffListAdminCommand;
        public ICommand StaffListAdminCommand => _menuStaffListAdminCommand ?? (_menuStaffListAdminCommand = new RelayCommand(OnStaffListAdmin));
        private void OnStaffListAdmin() => _navigationService.NavigateTo(typeof(StaffListAdminVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuStaffListStaffCommand;
        public ICommand StaffListStaffCommand => _menuStaffListStaffCommand ?? (_menuStaffListStaffCommand = new RelayCommand(OnStaffListStaff));
        private void OnStaffListStaff() => _navigationService.NavigateTo(typeof(StaffListStaffVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuStaffListSupervisorCommand;
        public ICommand StaffListSupervisorCommand => _menuStaffListSupervisorCommand ?? (_menuStaffListSupervisorCommand = new RelayCommand(OnStaffListSupervisor));
        private void OnStaffListSupervisor() => _navigationService.NavigateTo(typeof(StaffListSupervisorVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuTmsAdminCommand;
        public ICommand TmsAdminCommand => _menuTmsAdminCommand ?? (_menuTmsAdminCommand = new RelayCommand(OnTmsAdmin));
        private void OnTmsAdmin() => _navigationService.NavigateTo(typeof(TmsAdminVM).FullName, null, true);

        // Menu Definition
        private ICommand _menuTmsStaffCommand;
        public ICommand TmsStaffCommand => _menuTmsStaffCommand ?? (_menuTmsStaffCommand = new RelayCommand(OnTmsStaff));
        private void OnTmsStaff() => _navigationService.NavigateTo(typeof(TmsStaffVM).FullName, null, true);
        
        // Menu Definition
        private ICommand _menuVistaMenuItemsCommand;
        public ICommand VistaMenuItemsCommand => _menuVistaMenuItemsCommand ?? (_menuVistaMenuItemsCommand = new RelayCommand(OnVistaMenuItems));
        private void OnVistaMenuItems() => _navigationService.NavigateTo(typeof(VistaMenuItemsVM).FullName, null, true);

        // Menu Definition
        private ICommand _MenuVistaMenuTemplatesCommand;
        public ICommand VistaMenuTemplatesCommand => _MenuVistaMenuTemplatesCommand ?? (_MenuVistaMenuTemplatesCommand = new RelayCommand(OnVistaMenuTemplates));
        private void OnVistaMenuTemplates() => _navigationService.NavigateTo(typeof(VistaMenuTemplatesVM).FullName, null, true);

        //        private ICommand _menuViewsFileManagerCommand;



        public ICommand LoadedCommand => _loadedCommand ?? (_loadedCommand = new RelayCommand(OnLoaded));

        public ICommand UnloadedCommand => _unloadedCommand ?? (_unloadedCommand = new RelayCommand(OnUnloaded));

        public ShellViewModel(INavigationService navigationService, IRightPaneService rightPaneService)
        {
            _rightPaneService = rightPaneService;
            _navigationService = navigationService;

        }

        private void OnLoaded()
        {
        }

        private void OnUnloaded()
        {
            _rightPaneService.CleanUp();
        }

        public bool IsLoggedIn
        {
            get { return _isLoggedIn; }
            set { Set(ref _isLoggedIn, value); }
        }
        private void OnLoggedIn(object sender, EventArgs e)
        {
            IsLoggedIn = true;
            IsAuthorized = IsLoggedIn && _identityService.IsAuthorized();
        }
        public bool IsAuthorized
        {
            get { return _isAuthorized; }
            set { Set(ref _isAuthorized, value); }
        }
        private void OnLoggedOut(object sender, EventArgs e)
        {
            IsLoggedIn = false;
            IsAuthorized = false;
            _navigationService.CleanNavigation();
            _navigationService.NavigateTo(typeof(MainViewModel).FullName, null, true);
        }



    }
}
