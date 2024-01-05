using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classDataBase
    {
        //Thuộc tính
        SqlConnection conn; // doi tuong dc su dung de connect data
        SqlCommand cmd;     // doi tuong dc thuc thi cau lenh 
        string conntring;

        public classDataBase()
        {

        }

        public classDataBase(string sername, string dbname, string user = "", string pass = "")
        {
            //kết nối csdl theo servername và database name

            conntring = "Data Source=" + sername + ";Initial Catalog=" + dbname + ";Integrated Security=True";
            conn = new SqlConnection(conntring);
            conn.Open(); // mo ket noi
        }

        //phương thức 
        //phương thức hỗ trợ kiểm tra kết nối thành công không
        public bool checkConn()
        {
            if (conn.State != ConnectionState.Open)
            {
                return false;
            }
            return true;
        }

        //phương thức lấy dữ liệu theo tên bảng
        public DataTable getTable(string tablename)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from " + tablename, this.conn);
            da.Fill(dt);
            return dt;
        }

        //phương thức lấy dữ liệu có điều kiện
        public DataTable getData(string sql)
        {
            DataTable dt = new DataTable(); // chứa một tập hợp các dòng và cột, lưu trữ dữ liệu từ cơ sở dữ liệu.(lưu trữ dữ liệu theo bảng)
            SqlDataAdapter da = new SqlDataAdapter(sql, this.conn);//lấy dữ liệu từ cơ sở dữ liệu 
            da.Fill(dt);//điền dữ liệu vào đối tượng DataTable
            return dt;
        }

        //phương thực thi câu lệnh truy vấn sql:insert,update,delet, create...
        public bool executeSQL(string sql)
        {
            cmd = new SqlCommand(sql); // doi tuong de thuc hien cau lenh 
            cmd.CommandType = CommandType.Text; // Thiết lập loại câu lệnh của đối tượng (Text cau lenh truyen vao la van ban)
            cmd.Connection = conn;  // gan doi tuong con. xac dinh co so du lieu duoc thuc hien 
            if (cmd.ExecuteNonQuery() > 0) // tra ve so luong row bi anh huong
            {
                return true;
            }
            return false;
        }
        //phương thức thực thi truy vấn qua thủ tục
        public DataTable executeSQLselect(string nameProcedure, SqlParameter[] parma)
        //nameProcedure: Chuỗi biểu diễn tên của thủ tục lưu trữ mà bạn muốn thực thi.
        //parma: Một mảng các đối tượng SqlParameter, đại diện cho các tham số của thủ tục lưu trữ.
        {
            cmd = new SqlCommand(nameProcedure); // doi tuong de thuc hien thu tuc
            cmd.CommandType = CommandType.StoredProcedure;  //StoredProcedure, đánh dấu rằng câu lệnh được thiết lập là thực hiện một thủ tục lưu trữ.
            foreach (SqlParameter par in parma)
            {
                cmd.Parameters.Add(par); // Thêm đối tượng(object) SqlParameter vào tập hợp các tham số của đối tượng SqlCommand( them vao la doi tuong)

            }
            cmd.Connection = conn;
            /*if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;*/
            DataTable dataTable = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dataTable);
            }
            return dataTable;
        }



        public DataTable ExecuteSQLSelect(string nameProcedure)
        {
            SqlCommand cmd = new SqlCommand(nameProcedure);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = conn;

            DataTable dataTable = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public bool executeProcedure(string nameProcedure, SqlParameter[] parma)
        {
            cmd = new SqlCommand(nameProcedure);//truy xuất database
            cmd.CommandType = CommandType.StoredProcedure;//lưu trữ kiểu thực thi 
            foreach (SqlParameter par in parma)
            {
                cmd.Parameters.Add(par);
            }
            cmd.Connection = conn;
                if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }


    }
}
