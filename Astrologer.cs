using System;
using System.Collections.Generic;
using System.Text;

namespace SignCalculator
{
    class Astrologer
    {
        private Sign[] zodiac = new Sign[12];
        public Astrologer()
        {
            zodiac[0] = new Sign{ name = "Aries", dayBegin = 21, monthBegin = 3, dayEnd = 19, monthEnd = 4, caracterisct = "The pioneer and trailblazer of the horoscope wheel, Aries energy helps us initiate, fight for our beliefs and fearlessly put ourselves out there." };
            zodiac[1] = new Sign{ name = "Taurus", dayBegin = 20, monthBegin = 4, dayEnd = 20, monthEnd = 5, caracterisct = "The persistent provider of the horoscope family, Taurus energy helps us seek security, enjoy earthly pleasures and get the job done." };
            zodiac[2] = new Sign{ name = "Gemini", dayBegin = 21, monthBegin = 5, dayEnd = 20, monthEnd = 6, caracterisct = "The most versatile and vibrant horoscope sign, Gemini energy helps us communicate, collaborate and fly our freak flags at full mast." };
            zodiac[3] = new Sign{ name = "Cancer", dayBegin = 21, monthBegin = 6, dayEnd = 22, monthEnd = 7, caracterisct = "The natural nurturer of the horoscope wheel, Cancer energy helps us connect with our feelings, plant deep roots and feather our family nests." };
            zodiac[4] = new Sign{ name = "Leo", dayBegin = 23, monthBegin = 7, dayEnd = 22, monthEnd = 8, caracterisct = "The drama queen and regal ruler of the horoscope clan, Leo energy helps us shine, express ourselves boldly and wear our hearts on our sleeves." };
            zodiac[5] = new Sign{ name = "Vigor", dayBegin = 23, monthBegin = 8, dayEnd = 22, monthEnd = 9, caracterisct = "The masterful helper of the horoscope wheel, Virgo energy teaches us to serve, do impeccable work and prioritize wellbeing—of ourselves, our loved ones and the planet." };
            zodiac[6] = new Sign{ name = "Libra", dayBegin = 23, monthBegin = 9, dayEnd = 22, monthEnd = 10, caracterisct = "The balanced beautifier of the horoscope family, Libra energy inspires us to seek peace, harmony and cooperation—and to do it with style and grace." };
            zodiac[7] = new Sign{ name = "Scorpio", dayBegin = 23, monthBegin = 10, dayEnd = 21, monthEnd = 11, caracterisct = "The most intense and focused of the horoscope signs, Scorpio energy helps us dive deep, merge our superpowers and form bonds that are built to last." };
            zodiac[8] = new Sign{ name = "Sagittarius", dayBegin = 22, monthBegin = 11, dayEnd = 21, monthEnd = 12, caracterisct = "The worldly adventurer of the horoscope wheel, Sagittarius energy inspires us to dream big, chase the impossible and take fearless risks." };
            zodiac[9] = new Sign{ name = "Capricorn", dayBegin = 22, monthBegin = 12, dayEnd = 19, monthEnd = 1, caracterisct = "The measured master planner of the horoscope family, Capricorn energy teaches us the power of structure and long-term goals." };
            zodiac[10] = new Sign{ name = "Aquarius", dayBegin = 20, monthBegin = 1, dayEnd = 18, monthEnd = 2, caracterisct = "The mad scientist and humanitarian of the horoscope wheel, futuristic Aquarius energy helps us innovate and unite for social justice." };
            zodiac[11] = new Sign{ name = "Pisces", dayBegin = 19, monthBegin = 2, dayEnd = 20, monthEnd = 3, caracterisct = "The dreamer and healer of the horoscope family, Pisces energy awakens compassion, imagination and artistry, uniting us as one" };
        }

        public Sign findSign(int birthday, int birthdayMonth)
        {
            Sign sign = null;

            for (int c = 0; c < zodiac.Length; c++) {
                if ((birthdayMonth == zodiac[c].monthBegin && birthday >= zodiac[c].dayBegin) ||
                    (birthdayMonth == zodiac[c].monthEnd && birthday <= zodiac[c].dayEnd)
                ) {
                    sign = zodiac[c];
                    break;
                } 
            }

            return sign;
        }
    }
}
