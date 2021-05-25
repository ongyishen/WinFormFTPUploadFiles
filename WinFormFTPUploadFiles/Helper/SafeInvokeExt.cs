using System;
using System.Reflection;
using System.Windows.Forms;

namespace WinFormFTPUploadFiles
{
    /*
 // get a property value in a safe-thread way
bool enabled = (bool)SafeInvoke.GetPropertyValue((Form)this, 
demoToolStripMenuItem, "Enabled"));

// set a property value in a safe-thread way
SafeInvoke.SetPropertyValue((Form)this, 
demoToolStripMenuItem,"Enabled", false);

// Invoke a method in a safe-thread way
SafeInvoke.InvokeMethod((Form)this, 
demoToolStripMenuItem, "PerformClick"); 
     */


    /// <summary>
    /// A helper class that allows to invoke control's methods and properties thread-safely.
    /// </summary>
    public static class SafeInvokeExt
    {
        /// <summary>
        /// Delegate to invoke a specific method on the control thread-safely.
        /// </summary>
        /// <param name="control">Control on which to invoke the method</param>
        /// <param name="methodName">Method to be invoked</param>
        /// <param name="paramValues">Method parameters</param>
        /// <returns>Velue returned by the invoked method</returns>
        private delegate object MethodInvoker(Control control, object formControl, string methodName, params object[] paramValues);

        /// <summary>
        /// Delegate to get a property value on the control thread-safely.
        /// </summary>
        /// <param name="control">Control on which to GET the property value</param>
        /// <param name="formControl">special control on which to GET the property value</param>
        /// <param name="propertyName">Property name</param>
        /// <returns>Property value</returns>
        private delegate object PropertyGetInvoker(Control control, object formControl, string propertyName);

        /// <summary>
        /// Delegate to set a property value on the control thread-safely.
        /// </summary>
        /// <param name="control">Control on which to SET the property value</param>
        /// <param name="formControl">Special control on which to SET the property value</param>
        /// <param name="propertyName">Property name</param>
        /// <param name="value">New property value</param>
        private delegate void PropertySetInvoker(Control control, object formControl, string propertyName, object value);

        /// <summary>
        /// Invoke a specific method on the control thread-safely.
        /// </summary>
        /// <param name="control">Control on which to invoke the method</param>
        /// <param name="methodName">Method to be invoked</param>
        /// <param name="paramValues">Method parameters</param>
        /// <returns>Velue returned by the invoked method</returns>
        public static object InvokeMethod(Control control, object formControl, string methodName, params object[] paramValues)
        {
            if (control != null && !string.IsNullOrEmpty(methodName))
            {
                if (control.InvokeRequired)
                {
                    return control.Invoke(new MethodInvoker(InvokeMethod), control, formControl, methodName, paramValues);
                }
                else
                {
                    MethodInfo methodInfo = null;

                    if (paramValues != null && paramValues.Length > 0)
                    {
                        Type[] types = new Type[paramValues.Length];
                        for (int i = 0; i < paramValues.Length; i++)
                        {
                            if (paramValues[i] != null)
                            {
                                types[i] = paramValues[i].GetType();
                            }
                        }
                        if (formControl != null)
                            methodInfo = formControl.GetType().GetMethod(methodName, types);
                        else
                            methodInfo = control.GetType().GetMethod(methodName, types);

                    }

                    else
                    {
                        if (formControl != null)
                            methodInfo = formControl.GetType().GetMethod(methodName);
                        else
                            methodInfo = control.GetType().GetMethod(methodName);

                    }

                    if (methodInfo != null)
                    {
                        if (formControl != null)
                            return methodInfo.Invoke(formControl, paramValues);
                        else
                            return methodInfo.Invoke(control, paramValues);

                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
        /// <summary>
        /// Invoke a specific method on the control thread-safely.
        /// </summary>
        /// <param name="control">Control on which to invoke the method</param>
        /// <param name="paramValues">Method parameters</param>
        /// <returns>Velue returned by the invoked method</returns>
        public static object InvokeMethod(Control control, string methodName, params object[] paramValues)
        {
            return InvokeMethod(control, new object(), methodName, paramValues);
        }

        /// <summary>
        /// Get a PropertyInfo object associated with a specific property on the control.
        /// </summary>
        /// <param name="control">Control</param>
        /// <param name="propertyName">Property name</param>
        /// <returns>A PropertyInfo object associated with 'propertyName' on specified 'control'</returns>
        private static PropertyInfo GetProperty(object control, object formControl, string propertyName)
        {
            if (control != null && !string.IsNullOrEmpty(propertyName))
            {
                PropertyInfo propertyInfo;
                if (formControl != null)
                    propertyInfo = formControl.GetType().GetProperty(propertyName);
                else
                    propertyInfo = control.GetType().GetProperty(propertyName);

                if (propertyInfo == null)
                {
                    throw new Exception(control.GetType().ToString() + " does not contain '" + propertyName + "' property.");
                }

                return propertyInfo;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Set a property value on the control thread-safely.
        /// </summary>
        /// <param name="control">Control on which to SET the property value or form control in special control cases</param>
        /// <param name="formControl">special control on which to SET the property value</param>
        /// <param name="propertyName">Property name</param>
        /// <param name="value">New property value</param>
        public static void SetPropertyValue(Control control, object formControl, string propertyName, object value)
        {
            if (control != null && !string.IsNullOrEmpty(propertyName))
            {
                if (control.InvokeRequired)
                {
                    control.Invoke(new PropertySetInvoker(SetPropertyValue), control, formControl, propertyName, value);
                }
                else
                {

                    PropertyInfo propertyInfo = GetProperty(control, formControl, propertyName);
                    if (propertyInfo != null)
                    {
                        if (propertyInfo.CanWrite)
                        {
                            if (formControl != null)
                                propertyInfo.SetValue(formControl, value, null);
                            else
                                propertyInfo.SetValue(control, value, null);

                        }
                        else
                        {
                            if (formControl != null)
                                throw new Exception(formControl.GetType().ToString() + "." + propertyName + " is read-only property.");
                            else
                                throw new Exception(control.GetType().ToString() + "." + propertyName + " is read-only property.");

                        }
                    }
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Set a property value on the control thread-safely.
        /// </summary>
        /// <param name="control">Control on which to SET the property value</param>
        /// <param name="propertyName">Property name</param>
        /// <param name="value">New property value</param>
        public static void SetPropertyValue(Control control, string propertyName, object value)
        {
            SetPropertyValue(control, null, propertyName, value);
        }

        /// <summary>
        /// Get a property value on the control thread-safely.
        /// </summary>
        /// <param name="control">Control on which to GET the property value or form control in special control cases</param>
        /// <param name="formControl">special control on which to GET the property value</param>
        /// <param name="propertyName">Property name</param>
        /// <returns>Property value</returns>
        public static object GetPropertyValue(Control control, object formControl, string propertyName)
        {
            if (control != null && !string.IsNullOrEmpty(propertyName))
            {
                if (control.InvokeRequired)
                {
                    return control.Invoke(new PropertyGetInvoker(GetPropertyValue), control, formControl, propertyName);
                }
                else
                {
                    PropertyInfo propertyInfo = GetProperty(control, formControl, propertyName);

                    if (propertyInfo != null)
                    {
                        if (propertyInfo.CanRead)
                        {
                            if (formControl != null)
                                return propertyInfo.GetValue(formControl, null);
                            else
                                return propertyInfo.GetValue(control, null);
                        }
                        else
                        {
                            if (formControl != null)
                                throw new Exception(formControl.GetType().ToString() + "." + propertyName + " is write-only property.");
                            else
                                throw new Exception(control.GetType().ToString() + "." + propertyName + " is write-only property.");

                        }
                    }

                    return null;
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Get a property value on the control thread-safely.
        /// </summary>
        /// <param name="control">Control on which to GET the property value</param>
        /// <param name="propertyName">Property name</param>
        /// <returns>Property value</returns>

        public static object GetPropertyValue(Control control, string propertyName)
        {
            return GetPropertyValue(control, null, propertyName);
        }

        /*
		 string Department = "";
							string totalitems = "";
							string batchqno = "";
							string batch = "";

							form.UIThread(()=> Department = form.DepartmentCode);
							form.UIThread(() => totalitems = form.lblTotalItem.Text);
							form.UIThread(() => batchqno = form.lblBatchnoQ.Text);
							form.UIThread(() => batch = form.lblBatchNumber.Text);
			 */
        public static void UIThread(this Control @this, Action code)
        {
            if (@this.InvokeRequired)
            {
                @this.BeginInvoke(code);
            }
            else
            {
                code.Invoke();
            }
        }

    }
}
