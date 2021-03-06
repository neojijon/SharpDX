// Copyright (c) 2010-2013 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
#if !W8CORE
using System;

namespace SharpDX.Direct3D11
{
    public partial struct ImageLoadInformation
    {
        /// <summary>
        /// The default value for load options.
        /// </summary>
        public const int FileDefaultValue = -1;

        /// <summary>
        /// Gets an ImageLoadInformation that is setup with all default values (<see cref="FileDefaultValue"/>).
        /// </summary>
        public static readonly ImageLoadInformation Default = GetDefault();

        private static ImageLoadInformation GetDefault()
        {
            var value = default(ImageLoadInformation);
            unsafe
            {
                Utilities.ClearMemory(new IntPtr(&value), 0xFF, Utilities.SizeOf<ImageLoadInformation>());
            }
            return value;
        }
    }
}
#endif