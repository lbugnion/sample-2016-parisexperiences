using System;
using HelloMvvm.ViewModel;
using NUnit.Framework;


namespace UnitTestApp1
{
    [TestFixture]
    public class TestsSample
    {
        [Test]
        public void TestUpdate()
        {
            var vm = new MainViewModel();

            var count = 1;
            vm.UpdateCommand.Execute(null);
            var should = string.Format(MainViewModel.MessageTemplate, count);
            Assert.AreEqual(should, vm.Title);

            count = 2;
            vm.UpdateCommand.Execute(null);
            should = string.Format(MainViewModel.MessageTemplate, count);
            Assert.AreEqual(should, vm.Title);
        }
    }
}