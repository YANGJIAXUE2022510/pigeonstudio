using UnityEngine;

public static class GlobalVariables {
    public static int score = 0;
    public static string dynasty = "周";
    public static string era = "凤临";
    public static int year = 0;
    public static int month = 0;
    //当前所在的地区名字 
    public static string currentLocation = "红谷.网游城";
    //我的计划是有好几个点  每个点都有自己的变量名根据变量名0,1搜索到当前城池名
    //比如0是红谷 但1是城市1  2是城市2  一个10个城市
 

    public static string GetChineseYearString(int year) {
        string[] chineseDigits = {"零", "一", "二", "三", "四", "五", "六", "七", "八", "九"};
        string yearString = "";

        if (year == 0) {
            yearString = "元";
        } else {
            int digitCount = (int)Mathf.Floor(Mathf.Log10(year)) + 1;
            for (int i = 0; i < digitCount; i++) {
                int digit = (year / (int)Mathf.Pow(10, digitCount - 1 - i)) % 10;
                if (digit != 0) {
                    yearString += chineseDigits[digit];
                    if (digitCount - 1 - i > 0) {
                        yearString += chineseDigits[digitCount - 1 - i];
                    }
                }
            }
        }

        return yearString+"年";
    }

     public static string GetChineseMonthString(int month) {
        string[] chineseMonths = {"正月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月"};
        return chineseMonths[month];
    }

        public static void IncrementMonth() {
        month++;
        if (month > 11) {
            month = 0;
            year++;
        }
    }
}
