using School.Core.Dataa;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace School.Core.DTO
{
//    PROCEDURE Searchn(sname in VARCHAR2, cname VARCHAR2, datefrom in date, dateto in date )
//as
//cur_all SYS_REFCURSOR;
//    BEGIN
//    open cur_all for select s.firstname, s.lastname, sc.markofstd , c.coursename , sc.DATEOFREGISTER
//    from student_s s
//    join STDCOURSE_S sc on sc.stdid= s.student_id
//    join course_s c on c.course_id= sc.courdeid
//    where upper(s.firstname ) like '%' || upper(sname)||'%' and upper(c.coursename) like '%' || upper(cname)||'%' and (datefrom in null or dateto is null or DATEOFREGISTER BETWEEN '2023-02-20' and '2023-02-22');
//    dbms_sql.return_result(cur_all);
//end;
    public class Search
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public decimal? markofstd { get; set; }
        public string coursename { get; set; }

        public DateTime? datefrom { get; set; }
        public DateTime? dateto { get; set; }

    }
}
