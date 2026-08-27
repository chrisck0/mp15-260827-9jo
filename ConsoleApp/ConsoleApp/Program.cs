using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== 9조 팀원 소개 ===");
        // 여기에 팀원 소개 호출을 한 줄씩 추가합니다
        ChouChou10();
        IntroLeeJoonBin();
        chrisck0();

        Console.WriteLine("=== 소개 끝 ===");
    }
    

    public static void IntroLeeJoonBin()
    {
        Console.WriteLine("이준빈입니다. / 잘 부탁드립니다.");
    }
    // 여기에 팀원 소개 메서드를 하나씩 추가합니다  
    public static void ChouChou10()
    {
        Console.WriteLine("이름: 한장수 / 취미는 여행이고 잘부탁드립니다~~~ ");
    }
    public static void chrisck0()
    {
        Console.WriteLine("강채아 / 치즈를 좋아합니다.");
    }
}