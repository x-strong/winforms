// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;

namespace System.Windows.Forms.Tests
{
    public class DataGridViewImageCellAccessibleObjectTests : DataGridViewImageCell
    {
        [WinFormsFact]
        public void DataGridViewImageCellAccessibleObject_Ctor_Default()
        {
            var accessibleObject = new DataGridViewImageCellAccessibleObject(null);
            Assert.Null(accessibleObject.Owner);
            Assert.Equal(AccessibleRole.Cell, accessibleObject.Role);
        }
    }
}
