using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlayStation_Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public Guid Id { get; set; }


        [Display(Name = "Введите имя")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина имени не менее 3 символов")]
        [Required(ErrorMessage = "Введите данные!")]
        public string Name { get; set; }

        [Display(Name = "Введите фамилию")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина фамилии не менее 3 символов")]
        [Required(ErrorMessage = "Введите данные!")]
        public string SurName { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Длина адреса не менее 10 символов")]
        [Required(ErrorMessage = "Введите данные!")]
        public string Adress { get; set; }

        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Длина номера не менее 10 символов")]
        [Required(ErrorMessage = "Введите данные!")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(70, MinimumLength = 5, ErrorMessage = "Длина Email не менее 5 символов")]
        [Required(ErrorMessage = "Введите данные!")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

    }
}
