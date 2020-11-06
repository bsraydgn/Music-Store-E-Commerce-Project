using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MainMusicStore.Models.DbModels
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field cannot be blank")]
        [StringLength(250,MinimumLength =3,ErrorMessage = "Please Enter Values According To The Conditions")]
        public string CategoryName { get; set; }
    }
}
