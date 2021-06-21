
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

using Slats.Contracts.Services;
using Slats.Helpers;
using Slats.ViewModels;
using Slats.Views;

namespace Slats.Services
{
    public class PageService : IPageService
    {
        private readonly Dictionary<string, Type> _pages = new Dictionary<string, Type>();
        private readonly IServiceProvider _serviceProvider;

        public PageService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            Configure<MainViewModel, MainPage>();
            Configure<WebViewViewModel, WebViewPage>();
            Configure<DataGridViewModel, DataGridPage>();
            Configure<ContentGridViewModel, ContentGridPage>();
            Configure<ContentGridDetailViewModel, ContentGridDetailPage>();
            Configure<MasterDetailViewModel, MasterDetailPage>();
            Configure<SettingsViewModel, SettingsPage>();
            Configure<MeetingAttendanceVM, MeetingAttendancePage>();
            Configure<CprAssignmentMakerVM, CprAssignmentMakerPage>();
            Configure<CprReviewAdminVM, CprReviewAdminPage>();
            Configure<CprReviewStaffVM, CprReviewStaffPage>();
            Configure<CprReviewSupervisorVM, CprReviewSupervisorPage>();
            Configure<CprSummaryVM, CprSummaryPage>();
            Configure<CprBuilderVM, CprBuilderPage>();
            Configure<CprPoolsVM, CprPoolsPage>();
            Configure<DataManagerVM, DataManagerPage>();
            Configure<FeeBasisStaffVM, FeeBasisStaffPage>();
            Configure<FeeBasisAdminVM, FeeBasisAdminPage>();
            Configure<FeeBasisSupervVM, FeeBasisSupervPage>();
            Configure<FileManagerVM, FileManager>();
            Configure<FlipNotesVM, FlipNotes>();
            Configure<FormFillVM, FormFillPage>();
            Configure<FormManagerVM, FormManagerPage>();
            Configure<MeetingAttendAdminVM, MeetingAttendAdminPage>();
            Configure<MeetingAttendStaffVM, MeetingAttendStaffPage>();
            Configure<MeetingAttendSupervisorVM, MeetingAttendSupervisorPage>();
            Configure<NewEditPersonVM, NewEditPersonPage>();
            Configure<ReportDesignerVM, ReportDesignerPage>();
            Configure<ReportPageVM, ReportPagePage>();
            Configure<ReportViewerVM, ReportViewerPage>();
            Configure<ScheduleDayVM, ScheduleDayPage>();
            Configure<SchedulePpVM, SchedulePpPage>();
            Configure<ScheduleStaffVM, ScheduleStaffPage>();
            Configure<ScheduleWeekVM, ScheduleWeekPage>();
            Configure<StaffDetailVM, StaffDetailPage>();
            Configure<StaffListAdminVM, StaffListAdminPage>();
            Configure<StaffListStaffVM, StaffListStaffPage>();
            Configure<StaffListSupervisorVM, StaffListSupervisorPage>();
            Configure<PositionsVM, Positions>();
            Configure<ProgramInfoVM, ProgramInfoPage>();
            Configure<LeavePollVM, LeavePollPage>();
            Configure<OrgChartVM, OrgChart>();
            Configure<VistaMenuItemsVM, VistaMenuItemsPage>();
            Configure<VistaMenuTemplatesVM, VistaMenuTemplatesPage>();
            Configure<NotifyEmailTemplatesVM, NotifyEmailTemplatesPage>();
            Configure<PrivilegesVM, Privileges>();
            Configure<ProductivityAdminVM, ProductivityAdminPage>();
            Configure<ProductivityCptVM, ProductivityCptPage>();
            Configure<ProductivityDxVM, ProductivityDxPage>();
            Configure<ProductivityVM, ProductivityPage>();
            Configure<TmsStaffVM, TmsStaffPage>();
            Configure<TmsAdminVM, TmsAdminPage>();
        }

        public Type GetPageType(string key)
        {
            Type pageType;
            lock (_pages)
            {
                if (!_pages.TryGetValue(key, out pageType))
                {
                    throw new ArgumentException($"Page not found: {key}. Did you forget to call PageService.Configure?");
                }
            }

            return pageType;
        }

        public Page GetPage(string key)
        {
            var pageType = GetPageType(key);
            return _serviceProvider.GetService(pageType) as Page;
        }

        private void Configure<VM, V>()
            where VM : Observable
            where V : Page
        {
            lock (_pages)
            {
                var key = typeof(VM).FullName;
                if (_pages.ContainsKey(key))
                {
                    throw new ArgumentException($"The key {key} is already configured in PageService");
                }

                var type = typeof(V);
                if (_pages.Any(p => p.Value == type))
                {
                    throw new ArgumentException($"This type is already configured with key {_pages.First(p => p.Value == type).Key}");
                }

                _pages.Add(key, type);
            }
        }
    }
}
