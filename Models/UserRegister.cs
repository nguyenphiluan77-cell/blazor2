// Tạo ra 1 đối tượng để binding dữ liệu từ form đăng ký, dữ liệu này khớp với các trường input trong file register
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class UserRegisterViewModel
{
    [Required(ErrorMessage = "Username không được để trống")]
    [MinLength(3, ErrorMessage = "Username phải có ít nhất 3 ký tự")]
    [MaxLength(20, ErrorMessage = "Username không được vượt quá 20 ký tự")]
    public string Username { get; set; } = "Luận";

    [Required(ErrorMessage = "Email không được để trống")]
    [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
    public string Email { get; set; } = "nguyenphiluan77@gmail.com";

    [Required(ErrorMessage = "Password không được để trống")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$",
    ErrorMessage = "Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường và số")]
    public string Password { get; set; } = "";
    // cho tôi regex c# về password, có chữ hoa, chữ thường, có số. cách search regex cho pass trên mạng
    public bool Gender { get; set; } = false; // true: nữ, false: nam

    [Required(ErrorMessage = "City không được để trống")]
    public string City { get; set; } = "";
    public List<string> Hobbies { get; set; } = new List<string>();
}
// để cho các regex hoạt động thì thêm <DataAnnotationsValidator/> vào file Register.razor
