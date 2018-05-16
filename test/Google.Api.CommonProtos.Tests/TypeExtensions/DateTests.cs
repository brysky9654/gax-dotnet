﻿/*
 * Copyright 2018 Google Inc. All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

using Google.Type;
using System;
using Xunit;

namespace Google.Api.CommonProtos.Tests.TypeExtensions
{
    public class DateTests
    {
        public class InvalidDateTheoryData : TheoryData<int, int, int>
        {
            public InvalidDateTheoryData()
            {
                // In the order of Year, Month, Day.
                Add(-1, -1, -1);
                Add(0, 0, 0);
                Add(0, 4, 28);
                Add(2018, 0, 28);
                Add(2018, 4, 0);
                Add(10000, 4, 28);
                Add(2018, 13, 28);
                Add(2018, 4, 32);
            }
        }

        public class ValidDateTheoryData : TheoryData<int, int, int>
        {
            public ValidDateTheoryData()
            {
                // In the order of Year, Month, Day.
                Add(0001, 1, 1);
                Add(2000, 2, 29);
                Add(2018, 4, 28);
                Add(9999, 12, 31);
            }
        }

        [Fact]
        public void ToDateTimeThrowsInvalidOperationExceptionWhenDateIsNotInitialized()
        {
            Assert.Throws<InvalidOperationException>(
                () => new Date().ToDateTime());
        }

        [Theory, ClassData(typeof(InvalidDateTheoryData))]
        public void ToDateTimeThrowsInvalidOperationExceptionWhenDateIsInvalidState(int year, int month, int day)
        {
            Assert.Throws<InvalidOperationException>(
                () => new Date
                {
                    Year = year,
                    Month = month,
                    Day = day
                }.ToDateTime());
        }

        [Fact]
        public void ToDateTimeOffsetThrowsInvalidOperationExceptionWhenDateIsNotInitialized()
        {
            Assert.Throws<InvalidOperationException>(
                () => new Date().ToDateTimeOffset());
        }

        [Theory, ClassData(typeof(InvalidDateTheoryData))]
        public void ToDateTimeOffsetThrowsInvalidOperationExceptionWhenDateIsInvalidState(int year, int month, int day)
        {
            Assert.Throws<InvalidOperationException>(
                () => new Date
                {
                    Year = year,
                    Month = month,
                    Day = day
                }.ToDateTimeOffset());
        }

        [Theory, ClassData(typeof(ValidDateTheoryData))]
        public void IsConvertedToDateTime(int year, int month, int day)
        {
            var subjectUnderTest = new Date
            {
                Year = year,
                Month = month,
                Day = day
            };
            var actualDateTime = subjectUnderTest.ToDateTime();
            Assert.Equal(year, actualDateTime.Year);
            Assert.Equal(month, actualDateTime.Month);
            Assert.Equal(day, actualDateTime.Day);
            Assert.Equal(0, actualDateTime.Hour);
            Assert.Equal(0, actualDateTime.Minute);
            Assert.Equal(0, actualDateTime.Second);
            Assert.Equal(0, actualDateTime.Millisecond);
            Assert.Equal(DateTimeKind.Unspecified, actualDateTime.Kind);
        }

        [Theory, ClassData(typeof(ValidDateTheoryData))]
        public void IsConvertedToDateTimeOffset(int year, int month, int day)
        {
            var subjectUnderTest = new Date
            {
                Year = year,
                Month = month,
                Day = day
            };
            var actualDateTimeOffset = subjectUnderTest.ToDateTimeOffset();
            Assert.Equal(year, actualDateTimeOffset.Year);
            Assert.Equal(month, actualDateTimeOffset.Month);
            Assert.Equal(day, actualDateTimeOffset.Day);
            Assert.Equal(0, actualDateTimeOffset.Hour);
            Assert.Equal(0, actualDateTimeOffset.Minute);
            Assert.Equal(0, actualDateTimeOffset.Second);
            Assert.Equal(0, actualDateTimeOffset.Millisecond);
            Assert.Equal(TimeSpan.Zero, actualDateTimeOffset.TimeOfDay);
            Assert.Equal(TimeSpan.Zero, actualDateTimeOffset.Offset);
            Assert.Equal(DateTimeKind.Unspecified, actualDateTimeOffset.DateTime.Kind);
        }

        [Theory, ClassData(typeof(ValidDateTheoryData))]
        public void IsConvertedToDateFromDateTime(int year, int month, int day)
        {
            var subjectUnderTest = new DateTime(year, month, day);
            var actualDate = subjectUnderTest.ToDate();
            Assert.Equal(year, actualDate.Year);
            Assert.Equal(month, actualDate.Month);
            Assert.Equal(day, actualDate.Day);
        }

        [Theory, ClassData(typeof(ValidDateTheoryData))]
        public void IsConvertedToDateFromDateTimeOffset(int year, int month, int day)
        {
            var someHours = 2;
            var someMinutes = 59;
            var someSeconds = 30;
            var someTimeSpan = TimeSpan.Zero;
            var subjectUnderTest = new DateTimeOffset(year, month, day, someHours, someMinutes, someSeconds, someTimeSpan);
            var actualDate = subjectUnderTest.ToDate();
            Assert.Equal(year, actualDate.Year);
            Assert.Equal(month, actualDate.Month);
            Assert.Equal(day, actualDate.Day);
        }
    }
}
