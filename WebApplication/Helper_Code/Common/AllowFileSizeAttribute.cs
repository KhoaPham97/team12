//-----------------------------------------------------------------------
// <copyright file="AllowFileSizeAttribute.cs" company="None">
//     Copyright (c) Allow to distribute this code and utilize this code for personal or commercial purpose.
// </copyright>
// <author>Asma Khalid</author>
//-----------------------------------------------------------------------

namespace WebApplication.Helper_Code.Common
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using System.Web.Hosting;


    /// <summary>
    /// Allow file size attribute class
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class AllowFileSizeAttribute : ValidationAttribute
    {

        #region Public / Protected Properties

        /// <summary>
        /// Gets or sets file size property. Default is 1GB (the value is in Bytes).
        /// </summary>
        public int FileSize { get; set; } = 1 * 1024 * 1024 * 1024;
        public string Extensions { get; set; } = "png,jpg,jpeg,gif,docx";
        #endregion

        #region Is valid method

        /// <summary>
        /// Is valid method.
        /// </summary>
        /// <param name="value">Value parameter</param>
        /// <returns>Returns - true is specify extension matches.</returns>
        public override bool IsValid(object value)
        {
            // Initialization
            HttpPostedFileBase file = value as HttpPostedFileBase;
            bool isValid = true;
            List<string> allowedExtensions = this.Extensions.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            // Settings.
            int allowedFileSize = this.FileSize;

            // Verification.
            if (file != null)
            {
                // Initialization.
                var fileSize = file.ContentLength;
                var fileName = file.FileName;

                // Settings.
                isValid = allowedExtensions.Any(y => fileName.EndsWith(y)) && fileSize <= allowedFileSize;

                if (isValid == true)
                {
                    file.SaveAs(HostingEnvironment.MapPath("~/Content/")
                                                          + file.FileName);
                }
            }

            // Info
            return isValid;
        }

        #endregion
    }
}