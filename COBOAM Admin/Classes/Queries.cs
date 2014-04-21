using System;

namespace COBOAM_Admin.Classes
{
    abstract class Queries
    {
        public static string ToString(QueryIndex queryIndex)
        {
            switch (queryIndex)
            {
                case QueryIndex.Login1:
                    return "SELECT * FROM `login` WHERE `Username` = '{0}' AND `Password2` = '{1}';";
                case QueryIndex.Devotion1:
                    return "SELECT * FROM `devotion` ORDER BY `ID` DESC;";
                case QueryIndex.Logs1:
                    return "SELECT * FROM `log` ORDER BY `ID` DESC";
                case QueryIndex.Logs2:
                    return "SELECT * FROM `log` WHERE `Type`='{0}' ORDER BY `ID` DESC";
                case QueryIndex.Logs3:
                    return "INSERT INTO `log`(`Type`,`Date`,`IP`,`Msg`) VALUES('{0}','" + DateTime.Now + "','" + Program.uCIP + "',\"{3}\");";
                case QueryIndex.Devotion2:
                    return "INSERT INTO `devotion` (`Month`,`Year`,`Quote`,`Scripture`,`Text`) VALUES('{0}','{1}','{2}','{3}','{4}');";
                case QueryIndex.Devotion3:
                    return "UPDATE `devotion` SET `Quote`='{1}', `Scripture`='{2}', `Text`='{3}', `Month`='{4}', `Year`='{5}' WHERE `ID` = '{0}'";
                case QueryIndex.Devotion4:
                    return "DELETE FROM `devotion` WHERE `Month`='{0}' AND `Year`='{1}'";
                case QueryIndex.Greetings1:
                    return "SELECT * FROM `greetings` ORDER BY `ID` ASC";
                case QueryIndex.Greetings2:
                    return "UPDATE `greetings` SET `Current`= 0";
                case QueryIndex.Greetings3:
                    return "INSERT INTO `greetings` (Current, Title, Part1, Part2) VALUES('{0}','{1}','{2}','{3}')";
                case QueryIndex.Greetings4:
                    return "UPDATE `greetings` SET `Current`='{0}',`Title`='{1}', `Part1`='{2}', `Part2`='{3}' WHERE `ID`='{4}'";
                case QueryIndex.Greetings5:
                    return "DELETE FROM `greetings` WHERE `ID`='{0}'";
                case QueryIndex.Announcement1:
                    return "SELECT * FROM `announcement` ORDER BY `ID` ASC";
                case QueryIndex.Announcement2:
                    return "INSERT INTO `announcement` (Title, Text, StartDate, ExpDate) VALUES('{0}','{1}','{2}','{3}')";
                case QueryIndex.Announcement3:
                    return "UPDATE `announcement` SET `Title`='{0}', `Text`='{1}', `StartDate`='{2}', `ExpDate`='{3}' WHERE `ID`='{4}'";
                case QueryIndex.Announcement4:
                    return "DELETE FROM `announcement` WHERE `ID`='{0}'";
                case QueryIndex.Members1:
                    return "SELECT * FROM `login` WHERE `LName`<>\"\" ORDER BY `LName` ";
                case QueryIndex.Members2:
                    return "INSERT INTO `login` (`Username`,`Password`,`Email`,`FName`, `LName`, `Level`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')";
                case QueryIndex.Members3:
                    return "UPDATE `login` SET `Username`='{0}', `Email`='{1}', `FName`='{2}', `LName`='{3}', `Level`='{4}' WHERE `ID`='{5}'";
                case QueryIndex.Members4:
                    return "UPDATE `login` SET `Disabled` = b'{1}' WHERE `ID`={0}";
                case QueryIndex.Members5:
                    return "SELECT COUNT(*) FROM `login` WHERE `Username` = '{0}';";
                case QueryIndex.Members6:
                    return "SELECT COUNT(*) FROM `login` WHERE `Email` = '{0}';";
            }
            return "";
        }
    }

    public enum QueryIndex
    {
        Login1,
        Logs1,
        Logs2,
        Logs3,
        Devotion1,
        Devotion2,
        Devotion3,
        Devotion4,
        Greetings1,
        Greetings2,
        Greetings3,
        Greetings4,
        Greetings5,
        Announcement1,
        Announcement2,
        Announcement3,
        Announcement4,
        Members1,
        Members2,
        Members3,
        Members4,
        Members5,
        Members6
    }
}
