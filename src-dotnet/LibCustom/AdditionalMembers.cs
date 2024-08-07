namespace ECMAScript.Lib;

public partial interface Document
{
    public new HTMLElement createElement(string tagName, ElementCreationOptions options);
    
    public new HTMLElement createElementNS(string namespaceURI, string qualifiedName);

    public new TElement createElement<TElement>(string tagName, ElementCreationOptions options)
        where TElement : Element;

    public new TElement createElementNS<TElement>(string namespaceURI, string qualifiedName) where TElement : Element;
    
    public new Event createEvent(string eventInterface);
    
    public new TEvent createEvent<TEvent>(string eventInterface) where TEvent : Event;
}