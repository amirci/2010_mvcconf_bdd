using System;
using MavenThought.MediaLibrary.Acceptance.Tests.PageObjects;
using TechTalk.SpecFlow;

namespace MavenThought.MediaLibrary.Acceptance.Tests.Steps
{
    /// <summary>
    /// Steps related to movie
    /// </summary>
    [Binding]
    public class MovieSteps
    {
        public MovieSteps()
        {
            this.Page = new AddMoviePage();
        }

        protected AddMoviePage Page { get; set; }

        [When(@"I enter (.*) in the title")]
        public void EnterTitle(string title)
        {
            this.Page.Title = title;
        }

        [When(@"I click Submit")]
        public void SubmitNewMovie()
        {
            this.Page.Submit();
        }
    }
}