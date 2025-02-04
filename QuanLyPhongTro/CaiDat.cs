using System;
using System.Collections.Generic;
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

        public static void ThemPhuPhi(string tenPhuPhi, int giaPhuPhi)
        {
            if (string.IsNullOrEmpty(tenPhuPhi))
            {
                throw new ArgumentException("Tên phụ phí không được để trống.");
            }

            string lenhThemPhuPhi = @"INSERT INTO PhuPhi (TenPhuPhi, GiaPhuphi, Xoa) 
                              VALUES (@tenPhuPhi, @giaPhuPhi, 0);";

            using (SQLiteCommand truyVan = new SQLiteCommand(lenhThemPhuPhi, CSDL))
            {
                truyVan.Parameters.AddWithValue("@tenPhuPhi", tenPhuPhi);
                truyVan.Parameters.AddWithValue("@giaPhuPhi", giaPhuPhi);

                truyVan.ExecuteNonQuery();
            }
        }

        public static void XoaPhuPhi(int maPhuPhi)
        {
            string lenhXoaPhuPhi = @"UPDATE PhuPhi 
                             SET Xoa = 1 
                             WHERE MaPhuPhi = @maPhuPhi;";

            using (SQLiteCommand truyVan = new SQLiteCommand(lenhXoaPhuPhi, CSDL))
            {
                truyVan.Parameters.AddWithValue("@maPhuPhi", maPhuPhi);

                truyVan.ExecuteNonQuery();
            }
        }

        public static List<(int MaPhuPhi, string TenPhuPhi, int GiaPhuPhi)> LayDanhSachPhuPhi()
        {
            List<(int, string, int)> danhSachPhuPhi = new List<(int, string, int)>();

            string lenhLayPhuPhi = @"SELECT MaPhuPhi, TenPhuPhi, GiaPhuphi 
                             FROM PhuPhi 
                             WHERE Xoa = 0;";

            using (SQLiteCommand truyVan = new SQLiteCommand(lenhLayPhuPhi, CSDL))
            using (SQLiteDataReader docDL = truyVan.ExecuteReader())
            {
                while (docDL.Read())
                {
                    int maPhuPhi = docDL.GetInt32(0);
                    string tenPhuPhi = docDL.GetString(1);
                    int giaPhuPhi = docDL.GetInt32(2);

                    danhSachPhuPhi.Add((maPhuPhi, tenPhuPhi, giaPhuPhi));
                }
            }

            return danhSachPhuPhi;
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
	""TenPhuPhi""	INTEGER NOT NULL,
	""GiaPhuphi""	INTEGER NOT NULL,
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
