using System;
using Microsoft.EntityFrameworkCore;
using CustomerSupport.EntityFramework.Entities;
using CustomerSupport.Core.Models;

namespace CustomerSupport.Core.BusinessLogic
{
    public class Ticket : ITicket
    {
        private protected long _id;

        private protected long _projectId;

        private protected long _issueId;

        private protected string _type;

        private protected readonly string _summary;

        private protected readonly string _reporter;

        private protected readonly DateTime _dueDate;

        private protected readonly string _description;

        private protected readonly long _assigneeId;

        private protected readonly long _priorityId;

        private protected readonly string _originalEst;

        private protected readonly CustomerSupportContext _db;

        public Ticket(BaseTicketDto ticket, CustomerSupportContext db) 
        {
            this._projectId = ticket.ProjectId;
            this._issueId = ticket.IssueId;
            this._summary = ticket.Summary;
            this._reporter = ticket.Reporter;
            this._dueDate = DateTime.Parse(ticket.DueDate);
            this._description = ticket.Description;
            this._assigneeId = ticket.AssigneeId;
            this._priorityId = ticket.PriorityId;
            this._originalEst = ticket.OriginalEstimate;
            this._type = ticket.Type;
            this._db = db;
        }

        public Ticket(UpdateTicketDto ticket, CustomerSupportContext db) 
        {
            this._id = ticket.Id;
            this._projectId = ticket.ProjectId;
            this._issueId = ticket.IssueId;
            this._summary = ticket.Summary;
            this._reporter = ticket.Reporter;
            this._dueDate = DateTime.Parse(ticket.DueDate);
            this._description = ticket.Description;
            this._assigneeId = ticket.AssigneeId;
            this._priorityId = ticket.PriorityId;
            this._originalEst = ticket.OriginalEstimate;
            this._type = ticket.Type;
            this._db = db;
        }

        public void Create()
        {
            var ticket = new CustomerSupport.EntityFramework.Entities.Ticket();
            
            ticket.AssigneeId = _assigneeId;
            ticket.Description = _description;
            ticket.DueDate = _dueDate;
            ticket.OriginalEstimate = _originalEst;
            ticket.PriorityId = _priorityId;
            ticket.ProjectId = _projectId;
            ticket.Reporter = _reporter;
            ticket.Summary = _summary;
            ticket.Type = _type;
            ticket.IssueId = _issueId;

            _db.Tickets.Add(ticket);
            _db.SaveChanges();

            _id = ticket.Id;
        }

        public void Upate()
        {
            var ticket = _db.Tickets.FirstOrDefaultAsync(t => t.Id == _id).Result;
            
            ticket.AssigneeId = _assigneeId;
            ticket.Description = _description;
            ticket.DueDate = _dueDate;
            ticket.OriginalEstimate = _originalEst;
            ticket.PriorityId = _priorityId;
            ticket.ProjectId = _projectId;
            ticket.Reporter = _reporter;
            ticket.Summary = _summary;
            ticket.IssueId = _issueId;
            ticket.Type = _type;

            _db.SaveChanges();
        }
    }
}