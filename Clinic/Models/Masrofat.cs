using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


    public class Masrofat
    {
    [Key]
    public int id_masrof { get; set; }

    [Required(ErrorMessage = "يجب ادخال نوع المصروف"), Display(Name = "نوع المصروف"), StringLength(500)]
    public string masrof_type { get; set; }

    [Display(Name = "الوقت والتاريخ")]
    public DateTime addtime_masrof { get; set; }

    [Required(ErrorMessage ="يجب ادخال قيمة الصروف"),Display(Name ="المبلغ"),DataType(DataType.Currency),Column(TypeName="decimal(6,2)")]
    public decimal amount { get; set; }

}

