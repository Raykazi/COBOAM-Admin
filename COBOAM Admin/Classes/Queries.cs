using System;
using System.Collections.Generic;
using System.Net;

namespace COBOAM_Admin.Classes
{
    abstract class Queries
    {

        private static readonly Dictionary<QueryIndex, string> Query = new Dictionary<QueryIndex, string>
        {
            {QueryIndex.Login1, "SELECT * FROM `login` WHERE `Username` = ?p0 AND `Password2` = ?p1;"},
            {QueryIndex.Devotion1, "SELECT * FROM `devotion` ORDER BY `ID` DESC;"},
            {QueryIndex.Logs1, "SELECT * FROM `log` ORDER BY `ID` DESC"},
            {QueryIndex.Logs2, "SELECT * FROM `log` WHERE `Type`=?p0 ORDER BY `ID` DESC"},
            {QueryIndex.Logs3, "INSERT INTO `log`(`Type`,`Date`,`IP`,`Msg`) VALUES(?p0,'" + DateTime.Now + "','" + new WebClient().DownloadString("http://channelofblessings.com/includes/IP.php") + "',?p1);"},
            {QueryIndex.Devotion2, "INSERT INTO `devotion` (`Month`,`Year`,`Quote`,`Scripture`,`Text`) VALUES(?p0,?p1,?p2,?p3,?p4);"},
            {QueryIndex.Devotion3, "UPDATE `devotion` SET `Quote`=?p1, `Scripture`=?p2, `Text`=?p3, `Month`=?p4, `Year`=?p5 WHERE `ID` = ?p0"},
            {QueryIndex.Devotion4, "DELETE FROM `devotion` WHERE `Month`=?p0 AND `Year`=?p1"},
            {QueryIndex.Greetings1, "SELECT * FROM `greetings` ORDER BY `ID` ASC"},
            {QueryIndex.Greetings2, "UPDATE `greetings` SET `Current`= 0"},
            {QueryIndex.Greetings3, "INSERT INTO `greetings` (Current, Title, Part1, Part2) VALUES(?p0,?p1,?p2,?p3)"},
            {QueryIndex.Greetings4, "UPDATE `greetings` SET `Current`=?p0,`Title`=?p1, `Part1`=?p2, `Part2`=?p3 WHERE `ID`=?p4"},
            {QueryIndex.Greetings5, "DELETE FROM `greetings` WHERE `ID`=?p0"},
            {QueryIndex.Announcement1, "SELECT * FROM `announcement` ORDER BY `ID` ASC"},
            {QueryIndex.Announcement2, "INSERT INTO `announcement` (Title, Text, StartDate, ExpDate, Order) VALUES(?p0,?p1,?p2,?p3,?p4)"},
            {QueryIndex.Announcement3, "UPDATE `announcement` SET `Title`=?p0, `Text`=?p1, `StartDate`=?p2, `ExpDate`=?p3 `Order`=?p4 WHERE `ID`=?p5"},
            {QueryIndex.Announcement4, "DELETE FROM `announcement` WHERE `ID`=?p0"},
            {QueryIndex.Members1, "SELECT * FROM `login` WHERE `LName`<>\"\" ORDER BY `LName` "},
            {QueryIndex.Members2, "INSERT INTO `login` (`Username`,`Password`,`Email`,`FName`, `LName`, `Level`) VALUES (?p0,?p1,?p2,?p3,?p4,?p5)"},
            {QueryIndex.Members3, "UPDATE `login` SET `Username`=?p0, `Email`=?p1, `FName`=?p2, `LName`=?p3, `Level`=?p4 WHERE `ID`=?p5"},
            {QueryIndex.Members4, "UPDATE `login` SET `Disabled` = ?p1 WHERE `ID`=?p0"},
            {QueryIndex.Members5, "SELECT COUNT(*) FROM `login` WHERE `Username` = ?p0;"},
            {QueryIndex.Members6, "SELECT COUNT(*) FROM `login` WHERE `Email` = ?p0;"},
            {QueryIndex.Newsletter1, "INSERT INTO `newsletter` (`Path`,`Year`,`Quarter`,`Current`) VALUES (?p0,?p1,?p2,?p3)"},
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
