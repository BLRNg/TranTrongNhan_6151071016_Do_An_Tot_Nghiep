//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Parking_Slot
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        public string user_name { get; set; }
        public byte[] Salt { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}
