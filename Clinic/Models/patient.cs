using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


    public class patient
    {
    [Key]
    public int idpatiend { get; set; }
    [Required(ErrorMessage ="يجب ادخال رقم الحجز"),Display(Name ="رقم الحجز")]
    public int code { get; set; }
    [Required(ErrorMessage ="يجب ادخال اسم المريض"), Display(Name = "اسم المريض"),StringLength(50)]
    public string name_patient { get; set; }

    [Display(Name ="رقم التليفون"),DataType(DataType.PhoneNumber)]
    public string phone_patient { get; set; }
    [Display(Name = "العنوان"),StringLength(250)]
    public string adress_patient { get; set; }
    [Display(Name = "تاريخ الحجز")]
    public DateTime addtime { get; set; }
    [Display(Name = "السن")]
    public int age { get; set; }
    [Required(ErrorMessage = "يجب ادخال نوع الكشف"), Display(Name = "نوع الكشف"), StringLength(50)]
    public string type_kashf { get; set; }
    [Required(ErrorMessage = "يجب ادخال التاريخ المرضى للمريض"), Display(Name = "ملاحظات"), StringLength(1000)]
    public string notes { get; set; }
   

    [Required(ErrorMessage = "يجب ادخال مبلغ الكشف او الاعاده"), Display(Name = "المبلغ المدفوع"), DataType(DataType.Currency),Column(TypeName = "decimal(6,2)")]
    public decimal paied { get; set; }

    

}

