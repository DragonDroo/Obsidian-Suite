using System;
using System.Windows;
using System.Windows.Controls;
using Fluent;
using MahApps.Metro.Controls;
using Slats.Behaviors;
using Slats.Contracts.Services;
using Slats.Contracts.Views;
using Slats.ViewModels;
using System.Windows.Data;
using Slats.DAL;
using Slats.Models;
using Microsoft.EntityFrameworkCore;

namespace Slats.Views
{
    
    public partial class ShellWindow : MetroWindow, IShellWindow, IRibbonWindow
    {
        public RibbonTitleBar TitleBar
        {
            get => (RibbonTitleBar)GetValue(TitleBarProperty);
            private set => SetValue(TitleBarPropertyKey, value);
        }

        private static readonly DependencyPropertyKey TitleBarPropertyKey = DependencyProperty.RegisterReadOnly(nameof(TitleBar), typeof(RibbonTitleBar), typeof(ShellWindow), new PropertyMetadata());

        public static readonly DependencyProperty TitleBarProperty = TitleBarPropertyKey.DependencyProperty;

        //Temporary Declaration
   //     private readonly DbContextGeneral _context = new DbContextGeneral();
        private CollectionViewSource sectionViewSource;


        public ShellWindow(IPageService pageService, ShellViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
            navigationBehavior.Initialize(pageService);
        }

        public Frame GetNavigationFrame()
            => shellFrame;

        public RibbonTabsBehavior GetRibbonTabsBehavior()
            => tabsBehavior;

        public Frame GetRightPaneFrame()
            => rightPaneFrame;

        public SplitView GetSplitView()
            => splitView;

        public void ShowWindow()
            => Show();

        public void CloseWindow()
            => Close();

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            var window = sender as MetroWindow;
            TitleBar = window.FindChild<RibbonTitleBar>("RibbonTitleBar");
            TitleBar.InvalidateArrange();
            TitleBar.UpdateLayout();

            // Temporary Declaration
    
    }

        private void OnUnloaded(object sender, RoutedEventArgs e)
        {
            tabsBehavior.Unsubscribe();
        }

        private void CreatedbTest_Click(object sender, RoutedEventArgs e)
        {
            // load the entities into EF Core
            DbContextGeneral _context = new DbContextGeneral();

            // this is for demo purposes only, to make it easier
            // to get up and running
            _context.Database.EnsureCreated();

            Person p = new Person();
            p.EmployeeId = 12;
            p.FirstName = "asdf";
            p.LastName = "asdf";
            p.NtId = "Something";

            _context.Persons.Add(p);
            _context.SaveChanges();

            //HPlusSportsContext _context2 = new HPlusSportsContext();
            //_context2.Database.EnsureCreated();
            //_context2.SaveChanges();
        }

        private void AddRecordTest_Click(object sender, RoutedEventArgs e)
        {
            //HPlusSportsContext _context2 = new HPlusSportsContext();
            //HPlusSports.Models.SalesGroup g = new SalesGroup();
            //g.Deleted = false;
            //g.State = "S";
            //g.Type = 2;

            //HPlusSports.Models.Salesperson p = new Salesperson();
            //p.FirstName = "asdf";
            //p.LastName = "asdf";
            //p.Email = "email@va.gov";
            //p.SalesGroup = g;

            //_context2.SalesGroup.Add(g);
            //_context2.Salesperson.Add(p);
            //_context2.SaveChanges();

            DbContextGeneral context = new DbContextGeneral();
            Person person = new Person();
            person.FirstName = "asdf";
            person.LastName = "xdsd";
            person.MiddleNames = "asdf fff";
            person.EmployeeId = 232;

            StaffProvider sp = new StaffProvider();
            sp.ClinicalSuper = 1;
            sp.CprPoolIdPerm = 1;
            sp.CprPoolIdTemp = 2;
            sp.License = 444;

            person.StaffPriv.PrivateEmail = "asdf";
            person.ProviderRoles.Add(sp);

            context.Persons.Add(person);
            //context.Providers.Add(sp);
            context.SaveChanges();

            // _context.Ds_Sections.Load();
            //_context.Persons.Load();

            //sectionViewSource = (CollectionViewSource)FindResource(nameof(sectionViewSource));
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            //_context.SaveChanges();

        }

        private void NewProvider_Click(object sender, RoutedEventArgs e)
        {
            //ToDo Replace this call with a command to create new Staff
            // load the entities into EF Core
            DbContextGeneral _context = new DbContextGeneral();

            // this is for demo purposes only, to make it easier
            // to get up and running
            _context.Database.EnsureCreated();

            MedPrivilege mp = new MedPrivilege();
            mp.Start = DateTime.Now;
            mp.ShortName = "ECT";
            mp.LongName = "Electrocharge Therapy";

            MedPrivilegeProf mpp = new MedPrivilegeProf();
            mpp.Activation = DateTime.Parse("12/20/2020");
            mpp.Expiration = DateTime.Parse("12/19/2022");
            mpp.MedPrivilege.Add(mp);

            StaffProvider sp = new StaffProvider();
            sp.ClinicalSuper = 1;
         //   sp.Credentials = 1;
            sp.ProviderClass = "Psychologist";
            sp.Start = DateTime.Today;
            sp.License = 351;
            sp.MedPrivilegeProf.Add(mpp);

            Person p = new Person();
            p.EmployeeId = 12;
            p.FirstName = "asdf";
            p.LastName = "asdf";
            p.NtId = "Something";

            _context.Providers.Add(sp);
            _context.SaveChanges();
        }
    }
}
