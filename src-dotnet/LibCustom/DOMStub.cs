// ReSharper disable InconsistentNaming, UnassignedGetOnlyAutoProperty

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;

namespace DOM;

// TODO:
//  - deprecated -> obsolete
//  - MaybeNull

/*
interface EventListenerOptions {
    capture?: boolean;
}
*/

public interface EventListenerOptions
{
  public bool capture { get; set; }
}

/*
interface AddEventListenerOptions extends EventListenerOptions {
    once?: boolean;
    passive?: boolean;
    signal?: AbortSignal;
}
*/
public interface AddEventListenerOptions : EventListenerOptions
{
  public bool once { get; set; }

  public bool passive { get; set; }

  public bool signal { get; set; }
}

public enum MouseEventName
{
  Click,
  Contextmenu,
}

public enum PointerEventName
{
  PointerCancel,
  PointerDown,
}

public delegate void EventListener<in TEvent, in TOptions>(TEvent evt, TOptions options = default(TOptions));

public interface MouseEvent
{
  // lots of properties
}

public interface PointerEvent
{
  // lots of properties
}

/// <summary>
/// Any HTML element. Some elements directly implement this interface, while others implement it via an interface that inherits it.
/// </summary>
/// <remarks>
/// Link: https://developer.mozilla.org/docs/Web/API/HTMLElement
/// </remarks>
public interface DOMStub :
    Element,
    EventListenerMixin<MouseEvent, MouseEventName>,
    EventListenerMixin<PointerEvent, PointerEventName>
{
  /** [MDN Reference](https://developer.mozilla.org/docs/Web/API/HTMLElement/accessKey) */
  public string accessKey { get; set; }

  public void click();
}

public interface EventListenerMixin<out TEvent, in TEventName>
{
  public void addEventListener(string type, Action<TEvent> listener, bool options = false);

  public void addEventListener(string type, Action<TEvent, AddEventListenerOptions> listener);

  public void addEventListener(TEventName type, Action<TEvent> listener, bool options = false);

  public void addEventListener(TEventName type, Action<TEvent, AddEventListenerOptions> listener);
}

public interface Element { }

public interface RuntimeType<out TType>
{
  public TType prototype { get; }

  public TType newMethod();
}

public static partial class Runtime
{
  public static RuntimeType<DOMStub> Element { get; }

  public static RuntimeType<DOMStub> HTMLElement { get; }
}

internal class MyClass
{
  internal static void Playground(DOMStub div) {
    div.addEventListener("click", (MouseEvent evt) => { });
    div.addEventListener(MouseEventName.Click, (evt) => { });
    div.addEventListener(MouseEventName.Click, (evt) => { }, true);
    div.addEventListener(MouseEventName.Click, (MouseEvent evt) => { });

    var accessKey = Runtime.HTMLElement.prototype.accessKey;
  }
}
