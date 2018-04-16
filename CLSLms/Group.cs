//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CLSLms
{
    using System;
    using System.Collections.Generic;
    
    public partial class Group
    {
        public Group()
        {
            this.GroupCourses = new HashSet<GroupCourse>();
            this.GroupDocuments = new HashSet<GroupDocument>();
            this.GroupHomepages = new HashSet<GroupHomepage>();
            this.GroupInfoes = new HashSet<GroupInfo>();
            this.UserGroups = new HashSet<UserGroup>();
            this.GroupQuizs = new HashSet<GroupQuiz>();
            this.Topics = new HashSet<Topic>();
        }
    
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public string GroupManager { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNo { get; set; }
        public bool Status { get; set; }
        public Nullable<int> OrganisationID { get; set; }
        public long CreatedById { get; set; }
        public System.DateTime CreationDate { get; set; }
        public Nullable<long> LastModifiedByID { get; set; }
        public Nullable<System.DateTime> DateLastModified { get; set; }
        public bool IsDeleted { get; set; }
        public string DeleteInformation { get; set; }
        public long MaxUsers { get; set; }
        public Nullable<long> AssignedUsers { get; set; }
    
        public virtual ICollection<GroupCourse> GroupCourses { get; set; }
        public virtual ICollection<GroupDocument> GroupDocuments { get; set; }
        public virtual ICollection<GroupHomepage> GroupHomepages { get; set; }
        public virtual ICollection<GroupInfo> GroupInfoes { get; set; }
        public virtual Organisation Organisation { get; set; }
        public virtual ICollection<UserGroup> UserGroups { get; set; }
        public virtual ICollection<GroupQuiz> GroupQuizs { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }
    }
}