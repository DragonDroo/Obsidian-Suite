using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Threading;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Slats.Contracts.Services;
using Slats.Contracts.Views;
using Slats.Core.Contracts.Services;
using Slats.Core.Services;
using Slats.Models;
using Slats.Services;
using Slats.ViewModels;
using Slats.Views;

namespace Slats
{
    // For more inforation about application lifecyle events see https://docs.microsoft.com/dotnet/framework/wpf/app-development/application-management-overview

    // WPF UI elements use language en-US by default.
    // If you need to support other cultures make sure you add converters and review dates and numbers in your UI to ensure everything adapts correctly.
    // Tracking issue for improving this is https://github.com/dotnet/wpf/issues/1946
    public partial class App : Application
    {
        private IHost _host;

        public T GetService<T>()
            where T : class
            => _host.Services.GetService(typeof(T)) as T;

        public App()
        {
        }

        private async void OnStartup(object sender, StartupEventArgs e)
        {
            var appLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            // For more information about .NET generic host see  https://docs.microsoft.com/aspnet/core/fundamentals/host/generic-host?view=aspnetcore-3.0
            _host = Host.CreateDefaultBuilder(e.Args)
                    .ConfigureAppConfiguration(c =>
                    {
                        c.SetBasePath(appLocation);
                    })
                    .ConfigureServices(ConfigureServices)
                    .Build();

            await _host.StartAsync();
        }

        private void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {
            // TODO WTS: Register your services, viewmodels and pages here

            // App Host
            services.AddHostedService<ApplicationHostService>();
            services.AddSingleton<IIdentityCacheService, IdentityCacheService>();
            services.AddHttpClient("msgraph", client =>
            {
                client.BaseAddress = new System.Uri("https://graph.microsoft.com/v1.0/");
            });

            // Core Services
            services.AddSingleton<IMicrosoftGraphService, MicrosoftGraphService>();
            services.AddSingleton<IIdentityService, IdentityService>();
            services.AddSingleton<IFileService, FileService>();

            // Services
            services.AddSingleton<IUserDataService, UserDataService>();
            services.AddSingleton<IWindowManagerService, WindowManagerService>();
            services.AddSingleton<IApplicationInfoService, ApplicationInfoService>();
            services.AddSingleton<IPersistAndRestoreService, PersistAndRestoreService>();
            services.AddSingleton<IThemeSelectorService, ThemeSelectorService>();
            services.AddSingleton<ISampleDataService, SampleDataService>();
            services.AddSingleton<ISystemService, SystemService>();
            services.AddSingleton<IRightPaneService, RightPaneService>();
            services.AddSingleton<IPageService, PageService>();
            services.AddSingleton<INavigationService, NavigationService>();
            //services.AddSingleton<ISalesPersonService, SalesPersonService>();
            //services.AddSingleton<ISalesPersonRepository, SalesPersonRepository>();

            //
            // Views and ViewModels
            services.AddTransient<CprAssignmentMakerVM>();                  services.AddTransient<CprAssignmentMakerPage>();
            services.AddTransient<ContentGridDetailViewModel>();            services.AddTransient<ContentGridDetailPage>();
            services.AddTransient<ContentGridViewModel>();                  services.AddTransient<ContentGridPage>();
            services.AddTransient<CprBuilderVM>();                          services.AddTransient<CprBuilderPage>();
            services.AddTransient<CprFormVM>();                             services.AddTransient<CprFormPage>();
            services.AddTransient<CprPoolsVM>();                            services.AddTransient<CprPoolsPage>();
            services.AddTransient<CprReviewAdminVM>();                      services.AddTransient<CprReviewAdminPage>();
            services.AddTransient<CprReviewStaffVM>();                      services.AddTransient<CprReviewStaffPage>();
            services.AddTransient<CprReviewSupervisorVM>();                 services.AddTransient<CprReviewSupervisorPage>();
            services.AddTransient<CprSummaryVM>();                          services.AddTransient<CprSummaryPage>();
            services.AddTransient<DataGridViewModel>();                     services.AddTransient<DataGridPage>();
            services.AddTransient<DataManagerVM>();                         services.AddTransient<DataManagerPage>();
            services.AddTransient<FeeBasisSupervVM>();                      services.AddTransient<FeeBasisSupervPage>();
            services.AddTransient<FeeBasisAdminVM>();                       services.AddTransient<FeeBasisAdminPage>();
            services.AddTransient<FeeBasisStaffVM>();                       services.AddTransient<FeeBasisStaffPage>();
            services.AddTransient<FormFillVM>();                            services.AddTransient<FormFillPage>();
            services.AddTransient<FormManagerVM>();                         services.AddTransient<FormManagerPage>();
            services.AddTransient<IShellWindow, ShellWindow>();             services.AddTransient<ShellViewModel>();
            services.AddTransient<IShellDialogWindow, ShellDialogWindow>(); services.AddTransient<ShellDialogViewModel>();
            services.AddTransient<DataManagerVM>();	                        services.AddTransient<DataManagerPage>();
            services.AddTransient<FileManagerVM>();                         services.AddTransient<FileManager>();
            services.AddTransient<FlipNotesVM>();                           services.AddTransient<FlipNotes>();
            services.AddTransient<FormFillVM>();                            services.AddTransient<FormFillPage>();
            services.AddTransient<FormManagerVM>();                         services.AddTransient<FormManagerPage>();
            services.AddTransient<LeavePollVM>();                           services.AddTransient<LeavePollPage>();
            services.AddTransient<MainViewModel>();                         services.AddTransient<MainPage>();
            services.AddTransient<MasterDetailViewModel>();                 services.AddTransient<MasterDetailPage>();
            services.AddTransient<MeetingAttendAdminVM>();                  services.AddTransient<MeetingAttendAdminPage>();
            services.AddTransient<MeetingAttendanceVM>();                   services.AddTransient<MeetingAttendancePage>();
            services.AddTransient<MeetingAttendStaffVM>();                  services.AddTransient<MeetingAttendStaffPage>();
            services.AddTransient<MeetingAttendSupervisorVM>();             services.AddTransient<MeetingAttendSupervisorPage>();
            services.AddTransient<NewEditPersonVM>();                       services.AddTransient<NewEditPersonPage>();
            services.AddTransient<OrgChart>();                              services.AddTransient<OrgChartVM>();
            services.AddTransient<PositionsVM>();                           services.AddTransient<Positions>();
            services.AddTransient<ProductivityAdminVM>();                   services.AddTransient<ProductivityAdminPage>();
            services.AddTransient<ProductivityCptVM>();                     services.AddTransient<ProductivityCptPage>();
            services.AddTransient<ProductivityDxVM>();                      services.AddTransient<ProductivityDxPage>();
            services.AddTransient<ProductivityVM>();                        services.AddTransient<ProductivityPage>();
            services.AddTransient<ProgramInfoVM>();                         services.AddTransient<ProgramInfoPage>();
            services.AddTransient<PrivilegesVM>();                          services.AddTransient<Privileges>();
            services.AddTransient<ReportDesignerVM>();                      services.AddTransient<ReportDesignerPage>();
            services.AddTransient<ReportPageVM>();                          services.AddTransient<ReportPagePage>();
            services.AddTransient<ReportViewerVM>();                        services.AddTransient<ReportViewerPage>();
            services.AddTransient<ScheduleDayVM>();	                        services.AddTransient<ScheduleDayPage>();
            services.AddTransient<SchedulePpVM>();                          services.AddTransient<SchedulePpPage>();
            services.AddTransient<ScheduleStaffVM>();                       services.AddTransient<ScheduleStaffPage>();
            services.AddTransient<ScheduleWeekVM>();                        services.AddTransient<ScheduleWeekPage>();
            services.AddTransient<SettingsViewModel>();                     services.AddTransient<SettingsPage>();
            services.AddTransient<AboutVM>();                               services.AddTransient<About>();
            services.AddTransient<NotificationSettingsVM>();                services.AddTransient<NotificationSettings>();
            services.AddTransient<ServiceSettingsVM>();                     services.AddTransient<ServiceSettings>();
            services.AddTransient<SignInConnectVM>();                       services.AddTransient<SignInConnect>();
            services.AddTransient<SystemSettingsVM>();                      services.AddTransient<SystemSettings>();
            services.AddTransient<StaffDetailVM>();	                        services.AddTransient<StaffDetailPage>();
            services.AddTransient<StaffListAdminVM>();	                    services.AddTransient<StaffListAdminPage>();
            services.AddTransient<StaffListStaffVM>();	                    services.AddTransient<StaffListStaffPage>();
            services.AddTransient<StaffListSupervisorVM>();	                services.AddTransient<StaffListSupervisorPage>();
            services.AddTransient<TmsAdminVM>();                            services.AddTransient<TmsAdminPage>();
            services.AddTransient<TmsStaffVM>();                            services.AddTransient<TmsStaffPage>();
            services.AddTransient<VistaMenuItemsVM>();                      services.AddTransient<VistaMenuItemsPage>();
            services.AddTransient<VistaMenuTemplatesVM>();                  services.AddTransient<VistaMenuTemplatesPage>();
            services.AddTransient<NotifyEmailTemplatesVM>();                services.AddTransient<NotifyEmailTemplatesPage>();

            services.AddTransient<WebViewViewModel>(); services.AddTransient<WebViewPage>();

            // Configuration
            services.Configure<AppConfig>(context.Configuration.GetSection(nameof(AppConfig)));

            Slats.DAL.Configure.ConfigureServices(services, "TestDb.pmt");

        }

        private async void OnExit(object sender, ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();
            _host = null;
        }

        private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            // TODO WTS: Please log and handle the exception as appropriate to your scenario
            // For more info see https://docs.microsoft.com/dotnet/api/system.windows.application.dispatcherunhandledexception?view=netcore-3.0
        }
    }
}
