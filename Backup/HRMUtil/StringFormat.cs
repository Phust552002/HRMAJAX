using System;
using System.Collections.Generic;
using System.Text;

namespace HRMUtil
{
    public class StringFormat
    {

        public static string ReplaceWordWrap(string text)
        {
            text = text.Replace("'", "\"");
            text = text.Replace("|", ":");
            text = text.Replace(";", "<br/>");
            return text;
        }

        public static string FormatDate(DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }
        public static string FormatMonthYearVN(DateTime date)
        {
            return date.ToString("MM/yyyy");
        }


        public static string GetUserCode(int userId)
        {
            return userId.ToString("000#");
        }

        public static string FormatMark
        {
            get
            {
                return "#0.00";
            }
        }
        public static string FormatCurrency
        {
            get
            {
                return "#,###0.00";
            }
        }
        public static string FormatRepresentative
        {
            get
            {
                return "#,###0.000";
            }
        }
        public static string FormatCurrencyFinal
        {
            get
            {
                return "#,###0";
            }
        }
        public static string FormatCoefficient
        {
            get
            {
                return "#0.0";
            }
        }

        public static string SetFormatCoefficient(double value)
        {
            return value.ToString("#0.00");
        }

        public static string SetFormatMoney(decimal value)
        {
            return value.ToString("#,###0.00");
        }
        public static string SetFormatMoneyFinal(decimal value)
        {
            return value.ToString("#,###0");
        }

        public static string getSHA1(string inputString)
        {
            return BitConverter.ToString(System.Security.Cryptography.SHA1Managed.Create().ComputeHash(Encoding.Default.GetBytes(inputString))).Replace("-", "");
        }

        public static string TrimFullName(string fullname)
        {
            string[] arrFN = fullname.Split(' ');
            string fullnameReturn = string.Empty;
            for (int i = 0; i < arrFN.Length; i++ )
            {
                string s = arrFN[i];
                if (s.Trim().Length > 0)
                {

                    if (fullnameReturn.Length > 0)
                    {
                        fullnameReturn = fullnameReturn + " " + s;
                    }
                    else
                    {
                        fullnameReturn = s;
                    }
                }
            }
            return fullnameReturn;
        }

        public static string GetStringByNumber(decimal number)
        {
            string s = number.ToString("#");
            string[] so = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hang = new string[] { "", "nghìn", "triệu", "tỷ" };
            int i, j, donvi, chuc, tram;
            string str = " ";
            bool booAm = false;
            decimal decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDecimal(s.ToString());
            }
            catch
            {
            }
            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }
            i = s.Length;
            if (i == 0)
                str = so[0] + str;
            else
            {
                j = 0;
                while (i > 0)
                {
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        chuc = -1;
                    i--;
                    if (i > 0)
                        tram = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        tram = -1;
                    i--;
                    if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
                        str = hang[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((donvi == 1) && (chuc > 1))
                        str = "một " + str;
                    else
                    {
                        if ((donvi == 5) && (chuc > 0))
                            str = "lăm " + str;
                        else if (donvi > 0)
                            str = so[donvi] + " " + str;
                    }
                    if (chuc < 0)
                        break;
                    else
                    {
                        if ((chuc == 0) && (donvi > 0)) str = "lẻ " + str;
                        if (chuc == 1) str = "mười " + str;
                        if (chuc > 1) str = so[chuc] + " mươi " + str;
                    }
                    if (tram < 0) break;
                    else
                    {
                        if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " trăm " + str;
                    }
                    str = " " + str;
                }
            }
            if (booAm) str = "Âm " + str;
            str = str + "đồng chẵn";

            str = char.ToUpper(str[0]) + str.Substring(1);
            return str;
        }

        public static string GetStringByNumber(double number)
        {
            string s = number.ToString("#");
            string[] so = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hang = new string[] { "", "nghìn", "triệu", "tỷ" };
            int i, j, donvi, chuc, tram;
            string str = " ";
            bool booAm = false;
            double decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDouble(s.ToString());
            }
            catch
            {
            }
            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }
            i = s.Length;
            if (i == 0)
                str = so[0] + str;
            else
            {
                j = 0;
                while (i > 0)
                {
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        chuc = -1;
                    i--;
                    if (i > 0)
                        tram = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        tram = -1;
                    i--;
                    if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
                        str = hang[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((donvi == 1) && (chuc > 1))
                        str = "một " + str;
                    else
                    {
                        if ((donvi == 5) && (chuc > 0))
                            str = "lăm " + str;
                        else if (donvi > 0)
                            str = so[donvi] + " " + str;
                    }
                    if (chuc < 0)
                        break;
                    else
                    {
                        if ((chuc == 0) && (donvi > 0)) str = "lẻ " + str;
                        if (chuc == 1) str = "mười " + str;
                        if (chuc > 1) str = so[chuc] + " mươi " + str;
                    }
                    if (tram < 0) break;
                    else
                    {
                        if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " trăm " + str;
                    }
                    str = " " + str;
                }
            }
            if (booAm) str = "Âm " + str;

            str = str + "đồng chẵn";

            str = char.ToUpper(str[0]) + str.Substring(1);
            return str;
        }
    }
}
