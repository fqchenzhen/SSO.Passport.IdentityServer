//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PermissionModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserPermission
    {
        public int Id { get; set; }
        public bool HasPermission { get; set; }
        public Nullable<System.Guid> UserInfoId { get; set; }
        public Nullable<int> PermissionId { get; set; }
    
        public virtual Permission Permission { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
