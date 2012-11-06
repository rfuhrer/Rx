﻿/*
 * This file is manually generated upon every change to the corresponding .resx file, using the built-in code generator.
 * However, we can't use auto-generated code because the output is different for .NET 4.5 for Metro and PLIB, due to
 * changes in the reflection APIs (search for CRIPPLED_REFLECTION in this file), and because regeneration doesn't happen
 * as part of build, but rather at design time in Visual Studio. While we likely could tweak MSBuild to force regeneration
 * using the right version of ResGen.exe, this approach turned out to be the easiest for the time being.
 * 
 * Upon adding entries to the ResX file, regenerate this file, put this comment back, and make sure to add the #if checks
 * for conditional use of the right flavor of reflection (using the CRIPPLED_REFLECTION defined symbol).
 */

// Required for the use of the GetTypeInfo extension method.
#if CRIPPLED_REFLECTION
using System.Reflection;
#endif

// GENERATED CODE starts here

namespace System.Reactive
{
    using System;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings_Linq
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings_Linq()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
#if CRIPPLED_REFLECTION
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Reactive.Strings_Linq", typeof(Strings_Linq).GetTypeInfo().Assembly);
#else
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Reactive.Strings_Linq", typeof(Strings_Linq).Assembly);
#endif
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Could not find event &apos;{0}&apos; on object of type &apos;{1}&apos;..
        /// </summary>
        internal static string COULD_NOT_FIND_INSTANCE_EVENT
        {
            get
            {
                return ResourceManager.GetString("COULD_NOT_FIND_INSTANCE_EVENT", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Could not find event &apos;{0}&apos; on type &apos;{1}&apos;..
        /// </summary>
        internal static string COULD_NOT_FIND_STATIC_EVENT
        {
            get
            {
                return ResourceManager.GetString("COULD_NOT_FIND_STATIC_EVENT", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Add method should take 1 parameter..
        /// </summary>
        internal static string EVENT_ADD_METHOD_SHOULD_TAKE_ONE_PARAMETER
        {
            get
            {
                return ResourceManager.GetString("EVENT_ADD_METHOD_SHOULD_TAKE_ONE_PARAMETER", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The second parameter of the event delegate must be assignable to &apos;{0}&apos;..
        /// </summary>
        internal static string EVENT_ARGS_NOT_ASSIGNABLE
        {
            get
            {
                return ResourceManager.GetString("EVENT_ARGS_NOT_ASSIGNABLE", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Event is missing the add method..
        /// </summary>
        internal static string EVENT_MISSING_ADD_METHOD
        {
            get
            {
                return ResourceManager.GetString("EVENT_MISSING_ADD_METHOD", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Event is missing the remove method..
        /// </summary>
        internal static string EVENT_MISSING_REMOVE_METHOD
        {
            get
            {
                return ResourceManager.GetString("EVENT_MISSING_REMOVE_METHOD", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The event delegate must have a void return type..
        /// </summary>
        internal static string EVENT_MUST_RETURN_VOID
        {
            get
            {
                return ResourceManager.GetString("EVENT_MUST_RETURN_VOID", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The event delegate must have exactly two parameters..
        /// </summary>
        internal static string EVENT_PATTERN_REQUIRES_TWO_PARAMETERS
        {
            get
            {
                return ResourceManager.GetString("EVENT_PATTERN_REQUIRES_TWO_PARAMETERS", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Remove method should take 1 parameter..
        /// </summary>
        internal static string EVENT_REMOVE_METHOD_SHOULD_TAKE_ONE_PARAMETER
        {
            get
            {
                return ResourceManager.GetString("EVENT_REMOVE_METHOD_SHOULD_TAKE_ONE_PARAMETER", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The first parameter of the event delegate must be assignable to &apos;{0}&apos;..
        /// </summary>
        internal static string EVENT_SENDER_NOT_ASSIGNABLE
        {
            get
            {
                return ResourceManager.GetString("EVENT_SENDER_NOT_ASSIGNABLE", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Remove method of a WinRT event should take an EventRegistrationToken..
        /// </summary>
        internal static string EVENT_WINRT_REMOVE_METHOD_SHOULD_TAKE_ERT
        {
            get
            {
                return ResourceManager.GetString("EVENT_WINRT_REMOVE_METHOD_SHOULD_TAKE_ERT", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Sequence contains more than one element..
        /// </summary>
        internal static string MORE_THAN_ONE_ELEMENT
        {
            get
            {
                return ResourceManager.GetString("MORE_THAN_ONE_ELEMENT", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Sequence contains more than one matching element..
        /// </summary>
        internal static string MORE_THAN_ONE_MATCHING_ELEMENT
        {
            get
            {
                return ResourceManager.GetString("MORE_THAN_ONE_MATCHING_ELEMENT", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Sequence contains no elements..
        /// </summary>
        internal static string NO_ELEMENTS
        {
            get
            {
                return ResourceManager.GetString("NO_ELEMENTS", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Sequence contains no matching element..
        /// </summary>
        internal static string NO_MATCHING_ELEMENTS
        {
            get
            {
                return ResourceManager.GetString("NO_MATCHING_ELEMENTS", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be called when the scheduler is already running. Try using Sleep instead..
        /// </summary>
        internal static string CANT_ADVANCE_WHILE_RUNNING
        {
            get
            {
                return ResourceManager.GetString("CANT_ADVANCE_WHILE_RUNNING", resourceCulture);
            }
        }
    }
}
