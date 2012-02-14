using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcJqGrid.Enums;

namespace MvcJqGrid
{
    public class PagerButton
    {
        private string _caption;
        private string _buttonImg;
        private string _onClickButton;
        private PagerButtonPosition _position;
        private string _title;

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name = "Caption">Caption of the button</param>
        public PagerButton(string Caption)
        {
            if (string.IsNullOrWhiteSpace(Caption))
            {
                throw new ArgumentException("Caption must contain a value to identify the button");
            }
            _caption = Caption;
        }

        /// <summary>
        ///     Full path to valid image. If empty string, no image will be attached.
        /// </summary>
        /// <param name = "ButtonImg"></param>
        public PagerButton SetButtonImg(string ButtonImg)
        {
            _buttonImg = ButtonImg;
            return this;
        }

        /// <summary>
        ///     ("first" or "last") the position where the button will be added  
        ///     (i.e., before or after the standard buttons).
        /// </summary>
        /// <param name = "recordPos">Position of record information</param>
        public PagerButton SetRecordPos(PagerButtonPosition Position)
        {
            _position = Position;
            return this;
        }

        /// <summary>
        ///     This fires when user clicks on the button. 
        ///     Variables available in call: event
        /// </summary>
        /// <param name = "OnClickButton">Script to be executed</param>
        public PagerButton OnClickButton(string OnClickButton)
        {
            _onClickButton = OnClickButton;
            return this;
        }

        public override string ToString()
        {
            var options = new List<string>();

            // Caption
            if (!string.IsNullOrWhiteSpace(_caption))
                options.Add("caption:\"" + _caption + "\"");
            
            // Title
            if (!string.IsNullOrWhiteSpace(_title))
                options.Add("title:\"" + _title + "\"");
            
            // Button image
            if (!string.IsNullOrWhiteSpace(_buttonImg))
                options.Add("buttonicon:\"" + _buttonImg + "\"");

            // onClickButton
            if (!string.IsNullOrWhiteSpace(_onClickButton))
                options.Add("onClickButton: " + _title);
            
            return string.Join(", ", options);
        }
    }
}
