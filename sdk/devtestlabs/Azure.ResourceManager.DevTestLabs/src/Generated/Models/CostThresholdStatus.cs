// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Indicates whether this threshold will be displayed on cost charts. </summary>
    public readonly partial struct CostThresholdStatus : IEquatable<CostThresholdStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CostThresholdStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CostThresholdStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static CostThresholdStatus Enabled { get; } = new CostThresholdStatus(EnabledValue);
        /// <summary> Disabled. </summary>
        public static CostThresholdStatus Disabled { get; } = new CostThresholdStatus(DisabledValue);
        /// <summary> Determines if two <see cref="CostThresholdStatus"/> values are the same. </summary>
        public static bool operator ==(CostThresholdStatus left, CostThresholdStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CostThresholdStatus"/> values are not the same. </summary>
        public static bool operator !=(CostThresholdStatus left, CostThresholdStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CostThresholdStatus"/>. </summary>
        public static implicit operator CostThresholdStatus(string value) => new CostThresholdStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CostThresholdStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CostThresholdStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
