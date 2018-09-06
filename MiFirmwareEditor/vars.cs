using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiFirmwareEditor
{
    class vars
    {

        public String[] categories_pro_10154 = new String[] //Dont change the order!!!
        {
            "App Notification Icons",
            "Medium sized time numbers",
            "Small date characters"
        };

        public String[] categories_pro_10181 = new String[] //Dont change the order!!!
        {
            "App Notification Icons",
            "Medium sized time numbers",
            "Small date characters"
        };

        public String[,] notificationNames_pro_10154 = new String[,]
        {
            //{ "Animated Phone ringing", "", "" },
            //{ "Animated Call Icon", "", "" },
            { "Email", "285ac", "2865f" },
            { "Facebook", "27a0d", "27ac0" },
            { "Call (no animation)", "277f1", "278a4" },
            { "Generic App", "270f8", "271ab" },
            //{ "Message Heart", "", "" },
            { "Mi Fit", "26cc0", "26d73" },
            { "Mi Talk", "2773d", "277f0" },
            { "Facebook Messenger", "28228", "282db" },
            { "Tencent QQ", "27314", "273c7" },
            //{ "Message App Icon", "" "" },
            { "Snapchat", "27959", "27a0c" },
            { "Taobao", "27e82", "27f35" },
            { "Google Hangouts", "287dc", "2888f" },
            { "Twitter", "26edc", "26f8f" },
            //{ "Weird Message Icon", "", "" },
            { "Weibo", "280c0", "28173" },
            { "Whatsapp", "26f90", "27043" },
            { "Instagram", "284f8", "285ab" },
            { "VKontakte", "273c8", "2747b" },
            { "Pokemon Go", "27f36", "27fe9" },
            { "Skype", "28408", "284bb" },
            { "Telegram", "2800c", "280bf" },
            { "Calendar", "27260", "27313" },
            { "Chinese Mail thing ???", "278a5", "27958" },
            { "Some Explosion ???", "282dc", "2838f" },
            { "Chinese App 1 ???", "27dce", "27e81" },
            { "Qianniu", "27689", "2773c" },
            { "Chinese App 3 ???", "28174", "28227" },
            { "Alipay", "26d74", "26e27" },
            { "QZone", "28890", "28943" },
            { "Xianyu", "271ac", "2725f" },
            { "JD.com", "27bd4", "27c87" },
            { "DingTalk", "26e28", "26edb" },
            { "Line", "27044", "270f7" },
            { "Talk", "28728", "287db" },
            { "Mi", "27ca8", "27d5b" }
        };

        public String[,] notificationNames_pro_10181 = new String[,]
        {
            //{ "Animated Phone ringing", "", "" },
            //{ "Animated Call Icon", "", "" },
            { "Email", "27154", "27207" },
            { "Facebook", "264f1", "265a4" },
            { "Call (no animation)", "26c68", "26d1b" },
            { "Generic App", "25c90", "25d43" },
            //{ "Message Heart", "", "" },
            { "Mi Fit", "25858", "2590b" },
            { "Mi Talk", "262d5", "26388" },
            { "Facebook Messenger", "26dd0", "26e83" },
            //{ "Tencent QQ", "27314", "273c7" },
            //{ "Message App Icon", "" "" },
            //{ "Snapchat", "27959", "27a0c" },
            { "Taobao", "26976", "26a29" },
            { "Google Hangouts", "27438", "274eb" },
            { "Twitter", "259c0", "25a73" },
            //{ "Weird Message Icon", "", "" },
            { "Weibo", "26bb4", "26c67" },
            { "Whatsapp", "25a74", "25b27" },
            { "Instagram", "270a0", "27153" },
            { "VKontakte", "25eac", "25f5f" },
            { "Pokemon Go", "26a2a", "26add" },
            { "Skype", "26fb0", "27063" },
            { "Telegram", "26b00", "26bb3" },
            { "Calendar", "272d0", "27383" },
            { "Chinese Mail thing ???", "26389", "2643c" },
            { "Some Explosion ???", "26e84", "26f37" },
            { "Chinese App 1 ???", "268c2", "26975" },
            //{ "Qianniu", "27689", "2773c" },
            { "Chinese App 3 ???", "26d1c", "26dcf" },
            { "Alipay", "2590c", "259bf" },
            { "QZone", "275a0", "27653" },
            { "Xianyu", "25d44", "25df7" },
            { "JD.com", "266c8", "2677b" },
            { "DingTalk", "2616d", "26220" },
            { "Line", "26bdc", "25c8f" },
            { "Talk", "27384", "27437" },
            { "Mi", "2679c", "2684f" }
        };

        public String[,] mediumNumberNames_pro_10154 = new String[,]
        {
            { "0", "28ac0", "28ae3" },
            { "1", "28ae4", "28b07" },
            { "2", "28b08", "28b2b" },
            { "3", "28b2c", "28b4f" },
            { "4", "28b50", "28b73" },
            { "5", "28b74", "28b97" },
            { "6", "28b98", "28bbb" },
            { "7", "28bbc", "28bdf" },
            { "8", "28be0", "28c03" },
            { "9", "28c04", "28c27" }
        };

        public String[,] mediumNumberNames_pro_10181 = new String[,]
        {
            { "0", "2780c", "2782f" },
            { "1", "27830", "27853" },
            { "2", "27854", "27877" },
            { "3", "27878", "2789b" },
            { "4", "2789c", "278bf" },
            { "5", "278c0", "278e3" },
            { "6", "278e4", "27907" },
            { "7", "27908", "2792b" },
            { "8", "2792c", "2794f" },
            { "9", "27950", "27973" }
        };

        public String[,] smallDateTextAndWidths_pro_10154 = new String[,]
        {
            { "a", "5", "28aae", "28ab7" },
            { "b", "4", "28c91", "28c98" },
            { "c", "4", "28f32", "28f39" },
            { "d", "5", "28c87", "28c90" },
            { "e", "4", "28e5c", "28e63" },
            { "g", "4", "28e64", "28e6b" },
            { "h", "4", "28dfe", "28e05" },
            { "i", "1", "28aac", "28aad" },
            { "l", "1", "28c5e", "28c5f" },
            { "n", "4", "28df6", "28dfd" },
            { "o", "4", "28e4c", "28e53" },
            { "p", "4", "28c6a", "28c71" },
            { "r", "4", "28c56", "28c5d" },
            { "t", "4", "28ab8", "28abf" },
            { "u", "5", "28e42", "28e4b" },
            { "v", "5", "28c60", "28c69" },
            { "y", "4", "28e54", "28e5b" },
            { "A", "6", "28f48", "28f53" },
            { "D", "6", "28e06", "28e11" },
            { "F", "5", "28dec", "28df5" },
            { "J", "5", "28c4c", "28c55" },
            { "M", "7", "28f5e", "28f6b" },
            { "N", "6", "28ca3", "28cae" },
            { "O", "5", "28e36", "28e3f" },
            { "S", "5", "28f54", "28f5d" },
            { "T", "5", "28c99", "28ca2" },
            { "W", "7", "28f3a", "28f47" }
        };

        public String[,] smallDateTextAndWidths_pro_10181 = new String[,]
        {
            { "a", "5", "277fa", "27803" },
            { "b", "4", "279dd", "279e4" },
            { "c", "4", "27c7e", "27c85" },
            { "d", "5", "279d3", "279dc" },
            { "e", "4", "27ba8", "27baf" },
            { "g", "4", "27bb0", "27bb7" },
            { "h", "4", "27b4b", "27b51" },
            { "i", "1", "277f8", "277f9" },
            //{ "l", "1", "27b42", "28c5f" },
            { "n", "4", "27b42", "28dfd" },
            { "o", "4", "27b98", "28e53" },
            { "p", "4", "279b6", "28c71" },
            { "r", "4", "279a2", "28c5d" },
            { "t", "4", "27804", "28abf" },
            { "u", "5", "27b8e", "28e4b" },
            { "v", "5", "279ac", "28c69" },
            { "y", "4", "27ba0", "28e5b" },

            { "A", "6", "27c94", "27c9f" },
            { "D", "6", "27b52", "27b5d" },
            { "F", "5", "27b38", "27b41" },
            { "J", "5", "27998", "279a1" },
            { "M", "7", "27caa", "27cb7" },

            { "N", "6", "279ef", "279fa" },
            { "O", "5", "27ad4", "27add" },
            { "S", "5", "27ca0", "27ca9" },
            { "T", "5", "279e5", "279ee" },
            { "W", "7", "27c86", "27c93" }
        };

        // Getter Functions

        public String[] getCategories(String version)
        {
            if (version == "pro_1.0.1.54") return categories_pro_10154;
            if (version == "pro_1.0.1.81") return categories_pro_10181;

            return null;
        }

        public String[,] getNotificationNames(String version)
        {
            if (version == "pro_1.0.1.54") return notificationNames_pro_10154;
            if (version == "pro_1.0.1.81") return notificationNames_pro_10181;

            return null;
        }

        public String[,] getMediumNumberNames(String version)
        {
            if (version == "pro_1.0.1.54") return mediumNumberNames_pro_10154;
            if (version == "pro_1.0.1.81") return mediumNumberNames_pro_10181;

            return null;
        }

        public String[,] getSmallDateTextAndWidths(String version)
        {
            if (version == "pro_1.0.1.54") return smallDateTextAndWidths_pro_10154;
            if (version == "pro_1.0.1.81") return smallDateTextAndWidths_pro_10181;

            return null;
        }

    }
}
