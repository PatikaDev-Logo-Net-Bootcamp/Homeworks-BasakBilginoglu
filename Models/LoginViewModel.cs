using System.ComponentModel.DataAnnotations;

namespace HomeworkOne.Models
{
    public class LoginViewModel
    {

        [Display(Name = "Adınız")]
        [Required(ErrorMessage = "Lütfen ad alanını boş bırakmayınız!")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Lütfen yalnızca harf kullanın.")]
        public string FirstName { get; set; }




        [Display(Name = "Soyadınız")]
        [Required(ErrorMessage = "Lütfen soyadı alanını boş bırakmayınız!")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Lütfen yalnızca  harf kullanın.")]
        public string LastName { get; set; }




        [Display(Name = "EMail")]
        [Required(ErrorMessage = "Lütfen email alanını boş bırakmayınız!")]
        [RegularExpression("^[A-Za-z0-9](([_\\.\\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\\.\\-]?[a-zA-Z0-9]+)*)\\.([A-Za-z]{2,})$", ErrorMessage = "Lütfen geçerli bir email adresi girin!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }



        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şifre alanını boş bırakmayınız!")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = "Şifre en az 8 karakter olmalıdır! En az 1 büyük harf, en az 1 karakter ve en az 1 sayı içermelidir!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

