using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


    public class Users
    {
    [Key]
    public int id_user { get; set; }

    [StringLength(250), Required(ErrorMessage = "يجب ادخال اسم المستخدم"), Display(Name = "اسم المستخدم")]
    public string Username { get; set; }


    [ Required( ErrorMessage = "يجب ادخال الرقم السرى"), Display(Name = "الرقم السرى"), DataType(DataType.Password)]
    public string Password { get; set; }


}

