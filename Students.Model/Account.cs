﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Students.Model
{
    public partial class Account : IEquatable<Account>
    {
        public Account()
        {
            TabAccountRoles = new HashSet<AccountRole>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<AccountRole> TabAccountRoles { get; set; }

        public bool Equals(Account other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id && Login == other.Login && Password == other.Password && IsActive == other.IsActive;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Account)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Login, Password, IsActive);
        }
    }
}
