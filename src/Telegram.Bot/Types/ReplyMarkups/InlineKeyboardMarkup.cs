﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.Bot.Types.InlineKeyboardButtons;

namespace Telegram.Bot.Types.ReplyMarkups
{
    /// <summary>
    /// This object represents an inline keyboard that appears right next to the <see cref="Message"/> it belongs to.
    /// </summary>
    /// <remarks>
    /// Inline keyboards are currently being tested and are not available in channels yet. For now, feel free to use them in one-on-one chats or groups.
    /// </remarks>
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class InlineKeyboardMarkup : IReplyMarkup
    {
        /// <summary>
        /// Array of <see cref="InlineKeyboardButton"/> rows, each represented by an Array of <see cref="InlineKeyboardButton"/>.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public InlineKeyboardButton[][] InlineKeyboard { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineKeyboardMarkup"/> class.
        /// </summary>
        public InlineKeyboardMarkup() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineKeyboardMarkup"/> class with only one keyboard button
        /// </summary>
        /// <param name="inlineKeyboardButton">Keyboard button</param>
        public InlineKeyboardMarkup(InlineKeyboardButton inlineKeyboardButton)
            : this(new[] { inlineKeyboardButton })
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineKeyboardMarkup"/> class with a one-row keyboard
        /// </summary>
        /// <param name="inlineKeyboardRow">The inline keyboard row</param>
        public InlineKeyboardMarkup(InlineKeyboardButton[] inlineKeyboardRow)
        {
            InlineKeyboard = new[]
            {
                inlineKeyboardRow
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineKeyboardMarkup"/> class.
        /// </summary>
        /// <param name="inlineKeyboard">The inline keyboard.</param>
        public InlineKeyboardMarkup(InlineKeyboardButton[][] inlineKeyboard)
        {
            InlineKeyboard = inlineKeyboard;
        }

        public static InlineKeyboardMarkup Empty() =>
            new InlineKeyboardMarkup(new InlineKeyboardButton[0][]);

        public static implicit operator InlineKeyboardMarkup(InlineKeyboardButton button) =>
            button is default
                ? default
                : new InlineKeyboardMarkup(button);

        public static implicit operator InlineKeyboardMarkup(string buttonText) =>
            buttonText is default
                ? default
                : new InlineKeyboardMarkup(buttonText);
    }
}
