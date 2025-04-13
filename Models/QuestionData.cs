using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{

    public static class QuestionData
    {
        public static List<Question> Questions = new List<Question>
        {
            new Question
            {
                Id = 1,
                Text = "You see a friend in need on the street, what do you do?",
                Options = new List<Option>
                {
                    new Option { Text = "Approach and ask how to help", Traits = new List<string> { "Caring", "Loyal" } },
                    new Option { Text = "Analyze and act", Traits = new List<string> { "Sharp", "Clever" } },
                    new Option { Text = "Watch and learn", Traits = new List<string> { "Innocent", "Clever" } },
                    new Option { Text = "Take charge", Traits = new List<string> { "Leader", "Fearless" } },
                    new Option { Text = "Cheer them up", Traits = new List<string> { "Joyful", "Playful" } }
                }
            },
            new Question
            {
                Id = 2,
                Text = "At a social gathering, you notice someone standing alone. How do you react?",
                Options = new List<Option>
                {
                    new Option { Text = "Introduce yourself and invite them to join in", Traits = new List<string> { "Caring", "Loyal" } },
                    new Option { Text = "Approach them gently and start a conversation", Traits = new List<string> { "Clever", "Independent" } },
                    new Option { Text = "Wait for them to make the first move", Traits = new List<string> { "Innocent", "Cautious" } },
                    new Option { Text = "Take the lead and organize a group activity", Traits = new List<string> { "Leader", "Fearless" } },
                    new Option { Text = "Lighten the mood with humor", Traits = new List<string> { "Joyful", "Playful" } }
                }
            },
            new Question
            {
                Id = 3,
                Text = "You encounter an unexpected challenge at work. How do you approach it?",
                Options = new List<Option>
                {
                    new Option { Text = "Carefully plan a strategy before acting", Traits = new List<string> { "Clever", "Sharp" } },
                    new Option { Text = "Rally your team to overcome the challenge together", Traits = new List<string> { "Leader", "Caring" } },
                    new Option { Text = "Tackle the problem head-on without hesitation", Traits = new List<string> { "Fearless", "Leader" } },
                    new Option { Text = "Innovate a creative solution by thinking outside the box", Traits = new List<string> { "Clever", "Curious" } },
                    new Option { Text = "Take a moment to observe and learn from the situation", Traits = new List<string> { "Innocent", "Wise" } }
                }
            },
            new Question
            {
                Id = 4,
                Text = "When making important decisions, which approach resonates most with you?",
                Options = new List<Option>
                {
                    new Option { Text = "Trusting your intuition and heart", Traits = new List<string> { "Innocent", "Caring" } },
                    new Option { Text = "Relying on deep analysis and logic", Traits = new List<string> { "Clever", "Sharp" } },
                    new Option { Text = "Making bold moves even if they’re risky", Traits = new List<string> { "Fearless", "Leader" } },
                    new Option { Text = "Thinking creatively and innovatively", Traits = new List<string> { "Curious", "Playful" } },
                    new Option { Text = "Sticking with tradition and proven methods", Traits = new List<string> { "Loyal", "Wise" } }
                }
            },
            new Question
            {
                Id = 5,
                Text = "How do you approach learning something entirely new?",
                Options = new List<Option>
                {
                    new Option { Text = "Jump in with both feet and learn by doing", Traits = new List<string> { "Fearless", "Curious" } },
                    new Option { Text = "Study carefully and ask lots of questions", Traits = new List<string> { "Clever", "Sharp" } },
                    new Option { Text = "Observe first and then slowly participate", Traits = new List<string> { "Innocent", "Wise" } },
                    new Option { Text = "Learn by helping others along the way", Traits = new List<string> { "Caring", "Loyal" } },
                    new Option { Text = "Make the experience fun and engaging", Traits = new List<string> { "Joyful", "Playful" } }
                }
            },
            new Question
            {
                Id = 6,
                Text = "How would you describe your decision-making style?",
                Options = new List<Option>
                {
                    new Option { Text = "Decisions are made with empathy", Traits = new List<string> { "Caring", "Loyal" } },
                    new Option { Text = "I weigh all details and think it through", Traits = new List<string> { "Sharp", "Clever" } },
                    new Option { Text = "I rely on my gut instinct", Traits = new List<string> { "Innocent", "Fearless" } },
                    new Option { Text = "I take charge and decide for the group", Traits = new List<string> { "Leader", "Protective" } },
                    new Option { Text = "I experiment and learn from trial and error", Traits = new List<string> { "Curious", "Playful" } }
                }
            },
            new Question
            {
                Id = 7,
                Text = "What would your close friends say best describes you?",
                Options = new List<Option>
                {
                    new Option { Text = "Dependable and caring", Traits = new List<string> { "Caring", "Loyal" } },
                    new Option { Text = "Smart and quick-witted", Traits = new List<string> { "Clever", "Sharp" } },
                    new Option { Text = "Brave and always ready to help", Traits = new List<string> { "Fearless", "Protective" } },
                    new Option { Text = "A natural leader", Traits = new List<string> { "Leader", "Confident" } },
                    new Option { Text = "Fun-loving and playful", Traits = new List<string> { "Joyful", "Playful" } }
                }
            },
            new Question
            {
                Id = 8,
                Text = "Which environment appeals to you the most?",
                Options = new List<Option>
                {
                    new Option { Text = "A quiet forest", Traits = new List<string> { "Innocent", "Wise" } },
                    new Option { Text = "A bustling city", Traits = new List<string> { "Clever", "Curious" } },
                    new Option { Text = "A challenging mountain", Traits = new List<string> { "Fearless", "Leader" } },
                    new Option { Text = "A peaceful beach", Traits = new List<string> { "Caring", "Joyful" } },
                    new Option { Text = "An innovative tech hub", Traits = new List<string> { "Sharp", "Independent" } }
                }
            }
        };

        public static Dictionary<string, List<string>> AnimalTraits = new Dictionary<string, List<string>>
        {
            { "Rabbit", new List<string>{ "Innocent", "Caring", "Joyful" } },
            { "Lion", new List<string>{ "Fearless", "Leader", "Protective" } },
            { "Dolphin", new List<string>{ "Joyful", "Playful", "Caring" } },
            { "Owl", new List<string>{ "Sharp", "Wise", "Clever" } },
            { "Fox", new List<string>{ "Clever", "Curious", "Independent" } },
            { "Elephant", new List<string>{ "Loyal", "Caring", "Leader" } },
            { "Turtle", new List<string>{ "Wise", "Innocent", "Loyal" } },
            { "Dog", new List<string>{ "Loyal", "Protective", "Caring" } }
        };

    }
}