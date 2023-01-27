using System;
using System.Diagnostics;

class Verkkosivu
{
    static void Main(string[] args)
    {
        // Specify the URL of the website
        string verkkosivu = "https://www.keuda.fi/opiskelijalle/";

        // Open the website using the default web browser
        Process.Start(verkkosivu);
    }
}