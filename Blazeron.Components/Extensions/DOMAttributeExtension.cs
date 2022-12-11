namespace Blazeron.Components.Extensions
{
    using Blazeron.Components.Constants;
    using Blazeron.Components.Enums;
    using Blazeron.Utilities.Extensions;

    /// <summary>
    /// Defines the <see cref="DOMAttributeExtension" />.
    /// </summary>
    internal static class DOMAttributeExtension
    {
        /// <summary>
        /// Gets the size of the border.
        /// </summary>
        /// <param name="sizeType">The sizeType<see cref="BorderSizeType"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetBorderSize(this BorderSizeType sizeType)
        {
            if (sizeType.Equals(BorderSizeType.None)) return default;

            return $"{UIConstants.RoundedPrefix}-{(int)sizeType - 1}";
        }

        /// <summary>
        /// Gets the table variant.
        /// </summary>
        /// <param name="colorType">The colorType<see cref="ColorType"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetTableVariant(this ColorType colorType)
        {
            if (colorType == ColorType.None)
                return default;

            return $"{UIConstants.TablePrefix}-{colorType.GetDisplayName()}";
        }

        /// <summary>
        /// Gets the background variant.
        /// </summary>
        /// <param name="colorType">The colorType<see cref="ColorType"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetBackgroundVariant(this ColorType colorType)
        {
            if (colorType == ColorType.None)
                return default;

            return $"{UIConstants.BackgroundPrefix}-{colorType.GetDisplayName()}";
        }

        /// <summary>
        /// Gets the table align.
        /// </summary>
        /// <param name="alignType">The alignType<see cref="TableAlignType"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetTableAlign(this TableAlignType alignType)
        {
            if (alignType == TableAlignType.None)
                return default;

            return $"{UIConstants.AlignPrefix}-{alignType.GetDisplayName()}";
        }

        /// <summary>
        /// Gets the text align.
        /// </summary>
        /// <param name="alignType">The alignType<see cref="TextAlignType"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetTextAlign(this TextAlignType alignType)
        {
            if (alignType == TextAlignType.None)
                return default;

            return $"{UIConstants.TextPrefix}-{alignType.GetDisplayName()}";
        }

        /// <summary>
        /// Gets the color of the text.
        /// </summary>
        /// <param name="colorType">The colorType<see cref="TextColorType"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetTextColor(this TextColorType colorType)
        {
            if (colorType == TextColorType.None)
                return default;

            return $"{UIConstants.TextPrefix}-{colorType.GetDisplayName()}";
        }

        /// <summary>
        /// Gets the alert variant.
        /// </summary>
        /// <param name="colorType">The colorType<see cref="ColorType"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetAlertVariant(this ColorType colorType)
        {
            if (colorType == ColorType.None)
                return $"{UIConstants.AlertPrefix}-{ColorType.Primary.GetDisplayName()}";

            return $"{UIConstants.AlertPrefix}-{colorType.GetDisplayName()}";
        }

        /// <summary>
        /// Gets the type of the animation effect.
        /// </summary>
        /// <param name="effectType">The effectType<see cref="AnimationEffectType"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetAnimationEffectType(this AnimationEffectType effectType)
        {
            if (effectType == AnimationEffectType.None)
                return default;

            return effectType.GetDisplayName();
        }

        /// <summary>
        /// Gets the type of the badge radius.
        /// </summary>
        /// <param name="radiusType">Type of the radius<see cref="BadgeRadiusType"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetBadgeRadiusType(this BadgeRadiusType radiusType)
        {
            if (radiusType == BadgeRadiusType.None)
                return default;

            return $"{UIConstants.RoundedPrefix}-{radiusType.GetDisplayName().ToLower()}";
        }
    }
}
