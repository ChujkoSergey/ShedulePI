//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartScheduler.Models.DataContexts
{
    using System;
    using System.Collections.Generic;
    
    public partial class DbGroup
    {
        public DbGroup()
        {
            this.ScheduleItems = new HashSet<DbScheduleItem>();
            this.StudentsInGroups = new HashSet<DbStudentsInGroup>();
        }
    
        public int GroupId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<DbScheduleItem> ScheduleItems { get; set; }
        public virtual ICollection<DbStudentsInGroup> StudentsInGroups { get; set; }
    }
}