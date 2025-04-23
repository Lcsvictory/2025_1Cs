using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime 클래스 메소드 예시
            DateTime d = DateTime.Now.AddDays(-(new Random()).Next(20, 100));
            DateTime d1 = new DateTime(2025,10,10);
            DateTime d2 = new DateTime(2024,5,5);
            
            // AddDays(double days) : 지정된 일수를 더한 새 DateTime 반환
            DateTime tomorrow = d.AddDays(1);
            
            // AddMonths(int months) : 지정된 개월 수를 더한 새 DateTime 반환
            DateTime nextMonth = d.AddMonths(1);
            
            // ToString() 메소드의 다양한 포맷 예시
            // "d" : 간단한 날짜 - 2024/03/15
            string shortDate = d.ToString("d");
            
            // "D" : 자세한 날짜 - 2024년 3월 15일 금요일
            string longDate = d.ToString("D");
            
            // "t" : 간단한 시간 - 오후 4:30
            string shortTime = d.ToString("t");
            
            // "T" : 자세한 시간 - 오후 4:30:25
            string longTime = d.ToString("T");
            
            // "f" : 간단한 날짜와 시간 - 2024년 3월 15일 금요일 오후 4:30
            string shortDateTime = d.ToString("f");
            
            // "F" : 자세한 날짜와 시간 - 2024년 3월 15일 금요일 오후 4:30:25
            string longDateTime = d.ToString("F");
            
            // 사용자 지정 포맷
            // "yyyy-MM-dd" : 2024-03-15
            string customFormat1 = d.ToString("yyyy-MM-dd");
            
            // "yyyy년 MM월 dd일 HH:mm:ss" : 2024년 03월 15일 16:30:25
            string customFormat2 = d.ToString("yyyy년 MM월 dd일 HH:mm:ss");
            
            // "ddd, dd MMM yyyy" : 금, 15 3월 2024
            string customFormat3 = d.ToString("ddd, dd MMM yyyy");

            // Random 클래스 메소드 예시
            Random random = new Random();
            
            // Next(int maxValue) : 0부터 maxValue-1 사이의 난수 반환
            int rand1 = random.Next(100);
            
            // Next(int minValue, int maxValue) : minValue부터 maxValue-1 사이의 난수 반환
            int rand2 = random.Next(1, 10);
            
            // NextDouble() : 0.0부터 0.99999999999999999 까지의 난수 반환
            double rand3 = random.NextDouble();

            // TimeSpan 클래스 메소드 예시
            TimeSpan diff = d1 - d2;
            
            // Add(TimeSpan ts) : 지정된 TimeSpan을 더한 새 TimeSpan 반환
            TimeSpan newDiff = diff.Add(TimeSpan.FromDays(1));
            
            // FromHours(double hours) : 지정된 시간으로 TimeSpan 생성
            TimeSpan duration = TimeSpan.FromHours(2.5);
            
            // TotalDays : TimeSpan의 총 일수를 double로 반환
            double totalDays = diff.TotalDays;

            // String 클래스 메소드 예시
            string s = "hello world";
            
            // Substring(int startIndex, int length) : 지정된 위치에서 지정된 길이만큼의 문자열 반환
            string sub = s.Substring(0, 5);  // "hello"
            
            // ToUpper() : 모든 문자를 대문자로 변환
            string upper = s.ToUpper();  // "HELLO WORLD"
            
            // Replace(string oldValue, string newValue) : 지정된 문자열을 새 문자열로 교체
            string replaced = s.Replace("hello", "hi");  // "hi world"
            
            // Split(char separator) : 지정된 구분자로 문자열을 분할하여 배열로 반환
            string[] words = s.Split(' ');  // ["hello", "world"]
        }
    }
}
