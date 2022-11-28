//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using solution.EDMModels;
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Data.Services.Providers;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;

namespace solution.DataServices
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class WDS : EntityFrameworkDataService<WDSEntities>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            config.SetEntitySetAccessRule("*", EntitySetRights.All);
            config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        }

        [WebGet]
        public IQueryable<Students> InsertStudent(string name)
        {
            Students student = new Students();
            student.Name = name;

            WDSEntities context = this.CurrentDataSource;
            context.Students.Add(student);
            context.SaveChanges();

            return context.Students;
        }

        [WebGet]
        public IQueryable<Notes> InsertNote(string subj, int noteValue, int studentId)
        {
            Notes note = new Notes();
            note.Subj = subj;
            note.StudentId = studentId;
            note.NoteValue = noteValue;

            WDSEntities context = this.CurrentDataSource;
            context.Notes.Add(note);
            context.SaveChanges();

            return context.Notes;
        }

        [WebGet]
        public IQueryable<Students> ChangeStudent(int id, string name)
        {
            WDSEntities context = this.CurrentDataSource;
            Students student = context.Students.Find(id);
            student.Name = name;
            context.SaveChanges();
            return context.Students;
        }

        [WebGet]
        public IQueryable<Notes> ChangeNote(int id, string subj, int noteValue)
        {
            WDSEntities context = this.CurrentDataSource;
            Notes note = context.Notes.Find(id);
            note.Subj = subj;
            note.NoteValue = noteValue;
            context.SaveChanges();
            return context.Notes;
        }
    }
}
