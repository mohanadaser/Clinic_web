using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


    public class Setting
    {
    [Key]
    public int id_clinic { get; set; }

    [Display(Name ="اسم الدكتور")]
    public string doctor_name { get; set; }

    [Display(Name = "رقم تليفون العياده"),DataType(DataType.PhoneNumber)]
    public string phone_clinic { get; set; }

    [Display(Name = "لوجو للعياده")]
    public string logo { get; set; }

}

