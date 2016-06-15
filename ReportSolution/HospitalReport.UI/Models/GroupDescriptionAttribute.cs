using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Genernal.UI.Models
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class GroupDescriptionAttribute : Attribute
    {
        public string Description { get; set; }
        public string GroupName { get; set; }
        public int GroupId { get; set; }

        //public GroupDescriptionAttribute(string groupName, string description)
        //{
        //    groupName = GroupName;
        //    description = Description;
        //}

        //public GroupDescriptionAttribute(int groupId, string groupName, string description)
        //{
        //    groupId = GroupId;
        //    groupName = GroupName;
        //    description = Description;
        //}

        //private string _description;
        //private string _groupName;
        //private int _groupId;

        //public string Description { get { return _description; } }
        //public string GroupName { get { return _groupName; } }
        //public int GroupId { get { return _groupId; } }

        //public GroupDescriptionAttribute()
        //{

        //}

        //public GroupDescriptionAttribute(string groupName, string description)
        //{
        //    _groupName = GroupName;
        //    _description = Description;
        //}

        //public GroupDescriptionAttribute(int groupId, string groupName, string description)
        //{
        //    _groupId = GroupId;
        //    _groupName = GroupName;
        //    _description = Description;
        //}

    }
}