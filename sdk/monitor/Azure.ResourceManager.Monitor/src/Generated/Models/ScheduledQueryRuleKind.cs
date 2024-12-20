// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Indicates the type of scheduled query rule. The default is LogAlert. </summary>
    public readonly partial struct ScheduledQueryRuleKind : IEquatable<ScheduledQueryRuleKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScheduledQueryRuleKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScheduledQueryRuleKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LogAlertValue = "LogAlert";
        private const string EventLogAlertValue = "EventLogAlert";
        private const string LogToMetricValue = "LogToMetric";

        /// <summary> LogAlert. </summary>
        public static ScheduledQueryRuleKind LogAlert { get; } = new ScheduledQueryRuleKind(LogAlertValue);
        /// <summary> EventLogAlert. </summary>
        public static ScheduledQueryRuleKind EventLogAlert { get; } = new ScheduledQueryRuleKind(EventLogAlertValue);
        /// <summary> LogToMetric. </summary>
        public static ScheduledQueryRuleKind LogToMetric { get; } = new ScheduledQueryRuleKind(LogToMetricValue);
        /// <summary> Determines if two <see cref="ScheduledQueryRuleKind"/> values are the same. </summary>
        public static bool operator ==(ScheduledQueryRuleKind left, ScheduledQueryRuleKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScheduledQueryRuleKind"/> values are not the same. </summary>
        public static bool operator !=(ScheduledQueryRuleKind left, ScheduledQueryRuleKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ScheduledQueryRuleKind"/>. </summary>
        public static implicit operator ScheduledQueryRuleKind(string value) => new ScheduledQueryRuleKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScheduledQueryRuleKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScheduledQueryRuleKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
