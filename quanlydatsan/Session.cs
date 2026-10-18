namespace quanlydatsan
{
    public static class Session
    {
        public static string UserId { get; set; }      // MaChuSan hoặc MaKhach
        public static string FullName { get; set; }    // Tên người dùng
        public static string Role { get; set; }        // Vai trò: "ChuSan" hoặc "KhachHang"
        public static string Email { get; set; }
        public static string Phone { get; set; }
    }
}