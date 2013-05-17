using System;

class PrintTable
{
    // according to http://www.ascii-code.com/ all ASCII symbols are 255. So they can be stored in a byte.
    
    static void Main()
    {
        Console.WriteLine(" The complete ASCII table characters are: ");
        Console.WriteLine();

        string[] symbolsArray = new string[] { "NUL SOH TX ETX EOT ENQ ACK BEL BS TAB LF VT FF CR SO SI DLE DC1 DC2 DC3 DC4 NAK SYN ETB CAN EM SUB ESC FS GS RS US (space) ! \" # $ % & ' ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9 : ; < = > ? @ A B C D E F G H I J K L M N O P Q R S T U V W X Y Z [ \\ ] ^ _ ` a b c d e f g h i j k l m n o p q r s t u v w x y z { | } ~ €  ‚ ? „ … † ‡ ? ‰ S ‹ ?  Z   ‘ ’ “ ” • – — ? ™ s › ?  z Y  ? ? ? ¤ ? ¦ § ? © ?  « ¬  ® ? ° ± ? ? µ ¶ · ? ? ? » ? ? ? ? A A A A A A ? C E E E E I I I I ? N O O O O O ? O U U U U Y ? ? a a a a a a ? c e e e e i i i i ? n o o o o o ? o u u u u y ? y" };
               

        foreach (var symbols in symbolsArray)
        {
            Console.WriteLine(symbols);
        }
    }
        
}
