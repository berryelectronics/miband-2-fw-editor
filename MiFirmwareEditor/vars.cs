using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiFirmwareEditor
{
    class vars
    {

        public String[] categories = new String[] //Dont change the order!!!
        {
            "App Notification Icons",
            "Medium sized time numbers",
            "Small date characters"
        };

        public String[,] notificationNames = new String[,]
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
            { "Penguin thing ???", "27314", "273c7" },
            //{ "Message App Icon", "" "" },
            { "Snapchat", "27959", "27a0c" },
            { "Taobao", "27e82", "27f35" },
            { "Google Hangouts", "287dc", "2888f" },
            { "Twitter", "26edc", "26f8f" },
            //{ "Weird Message Icon", "", "" },
            { "Weibo", "280c0", "28173" },
            { "Whatsapp", "26f90", "27043" },
            { "Instagram", "284f8", "285ab" },
            { "VK ???", "273c8", "2747b" },
            { "Pokemon Go", "27f36", "27fe9" },
            { "Skype", "28408", "284bb" },
            { "Telegram", "2800c", "280bf" },
            { "Calendar", "27260", "27313" },
            { "Chinese Mail thing ???", "278a5", "27958" },
            { "Some Explosion ???", "282dc", "2838f" },
            { "Chinese App 1 ???", "27dce", "27e81" },
            { "Chinese App 2 ???", "27689", "2773c" },
            { "Chinese App 3 ???", "28174", "28227" },
            { "Alipay", "26d74", "26e27" },
            { "Chinese App 4 ???", "28890", "28943" },
            { "Chinese App 5 ???", "271ac", "2725f" },
            { "Chinese App 6 ???", "27bd4", "27c87" },
            { "Chinese App 7 ???", "26e28", "26edb" },
            { "Line", "27044", "270f7" },
            { "Talk", "28728", "287db" },
            { "Mi", "27ca8", "27d5b" }
        };

        public String[,] mediumNumberNames = new String[,]
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

        public String[,] smallDateTextAndWidth = new String[,]
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

    }
}
