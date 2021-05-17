using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace LAB5
{
    public class BaseTest
    {
        [BeforeScenario]
        public void InstantiateBrowser()
        {
            
        }

        [AfterScenario]
        public void TearDown()
        {
        }
    }
}
