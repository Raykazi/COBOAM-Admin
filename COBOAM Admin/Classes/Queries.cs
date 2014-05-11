using System;
using System.Collections.Generic;

namespace COBOAM_Admin.Classes
{
    abstract class Queries
    {

        private static readonly Dictionary<QueryIndex, string> Query = new Dictionary<QueryIndex, string>
        {
            {QueryIndex.Login1, "SELECT * FROM `login` WHERE `Username` = '{0}' AND `Password2` = '{1}';"},
            {QueryIndex.Devotion1, "SELECT * FROM `devotion` ORDER BY `ID` DESC;"},
            {QueryIndex.Logs1, "SELECT * FROM `log` ORDER BY `ID` DESC"},
            {QueryIndex.Logs2, "SELECT * FROM `log` WHERE `Type`='{0}' ORDER BY `ID` DESC"},
            {QueryIndex.Logs3, "INSERT INTO `log`(`Type`,`Date`,`IP`,`Msg`) VALUES('{0}','" + DateTime.Now + "','" + Program.uCIP + "',\"{3}\");"},
            {QueryIndex.Devotion2, "INSERT INTO `devotion` (`Month`,`Year`,`Quote`,`Scripture`,`Text`) VALUES('{0}','{1}','{2}','{3}','{4}');"},
            {QueryIndex.Devotion3, "UPDATE `devotion` SET `Quote`='{1}', `Scripture`='{2}', `Text`='{3}', `Month`='{4}', `Year`='{5}' WHERE `ID` = '{0}'"},
            {QueryIndex.Devotion4, "DELETE FROM `devotion` WHERE `Month`='{0}' AND `Year`='{1}'"},
            {QueryIndex.Greetings1, "SELECT * FROM `greetings` ORDER BY `ID` ASC"},
            {QueryIndex.Greetings2, "UPDATE `greetings` SET `Current`= 0"},
            {QueryIndex.Greetings3, "INSERT INTO `greetings` (Current, Title, Part1, Part2) VALUES('{0}','{1}','{2}','{3}')"},
            {QueryIndex.Greetings4, "UPDATE `greetings` SET `Current`='{0}',`Title`='{1}', `Part1`='{2}', `Part2`='{3}' WHERE `ID`='{4}'"},
            {QueryIndex.Greetings5, "DELETE FROM `greetings` WHERE `ID`='{0}'"},
            {QueryIndex.Announcement1, "SELECT * FROM `announcement` ORDER BY `ID` ASC"},
            {QueryIndex.Announcement2, "INSERT INTO `announcement` (Title, Text, StartDate, ExpDate) VALUES('{0}','{1}','{2}','{3}')"},
            {QueryIndex.Announcement3, "UPDATE `announcement` SET `Title`='{0}', `Text`='{1}', `StartDate`='{2}', `ExpDate`='{3}' WHERE `ID`='{4}'"},
            {QueryIndex.Announcement4, "DELETE FROM `announcement` WHERE `ID`='{0}'"},
            {QueryIndex.Members1, "SELECT * FROM `login` WHERE `LName`<>\"\" ORDER BY `LName` "},
            {QueryIndex.Members2, "INSERT INTO `login` (`Username`,`Password`,`Email`,`FName`, `LName`, `Level`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')"},
            {QueryIndex.Members3, "UPDATE `login` SET `Username`='{0}', `Email`='{1}', `FName`='{2}', `LName`='{3}', `Level`='{4}' WHERE `ID`='{5}'"},
            {QueryIndex.Members4, "UPDATE `login` SET `Disabled` = b'{1}' WHERE `ID`={0}"},
            {QueryIndex.Members5, "SELECT COUNT(*) FROM `login` WHERE `Username` = '{0}';"},
            {QueryIndex.Members6, "SELECT COUNT(*) FROM `login` WHERE `Email` = '{0}';"},
            {QueryIndex.Newsletter1, "INSERT INTO `newsletter` (`Path`,`Year`,`Quarter`,`Current`) VALUES ('{0}','{1}','{2}','{3}')"},
            {QueryIndex.Newsletter2, "SELECT * FROM `newsletter` ORDER BY `ID` DESC"},
            {QueryIndex.Subscribers1, "SELECT * FROM `subscribers` ORDER BY `ID`"},
        };

        public static string Value(QueryIndex qi)
        {
            string value;
            Query.TryGetValue(qi, out value);
            return value;
        }
    }

    public enum QueryIndex : uint
    {
        Login1 = 0,
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
        Members6,
        Newsletter1,
        Newsletter2,
        Subscribers1,
    }
}
