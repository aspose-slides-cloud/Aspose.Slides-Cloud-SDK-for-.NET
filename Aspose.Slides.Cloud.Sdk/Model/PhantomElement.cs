// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PhantomElement.cs">
//   Copyright (c) 2018 Aspose.Slides for Cloud
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Xml.Serialization;

namespace Aspose.Slides.Cloud.Sdk.Model
{
    /// <summary>
    /// Specifies an instance of mathematical text that contained within a MathParagraph and starts on its own line.
    /// </summary>  
    public class PhantomElement : MathElement 
    {                       
        /// <summary>
        /// Base element
        /// </summary>
        public MathElement Base { get; set; }

        /// <summary>
        /// true if the base element is displayed.
        /// </summary>
        public bool? Show { get; set; }

        /// <summary>
        /// true if the the width of the base element should be treated as zero.
        /// </summary>
        public bool? ZeroWidth { get; set; }

        /// <summary>
        /// true if the the ascent (height above baseline) of the base element should be treated as zero.
        /// </summary>
        public bool? ZeroAsc { get; set; }

        /// <summary>
        /// true if the the descent (depth below baseline) of the base element should be treated as zero.
        /// </summary>
        public bool? ZeroDesc { get; set; }

        /// <summary>
        /// true if operators and symbols inside the phantom still affect mathematical spacing around the phantom (as if visible).
        /// </summary>
        public bool? Transp { get; set; }


        /// <summary>
        /// Property values to determine the type when deserializing from Json
        /// </summary>
        public static new Dictionary<string, object> TypeDeterminers
        {
            get
            {
                if (s_typeDeterminers == null)
                {
                    s_typeDeterminers = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
                    s_typeDeterminers.Add("Type", TypeEnum.Phantom);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public PhantomElement() : base()
        {
            Type = TypeEnum.Phantom;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class PhantomElement {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Base: ").Append(this.Base).Append("\n");
            sb.Append("  Show: ").Append(this.Show).Append("\n");
            sb.Append("  ZeroWidth: ").Append(this.ZeroWidth).Append("\n");
            sb.Append("  ZeroAsc: ").Append(this.ZeroAsc).Append("\n");
            sb.Append("  ZeroDesc: ").Append(this.ZeroDesc).Append("\n");
            sb.Append("  Transp: ").Append(this.Transp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
