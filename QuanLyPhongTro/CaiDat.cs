using System;
using System.Data.SQLite;
using System.IO;

namespace QuanLyPhongTro
{
    public static class CaiDat
    {
        //Tên phần mềm
        public static readonly string TenPhanMem = "Quản Lý Phòng Trọ";

        //Mutex phần mềm
        public static readonly string Mutex = "QuanLyPhongTro";

        //Class cơ sở dữ liệu
        public static SQLiteConnection CSDL;

        //Đường dẫn mặc định của cơ sở dữ liệu
        private static readonly string duongDanCSDL = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.sqlite3");

        //Giá điện tự cập nhật và truy xuất từ cơ sở dữ liệu
        public static int _GiaDien = -1;
        public static int GiaDien
        {
            get
            {
                if (_GiaDien != -1)
                {
                    return _GiaDien;
                }
                else
                {
                    using (SQLiteCommand truyVan = new SQLiteCommand("SELECT DuLieu FROM CaiDat WHERE TenCaiDat = @tenCaiDat", CSDL))
                    {
                        truyVan.Parameters.AddWithValue("@tenCaiDat", "GiaDien");

                        _GiaDien = BitConverter.ToInt32((byte[])truyVan.ExecuteScalar(), 0);
                        return _GiaDien;
                    }
                }
            }
            set
            {
                using (SQLiteCommand truyVan = new SQLiteCommand("INSERT OR REPLACE INTO CaiDat(TenCaiDat, DuLieu) VALUES(@tenCaiDat, @duLieu)", CSDL))
                {
                    truyVan.Parameters.AddWithValue("@tenCaiDat", "GiaDien");
                    truyVan.Parameters.AddWithValue("@duLieu", BitConverter.GetBytes(value));

                    truyVan.ExecuteNonQuery();
                }
            }
        }

        //Giá nước tự cập nhật và truy xuất từ cơ sở dữ liệu
        public static int _GiaNuoc = -1;
        public static int GiaNuoc
        {
            get
            {
                if (_GiaNuoc != -1)
                {
                    return _GiaNuoc;
                }
                else
                {
                    using (SQLiteCommand truyVan = new SQLiteCommand("SELECT DuLieu FROM CaiDat WHERE TenCaiDat = @tenCaiDat", CSDL))
                    {
                        truyVan.Parameters.AddWithValue("@tenCaiDat", "GiaNuoc");

                        _GiaNuoc = BitConverter.ToInt32((byte[])truyVan.ExecuteScalar(), 0);
                        return _GiaNuoc;
                    }
                }
            }
            set
            {
                using (SQLiteCommand truyVan = new SQLiteCommand("INSERT OR REPLACE INTO CaiDat(TenCaiDat, DuLieu) VALUES(@tenCaiDat, @duLieu)", CSDL))
                {
                    truyVan.Parameters.AddWithValue("@tenCaiDat", "GiaNuoc");
                    truyVan.Parameters.AddWithValue("@duLieu", BitConverter.GetBytes(value));

                    truyVan.ExecuteNonQuery();
                }
            }
        }

        public static void init()
        {
            //Kiểm tra cơ sở dữ liệu có tồn tại không nếu không thì tạo
            if (!File.Exists(duongDanCSDL))
            {
                CSDL = new SQLiteConnection(string.Format("Data Source={0};Version=3;", duongDanCSDL));
                CSDL.Open();

                string lenhThemCSDL = @"BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS ""Phong"" (
	""MaPhong""	INTEGER PRIMARY KEY AUTOINCREMENT,
	""TenPhong""	TEXT NOT NULL,
	""GiaPhong""	INTEGER NOT NULL,
	""PhuPhi""	INTEGER NOT NULL,
	""TrangThai""	INTEGER NOT NULL,
	""NguoiThue""	TEXT NOT NULL,
	""NgayThue""	TEXT NOT NULL,
	""SoDienCu""	INTEGER NOT NULL,
	""SoNuocCu""	INTEGER NOT NULL,
	""GhiChu""	TEXT NOT NULL,
    ""Xoa"" INTEGER NOT NULL
);
CREATE TABLE IF NOT EXISTS ""PhuPhi"" (
	""MaPhuPhi""	INTEGER PRIMARY KEY AUTOINCREMENT,
	""TenPhuPhi""	TEXT NOT NULL,
	""GiaPhuPhi""	INTEGER NOT NULL,
    ""Xoa"" INTEGER NOT NULL
);
CREATE TABLE IF NOT EXISTS ""PhongVaPhuPhi"" (
	""MaPhong""	INTEGER NOT NULL,
	""MaPhuPhi""	INTEGER NOT NULL,
	FOREIGN KEY(""MaPhuPhi"") REFERENCES ""PhuPhi""(""MaPhuPhi""),
	FOREIGN KEY(""MaPhong"") REFERENCES ""Phong""(""MaPhong""),
	PRIMARY KEY(""MaPhong"",""MaPhuPhi"")
);
CREATE TABLE IF NOT EXISTS ""CaiDat"" (
	""TenCaiDat""	TEXT NOT NULL,
	""DuLieu""	BLOB NOT NULL,
	PRIMARY KEY(""TenCaiDat"")
);
COMMIT;
";
                using (SQLiteCommand truyVan = new SQLiteCommand(lenhThemCSDL, CSDL))
                {
                    truyVan.ExecuteNonQuery();
                }

                GiaDien = 3000;
                GiaNuoc = 9000;

            }
            else
            {
                CSDL = new SQLiteConnection(string.Format("Data Source={0};Version=3;", duongDanCSDL));
                CSDL.Open();
            }
        }
    }
}
