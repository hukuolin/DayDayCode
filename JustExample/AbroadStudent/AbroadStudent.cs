using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseHelper;
namespace JustExample
{
    public class AbroadStudent
    {
        public string compowers { get; set; }//身份证号
        public string indentitytype { get; set; }//身份证明类型
        public string identifycode { get; set; }//身份证明号码
        public string pilotname { get; set; }//中文名
        public string pilotnameeng { get; set; }//英文名
        public string nationality { get; set; }//国籍
        public string birthplace { get; set; }//出生地
        public string birthday { get; set; }//出生日期 精确到天
        public int sex { get; set; }//性别
        public string nation { get; set; }//民族
        public string mobile { get; set; }//手机号
        public string manager { get; set; }//管理局
        public string org { get; set; }//学生所属单位
        public string address { get; set; }//居住地址
        public string zipcode { get; set; }//邮编
        public string mailaddr { get; set; }//通信地址
        public string xueli { get; set; }//学历
        public int school_id { get; set; }
        public string register_date { get; set; }//注册日期
        public int isgraduaction { get; set; }
    }
    public class AbroadStudentManage 
    {
        public string FillDataToXml(string xmlPath) 
        {
            AbroadStudent stu = new AbroadStudent()
            {
                compowers = "123456789123456789",
                indentitytype = "身份证",
                identifycode = "123456789123456789",
                pilotname = "刘书陶",
                pilotnameeng = "LIU Shutao",
                nationality = "中国",
                birthplace = "江苏省",
                birthday = "1974-07-14",
                sex = 0,
                nation = "汉",
                mobile = "13800000000",
                manager = "中南管理局",
                org = "深航",
                address = "深圳",
                zipcode = "123456",
                mailaddr = "深圳",
                xueli = "本科",
                school_id = 24,
                register_date = "2013-10-30",
                isgraduaction=0
            };
            string data= xmlPath.XmlTemplateFillData(stu);
            return data;
        }
    }
    public class ApplyStatueWcfResponseXml
    {
        public string successflag { get; set; }
        public string licenseno { get; set; }

        public string pilotname { get; set; }
        public string pilotnameeng { get; set; }
        public string org { get; set; }
        public string apptype { get; set; }
        public string status { get; set; }
        public string isfinish { get; set; }
        public string ismodify { get; set; }
        public string isspic { get; set; }
        public string isaccept { get; set; }
        public string designate_user { get; set; }
        public string designate_date { get; set; }
        public string reg_inspector { get; set; }
        public string reg_review_date { get; set; }
        public string reg_poi_disagree { get; set; }
        public string regresponsibleperson { get; set; }
        public string regissuedate { get; set; }
        public string disagree_info { get; set; }
        public string caacresponsible { get; set; }
        public string caacissuedate { get; set; } 
        public string caac_disagree_info { get; set; }

    }
}
