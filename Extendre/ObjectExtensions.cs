using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Delegate type for binding onto objects.
/// </summary>
/// <param name="sender">The object calling the event.</param>
/// <param name="args">The event arguments.</param>
public delegate void ObjectBinding(object sender, params object[] args);

/// <summary>
/// Provides extension methods for the Object base class.
/// </summary>
public static class ObjectExtensions {

    /// <summary>
    /// All current bindings.
    /// </summary>
    private static Dictionary<object, List<ObjectBinding>> bindings = new Dictionary<object, List<ObjectBinding>>();

    /// <summary>
    /// Bind an ObjectBinding to a particular object.
    /// </summary>
    /// <param name="obj">The object to be bound.</param>
    /// <param name="binding">The binding to bind.</param>
    public static void Bind(this object obj, ObjectBinding binding) {
        if (bindings.ContainsKey(obj)) {
            bindings[obj].Add(binding);
        } else {
            bindings.Add(obj, new List<ObjectBinding>());
            bindings[obj].Add(binding);
        }
    }

    /// <summary>
    /// Invoke all bindings bound to this object. Bindings are invoked in the order they were bound.
    /// </summary>
    /// <param name="obj">The object to invoke bound bindings for.</param>
    /// <param name="args">The arguments to pass to the binding.</param>
    public static void InvokeBindings(this object obj, params object[] args) {
        if (bindings.ContainsKey(obj)) {
            foreach (ObjectBinding binding in bindings[obj]) {
                binding.Invoke(obj, args);
            }
        }
    }

    /// <summary>
    /// Asynchronously Invoke all bindings bound to this object. Bindings are invoked in the order they were bound.
    /// </summary>
    /// <param name="obj">The object to invoke bound bindings for.</param>
    /// <param name="args">The arguments to pass to the binding.</param>
    public static void InvokeBindingsAsync(this object obj, params object[] args) {
        if (bindings.ContainsKey(obj)) {
            foreach (ObjectBinding binding in bindings[obj]) {
                binding.BeginInvoke(obj, args, null, null);
            }
        }
    }

    /// <summary>
    /// Removes the first instance of the specefied binding from the objects bindings.
    /// </summary>
    /// <param name="obj">The object to remove the binding from.</param>
    /// <param name="binding">The binding to remove.</param>
    public static void RemoveBinding(this object obj, ObjectBinding binding) {
        if (bindings.ContainsKey(obj)) {
            bindings[obj].Remove(binding);
        }
    }

    /// <summary>
    /// Removes every binding from this object.
    /// </summary>
    /// <param name="obj">The object to remove the bindings from.</param>
    public static void ClearBindings(this object obj) {
        if (bindings.ContainsKey(obj)) {
            bindings[obj].Clear();
            bindings.Remove(obj);
        }
    }

}
