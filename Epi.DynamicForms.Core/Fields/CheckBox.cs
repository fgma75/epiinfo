﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Epi.Core.EnterInterpreter;
namespace MvcDynamicForms.Fields
{
    /// <summary>
    /// Represents a single html checkbox input field.
    /// </summary>
    [Serializable]
    public class CheckBox : InputField
    {
        private string _checkedValue = "Yes";
        private string _uncheckedValue = "No";
        new private string _promptClass = "MvcDynamicCheckboxPrompt";

        /// <summary>
        /// The text to be used as the user's response when they check the checkbox.
        /// </summary>
        public string CheckedValue
        {
            get
            {
                return _checkedValue;
            }
            set
            {
                _checkedValue = value;
            }
        }
        /// <summary>
        /// The text to be used as the user's response when they do not check the checkbox.
        /// </summary>
        public string UncheckedValue
        {
            get
            {
                return _uncheckedValue;
            }
            set
            {
                _uncheckedValue = value;
            }
        }
        /// <summary>
        /// The state of the checkbox.
        /// </summary>
        public bool Checked { get; set; }

        public override string Response
        {
            get
            {
                return Checked ? _checkedValue : _uncheckedValue;
            }
            set
            {
               
            }
        }

        public override bool Validate()
        {
            /*
            if (Required && !Checked)
            {
                // Isn't valid
                Error = _requiredMessage;
                return false;
            }

            // Is Valid
            */
            ClearError();
            return true;
        }

        public override string RenderHtml()
        {
            var inputName = _form.FieldPrefix + _key;
            var html = new StringBuilder();
            string ErrorStyle = string.Empty;

            // error label
            if (!IsValid)
            {
                //Add new Error to the error Obj
                ErrorStyle = ";border-color: red";
            }

            // checkbox input
            var chk = new TagBuilder("input");
            chk.Attributes.Add("id", inputName);
            chk.Attributes.Add("name", inputName);
            chk.Attributes.Add("type", "checkbox");
            if (Checked) chk.Attributes.Add("checked", "checked");
            chk.Attributes.Add("value", bool.TrueString);
            string IsHiddenStyle = "";
            if (_IsHidden)
            {
                IsHiddenStyle = "display:none";
            }
            ////////////Check code start//////////////////
           // chk.Attributes.Add("onfocus", "EventArray.push('" + Prompt + "Befor')");//befor
            //chk.Attributes.Add("onblur", "EventArray.push('" + Prompt + "After')");//After
            ////////////Check code end//////////////////

            chk.Attributes.Add("style", "position:absolute;left:" + _left.ToString() + "px;top:" + _top.ToString() + "px" + ";width:" + _ControlWidth.ToString() + "px" + ErrorStyle + ";" + IsHiddenStyle);            
          
            chk.MergeAttributes(_inputHtmlAttributes);
            html.Append(chk.ToString(TagRenderMode.SelfClosing));

            // prompt label
            var prompt = new TagBuilder("label");
            prompt.SetInnerText(Prompt);
            prompt.Attributes.Add("for", inputName);
            prompt.Attributes.Add("class", "EpiLabel");
            StringBuilder StyleValues = new StringBuilder();
            StyleValues.Append(GetContolStyle(_fontstyle.ToString(), _Prompttop.ToString(), _Promptleft.ToString(), null, Height.ToString(), IsHidden));
            prompt.Attributes.Add("style", StyleValues.ToString());
            html.Append(prompt.ToString());
            if (ReadOnly)
            {
                var scriptReadOnlyText = new TagBuilder("script");
                scriptReadOnlyText.InnerHtml = "$(function(){$('#" + inputName + "').attr('disabled','disabled')});";
                html.Append(scriptReadOnlyText.ToString(TagRenderMode.Normal));
            }

            // hidden input (so that value is posted when checkbox is unchecked)
            var hdn = new TagBuilder("input");
            hdn.Attributes.Add("type", "hidden");
            hdn.Attributes.Add("id", inputName + "_hidden");
            hdn.Attributes.Add("name", inputName);
            hdn.Attributes.Add("value", bool.FalseString);
            ////////////Check code start//////////////////
            EnterRule FunctionObjectAfter = (EnterRule)_form.FormCheckCodeObj.Context.GetCommand("level=field&event=after&identifier=" + _key);
            if (FunctionObjectAfter != null)
            {
                StringBuilder JavaScript = new StringBuilder();
                FunctionObjectAfter.ToJavaScript(JavaScript);
                hdn.Attributes.Add("onblur", "function " + _key + JavaScript.ToString() + "; " + _key + "_After();"); //After
            }
            EnterRule FunctionObjectBefore = (EnterRule)_form.FormCheckCodeObj.Context.GetCommand("level=field&event=before&identifier=" + _key);
            if (FunctionObjectBefore != null)
            {
                StringBuilder JavaScript = new StringBuilder();
                FunctionObjectBefore.ToJavaScript(JavaScript);
                hdn.Attributes.Add("onfocus", "function " + _key + JavaScript.ToString() + "; " + _key + "_Before();"); //Before
            }

            ////////////Check code end//////////////////
            html.Append(hdn.ToString(TagRenderMode.SelfClosing));

          
            var wrapper = new TagBuilder(_fieldWrapper);
            wrapper.Attributes["class"] = _fieldWrapperClass;
            wrapper.InnerHtml = html.ToString();
            return wrapper.ToString();
        }
    }
}
