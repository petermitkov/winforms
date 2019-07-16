﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using WinForms.Common.Tests;
using Xunit;

namespace System.Windows.Forms.Tests
{
    public class TextBoxTests
    {
        [Fact]
        public void TextBox_Constructor()
        {
            var tb = new TextBox();

            Assert.NotNull(tb);
        }

        [Fact]
        public void TextBox_PlaceholderText()
        {
            var tb = new TextBox
            {
                PlaceholderText = "Enter your name"
            };
            Assert.False(string.IsNullOrEmpty(tb.PlaceholderText));
        }

        [Fact]
        public void TextBox_PlaceholderText_DefaultValue()
        {
            var tb = new TextBox();
            Assert.Equal(string.Empty, tb.PlaceholderText);
        }

        [Fact]
        public void TextBox_PlaceholderText_When_InAccessibility_Doesnot_Raise_TextChanged()
        {
            var tb = new SubTextBox();
            bool eventRaised = false;
            EventHandler handler = (o, e) => eventRaised = true;
            tb.TextChanged += handler;
            tb.CreateAccessibilityInternal();
            Assert.False(eventRaised);
            tb.TextChanged -= handler;
        }

        [Fact]
        public void TextBox_Text_IsNot_Accessed_When_Handling_WP_PAINT()
        {
            var tb = new SubTextBox();
            Message m = new Message();
            m.Msg = Interop.WindowMessages.WM_PAINT;
            tb.DrawPlaceholderText(ref m);

            Assert.False(tb.textAccessed);
        }

        [Fact]
        public void TextBox_PlaceholderText_NullValue_CoercedTo_StringEmpty()
        {
            var tb = new TextBox()
            {
                PlaceholderText = "Text"
            };

            tb.PlaceholderText = null;
            Assert.Equal(string.Empty, tb.PlaceholderText);
        }

        [Fact]
        public void TextBox_PlaceholderText_Overriden()
        {
            var tb = new SubTextBox();

            Assert.NotNull(tb);
        }

        [Fact]
        public void TextBox_PlaceholderTextAlignments()
        {
            var tb = new TextBox
            {
                PlaceholderText = "Enter your name"
            };

            System.Runtime.InteropServices.HandleRef refHandle = new System.Runtime.InteropServices.HandleRef(tb, tb.Handle);

            //Cover the Placeholder draw code path 
            UnsafeNativeMethods.SendMessage(refHandle, Interop.WindowMessages.WM_PAINT, false, 0);
            tb.TextAlign = HorizontalAlignment.Center;
            UnsafeNativeMethods.SendMessage(refHandle, Interop.WindowMessages.WM_PAINT, false, 0);
            tb.TextAlign = HorizontalAlignment.Right;
            UnsafeNativeMethods.SendMessage(refHandle, Interop.WindowMessages.WM_PAINT, false, 0);

            Assert.False(string.IsNullOrEmpty(tb.PlaceholderText));
        }

        [Fact]
        public void TextBox_PlaceholderTextAlignmentsInRightToLeft()
        {
            var tb = new TextBox
            {
                PlaceholderText = "Enter your name",
                RightToLeft = RightToLeft.Yes
            };

            System.Runtime.InteropServices.HandleRef refHandle = new System.Runtime.InteropServices.HandleRef(tb, tb.Handle);

            //Cover the Placeholder draw code path in RightToLeft scenario
            UnsafeNativeMethods.SendMessage(refHandle, Interop.WindowMessages.WM_PAINT, false, 0);
            tb.TextAlign = HorizontalAlignment.Center;
            UnsafeNativeMethods.SendMessage(refHandle, Interop.WindowMessages.WM_PAINT, false, 0);
            tb.TextAlign = HorizontalAlignment.Right;
            UnsafeNativeMethods.SendMessage(refHandle, Interop.WindowMessages.WM_PAINT, false, 0);

            Assert.False(string.IsNullOrEmpty(tb.PlaceholderText));
        }

        private SubTextBoxBase CreateTextBoxForCtrlBackspace(string text = "", int cursorRelativeToEnd = 0)
        {
            var tb = new SubTextBoxBase
            {
                Text = text
            };
            tb.Focus();
            tb.SelectionStart = tb.Text.Length + cursorRelativeToEnd;
            tb.SelectionLength = 0;
            return tb;
        }

        private void SendCtrlBackspace(SubTextBoxBase tb)
        {
            var message = new Message();
            tb.ProcessCmdKey(ref message, Keys.Control | Keys.Back);
        }

        [Fact]
        public void TextBox_CtrlBackspaceTextRemainsEmpty()
        {
            SubTextBoxBase tb = CreateTextBoxForCtrlBackspace();
            SendCtrlBackspace(tb);
            Assert.Equal("", tb.Text);
        }

        [Fact]
        public void TextBox_CtrlBackspaceReadOnlyTextUnchanged()
        {
            string text = "aaa";
            SubTextBoxBase tb = CreateTextBoxForCtrlBackspace(text);
            tb.ReadOnly = true;
            SendCtrlBackspace(tb);
            Assert.Equal(text, tb.Text);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetCtrlBackspaceData))]
        public void TextBox_CtrlBackspaceTextChanged(string value, string expected, int cursorRelativeToEnd)
        {
            SubTextBoxBase tb = CreateTextBoxForCtrlBackspace(value, cursorRelativeToEnd);
            SendCtrlBackspace(tb);
            Assert.Equal(expected, tb.Text);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetCtrlBackspaceRepeatedData))]
        public void TextBox_CtrlBackspaceRepeatedTextChanged(string value, string expected, int repeats)
        {
            SubTextBoxBase tb = CreateTextBoxForCtrlBackspace(value);
            for (int i = 0; i < repeats; i++)
            {
                SendCtrlBackspace(tb);
            }
            Assert.Equal(expected, tb.Text);
        }

        [Fact]
        public void TextBox_CtrlBackspaceDeletesSelection()
        {
            SubTextBoxBase tb = CreateTextBoxForCtrlBackspace("123-5-7-9");
            tb.SelectionStart = 2;
            tb.SelectionLength = 5;
            SendCtrlBackspace(tb);
            Assert.Equal("12-9", tb.Text);
        }

        private class SubTextBoxBase : TextBoxBase
        {
            public new bool ProcessCmdKey(ref Message msg, Keys keyData) => base.ProcessCmdKey(ref msg, keyData);
        }

        private class SubTextBox : TextBox
        {
            public override string PlaceholderText { get => base.PlaceholderText; set => base.PlaceholderText = value; }

            // used to test that PlaceholderText won't raise TextChanged event.
            internal void CreateAccessibilityInternal()
            {
                this.CreateAccessibilityInstance();
            }

            public override bool Focused => false;

            public bool textAccessed;

            public override string Text
            {
                get
                {
                    textAccessed = true;
                    return base.Text;
                }
                set => base.Text = value;
            }
        }
    }
}
