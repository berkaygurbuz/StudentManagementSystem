//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace studentManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Drawing;
    using System.IO;

    public partial class student
    {
        public int Std_ID { get; set; }
        public string Std_Name { get; set; }
        public string Std_Surname { get; set; }
        public Nullable<System.DateTime> Std_Birthdate { get; set; }
        public Nullable<bool> Std_Gender { get; set; }
        public string Std_Phone { get; set; }
        public string Std_Adress { get; set; }
        public string Std_Picture { get; set; }

        [NotMapped]
        public Image Picture
        {
            get
            {
                if (!string.IsNullOrEmpty(Std_Picture))
                {
                    if (File.Exists(Std_Picture))
                        return Image.FromFile(Std_Picture);
                }
                return null;
            }
        }
    }
}