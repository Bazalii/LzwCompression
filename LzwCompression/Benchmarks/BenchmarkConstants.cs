namespace LzwCompression.Benchmarks;

public static class BenchmarkConstants
{
    public const string Text1 =
        "I love going to the park the park is a beautiful place In the park you can walk play games and just relax I often go to the park with friends We love going to the park on a sunny day There are many green trees in the park and flowers grow everywhere I love going to the park and enjoying the fresh air The park is a great place to relax I love going to the park the park is a beautiful place In the park you can walk play games and just relax I often go to the park with friends We love going to the park on a sunny day There are many green trees in the park and flowers grow everywhere I love going to the park and enjoying the fresh air The park is a great place to relax I love going to the park the park is a beautiful place In the park you can walk play games and just relax I often go to the park with friends We love going to the park on a sunny day There are many green trees in the park and flowers grow everywhere I love going to the park and enjoying the fresh air The park is a great place to relax I love going to the park the park is a beautiful place In the park you can walk play games and just relax I often go to the park with friends We love going to the park on a sunny day There are many green trees in the park and flowers grow everywhere I love going to the park and enjoying the fresh air The park is a great place to relax I love going to the park the park is a beautiful place In the park you can walk play games and just relax I often go to the park with friends We love going to the park on a sunny day There are many green trees in the park and flowers grow everywhere I love going to the park and enjoying the fresh air The park is a great place to relax I love going to the park the park is a beautiful place In the park you can walk play games and just relax I often go to the park with friends We love going to the park on a sunny day There are many green trees in the park and flowers grow everywhere I love going to the park and enjoying the fresh air The park is a great place to relax I love going to the park the park is a beautiful place In the park you can walk play games and just relax I often go to the park with friends We love going to the park on a sunny day There are many green trees in the park and flowers grow everywhere I love going to the park and enjoying the fresh air The park is a great place to relax I love going to the park the park is a beautiful place In the park you can walk play games and just relax I often go to the park with friends We love going to the park on a sunny day There are many green trees in the park and flowers grow everywhere I love going to the park and enjoying the fresh air The park is a great place to relax I love going to the park the park is a beautiful place In the park you can walk play games and just relax I often go to the park with friends We love going to the park on a sunny day There are many green trees in the park and flowers grow everywhere I love going to the park and enjoying the fresh air The park is a great place to relax I love going to the park the park is a beautiful place In the park you can walk play games and just relax I often go to the park with friends We love going to the park on a sunny day There are many green trees in the park and flowers grow everywhere I love going to the park and enjoying the fresh air The park is a great place to relax I love going to the park the park is a beautiful place In the park you can walk play games and just relax I often go to the park with friends We love going to the park on a sunny day There are many green trees in the park and flowers grow everywhere I love going to the park and enjoying the fresh air The park is a great place to relax I love going to the park the park is a beautiful place In the park you can walk play games and just relax I often go to the park with friends We love going to the park on a sunny day There are many green trees in the park and flowers grow everywhere I love going to the park and enjoying the fresh air The park is a great place to relax I love going to the park the park is a beautiful place In the park you can walk play games and just relax I often go to the park with friends We love going to the park on a sunny day There are many green trees in the park and flowers grow everywhere I love going to the park and enjoying the fresh air The park is a great place to relax I love going to the park the park is a beautiful place In the park you can walk play games and just relax I often go to the park with friends We love going to the park on a sunny day There are many green trees in the park and flowers grow everywhere I love going to the park and enjoying the fresh air The park is a great place to relax";
    
    public const string Text2 = "Ilovegoingtotheparkt heparkisabeautifulplaceIntheparkyoucanwalkplaygamesandjustrelaxIoftengototheparkwithfriendsWelo egoingtotheparkonasunnydayTherearemanygreentreesintheparkandflowersgroweverywhereIlovegoingtotheparkan denjoyingthefreshairTheparkaisagreatplacetorelax";
    public const string ShortString1 = "TOBEORNOTTOBE";
    public const string LongString1 = "TOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBETOBEORNOTTOBE";
    public const string LongString2 = "TESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTESTTESTTESTTEST123123qweqweTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTESTTTEST123123qweqweTESTTESTTEST";
}