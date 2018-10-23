using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TandVark.Data.Data1
{
    public class TblUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FldId { get; set; }
        public string FldAccountName { get; set; }
        public string FldPassword { get; set; }

        [ForeignKey("UserTypeId")]
        public virtual TblUserType FldUserType { get; set; }
    }
}
