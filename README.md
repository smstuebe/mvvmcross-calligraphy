# <img src="doc/icon.png" width="71" height="71"/> Calligraphy for MvvmCross &nbsp;&nbsp;&nbsp;[![NuGet](https://img.shields.io/nuget/v/MvvmCross.Calligraphy.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/MvvmCross.Calligraphy/)

Provides a special Calligraphy binding for MvvmCross.

## Why? 

See the blog post: http://smstuebe.de/2017/02/12/mvvmcross-calligraphy/

## Usage

    Install-Package MvvmCross.Calligraphy
    
and modify your Setup.cs

    public class Setup : MvxAndroidSetup
    {
        protected override MvxAndroidBindingBuilder CreateBindingBuilder()
        {
            return new CalligraphyMvxAndroidBindingBuilder();
        }
    } 
