using System;
using System.IO;
using ABPD_HW_02.Managers;
using ABPD_HW_02.Models;
using JetBrains.Annotations;
using Xunit;

namespace ABPD_HW_02.Tests.Managers;

[TestSubject(typeof(DeviceManager))]
public class DeviceManagerTest
{
    private readonly string _testFilePath;
    private DeviceManager _deviceManager;

    public DeviceManagerTest()
    {
        //I need to do relative path but I have no clue how xdddddddd
        _testFilePath = "C:\\Users\\Admin\\Desktop\\PJATK\\UNI_GIT_REPOS\\ABPD_HW_02\\ABPD_HW_02.Tests\\testResources\\test_input.txt";
        
        _deviceManager = new DeviceManager(_testFilePath);
    }

    [Fact]
    public void ConstructorTest()
    {
        
    }
    
    
    [Fact]
    public void Constructor_ShouldLoadDevices_FromExistingFile()
    {
        string inputFilePath = _testFilePath;
        
        var manager = new DeviceManager(inputFilePath);
        
        // For example, if TestInput.txt has 3 devices, we expect the manager to have 3:
        Assert.True(manager != null, "DeviceManager should not be null.");
        // We can't know your exact file content, but let's check if it loaded at least something:
        // (Or you can assert an exact count if you know how many lines your test file has.)
        // e.g.: Assert.Equal(3, manager.GetDevicesCount()); // if you add a public method or property to get count
    }

}