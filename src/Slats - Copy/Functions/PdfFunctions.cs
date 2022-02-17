using System;
using System.Collections.Generic;
using System.Text;
//using PdfSharp.Pdf.IO;
//using PdfSharp.Pdf;
//using PdfSharp.Pdf.Security;

namespace Slats.Functions
{
    class PdfFunctions
    {
   
public void EncryptPDF(string filename, string password)
{
    // Encrypt a file.
    // Open an existing document. Providing an unrequired password is ignored.
 ///   PdfDocument document = PdfReader.Open(filename, "some text");

 ///   PdfSecuritySettings securitySettings = document.SecuritySettings;

    // Setting one of the passwords automatically sets the security level to 
    // PdfDocumentSecurityLevel.Encrypted128Bit.
 ///   securitySettings.UserPassword = password;
    //   securitySettings.OwnerPassword = "owner";

    // Don't use 40 bit encryption unless needed for compatibility reasons
    //securitySettings.DocumentSecurityLevel = PdfDocumentSecurityLevel.Encrypted40Bit;

    // Restrict some rights.
///    securitySettings.PermitAccessibilityExtractContent = false;
/// securitySettings.PermitAnnotations = false;
/// securitySettings.PermitAssembleDocument = false;
/// securitySettings.PermitExtractContent = false;
/// securitySettings.PermitFormsFill = true;
/// securitySettings.PermitFullQualityPrint = false;
/// securitySettings.PermitModifyDocument = true;
/// securitySettings.PermitPrint = false;

    // Save the document...
///    document.Save(filename);
        }
    }
}