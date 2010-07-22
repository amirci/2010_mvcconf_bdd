using MavenThought.MediaLibrary.Acceptance.Tests.Utility;

namespace MavenThought.MediaLibrary.Acceptance.Tests.PageObjects
{
    /// <summary>
    /// Page to abstract add movies page implementation on the web application
    /// </summary>
    public class AddMoviePage
    {
        public string Title
        {
            get { return Browser.Instance.TextField("Title").Value; }

            set { Browser.Instance.TextField("Title").Value = value; }
        }

        public void Submit()
        {
            Browser.Instance.Button("Submit").Click();
        }
    }
}