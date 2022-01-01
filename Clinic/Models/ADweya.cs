using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


    public class ADweya
    {
    [Key]
    public int id_adweya { get; set; }

    [Required,Display(Name = "اسم الدواء")]
    public string name_adweya { get; set; }


    [Required, Display(Name = "رقم تليفون المندوب"), DataType(DataType.PhoneNumber)]
    public string tel { get; set; }

    [Required, Display(Name = "اسم المندوب")]
    public string supplier_adweya { get; set; }

    [Display(Name = "دواعى الاستعمال"),StringLength(1000)]

    public string uses_adwya { get; set; }
}

