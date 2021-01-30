using EasyLanguageLearning.Domain;
using System;
using Xunit;

namespace EasyLanguageLearningKata.Test
{
    public class CourseShould
    {
        //Red phase
        [Fact]
        public void HaveMotherLanguageAndLearningLanguage()
        {
            //Arrange
            var course = default(Course);
            //Act

            //Assert
            Assert.NotNull(course);
        }
    }
}
