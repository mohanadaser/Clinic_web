using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


    public class Online
    {
    [Key]
    public int id_online { get; set; }

    [Required(ErrorMessage = "يجب ادخال اسم المريض"), Display(Name = "اسم المريض"), StringLength(50)]
    public string name_online { get; set; }

    [Display(Name = "العنوان"),StringLength(250)]
    public string adress_online { get; set; }

    [Required(ErrorMessage ="يجب ادخال رقم تليفون للتواصل"),Display(Name = "رقم التليفون"), DataType(DataType.PhoneNumber)]
    public string phone_online { get; set; }

    [Display(Name = "تاريخ الحجز"),Required(ErrorMessage ="يجب اختيار التاريخ الذى تريد الحجز فيه")]
    public DateTime date_online { get; set; }

    [Required(ErrorMessage = "يجب ادخال الحاله المرضيه للمريض"), Display(Name = "وصف الحاله المرضيه"), StringLength(1000)]
    public string description { get; set; }

}

