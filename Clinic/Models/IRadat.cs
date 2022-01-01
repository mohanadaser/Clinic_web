using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


    public class IRadat
    {
    [Key]
    public int id_irad { get; set; }

    [Required(ErrorMessage = "يجب ادخال نوع الايراد"), Display(Name = "نوع الايراد"), StringLength(500)]
    public string irad_type { get; set; }

    [Display(Name = "الوقت والتاريخ")]
    public DateTime addtime_irad { get; set; }

    [Required(ErrorMessage = "يجب ادخال قيمة الايراد"), Display(Name = "المبلغ"), DataType(DataType.Currency), Column(TypeName = "decimal(6,2)")]
    public decimal amount { get; set; }


}

